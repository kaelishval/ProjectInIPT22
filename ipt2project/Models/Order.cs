using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ipt2project.Models
{
    public class Order
    {
        internal static object id;

        public int Id { get; set; }
        public string OrderName { get; set; }
        public string OrderDetails { get; set; }
        public string Price { get;set;  }
    }
}