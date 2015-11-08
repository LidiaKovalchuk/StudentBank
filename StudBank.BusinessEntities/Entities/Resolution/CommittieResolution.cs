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
        public Guid LoanApplicationId { get; set; }
        [Required]
        public Guid UserId { get; set; }

        public Guid ProtocolDocumentId { get; set; }

        [Required]
        public string Resolution { get; set; }

        [ForeignKey("LoanApplicationId"), InverseProperty("CommitteeResolutions")]
        public virtual LoanApplication LoanApplication { get; set; }
        [ForeignKey("ProtocolDocumentId"), InverseProperty("CommitteeResolutions")]
        public virtual Document ProtocolDocument { get; set; }
    }
}
