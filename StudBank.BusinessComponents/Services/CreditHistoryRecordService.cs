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
    public class CreditHistoryRecordService : EntityService<CreditHistoryRecord>
    {
        public CreditHistoryRecordService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(CreditHistoryRecord entity)
        {
            return base.Add(entity);
        }

        public override bool Update(CreditHistoryRecord entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(CreditHistoryRecord entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<CreditHistoryRecord> Get(Expression<Func<CreditHistoryRecord, bool>> filter = null,
            Func<IQueryable<CreditHistoryRecord>, IOrderedQueryable<CreditHistoryRecord>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
