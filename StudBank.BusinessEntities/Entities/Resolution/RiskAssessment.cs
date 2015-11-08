using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class RiskAssessment : IEntity
    {
        [Key, ForeignKey("LoanAgreement")]
        public Guid LoanAgreementId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        [Required]
        public decimal Point { get; set; }
        [Required]
        public string Description { get; set; }

        [ForeignKey("LoanAgreementId")]
        public virtual LoanAgreement LoanAgreement { get; set; }
    }
}
