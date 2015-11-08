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
    public class PayoutStatusService : EntityService<PayoutStatus>
    {
        public PayoutStatusService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(PayoutStatus entity)
        {
            return base.Add(entity);
        }

        public override bool Update(PayoutStatus entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(PayoutStatus entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<PayoutStatus> Get(Expression<Func<PayoutStatus, bool>> filter = null,
            Func<IQueryable<PayoutStatus>, IOrderedQueryable<PayoutStatus>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
