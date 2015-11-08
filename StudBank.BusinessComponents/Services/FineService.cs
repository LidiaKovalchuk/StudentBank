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
    public class FineService : EntityService<Fine>
    {
        public FineService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(Fine entity)
        {
            return base.Add(entity);
        }

        public override bool Update(Fine entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(Fine entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<Fine> Get(Expression<Func<Fine, bool>> filter = null,
            Func<IQueryable<Fine>, IOrderedQueryable<Fine>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
