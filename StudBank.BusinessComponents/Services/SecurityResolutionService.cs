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
    public class SecurityResolutionService : EntityService<SecurityResolution>
    {
        public SecurityResolutionService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(SecurityResolution entity)
        {
            return base.Add(entity);
        }

        public override bool Update(SecurityResolution entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(SecurityResolution entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<SecurityResolution> Get(Expression<Func<SecurityResolution, bool>> filter = null,
            Func<IQueryable<SecurityResolution>, IOrderedQueryable<SecurityResolution>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
