using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using StudBank.BusinessEntities;

namespace StudBank.DataAccessLayer
{
    public class AuthorizationInitializer : DropCreateDatabaseAlways<StudAuthorizeContext>
    {
        protected override void Seed(StudAuthorizeContext context)
        {
            #region Roles
            var roles = new List<Role>
            {
                new Role{ Name="Admin" },
                new Role{ Name="User"},
            };
            roles.ForEach(item => context.Roles.Add(item));
            context.SaveChanges();
            #endregion

            #region Users
            var users = new List<User>
            {
                new User{ Login = "user1", Password = "pass1", Email = "email1", CreatedDate = DateTime.Now, 
                    FirstName = "Ivan", MiddleName = "Ivanovich", LastName = "Ivanov",
                    Roles = new List<Role>(new Role[] {roles[0]}) },
                new User{ Login = "user2", Password = "pass2", Email = "email2", CreatedDate = DateTime.Now, 
                    FirstName = "Petr", MiddleName = "Petrovich", LastName = "Petrov",
                    Roles = new List<Role>(new Role[] {roles[1]}) },
                new User{ Login = "user3", Password = "pass3", Email = "email3", CreatedDate = DateTime.Now, 
                    FirstName = "Nikolay", MiddleName = "Nikolayvich", LastName = "Nikolayov",
                    Roles = new List<Role>(new Role[] {roles[1]}) },
                new User{ Login = "user4", Password = "pass4", Email = "email4", CreatedDate = DateTime.Now, 
                    FirstName = "Vasiliy", MiddleName = "Vasiliyvich", LastName = "Vasiliyov",
                    Roles = new List<Role>(new Role[] {roles[1]}) },
                new User{ Login = "user5", Password = "pass5", Email = "email5", CreatedDate = DateTime.Now, 
                    FirstName = "Andrey", MiddleName = "Andreyvich", LastName = "Andreyov",
                    Roles = new List<Role>(new Role[] {roles[1]}) },
            };
            users.ForEach(item => context.Users.Add(item));
            context.SaveChanges();
            #endregion
        }
    }
}