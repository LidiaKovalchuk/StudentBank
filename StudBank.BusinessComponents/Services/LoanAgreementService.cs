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
    public class LoanAgreementService : EntityService<LoanAgreement>
    {
        public LoanAgreementService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(LoanAgreement entity)
        {
            return base.Add(entity);
        }

        public override bool Update(LoanAgreement entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(LoanAgreement entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<LoanAgreement> Get(Expression<Func<LoanAgreement, bool>> filter = null,
            Func<IQueryable<LoanAgreement>, IOrderedQueryable<LoanAgreement>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
