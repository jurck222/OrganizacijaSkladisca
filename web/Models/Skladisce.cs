using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public enum Cona
    {
        A, B, C
    }
    public class Skladisce
    {
        public int SkladisceId { get; set; }
        public int StudentID { get; set; }
        public Cona Cona { get; set; }
        public Izdelek? Izdelek{get;set;}
        public bool Zasedeno {get;set;}
    }
}