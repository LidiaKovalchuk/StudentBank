using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class ConsiderationRoute : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public int Providing { get; set; }
        [Required]
        public int Repayment { get; set; }
        [Required]
        public int SecurityDepartment { get; set; }
        [Required]
        public int CreditDepartment { get; set; }
        [Required]
        public int CreditCommitee { get; set; }
        [Required]
        public int AgreementPreparation { get; set; }
        [Required]
        public int SuretyAgreement { get; set; }
        [Required]
        public int BailAgreement { get; set; }
        [Required]
        public int LoanAgreement { get; set; }

        [InverseProperty("ConsiderationRoute")]
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
