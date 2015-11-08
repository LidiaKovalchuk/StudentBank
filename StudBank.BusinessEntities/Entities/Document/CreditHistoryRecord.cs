using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class CreditHistoryRecord : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid PersonId { get; set; }
        [Required]
        public Guid BankConstantsId { get; set; }

        [Required]
        public decimal Amount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }
        [Required]
        public decimal Interest { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime TermStartDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? TermEndDate { get; set; }

        public string AdditionalInfo { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        [ForeignKey("BankConstantsId")]
        public virtual BankConstants BankConstants { get; set; }
    }
}
