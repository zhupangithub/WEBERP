using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using ERP.Web.Models;
using ERP.Web.Areas.Erp.Common;

namespace ERP.Web.Areas.Erp.Controllers
{
    public class ErpBaseApi<TMasterModel, TMasterService, TDetailModel, TDetailService> : ApiController
        where TMasterModel : ModelBase, new()
        where TDetailModel : ModelBase, new()
        where TMasterService : ServiceBase<TMasterModel>, new()
        where TDetailService : ServiceBase<TDetailModel>, new()
    {
        #region 属性
        private TMasterService _masterService;
        private TDetailService _detailService;
        public TMasterService masterService
        {
            get
            {
                if (_masterService == null)
                    _masterService = new TMasterService();
                return _masterService;
            }
        }
        public TDetailService detailService
        {
            get
            {
                if (_detailService == null)
                    _detailService = new TDetailService();
                return _detailService;
            }
        }
        public string projectCode { get { return ErpHelper.GetCurrentProject(); } }
        public string userName { get { return ErpHelper.GetUserName(); } }
        #endregion

        #region 自动完成
        // GET api/erp/send/getbillno
        public virtual List<dynamic> GetBillNo(string q)
        {
            var pQuery = ParamQuery.Instance().Select("top 10 no").AndWhere("no", q, Cp.StartWith);
            return masterService.GetDynamicList(pQuery);
        }
        #endregion

        #region 采播
        // 取得新的主表Bill GET api/erp/send/getnewbillno
        public virtual string GetNewBillNo()
        {
            return masterService.GetNewKey("id", "erp_no",1,"TO");
        }

        // 取得新的明细表RowId GET api/erp/send/getnewrowid
        public virtual string GetNewRowId(int id, string BillNo)
        {
            return detailService.GetNewKey("RowId", "maxplus", id,"",ParamQuery.Instance().AndWhere("no", BillNo));
        }
        #endregion

        #region 查询
        // 查询主表数据列表 GET api/erp/send 
        public virtual dynamic Get(RequestWrapper query)
        {
            if (!query.IsLoadedSettings)
                query.LoadSettingXmlString(@"
            <settings defaultOrderBy='no'>
                <select>*</select>
                <from> {0}</from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
                    <field name='no' cp='equal'></field>
                </where>
            </settings>", typeof(TMasterModel).Name);
            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }

        // 取得编辑页面中的主表数据及上一页下一页主键 GET api/erp/send/geteditmaster 
        public virtual dynamic GetEditMaster(string id)
        {
            return new
            {
                form = masterService.GetModel(ParamQuery.Instance().AndWhere("no", id)),
                scrollKeys = masterService.ScrollKeys("no", id, ParamQuery.Instance())
            };
        }

        // 查询明细表 GET api/erp/send/getdetail
        public virtual dynamic GetDetail(string id)
        {
            var query = RequestWrapper
                .InstanceFromRequest()
                .SetRequestData("no", id)
                .LoadSettingXmlString(@"
                <settings defaultOrderBy='id'>
                    <select>
                        *
                    </select>
                    <from>
                        erp_parts
                    </from>
                    <where>
                        <field name='con_no' cp='equal'></field>
                    </where>
                </settings>", typeof(TDetailModel).Name);

            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }
        #endregion

        #region 删除
        // 删除 DELETE api/erp/send
        public virtual void Delete(string id)
        {
            var result = masterService.Delete(ParamDelete.Instance().AndWhere("no", id));
            ErpHelper.ThrowHttpExceptionWhen(result <= 0, "单据删除失败[BillNo={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 审核
        // 审核 DELETE api/erp/send/audit
        [HttpPost]
        public virtual void Audit(string id, JObject data)
        {
            var status = data["status"].ToString();
            var comment = data["comment"].ToString();
            var result = new ErpService().Audit(typeof(TMasterModel).Name, id, status, comment);
            ErpHelper.ThrowHttpExceptionWhen(result < 0, "单据审核失败[BillNo={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 保存
        // 保存 POST api/erp/send
        [HttpPost]
        public virtual void Edit(dynamic data)
        {
            var formWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table> {0}</table>
                <where><field name='id' cp='equal'></field></where>
            </settings>", typeof(TMasterModel).Name);

            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table>{0}</table>
                <where>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>", typeof(TDetailModel).Name);
            var result = masterService.Edit(formWrapper, null, data);
        }
        #endregion
    }
}