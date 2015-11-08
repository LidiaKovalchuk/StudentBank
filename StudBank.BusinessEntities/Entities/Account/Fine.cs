using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class Fine : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid LoanAgreementId { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime DeadLineDate { get; set; }
        [Required]
        public decimal FineRateOfInterest { get; set; }
        [Required]
        public bool IsClosed { get; set; }

        [ForeignKey("LoanAgreementId"), InverseProperty("Fines")]
        public virtual LoanAgreement LoanAgreement { get; set; }
    }
}
