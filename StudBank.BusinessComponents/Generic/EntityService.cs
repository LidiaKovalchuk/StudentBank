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
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class, IEntity
    {
        protected DbContext context;

        public EntityService(DbContext dbContext)
        {
            context = dbContext;
        }

        public virtual bool Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity is null.");
            }
            context.Set<TEntity>().Add(entity);
            return true;
        }

        public virtual bool Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null.");
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public virtual bool Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null.");
            if (context.Entry(entity).State == EntityState.Detached)
                context.Set<TEntity>().Attach(entity);

            context.Set<TEntity>().Remove(entity);
            return true;
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = context.Set<TEntity>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
