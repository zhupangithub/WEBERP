using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using ERP.Web.Models;
using ERP.Web;

namespace ERP.Web.Areas.Erp.Controllers
{
    public class ProcessController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                dataSource = new
                {
                    Items1 = new base_dataService().GetDynamicList(ParamQuery.Instance().Select("name as value,name as text").AndWhere("type", "单位").AndWhere("isenable", "1")),
                    Items2 = new base_dataService().GetDynamicList(ParamQuery.Instance().Select("name as value,name as text").AndWhere("type", "工序").AndWhere("isenable", "1"))
                },
                urls = new
                {
                    query = "/api/erp/Process",
                    edit = "/api/erp/Process/edit"
                },
                resx = new
                {
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                },
                form = new
                {
                    name = "",
                    type = "",
                    unit = "",
                },
                defaultRow = new
                {

                },
                setting = new
                {
                    postListFields = new string[] { "id", "name", "type", "unit", "guige", "isenable", "remark", "create_time", "create_username" }
                }
            };
            return View(model);
        }
    }

    public class ProcessApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
            <settings defaultOrderBy='id'>
                <select>*</select>
                <from>base_Process</from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
                    <field name='name'     cp='like'></field>
                    <field name='type'  cp='equal' ></field>
                    <field name='unit'  cp='equal'></field>
                </where>
            </settings>");
            var service = new base_processService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table>base_Process</table>
                <where>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>");
            var service = new base_processService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
