using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ICollection<Warehouse>? Warehouse { get; set; }
    }
}