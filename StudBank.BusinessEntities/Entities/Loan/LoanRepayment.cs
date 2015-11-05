using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class LoanRepayment : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required, StringLength(50)]
        public string Description { get; set; }

        public virtual ICollection<LoanAgreement> LoanAgreements { get; set; }
    }
}
