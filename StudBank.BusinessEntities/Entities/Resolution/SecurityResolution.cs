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
        public Guid UserId { get; set; }
        [Required]
        public string Convictions { get; set; }
        public string ConvictionsEstimate { get; set; }
        [Required]
        public decimal Income { get; set; }
        public decimal IncomeEstimate { get; set; }
        [Required]
        public string PlaceOfWork { get; set; }
        public string PlaceOfWorkEstimate { get; set; }
        [Required]
        public string Social { get; set; }
        public string SocialEstimate { get; set; }
        [Required]
        public decimal Property { get; set; }
        public decimal PropertyEstimate { get; set; }
        [Required]
        public decimal Bail { get; set; }
        public decimal BailEstimate { get; set; }

        [Required]
        public string CommonResolution { get; set; }
        [Required]
        public string CommonEstimate { get; set; }

        public virtual ICollection<LoanApplication> LoadApplications { get; set; }
    }
}
