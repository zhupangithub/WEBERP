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
    public class AreaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class AreaApiController : ApiController
    {
        public dynamic GetTypes(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
            <settings defaultOrderBy='id'>
               <where defaultIgnoreEmpty='true'>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>
            ");
            var result = new base_warehouseService().GetDynamicList(request.ToParamQuery());
            return result;
        }
        public dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
            <settings defaultOrderBy='id'>
               <where>
                    <field name='warehouse_id' cp='equal' ignoreEmpty='true'></field>
                </where>
            </settings>");
            var service = new base_areaService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table>base_Area</table>
                <where>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>");
            var service = new base_areaService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
