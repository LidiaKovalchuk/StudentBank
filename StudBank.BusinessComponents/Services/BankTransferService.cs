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
    public class BankTransferService : EntityService<BankTransfer>
    {
        public BankTransferService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(BankTransfer entity)
        {
            return base.Add(entity);
        }

        public override bool Update(BankTransfer entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(BankTransfer entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<BankTransfer> Get(Expression<Func<BankTransfer, bool>> filter = null,
            Func<IQueryable<BankTransfer>, IOrderedQueryable<BankTransfer>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
