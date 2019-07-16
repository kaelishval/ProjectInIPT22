﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ipt2project.Models
{
    public class History
    {
        //internal static object id;

        public int HistoryId { get; set; }
        public string OrderName { get; set; }
        public string OrderDetails { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public DateTime Date_ordered { get; set; }
        public DateTime Date_delivered { get; set; }


    }
}