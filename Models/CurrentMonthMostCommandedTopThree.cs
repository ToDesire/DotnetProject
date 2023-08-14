using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Models
{
    public class CurrentMonthMostCommandedTopThree
    {
        public string product_name { get; set; }
        public int commanded_quantity { get; set; }
        public string product_description { get; set; }
        public string product_image { get; set; }
        public int command_number { get; set; }
    }
}