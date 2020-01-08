using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace ERP.Web.Models
{
    [Module("Erp")]
    public class erp_workorder_produceService : ServiceBase<erp_workorder_produce>
    {
       
    }

    public class erp_workorder_produce : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public string workorder_no{ get; set; }
        public string product_name{ get; set; }
        public string parts_name{ get; set; }
        public string process_name{ get; set; }
        public int number{ get; set; }
        public int produce_number{ get; set; }
        public int? warehouse_id{ get; set; }
        public string warehouse_name{ get; set; }
        public int? area_id{ get; set; }
        public string area_name{ get; set; }
        public int? location_id{ get; set; }
        public int? location_name{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
