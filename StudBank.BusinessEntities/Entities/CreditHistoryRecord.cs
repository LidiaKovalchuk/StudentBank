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
        public decimal MoneyAmount { get; set; }
        [Required]
        public decimal Interest { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime TermStartDate { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime TermEndDate { get; set; }

        [StringLength(300)]
        public string BC { get; set; }
        [StringLength(300)]
        public string AdditionalInfo { get; set; }

        public virtual Person Person { get; set; }
    }
}
