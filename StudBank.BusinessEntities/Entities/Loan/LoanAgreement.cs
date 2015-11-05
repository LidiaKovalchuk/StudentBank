using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class LoanAgreement : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid LoanTypeId { get; set; }
        [Required]
        public Guid LoanProvidingId { get; set; }
        [Required]
        public Guid LoanRepaymentId { get; set; }
        [Required]
        public Guid LoanGuaranteeId { get; set; }
        [Required]
        public Guid AgreementTemplateId { get; set; }
        
        [Required]
        public Guid ClientId { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime AgreementDate { get; set; }
        
        [Required, StringLength(50)]
        public string ClientFirstName { get; set; }
        [Required, StringLength(50)]
        public string ClientMiddleName { get; set; }
        [Required, StringLength(50)]
        public string ClientLastName { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime Term { get; set; }      
        [Required]
        public decimal Amount { get; set; }   
        [Required]
        public decimal LoanAccount { get; set; }
        [Required]
        public decimal RepaymentAccount { get; set; }

        [Required]
        public decimal ProcessingFee { get; set; }
        [Required]
        public decimal MonthlyFee { get; set; }
        [Required]
        public decimal RateOfInterest { get; set; }
        [Required]
        public decimal FineRateOfInterest { get; set; }
        [Required]
        public bool IsFixedRateOfInterest { get; set; }
        [Required]
        public string FineContidions { get; set; }

        public string AdditionalInfo { get; set; }

        public virtual LoanType LoanType { get; set; }
        public virtual LoanProviding LoanProviding { get; set; }
        public virtual LoanRepayment LoanRepayment { get; set; }
        public virtual LoanGuarantee LoanGuarantee { get; set; }
        public virtual AgreementTemplate AgreementTemplate { get; set; }
    }
}
