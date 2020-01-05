using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace ERP.Web.Models
{
    [Module("Erp")]
    public class base_technologyService : ServiceBase<base_technology>
    {
       
    }

    public class base_technology : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int parts_id{ get; set; }
        public string name{ get; set; }
        public int orderby{ get; set; }
        public string remark{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
