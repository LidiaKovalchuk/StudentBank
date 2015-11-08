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
    public class LoanApplicationService : EntityService<LoanApplication>
    {
        public LoanApplicationService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(LoanApplication entity)
        {
            return base.Add(entity);
        }

        public override bool Update(LoanApplication entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(LoanApplication entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<LoanApplication> Get(Expression<Func<LoanApplication, bool>> filter = null,
            Func<IQueryable<LoanApplication>, IOrderedQueryable<LoanApplication>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
