using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class base_productService : ServiceBase<base_product>
    {
       
    }

    public class base_product : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string name{ get; set; }
        public string type{ get; set; }
        public string guige{ get; set; }
        public string unit{ get; set; }
        public decimal price{ get; set; }
        public bool isenable{ get; set; }
        public string remark{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
