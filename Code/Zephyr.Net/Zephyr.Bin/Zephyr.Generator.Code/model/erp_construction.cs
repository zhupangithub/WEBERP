using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class erp_constructionService : ServiceBase<erp_construction>
    {
       
    }

    public class erp_construction : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        [PrimaryKey]
        public string no{ get; set; }
        public int product_id{ get; set; }
        public string product_name{ get; set; }
        public string customer_no{ get; set; }
        public string customer_name{ get; set; }
        public int number{ get; set; }
        public int? practical_number{ get; set; }
        public int? loss_number{ get; set; }
        public string guige{ get; set; }
        public string zhuangdinfa{ get; set; }
        public string baozhuangfa{ get; set; }
        public string address{ get; set; }
        public date delivery_date{ get; set; }
        public string source_no{ get; set; }
        public int state{ get; set; }
        public DateTime? affirm_time{ get; set; }
        public string affirm_username{ get; set; }
        public DateTime? finish_time{ get; set; }
        public string finish_username{ get; set; }
        public DateTime create_time{ get; set; }
        public string create_username{ get; set; }
    }
}
