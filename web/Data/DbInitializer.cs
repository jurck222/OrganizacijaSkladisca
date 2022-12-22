using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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
            if (!context.Roles.Any())
            {
            var roles = new IdentityRole[]{
                new IdentityRole{Id="0",Name="Admin"},
                new IdentityRole{Id="1", Name="WarehouseLeader"},
                new IdentityRole{Id="2", Name="Worker"}
            };
            
            foreach (IdentityRole r in roles)
            {
                context.Roles.Add(r);
            }
            
            if (!context.Users.Any())
            {
            var user = new ApplicationUser
            {
                FirstName = "Admin",
                LastName = "Admin",
                City = "Ljubljana",
                Email = "admin@gmail.com",
                NormalizedEmail = "XXXX@GMAIL.COM",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var user2 = new ApplicationUser
            {
                FirstName = "delavec",
                LastName = "delavec",
                City = "Ljubljana",
                Email = "delavec@gmail.com",
                NormalizedEmail = "XXXX@GMAIL.COM",
                UserName = "delavec@gmail.com",
                NormalizedUserName = "delavec@gmail.com",
                PhoneNumber = "+111111111121",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            if (!context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user,"Admin123!");
                user.PasswordHash = hashed;
                context.Users.Add(user);
                password = new PasswordHasher<ApplicationUser>();
                hashed = password.HashPassword(user2,"Delo123!");
                user2.PasswordHash = hashed;
                context.Users.Add(user2);
                
            }
            
            context.SaveChanges();
            var UserRoles = new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>{RoleId = roles[0].Id, UserId=user.Id},
                new IdentityUserRole<string>{RoleId = roles[2].Id, UserId=user2.Id},
            };
            foreach (IdentityUserRole<string> r in UserRoles)
            {
                context.UserRoles.Add(r);
            }
            context.SaveChanges();
            // Look for any warehouses.
            }
            }
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
