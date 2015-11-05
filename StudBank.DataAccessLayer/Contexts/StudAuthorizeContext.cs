using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;

using StudBank.BusinessEntities;

namespace StudBank.DataAccessLayer
{
    public class StudAuthorizeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public StudAuthorizeContext(bool useInitializer = false) : base ()
        {
            if(useInitializer)
                Database.SetInitializer(new AuthorizationInitializer());
        }
        public StudAuthorizeContext(string nameOrConnectionString, bool useInitializer = false) : base(nameOrConnectionString)
        {
            if (useInitializer)
                Database.SetInitializer(new AuthorizationInitializer());
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                string rs = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    rs = string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        rs += string.Format(" Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new Exception(rs, e);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}