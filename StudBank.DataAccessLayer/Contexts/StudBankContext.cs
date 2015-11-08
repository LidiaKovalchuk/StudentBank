using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using StudBank.BusinessEntities;

namespace StudBank.DataAccessLayer
{
    public class StudBankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BankTransfer> BankTransfers { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Payout> Payouts { get; set; }
        public DbSet<ClientWithdrawal> ClientWithdrawal { get; set; }
        public DbSet<PayoutStatus> PayoutStatuses { get; set; }
        public DbSet<RiskAssessment> RiskAssesments { get; set; }
        public DbSet<BankConstants> BankConstants { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CreditHistoryRecord> CreditHistoryRecords { get; set; }
        public DbSet<ConsiderationRoute> ConsiderationRoutes { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanApplication> LoanApplications { get; set; }
        public DbSet<LoanAgreement> LoanAgreements { get; set; }
        public DbSet<SuretyAgreement> SuretyAgreements { get; set; }
        public DbSet<BailAgreement> BailAgreements { get; set; }
        public DbSet<SystemResolution> SystemResolutions { get; set; }
        public DbSet<SecurityResolution> SecurityResolutions { get; set; }
        public DbSet<ExpertResolution> ExpertResolutions { get; set; }
        public DbSet<CommitteeResolution> CommitteeResolutions { get; set; }

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
