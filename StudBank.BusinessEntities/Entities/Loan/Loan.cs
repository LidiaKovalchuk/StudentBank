using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudBank.BusinessEntities
{
    public enum LoanGuarantees { None = 0, Other, Surety, Bail }
    public enum LoanProvidings { None = 0, Other, NoncashTransfer, NonrevolvingCreditLine, RevolvingCreditLine }
    public enum LoanRepayments { None = 0, Other, Annuity, Differential }
    public enum LoanTypes { None = 0, Other, Personal, HomeImprovement, Car, Graduate, DebtConsolidation }

    public class Loan: IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public Guid ConsiderationRouteId { get; set; }

        [Required]
        public LoanTypes LoanType { get; set; }
        [Required]
        public LoanGuarantees LoanGuarantee { get; set; }
        [Required]
        public LoanProvidings LoanProviding { get; set; }
        [Required]
        public LoanRepayments LoanRepayment { get; set; }
        

        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }      
        [Required]
        public decimal MaxAmount { get; set; }
        [Required, StringLength(3)]
        public string Currency { get; set; }
        [Required]
        public int MaxTerm { get; set; }
        [Required]
        public decimal ProcessingFee { get; set; }
        [Required]
        public decimal MonthlyFee { get; set; }
        [Required]
        public decimal RateOfInterest { get; set; }
        [Required]
        public bool IsFixedRateOfInterest { get; set; }
        [Required]
        public string FineConditions { get; set; }
        [Required]
        public string PrepaymentConditions { get; set; }

        [Required]
        public decimal MinIncome { get; set; }
        [Required]
        public decimal MinScoringPoint { get; set; }

        [ForeignKey("ConsiderationRouteId"), InverseProperty("Loans")]
        public virtual ConsiderationRoute ConsiderationRoute { get; set; }

        [InverseProperty("Loan")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}
