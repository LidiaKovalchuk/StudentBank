using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class Person : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required, StringLength(14), Index(IsUnique = true)]
        public string IdentificationNumber { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string MiddleName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(128)]
        public string Address { get; set; }
        [Required, StringLength(128)]
        public string PhoneNumber { get; set; }
        [Required]
        public decimal MonthlyIncome { get; set; }

        [MaxLengthAttribute]
        public string AdditionalInfo { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<CreditHistoryRecord> CreditHistoryRecords { get; set; }
        [InverseProperty("Persons")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
        [InverseProperty("Sureties")]
        public virtual ICollection<LoanApplication> InsuredApplications { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<LoanAgreement> ClientLoanAgreements { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<SuretyAgreement> ClientSuretyAgreements { get; set; }
        [InverseProperty("Guarantor")]
        public virtual ICollection<SuretyAgreement> GuarantorSuretyAgreements { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<BailAgreement> ClientBailAgreements { get; set; }

    }
}
