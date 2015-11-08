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
    public class ExpertResolutionService : EntityService<ExpertResolution>
    {
        public ExpertResolutionService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(ExpertResolution entity)
        {
            return base.Add(entity);
        }

        public override bool Update(ExpertResolution entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(ExpertResolution entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<ExpertResolution> Get(Expression<Func<ExpertResolution, bool>> filter = null,
            Func<IQueryable<ExpertResolution>, IOrderedQueryable<ExpertResolution>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
