using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class SystemResolution : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public decimal MaxLoanAmount { get; set;}
        [Required]
        public decimal ScoringPoint { get; set; }

        public virtual ICollection<LoanApplication> LoadApplications { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
