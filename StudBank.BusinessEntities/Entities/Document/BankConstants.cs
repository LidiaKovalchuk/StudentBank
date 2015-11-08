using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class BankConstants : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [StringLength(9), Index(IsUnique = true)]
        public string BIC { get; set; }
        [Required, ForeignKey("CharterDocument")]
        public Guid CharterDocumentId { get; set; }

        [Required, StringLength(50)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string CharterName { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime CharterDate { get; set; }

        [ForeignKey("CharterDocumentId")]
        public virtual Document CharterDocument { get; set; }
        [InverseProperty("BankConstants")]
        public virtual ICollection<LoanAgreement> LoanAgreements { get; set; }
        [InverseProperty("BankConstants")]
        public virtual ICollection<SuretyAgreement> SuretyAgreements { get; set; }
        [InverseProperty("BankConstants")]
        public virtual ICollection<BailAgreement> BailAgreements { get; set; }
        [InverseProperty("BankConstants")]
        public virtual ICollection<CreditHistoryRecord> CreditHistoryRecords { get; set; }
    }
}
