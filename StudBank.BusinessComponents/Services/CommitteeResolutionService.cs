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
    public class CommitteeResolutionService : EntityService<CommitteeResolution>
    {
        public CommitteeResolutionService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(CommitteeResolution entity)
        {
            return base.Add(entity);
        }

        public override bool Update(CommitteeResolution entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(CommitteeResolution entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<CommitteeResolution> Get(Expression<Func<CommitteeResolution, bool>> filter = null,
            Func<IQueryable<CommitteeResolution>, IOrderedQueryable<CommitteeResolution>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
