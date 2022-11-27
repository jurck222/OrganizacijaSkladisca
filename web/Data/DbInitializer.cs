using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;

namespace web.Data
{
    public class DbInitializer
    {
       public static void Initialize(SkladisceContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Izdelki.Any())
            {
                return;   // DB has been seeded
            }

            var izdelki = new Izdelek[]
            {
                new Izdelek{Name="Plosca",Sifra=12345,Kolicina=5}
            };

            context.Izdelki.AddRange(izdelki);
            context.SaveChanges();

            

            var skladisca = new Skladisce[]
            {
                new Skladisce{StudentID=0,Cona=Cona.A,Zasedeno=false}
            };

            context.Skladisca.AddRange(skladisca);
            context.SaveChanges();
        }
    } 
}
