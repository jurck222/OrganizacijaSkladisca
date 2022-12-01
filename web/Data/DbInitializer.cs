using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;

namespace web.Data
{
    public class DbInitializer
    {
        public static void Initialize(WarehouseContext context)
        {
            context.Database.EnsureCreated();
            // Look for any articles.
            if (!context.Articles.Any())
            {
                var articles = new Article[]
                {
                    new Article{Code=1237,Description="Plošča",Quantity=5},
                    new Article{Code=174,Description="Paleta",Quantity=5},
                    new Article{Code=695,Description="Škatla",Quantity=5}
                };

                context.Articles.AddRange(articles);
                context.SaveChanges();
            }

            // Look for any warehouses.
            if (!context.Warehouses.Any())
            {
                var warehouses = new Warehouse[]
                {
                    new Warehouse{WarehouseCode="Skladisce 1",Zone=Zone.A,Full=false}
                };
                context.Warehouses.AddRange(warehouses);
                context.SaveChanges();
            }
        }
    }
}
