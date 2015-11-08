using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class BankTransfer : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [Required, Column(Order = 0)]
        public Guid AccountFromId { get; set; }
        [Required, Column(Order = 1)]
        public Guid AccountToId { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime TransferDate { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        [ForeignKey("AccountFromId"), InverseProperty("BankTransfersFrom")]
        public virtual Account AccountFrom { get; set; }
        [ForeignKey("AccountToId"), InverseProperty("BankTransfersTo")]
        public virtual Account AccountTo { get; set; }
    }
}
