using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class base_customerService : ServiceBase<base_customer>
    {
       
    }

    public class base_customer : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string jc_name{ get; set; }
        public string name{ get; set; }
        public string contacts{ get; set; }
        public string contacts_phone{ get; set; }
        public string email{ get; set; }
        public string grade{ get; set; }
        public string address{ get; set; }
        public bool isenable{ get; set; }
        public string remark{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
