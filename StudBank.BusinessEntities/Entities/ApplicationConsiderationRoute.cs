using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class ApplicationConsiderationRoute : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [Required, StringLength(50)]
        public string SecurityDepartment { get; set; }
        [Required, StringLength(50)]
        public string CreditDepartment { get; set; }
        [Required, StringLength(50)]
        public string AgreementPreparation { get; set; }
        [Required, StringLength(50)]
        public string Agreement { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
