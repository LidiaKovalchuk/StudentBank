using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class Document : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid DocumentTypeId { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<AgreementTemplate> AgreementTemplates { get; set; }
    }
}
