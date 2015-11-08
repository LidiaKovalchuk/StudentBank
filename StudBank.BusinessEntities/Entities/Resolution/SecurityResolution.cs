using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class SecurityResolution : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid LoanApplicationId { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Convictions { get; set; }
        public int ConvictionsEstimate { get; set; }
        [Required]
        public string Income { get; set; }
        public int IncomeEstimate { get; set; }
        [Required]
        public string PlaceOfWork { get; set; }
        public int PlaceOfWorkEstimate { get; set; }
        [Required]
        public string Social { get; set; }
        public int SocialEstimate { get; set; }
        [Required]
        public string Surety { get; set; }
        public int SuretyEstimate { get; set; }
        [Required]
        public string Property { get; set; }
        public int PropertyEstimate { get; set; }
        [Required]
        public string Bail { get; set; }
        public int BailEstimate { get; set; }

        [Required]
        public string CommonResolution { get; set; }
        [Required]
        public int CommonEstimate { get; set; }

        [ForeignKey("LoanApplicationId"), InverseProperty("SecurityResolutions")]
        public virtual LoanApplication LoanApplication { get; set; }
    }
}
