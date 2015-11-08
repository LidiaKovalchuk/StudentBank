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
    public class RiskAssessmentService : EntityService<RiskAssessment>
    {
        public RiskAssessmentService(DbContext dbContext):base(dbContext)
        {
        }

        public override bool Add(RiskAssessment entity)
        {
            return base.Add(entity);
        }

        public override bool Update(RiskAssessment entity)
        {
            return base.Update(entity);
        }

        public override bool Delete(RiskAssessment entity)
        {
            return base.Delete(entity);
        }

        public override IEnumerable<RiskAssessment> Get(Expression<Func<RiskAssessment, bool>> filter = null,
            Func<IQueryable<RiskAssessment>, IOrderedQueryable<RiskAssessment>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, includeProperties);
        }
    }
}
