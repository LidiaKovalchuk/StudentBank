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
        public Guid LoanApplicationId { get; set; }

        [Required]
        public decimal MaxLoanAmount { get; set;}
        [Required]
        public decimal ScoringPoint { get; set; }

        [ForeignKey("LoanApplicationId"), InverseProperty("SystemResolutions")]
        public virtual LoanApplication LoanApplication { get; set; }
    }
}
