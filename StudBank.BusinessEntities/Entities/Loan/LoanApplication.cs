using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class LoanApplication : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid ClientId { get; set; }
        [Required]
        public Guid LoanId { get; set; }

        [Required]
        public int Term { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }

        public string PrivilegesConditions { get; set; }
        public string Goal { get; set; }

        [ForeignKey("ClientId"), InverseProperty("LoanApplications")]
        public virtual Person Client { get; set; }
        [ForeignKey("LoanId"), InverseProperty("LoanApplications")]
        public virtual Loan Loan { get; set; }

        [InverseProperty("InsuredApplications")]
        public virtual ICollection<Person> Sureties { get; set; }
        [InverseProperty("LoanApplication")]
        public virtual ICollection<LoanAgreement> LoanAgreements { get; set; }
        [InverseProperty("LoanApplication")]
        public virtual ICollection<SuretyAgreement> SuretyAgreements { get; set; }
        [InverseProperty("LoanApplication")]
        public virtual ICollection<BailAgreement> BailAgreements { get; set; }

        [InverseProperty("LoanApplication")]
        public virtual ICollection<SystemResolution> SystemResolutions { get; set; }
        [InverseProperty("LoanApplication")]
        public virtual ICollection<SecurityResolution> SecurityResolutions { get; set; }
        [InverseProperty("LoanApplication")]
        public virtual ICollection<ExpertResolution> ExpertResolutions { get; set; }
        [InverseProperty("LoanApplication")]
        public virtual ICollection<CommitteeResolution> CommitteeResolutions { get; set; }
        
    }
}
