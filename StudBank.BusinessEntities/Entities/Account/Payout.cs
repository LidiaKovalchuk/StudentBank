using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public enum PayoutWays { None = 0, Other, BankBranch, NoncashTransfer }

    public class Payout : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid LoanAgreementId { get; set; }
        [Required]
        public Guid AccountId { get; set; }
        [Required]
        public PayoutWays PayoutWay { get; set; }
        
        [Required, Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public decimal LoanAmount { get; set; }
        [Required]
        public decimal InterestAmount { get; set; }
        [Required]
        public decimal ProcessingFee { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        [ForeignKey("LoanAgreementId"), InverseProperty("Payouts")]
        public virtual LoanAgreement LoanAgreement { get; set; }
        [ForeignKey("AccountId"), InverseProperty("Payouts")]
        public virtual Account Account { get; set; }
    }
}
