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
    public class LocationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class LocationApiController : ApiController
    {
        public dynamic GetTypes(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
            <settings>
                <select>
                    CAST(a.id as varchar(100)) + '+' + CAST(b.id as varchar(100)) as id,
                    b.name + '->' + a.name as name
                </select>
                <from>
                    base_area a inner join base_warehouse b 
                    on a.warehouse_id = b.id
                </from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
                    <field name='a.name'  cp='equal' ></field>
                </where>
            </settings>");
            var service = new base_areaService();
            var pQuery = request.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }
        //public dynamic Get(RequestWrapper query)
        //{
        //    query.LoadSettingXmlString(@"
        //    <settings defaultOrderBy='id'>
        //       <where>
        //            <field name='area_id' cp='equal' ignoreEmpty='true'></field>
        //        </where>
        //    </settings>");
        //    var service = new base_locationService();
        //    var pQuery = query.ToParamQuery();
        //    var result = service.GetDynamicListWithPaging(pQuery);
        //    return result;
        //}

        public dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
            <settings defaultOrderBy='id'>
                <select>*</select>
                <from>
                    base_location
                </from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
                    <field name='area_id'  cp='equal' ></field>
                </where>
            </settings>");
            var service = new base_locationService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table>base_Location</table>
                <where>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>");
            var service = new base_locationService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
