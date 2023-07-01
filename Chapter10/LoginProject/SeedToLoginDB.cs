using LoginProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    public class SeedToLoginDB
    {
        public void Seed()
        {
            using (LoginContext context = new LoginContext())
            {
                context.Database.EnsureCreated();
                if (context.roles.Count() == 0)
                {

                    context.roles.AddRange(new Role[]
                        {
                    new Role() { RoleName = RoleName.Admin },
                    new Role() { RoleName = RoleName.Guest },
                    new Role() { RoleName = RoleName.VIP },
                    new Role() { RoleName = RoleName.Regular }

                        });
                    context.SaveChanges();
                }
                if(context.users.Count() == 0)
                {
                    Role _role = context.roles.FirstOrDefault(r => r.RoleName == RoleName.Admin);
                    context.users.Add(new User() { Username = "Filip", Password = "Filip123!", Role = _role });
                    context.SaveChanges();          
                }
                
            }
        }


    }
}
