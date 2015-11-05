using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class Loan: IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid LoanTypeId { get; set; }
        [Required]
        public Guid LoanProvidingId { get; set; }
        [Required]
        public Guid LoanRepaymentId { get; set; }
        [Required]
        public Guid LoanGuaranteeId { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime MaxTerm { get; set; }
        [Required]
        public decimal MaxAmount { get; set; }
        [Required]
        public decimal ProcessingFee { get; set; }
        [Required]
        public decimal MonthlyFee { get; set; }
        [Required]
        public decimal RateOfInterest { get; set; }
        [Required]
        public bool IsFixedRateOfInterest { get; set; }
        [Required]
        public decimal FineRateOfInterest { get; set; }
        [Required]
        public string FineContitions { get; set; }     

        public virtual LoanType LoanType { get; set; }
        public virtual LoanProviding LoanProviding { get; set; }
        public virtual LoanRepayment LoanRepayment { get; set; }
        public virtual LoanGuarantee LoanGuarantee { get; set; }

        public virtual ICollection<SystemResolution> SystemResolutions { get; set; }
    }
}
