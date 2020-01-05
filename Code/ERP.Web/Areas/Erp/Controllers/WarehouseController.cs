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
    public class WarehouseController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                dataSource = new
                {

                },
                urls = new
                {
                    query = "/api/erp/Warehouse",
                    edit = "/api/erp/Warehouse/edit"
                },
                resx = new
                {
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                },
                form = new
                {
                    name = ""
                },
                defaultRow = new
                {

                },
                setting = new
                {
                    postListFields = new string[] { "id", "name", "isenable", "remark", "create_time", "create_username" }
                }
            };
            return View(model);
        }
    }

    public class WarehouseApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
            <settings defaultOrderBy='id'>
                <select>*</select>
                <from>base_Warehouse</from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
                    <field name='name'     cp='like'></field>
                </where>
            </settings>");
            var service = new base_warehouseService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table>base_Warehouse</table>
                <where>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>");
            var service = new base_warehouseService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
