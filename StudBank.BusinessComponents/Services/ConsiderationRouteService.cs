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
    public class ConsiderationRouteService : EntityService<ConsiderationRoute>
    {
        public ConsiderationRouteService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(ConsiderationRoute entity)
        {
            return base.Add(entity);
        }

        public override bool Update(ConsiderationRoute entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(ConsiderationRoute entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<ConsiderationRoute> Get(Expression<Func<ConsiderationRoute, bool>> filter = null,
            Func<IQueryable<ConsiderationRoute>, IOrderedQueryable<ConsiderationRoute>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
