using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public enum Zone
    {
        A, B, C
    }
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseCode {get; set;}
        public Zone Zone { get; set; }
        public Article? Article{get;set;}
        public bool Full {get;set;}
    }
}