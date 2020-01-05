using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class erp_partsService : ServiceBase<erp_parts>
    {
       
    }

    public class erp_parts : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public string con_no{ get; set; }
        public string parts_no{ get; set; }
        public string parts_name{ get; set; }
        public int number{ get; set; }
        public int state{ get; set; }
        public string remarrk{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
