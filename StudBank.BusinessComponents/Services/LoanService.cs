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
    public class LoanService : EntityService<Loan>
    {
        public LoanService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(Loan entity)
        {
            return base.Add(entity);
        }

        public override bool Update(Loan entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(Loan entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<Loan> Get(Expression<Func<Loan, bool>> filter = null,
            Func<IQueryable<Loan>, IOrderedQueryable<Loan>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
