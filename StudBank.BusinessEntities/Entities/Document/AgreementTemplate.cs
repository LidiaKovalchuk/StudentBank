using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class AgreementTemplate : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid DocumentId { get; set; }
        [Required, StringLength(100)]
        public string CharterName { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime CharterDate { get; set; }

        [Required]
        public string Rights { get; set; }
        [Required]
        public string Duties { get; set; }

        public virtual Document Document { get; set; }
        public virtual ICollection<LoanAgreement> LoanAgreements { get; set; }
    }
}
