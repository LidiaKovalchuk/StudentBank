using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using StudBank.BusinessEntities;

namespace StudBank.DataAccessLayer
{
    public class StudBankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<AgreementTemplate> AgreementTemplates { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<LoanAgreement> LoanAgreement { get; set; }
        public DbSet<LoanApplication> LoanApplications { get; set; }
        public DbSet<LoanGuarantee> LoanGuarantee { get; set; }
        public DbSet<LoanProviding> LoanProvidings { get; set; }
        public DbSet<LoanRepayment> LoanRepayments { get; set; }

        public StudBankContext(bool useInitializer = false) : base ()
        {
            if(useInitializer)
                Database.SetInitializer(new BankInitializer());
        }
        public StudBankContext(string nameOrConnectionString, bool useInitializer = false) : base (nameOrConnectionString)
        {
            if(useInitializer)
                Database.SetInitializer(new BankInitializer());
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
    }
}
