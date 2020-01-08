using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace ERP.Web.Models
{
    [Module("Erp")]
    public class erp_purchaseService : ServiceBase<erp_purchase>
    {
       
    }

    public class erp_purchase : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        [PrimaryKey]
        public string no{ get; set; }
        public string source_no{ get; set; }
        public int type{ get; set; }
        public int supplier_id{ get; set; }
        public int supplier_name{ get; set; }
        public DateTime delivery_date { get; set; }
        public int parts_id{ get; set; }
        public string parts_name{ get; set; }
        public int process_id{ get; set; }
        public string process_name{ get; set; }
        public int number{ get; set; }
        public decimal price{ get; set; }
        public decimal account{ get; set; }
        public string unit{ get; set; }
        public string remarrk{ get; set; }
        public int state{ get; set; }
        public string arrange_username{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
