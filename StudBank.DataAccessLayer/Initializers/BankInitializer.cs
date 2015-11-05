using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using StudBank.BusinessEntities;

namespace StudBank.DataAccessLayer
{
    public class BankInitializer : DropCreateDatabaseAlways<StudBankContext>
    {
        protected override void Seed(StudBankContext context)
        {
            #region AccountTypes
            var accountTypes = new List<AccountType>
            {
                new AccountType { Name = "AccountType1"},
                new AccountType { Name = "AccountType2"},
                new AccountType { Name = "AccountType3"},
            };
            accountTypes.ForEach(item => context.AccountTypes.Add(item));
            context.SaveChanges();
            #endregion

            #region Accounts
            var users = new List<Account>
            {
                new Account{ AccountTypeId = accountTypes[0].Id, MoneyAmount = 200.13415452m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[0].Id, MoneyAmount = 12.13m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[0].Id, MoneyAmount = 1m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[1].Id, MoneyAmount = 0m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[1].Id, MoneyAmount = 3881234.62424m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[2].Id, MoneyAmount = 22341516163.334141435452m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[2].Id, MoneyAmount = 1315135.431452m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[2].Id, MoneyAmount = 213.13415452m, OpenedDate = DateTime.Now},
                new Account{ AccountTypeId = accountTypes[2].Id, MoneyAmount = 1.13415452m, OpenedDate = DateTime.Now},
            };
            users.ForEach(item => context.Accounts.Add(item));
            context.SaveChanges();
            #endregion
        }
    }
}