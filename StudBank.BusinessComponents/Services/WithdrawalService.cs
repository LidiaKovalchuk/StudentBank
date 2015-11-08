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
    public class WithdrawalService : EntityService<ClientWithdrawal>
    {
        public WithdrawalService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(ClientWithdrawal entity)
        {
            return base.Add(entity);
        }

        public override bool Update(ClientWithdrawal entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(ClientWithdrawal entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<ClientWithdrawal> Get(Expression<Func<ClientWithdrawal, bool>> filter = null,
            Func<IQueryable<ClientWithdrawal>, IOrderedQueryable<ClientWithdrawal>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
