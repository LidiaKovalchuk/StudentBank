using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class SuretyAgreement : IEntity
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
        public Guid GuarantorId { get; set; }
        [Required]
        public Guid ConstantsId { get; set; }
        public Guid AgreementDocumentId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }
        [Required]
        public int LoanTerm { get; set; }
        [Required]
        public int SuretyTerm { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        public string AdditionalInfo { get; set; }

        [ForeignKey("LoanApplicationId"), InverseProperty("SuretyAgreements")]
        public virtual LoanApplication LoanApplication { get; set; }
        [ForeignKey("ClientId"), InverseProperty("ClientSuretyAgreements")]
        public virtual Person Client { get; set; }
        [ForeignKey("GuarantorId"), InverseProperty("GuarantorSuretyAgreements")]
        public virtual Person Guarantor { get; set; }
        [ForeignKey("ConstantsId")]
        public virtual BankConstants BankConstants { get; set; }
        [ForeignKey("AgreementDocumentId")]
        public virtual Document AgreementDocument { get; set; }
    }
}
