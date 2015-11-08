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
    public class BailAgreementService : EntityService<BailAgreement>
    {
        public BailAgreementService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(BailAgreement entity)
        {
            return base.Add(entity);
        }

        public override bool Update(BailAgreement entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(BailAgreement entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<BailAgreement> Get(Expression<Func<BailAgreement, bool>> filter = null,
            Func<IQueryable<BailAgreement>, IOrderedQueryable<BailAgreement>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
