using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Models
{
    public class CurrentMonthMostOrderedTopThree
    {
        public string product_name { get; set; }
        public int ordered_quantity { get; set; }
        public string product_description { get; set; }
        public string product_image { get; set; }
        public int order_number { get; set; }
    }
}