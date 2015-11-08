using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class BailAgreement : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [Required, ForeignKey("Client")]
        public Guid ClientId { get; set; }
        [Required, ForeignKey("LoanApplication")]
        public Guid LoanApplicationId { get; set; }
        [Required, ForeignKey("BankConstants")]
        public Guid BankConstantsId { get; set; }
        [ForeignKey("AgreementDocument")]
        public Guid AgreementDocumentId { get; set; }
        [Required, ForeignKey("EstimationDocument")]
        public Guid EstimationDocumentId { get; set; }
        [ForeignKey("InsuranceDocument")]
        public Guid InsuranceDocumentId { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Required]
        public string BailObject { get; set; }
        [Required, StringLength(50)]
        public string BailObjectEstimate { get; set; }
        [Required, StringLength(50)]
        public string BailObjectHolder { get; set; }

        [Required, StringLength(50)]
        public string EstimationCompanyName { get; set; }
        [StringLength(50)]
        public string InsuranceCompanyName { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? InsuranceExpirationDate { get; set; }

        [Required]
        public decimal Amount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        [Required]
        public int LoanTerm { get; set; }
        [Required]
        public int BailTerm { get; set; }

        public string Additional { get; set; }

        [ForeignKey("LoanApplicationId"), InverseProperty("BailAgreements")]
        public virtual LoanApplication LoanApplication { get; set; }
        [ForeignKey("BankConstantsId"), InverseProperty("BailAgreements")]
        public virtual BankConstants BankConstants { get; set; }
        [ForeignKey("ClientId"), InverseProperty("ClientBailAgreements")]
        public virtual Person Client { get; set; }

        [ForeignKey("AgreementDocumentId"), InverseProperty("BailAgreements")]
        public virtual Document AgreementDocument { get; set; }
        [ForeignKey("EstimationDocumentId"), InverseProperty("EstimationBailAgreements")]
        public virtual Document EstimationDocument { get; set; }
        [ForeignKey("InsuranceDocumentId"), InverseProperty("InsuranceBailAgreements")]
        public virtual Document InsuranceDocument { get; set; }
    }
}