using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class CommitteeResolution : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string Resolution { get; set; }

        public virtual ICollection<LoanApplication> LoadApplications { get; set; }
    }
}
