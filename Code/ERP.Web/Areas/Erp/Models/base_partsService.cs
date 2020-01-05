using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace ERP.Web.Models
{
    [Module("Erp")]
    public class base_partsService : ServiceBase<base_parts>
    {
       
    }

    public class base_parts : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string name{ get; set; }
        public string type{ get; set; }
        public string unit{ get; set; }
        public string guige{ get; set; }
        public bool isenable{ get; set; }
        public string remark{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
