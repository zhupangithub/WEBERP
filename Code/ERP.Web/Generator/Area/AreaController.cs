
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using ERP.Web.Models;

namespace ERP.Web.Areas.Erp.Controllers
{
    public class AreaController : Controller
    {
        public ActionResult Edit(string id = "")
        {

            var model = new
            {
                urls = new {
                    getdata = "/api/Erp/Area/GetPageData/",        //获取主表数据及数据滚动数据api
                    edit = "/api/Erp/Area/edit/",                      //数据保存api
                    audit = "/api/Erp/Area/audit/",                    //审核api
                    newkey = "/api/Erp/Area/GetNewRowId/"            //获取新的明细数据的主键(日语叫采番)
                },
                resx = new {
                    rejected = "已撤消修改！",
                    editSuccess = "保存成功！",
                    auditPassed ="单据已通过审核！",
                    auditReject = "单据已取消审核！"
                },
                dataSource = new{
                    pageData=new AreaApiController().GetPageData(id)
                    //payKinds = codeService.GetValueTextListByType("PayType")
                },
                form = new{
                    defaults = new base_area().Extend(new {  warehouse_id = "",isenable = "",remark = "",create_time = "",create_username = "",name = ""}),
                    primaryKeys = new string[]{"id"}
                },
                tabs = new object[]{
                    new{
                      type = "grid",
                      rowId = "id",
                      relationId = "id",
                      postFields = new string[] { "name","warehouse_id","isenable"},
                      defaults = new {name = "",warehouse_id = "",isenable = ""}
                    }    
                }
            };
            return View(model);
        }
    }

    public class AreaApiController : ApiController
    {
        public dynamic GetPageData(string id)
        {
            var masterService = new base_areaService();
            var pQuery = ParamQuery.Instance().AndWhere("id", id);

             var result = new {
                //主表数据
                form = masterService.GetModel(pQuery),
                scrollKeys = masterService.ScrollKeys("id", id),

                //明细数据
                tab0 = new base_areaService().GetDynamicList(pQuery)
            };
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Audit(string id, JObject data)
        {
            var pUpdate = ParamUpdate.Instance()
                .Update("base_area")
                .Column("ApproveState", data["status"])
                .Column("ApproveRemark", data["comment"])
                .Column("ApprovePerson", FormsAuth.GetUserData().UserName)
                .Column("ApproveDate", DateTime.Now)
                .AndWhere("id", id);

            var service = new base_areaService();
            var rowsAffected = service.Update(pUpdate);
            MmsHelper.ThrowHttpExceptionWhen(rowsAffected < 0, "单据审核失败[BillNo={0}]，请重试或联系管理员！", id);
        }
  
        //todo 改成支持多个Tab
        // 地址：GET api/mms/@(controller)/getnewrowid 预取得新的明细表的行号
        public string GetNewRowId(string type,string key,int qty=1)
        {
            switch (type)
            {
                case "grid0":
                    var service0 = new base_areaService();
                    return service0.GetNewKey("id", "maxplus", qty, ParamQuery.Instance().AndWhere("id", key, Cp.Equal));
                default:
                    return "";
            }
        }
  
        // 地址：POST api/mms/send 功能：保存收料单数据
        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var formWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
<settings>
    <table>
        base_area
    </table>
    <where>
        <field name='id' cp='equal'></field>
    </where>
</settings>");

            var tabsWrapper = new List<RequestWrapper>();
            tabsWrapper.Add(RequestWrapper.Instance().LoadSettingXmlString(@"
<settings>
    <table>base_area</table>
    <where>
        <field name='id' cp='equal'></field>      
    </where>
</settings>"));
             
            var service = new base_areaService();
            var result = service.EditPage(data, formWrapper, tabsWrapper);
        }
    }
}
