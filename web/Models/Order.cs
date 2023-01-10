using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderCode { get; set; }
        public int ArticleCode {get;set;}
        public int Quantity {get;set;}
        public string WarehouseName {get;set;}
        public string WhouseZone {get;set;}
    }
}