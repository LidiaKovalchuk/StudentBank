using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public enum WithdrawalWays { None = 0, Other, BankBranch, NoncashTransfer }

    public class ClientWithdrawal : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid ClientAccountId { get; set; }
        [Required]
        public Guid LoanAgreementId { get; set; }
        [Required]
        public WithdrawalWays WithdrawalWay { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        [Required]
        public decimal MoneyAmount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        public string Addition { get; set; }

        [ForeignKey("ClientAccountId")]
        public virtual Account ClientAccount { get; set; }
        [ForeignKey("LoanAgreementId")]
        public virtual LoanAgreement LoanAgreement { get; set; }
    }
}
