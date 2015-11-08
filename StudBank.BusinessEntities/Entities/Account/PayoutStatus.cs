using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class PayoutStatus : IEntity
    {
        [Key, ForeignKey("LoanAgreement")]
        public Guid LoanAgreementId { get; set; }
        [Required]
        public decimal RepaidTotalAmount { get; set; }
        [Required]
        public decimal LoanAmount { get; set; }
        [Required]
        public decimal CurrentRateOfInterest{ get; set; }
        [Required]
        public decimal CurrentFineRateOfInterest { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime NextPayoutDeadlineDate { get; set; }

        [ForeignKey("LoanAgreementId")]
        public virtual LoanAgreement LoanAgreement { get; set; }
    }
}
