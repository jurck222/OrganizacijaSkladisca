using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Izdelek
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Sifra { get; set; }
        public int Kolicina { get; set; }
        public ICollection<Skladisce>? Skladisca { get; set; }
    }
}