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
    public class SystemResolutionService : EntityService<SystemResolution>
    {
        public SystemResolutionService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(SystemResolution entity)
        {
            return base.Add(entity);
        }

        public override bool Update(SystemResolution entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(SystemResolution entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<SystemResolution> Get(Expression<Func<SystemResolution, bool>> filter = null,
            Func<IQueryable<SystemResolution>, IOrderedQueryable<SystemResolution>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
