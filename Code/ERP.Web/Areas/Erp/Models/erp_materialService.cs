using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;
using Zephyr.Utils;

namespace ERP.Web.Models
{
	[Module("Erp")]
    public class erp_materialService : ServiceBase<base_material>
    {
        
    }

    public class base_material : ModelBase
    {

        [PrimaryKey]
        public Guid id { get; set; }
        public string no { get; set; }
        public string name { get; set; }
        public Guid type { get; set; }
        public decimal price { get; set; }
        public bool isenable { get; set; }
        public string remark { get; set; }
        public DateTime create_time { get; set; }
        public string create_username { get; set; }
    }
}
