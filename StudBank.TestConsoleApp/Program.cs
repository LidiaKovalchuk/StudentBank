using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudBank.BusinessComponents;
using StudBank.BusinessEntities;
using StudBank.DataAccessLayer;

namespace StudBank.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var authContext = new StudAuthorizeContext(true))
            {
                var userService = new EntityService<User>(authContext);
                var roleService = new EntityService<Role>(authContext);
                foreach (var user in userService.Get(includeProperties: "Roles"))
                {
                    System.Console.WriteLine(string.Format("{0} {1} {2} {3}", user.FirstName,
                        user.MiddleName, user.LastName, user.Roles.First().Name));
                }
                System.Console.WriteLine();

                userService.Get(user => user.FirstName == "Ivan").First().FirstName = "Vano";
                authContext.SaveChanges();

                foreach (var user in userService.Get(includeProperties: "Roles"))
                {
                    System.Console.WriteLine(string.Format("{0} {1} {2} {3}", user.FirstName,
                        user.MiddleName, user.LastName, user.Roles.First().Name));
                }
            }
            System.Console.ReadKey(true);            
        }
    }
}
