using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace ERP.Web.Models
{
    [Module("Erp")]
    public class erp_processService : ServiceBase<erp_process>
    {
       
    }

    public class erp_process : ModelBase
    {

        [PrimaryKey]
        public Guid id{ get; set; }
        public string con_no{ get; set; }
        public Guid erp_parts_id{ get; set; }
        public int process_id{ get; set; }
        public string process_name{ get; set; }
        public int sort{ get; set; }
        public int number{ get; set; }
        public bool is_waifa{ get; set; }
        public string unit{ get; set; }
        public string panel{ get; set; }
        public string remarrk{ get; set; }
    }
}
