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
    public class BankConstantsService : EntityService<BankConstants>
    {
        public BankConstantsService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(BankConstants entity)
        {
            return base.Add(entity);
        }

        public override bool Update(BankConstants entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(BankConstants entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<BankConstants> Get(Expression<Func<BankConstants, bool>> filter = null,
            Func<IQueryable<BankConstants>, IOrderedQueryable<BankConstants>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
