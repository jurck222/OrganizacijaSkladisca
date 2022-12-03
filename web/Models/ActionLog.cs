using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class ActionLog
    {
        public int ActionLogID { get; set; }
        public string Code { get; set; }
        public Article Article{get;set;}
        public int Quantity {get;set;}
    }
}