using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class Account : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid AccountTypeId { get; set; }
        [Required]
        public decimal MoneyAmount { get; set; }

        [Required]
        public bool IsClosed { get; set; }
        [Required]
        public bool IsFrozen { get; set; }
        [Required]
        public bool IsInsured { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime OpenedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? ChangedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? ClosedDate { get; set; }

        public virtual AccountType AccountType { get; set; }
    }
}
