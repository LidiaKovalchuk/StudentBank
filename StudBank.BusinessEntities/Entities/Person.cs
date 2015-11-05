using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public class Person : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string MiddleName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }
        [Required, StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        public decimal MonthlyIncome { get; set; }

        [Required]
        public bool InStopList { get; set; }
        [StringLength(300)]
        public string AdditionalInfo { get; set; }

        public virtual ICollection<CreditHistoryRecord> CreditHistoryRecords { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
