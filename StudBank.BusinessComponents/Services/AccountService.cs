using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

using StudBank.BusinessEntities;

namespace StudBank.BusinessComponents
{
    public class AccountService : EntityService<Account>
    {
        public AccountService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(Account entity)
        {
            return base.Add(entity);
        }

        public override bool Update(Account entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(Account entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<Account> Get(Expression<Func<Account, bool>> filter = null,
            Func<IQueryable<Account>, IOrderedQueryable<Account>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
