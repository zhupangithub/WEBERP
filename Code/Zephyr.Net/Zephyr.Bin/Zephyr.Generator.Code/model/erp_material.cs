using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class erp_materialService : ServiceBase<erp_material>
    {
       
    }

    public class erp_material : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public string con_no{ get; set; }
        public int erp_parts_id{ get; set; }
        public string material_no{ get; set; }
        public string material_name{ get; set; }
        public bool is_waifadailiao{ get; set; }
        public int? number{ get; set; }
        public string unit{ get; set; }
        public string remarrk{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
