using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public enum DocumentTypes { None = 0, Other, BankCharter, LoanApplicationTemplate, SecurityResolutionTemplate,
        SystemResolutionTemplate, ExpertResolutionTemplate, CreditCommitteeProtocol, SuretyAgreement, BailAgreement,
        LoanAgreement, SuretyAgreementTemplate, BailAgreementTemplate, LoanAgreementTemplate, IncomeStatement,
        CriminalRecord, BailEstimation, BailInsurance }

    public class Document : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public DocumentTypes DocumentType { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        [InverseProperty("CharterDocument")]
        public virtual ICollection<BankConstants> BankConstants { get; set; }
        [InverseProperty("Documents")]
        public virtual ICollection<Person> Persons { get; set; }
        [InverseProperty("AgreementDocument")]
        public virtual ICollection<LoanAgreement> LoanAgreements { get; set; }
        [InverseProperty("AgreementDocument")]
        public virtual ICollection<SuretyAgreement> SuretyAgreements { get; set; }

        [InverseProperty("AgreementDocument")]
        public virtual ICollection<BailAgreement> BailAgreements { get; set; }
        [InverseProperty("EstimationDocument")]
        public virtual ICollection<BailAgreement> EstimationBailAgreements { get; set; }
        [InverseProperty("InsuranceDocument")]
        public virtual ICollection<BailAgreement> InsuranceBailAgreements { get; set; }
        [InverseProperty("ProtocolDocument")]
        public virtual ICollection<CommitteeResolution> CommitteeResolutions { get; set; }
    }
}
