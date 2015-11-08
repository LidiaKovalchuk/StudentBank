using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public enum AccountTypes { None, Other, Loan, Savings, Deposit }

    public class Account : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required, StringLength(13, MinimumLength = 13), Index(IsUnique = true)]
        public string IBAN { get; set; }

        [Required]
        public AccountTypes AccountType { get; set; }
        [Required]
        public decimal MoneyAmount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime OpenedDate { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime ChangedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? ClosedDate { get; set; }

        [Required]
        public bool IsClosed { get; set; }
        [Required]
        public bool IsFrozen { get; set; }

        [InverseProperty("AccountFrom")]
        public virtual ICollection<BankTransfer> BankTransfersFrom { get; set; }
        [InverseProperty("AccountTo")]
        public virtual ICollection<BankTransfer> BankTransfersTo { get; set; }
        [InverseProperty("ClientAccount")]
        public virtual ICollection<ClientWithdrawal> ClientWithdrawals { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<Payout> Payouts { get; set; }
    }
}
