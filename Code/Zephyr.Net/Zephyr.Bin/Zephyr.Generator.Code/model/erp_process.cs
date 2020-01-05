using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class erp_processService : ServiceBase<erp_process>
    {
       
    }

    public class erp_process : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public string con_no{ get; set; }
        public int erp_parts_id{ get; set; }
        public string process_no{ get; set; }
        public string process_name{ get; set; }
        public int sort{ get; set; }
        public int number{ get; set; }
        public int? practical_number{ get; set; }
        public int? loss_number{ get; set; }
        public bool is_waifa{ get; set; }
        public string unit{ get; set; }
        public string knife_no{ get; set; }
        public string remarrk{ get; set; }
        public int state{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
