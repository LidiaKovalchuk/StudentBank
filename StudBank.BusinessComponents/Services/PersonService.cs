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
    public class PersonService : EntityService<Person>
    {
        public PersonService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(Person entity)
        {
            return base.Add(entity);
        }

        public override bool Update(Person entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(Person entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<Person> Get(Expression<Func<Person, bool>> filter = null,
            Func<IQueryable<Person>, IOrderedQueryable<Person>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
