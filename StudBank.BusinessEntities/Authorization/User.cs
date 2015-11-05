using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class User : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string MiddleName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(50)]
        public string Login { get; set; }
        [Required, StringLength(128)]
        public string Password { get; set; }
        [Required, StringLength(128)]
        public string Email { get; set; }

        [Required]
        public bool IsLogged { get; set; }
        [Required]
        public bool IsBlocked { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        [Required, Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? LoggedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? BlockedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DeletedDate { get; set; }

        [StringLength(15)]
        public string LoginIP { get; set; }
        [StringLength(128)]
        public string PasswordSolt { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
