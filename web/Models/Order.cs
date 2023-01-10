using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    
    public class Order
    {
        public int OrderID { get; set; }
        public string Code { get; set; }
        public Article Article {get;set;}
        public int Quantity {get;set;}
        public Warehouse Warehouse {get;set;}
        public Zone Zone { get; set; }
    }
}