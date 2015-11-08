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
    public class SuretyAgreementService : EntityService<SuretyAgreement>
    {
        public SuretyAgreementService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(SuretyAgreement entity)
        {
            return base.Add(entity);
        }

        public override bool Update(SuretyAgreement entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(SuretyAgreement entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<SuretyAgreement> Get(Expression<Func<SuretyAgreement, bool>> filter = null,
            Func<IQueryable<SuretyAgreement>, IOrderedQueryable<SuretyAgreement>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
