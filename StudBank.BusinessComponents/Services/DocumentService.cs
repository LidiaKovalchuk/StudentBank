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
    public class DocumentService : EntityService<Document>
    {
        public DocumentService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(Document entity)
        {
            return base.Add(entity);
        }

        public override bool Update(Document entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(Document entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<Document> Get(Expression<Func<Document, bool>> filter = null,
            Func<IQueryable<Document>, IOrderedQueryable<Document>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
