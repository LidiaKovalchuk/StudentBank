using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class ExpertResolution : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid LoanApplicationId { get; set; }
        [Required]
        public Guid UserId { get; set; }

        public string Income { get; set; }
        [Required]
        public int IncomeEstimate { get; set; }
        
        public string Property { get; set; }
        [Required]
        public int PropertyEstimate { get; set; }
        
        public string Surety { get; set; }
        [Required]
        public int SuretyEstimate { get; set; }
        
        public string Bail { get; set; }
        [Required]
        public int BailEstimate { get; set; }

        [Required]
        public string CommonResolution { get; set; }
        [Required]
        public int CommonEstimate { get; set; }

        [ForeignKey("LoanApplicationId"), InverseProperty("ExpertResolutions")]
        public virtual LoanApplication LoanApplication { get; set; }
    }
}
