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

        [PrimaryKey]
        public Guid id{ get; set; }
        public string con_no{ get; set; }
        public int parts_id{ get; set; }
        public string parts_name{ get; set; }
        public string parts_guige{ get; set; }
        public int number{ get; set; }
        public int state{ get; set; }
        public string remarrk{ get; set; }
    }
}
