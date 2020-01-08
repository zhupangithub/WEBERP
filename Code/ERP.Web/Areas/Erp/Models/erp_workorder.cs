using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace ERP.Web.Models
{
    [Module("Erp")]
    public class erp_workorderService : ServiceBase<erp_workorder>
    {
       
    }

    public class erp_workorder : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        [PrimaryKey]
        public string no{ get; set; }
        public string con_no{ get; set; }
        public string product_name{ get; set; }
        public DateTime delivery_date { get; set; }
        public Guid erp_parts_id{ get; set; }
        public int parts_id{ get; set; }
        public string parts_name{ get; set; }
        public Guid erp_process_id{ get; set; }
        public int process_id{ get; set; }
        public string process_name{ get; set; }
        public string panel{ get; set; }
        public int number{ get; set; }
        public int? practical_number{ get; set; }
        public int? loss_number{ get; set; }
        public string unit{ get; set; }
        public int? workshop_id{ get; set; }
        public string workshop_name{ get; set; }
        public string remarrk{ get; set; }
        public int state{ get; set; }
        public string arrange_username{ get; set; }
        public DateTime? arrange_time{ get; set; }
        public string complete_username{ get; set; }
        public DateTime? complete_time{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
