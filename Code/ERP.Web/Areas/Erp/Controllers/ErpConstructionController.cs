﻿using System;
using System.Web.Mvc;
using Zephyr.Core;
using ERP.Web.Models;
using System.Web.Http;
using ERP.Web.Areas.Erp.Common;

namespace ERP.Web.Areas.Erp.Controllers
{
    public class ErpConstructionController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = ErpHelper.GetIndexUrls("ErpConstruction"),
                resx = ErpHelper.GetIndexResx("施工单"),
                dataSource = new
                {
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(ErpHelper.GetCurrentProject()),
                    supplyType = new sys_codeService().GetValueTextListByType("SupplyType")
                },
                form = new
                {
                    no = "",
                    product_name = "",
                    customer_name = "",
                    state = "",
                    create_time = ""
                }
            };

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            var userName = ErpHelper.GetUserName();
            var data = new ErpConstructionApiController().GetEditMaster(id);
            var codeService = new sys_codeService();
            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = ErpHelper.GetEditUrls("ErpConstruction"),
                resx = ErpHelper.GetEditResx("施工单"),
                dataSource = new
                {
                    measureUnit = codeService.GetMeasureUnitListByType()
                    //supplyType = codeService.GetValueTextListByType("SupplyType"),
                    //payKinds = codeService.GetValueTextListByType("PayType")
                },
                defaultForm = new erp_construction().Extend(new
                {
                    no = id,
                    create_time = DateTime.Now,
                    create_username = userName,
                    product_id = "",
                    delivery_date =DateTime.Now.AddDays(7)
                    //ErpConstructionDate = DateTime.Now,
                    //SupplyType = codeService.GetDefaultCode("SupplyType"),
                    //PayKind = codeService.GetDefaultCode("PayType"),
                }),
                defaultRow = new
                {
                    //CheckNum = 1,
                    //Num = 1,
                    //UnitPrice = 0,
                    //Money = 0,
                    //PrePay = 0
                },
                setting = new
                {
                    postFormKeys = new string[] { "no" },
                    postListFields = new string[] { "no","product_id","customer_id", "number",
                        "practical_number", "loss_number", "guige","zhuangdinfa","baozhuangfa","address","delivery_date","source_no","state","remark",
                        "create_time","create_username" }
                }
            };
            return View(model);
        }
    }

    public class ErpConstructionApiController : ErpBaseApi<erp_construction, erp_constructionService, base_data, base_dataService>
    {
        // 查询主表：GET api/mms/send
        public override dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
            <settings defaultOrderBy='create_time'>
                <select>*
                </select>
                <from>
                    Erp_Construction
                </from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true'>
                    <field name='id'       cp='equal'      ></field>
                    <field name='no'                cp='equal'      ></field>
                    <field name='product_id'           cp='like'       ></field>
                    <field name='customer_id'       cp='like'    variable='customer_id'   ></field>
                    <field name='state'       cp='equal'      ></field>
                    <field name='create_time' cp='daterange'  ></field>
                </where>
            </settings>");
            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }
    }
}