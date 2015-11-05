using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class LoanApplication : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid PersonId { get; set; }
        [Required]
        public Guid LoanId { get; set; }

        [Required]
        public Guid SecurityResolutionId { get; set; }
        [Required]
        public Guid SystemResolutionId { get; set; }
        [Required]
        public Guid ExpertResolutionId { get; set; }
        [Required]
        public Guid CommitteeResolutionId { get; set; }

        [Required]
        public string Goal { get; set; }

        public virtual Person Person { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual CommitteeResolution CommitteeResolution { get; set; }
        public virtual ExpertResolution ExpertResolution { get; set; }
        public virtual SecurityResolution SecurityResolution { get; set; }
        public virtual SystemResolution SystemResolution { get; set; }
    }
}
