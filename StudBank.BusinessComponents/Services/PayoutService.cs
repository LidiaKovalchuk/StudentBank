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
    public class PayoutService : EntityService<Payout>
    {
        public PayoutService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(Payout entity)
        {
            return base.Add(entity);
        }

        public override bool Update(Payout entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(Payout entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<Payout> Get(Expression<Func<Payout, bool>> filter = null,
            Func<IQueryable<Payout>, IOrderedQueryable<Payout>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
