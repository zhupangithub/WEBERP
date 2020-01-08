using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Data;
using ERP.Web.Models;

namespace ERP.Web.Areas.Erp.Common
{
    [Module("Erp")]
    public class ErpService : ServiceBase<ModelBase>
    {
        //审核表单
        public int Audit(string tableName, string billNo, string status, string comment)
        {
            db.UseTransaction(true);

            var userName = ErpHelper.GetUserName();
            var pUpdate = ParamUpdate.Instance()
                .Update(tableName)
                .Column("ApproveState", status)
                .Column("ApproveRemark", comment)
                .Column("ApprovePerson", userName)
                .Column("ApproveDate", DateTime.Now)
                .AndWhere("BillNo", billNo);

            var rowsAffected = BuilderParse(pUpdate).Execute();

            if (rowsAffected<=0)
            {
                db.Rollback();
                return rowsAffected;
            }

            //switch (tableName)
            //{
            //    case "erp_receive":
            //    case "erp_refund":
            //        rowsAffected = erp_warehouseStockService.UpdateWarehouseStock(db, tableName, billNo, status == "passed");
            //        break;

            //    case "erp_send":
            //    case "erp_return":
            //    case "erp_transfer":
            //    case "erp_lossReport":
            //        rowsAffected = erp_warehouseStockService.UpdateWarehouseStock(db, tableName, billNo, status != "passed");
            //        break;

            //    case "erp_rentOut":
            //        rowsAffected = erp_rentOutService.CalcRentOutMoney(db, billNo);
            //        break;
            //}
 
            if (rowsAffected<0)
            {
                db.Rollback();
                return rowsAffected;
            }

            db.Commit();
            return rowsAffected;
        }


        public static List<dynamic> GetReceiveSrcBillTypeList()
        {
            var result = new List<dynamic>();
            result.Add(new { value = "receive", text = "收料单" });
            result.Add(new { value = "return", text = "退货单" });
            result.Add(new { value = "direct", text = "直入直出单" });
            result.Add(new { value = "rentin", text = "租赁进场单" });

            return result;
        }

        public static List<dynamic> GetSendSrcBillTypeList()
        {
            var result = new List<dynamic>();
            result.Add(new { value = "send", text = "发料单" });
            result.Add(new { value = "direct", text = "直入直出单" });
            result.Add(new { value = "refund", text = "退库单" });
            result.Add(new { value = "rentin", text = "租赁进场单" });
            result.Add(new { value = "lossReport", text = "报损单" });
            result.Add(new { value = "transfer", text = "调拨单" });

            return result;
        }

        public static List<dynamic> GetAccountSrcBillTypeList()
        {
            var result = new List<dynamic>();
            result.Add(new { value = "receive", text = "收料单" });
            result.Add(new { value = "send", text = "发料单" });
            result.Add(new { value = "direct", text = "直入直出单" });
            result.Add(new { value = "refund", text = "退库单" });
            result.Add(new { value = "return", text = "退货单" });
            result.Add(new { value = "lossReport", text = "报损单" });
            result.Add(new { value = "transfer", text = "调拨单" });
            result.Add(new { value = "rentin", text = "租赁进场单" });

            return result;
        }


        //生成批次信息及更新来源单剩余数量
        public static void HandlerBillBatchesAfterEdit<TBill>(EditEventArgs arg)
        {
            #region 变量定义
            var billTable = typeof(TBill).Name;
            var billNo = arg.form["BillNo"].ToString();
            var userName = ErpHelper.GetUserName();
            var form = arg.db.Sql(String.Format("select * from {0} where BillNo='{1}'", billTable, billNo)).QuerySingle<dynamic>();

            var isBatch = billTable=="erp_lossReport" || form.PriceKind == "091";
            var table = new Dictionary<string, string>{ 
                {"receive","erp_receiveDetail"},
                {"refund","erp_refundDetail"},
                {"adjust","erp_stockAdjustDetail"}
            };
            #endregion


      
        }
    }
}