using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class LoanAgreement : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid LoanApplicationId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid ClientId { get; set; }
        [Required]
        public Guid LoanAccountId { get; set; }
        [Required]
        public Guid RepaymentAccountId { get; set; }
        [Required]
        public Guid ConstantsId { get; set; }
        public Guid AgreementDocumentId { get; set; }

        [Required]
        public LoanTypes LoanType { get; set; }
        [Required]
        public LoanGuarantees LoanGuarantee { get; set; }
        [Required]
        public LoanProvidings LoanProviding { get; set; }
        [Required]
        public LoanRepayments LoanRepayment { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }
        [Required]
        public int Term { get; set; }      
        [Required]
        public decimal Amount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }
        [Required]
        public decimal ProcessingFee { get; set; }
        [Required]
        public decimal MonthlyFee { get; set; }
        [Required]
        public decimal RateOfInterest { get; set; }
        [Required]
        public bool IsFixedRateOfInterest { get; set; }
        [Required]
        public string FineContidions { get; set; }
        [Required]
        public string PrepaymentConditions { get; set; }
        [Required]
        public string PrivelegesConditions { get; set; }

        [StringLength(50)]
        public string Goal { get; set; }

        public string AdditionalInfo { get; set; }

        [ForeignKey("LoanApplicationId")]
        public virtual LoanApplication LoanApplication { get; set; }     
        [ForeignKey("LoanAccountId")]
        public virtual Account LoanAccount { get; set; }
        [ForeignKey("RepaymentAccountId")]
        public virtual Account RepaymentAccount { get; set; }
        [ForeignKey("ConstantsId")]
        public virtual BankConstants BankConstants { get; set; }
        [ForeignKey("AgreementDocumentId")]
        public virtual Document AgreementDocument { get; set; }

        [ForeignKey("ClientId"), InverseProperty("ClientLoanAgreements")]
        public virtual Person Client { get; set; }

        [InverseProperty("LoanAgreement")]
        public virtual PayoutStatus PayoutStatus { get; set; }
        [InverseProperty("LoanAgreement")]
        public virtual RiskAssessment RiskAssesment { get; set; }

        [InverseProperty("LoanAgreement")]
        public virtual ICollection<Fine> Fines { get; set; }
        [InverseProperty("LoanAgreement")]
        public virtual ICollection<Payout> Payouts { get; set; }
        [InverseProperty("LoanAgreement")]
        public virtual ICollection<ClientWithdrawal> ClientWithdrawals { get; set; }
    }
}
