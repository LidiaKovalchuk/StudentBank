using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using StudBank.BusinessEntities;

namespace StudBank.DataAccessLayer
{
    public class BankInitializer : DropCreateDatabaseAlways<StudBankContext>
    {
        protected override void Seed(StudBankContext context)
        {
            #region Documents
            var documents = new List<Document>
            {
                new Document { DocumentType = DocumentTypes.BailAgreement, IsDeleted = false, Link = "link1" },
                new Document { DocumentType = DocumentTypes.BailEstimation, IsDeleted = false, Link = "link2" },
                new Document { DocumentType = DocumentTypes.CriminalRecord, IsDeleted = false, Link = "link3" },
                new Document { DocumentType = DocumentTypes.BankCharter, IsDeleted = false, Link = "link4" },
                new Document { DocumentType = DocumentTypes.IncomeStatement, IsDeleted = false, Link = "link5" },
                new Document { DocumentType = DocumentTypes.SuretyAgreement, IsDeleted = false, Link = "link6" },
                new Document { DocumentType = DocumentTypes.LoanAgreementTemplate, IsDeleted = false, Link = "link7" },
                new Document { DocumentType = DocumentTypes.LoanAgreement, IsDeleted = false, Link = "link8" },
                new Document { DocumentType = DocumentTypes.CreditCommitteeProtocol, IsDeleted = false, Link = "link9" },
                new Document { DocumentType = DocumentTypes.SecurityResolutionTemplate, IsDeleted = false, Link = "link10" },
            };
            context.Documents.AddRange(documents);
            context.SaveChanges();
            #endregion

            #region BankConstants
            var bankConstants = new List<BankConstants>
            {
                new BankConstants { Address = "Adress 1", BIC = "123456789", CharterDate = DateTime.Now, CharterName = "Charter 1", CharterDocument = documents[0] },
                new BankConstants { Address = "Adress 2", BIC = "123156789", CharterDate = DateTime.Now, CharterName = "Charter 2", CharterDocument = documents[1] },
                new BankConstants { Address = "Adress 3", BIC = "12345d789", CharterDate = DateTime.Now, CharterName = "Charter 3", CharterDocument = documents[2] },
                new BankConstants { Address = "Adress 4", BIC = "123g56789", CharterDate = DateTime.Now, CharterName = "Charter 4", CharterDocument = documents[3] },
                new BankConstants { Address = "Adress 5", BIC = "123456f89", CharterDate = DateTime.Now, CharterName = "Charter 5", CharterDocument = documents[4] },
                new BankConstants { Address = "Adress 6", BIC = "1234567j9", CharterDate = DateTime.Now, CharterName = "Charter 6", CharterDocument = documents[5] },
                new BankConstants { Address = "Adress 7", BIC = "12345678k", CharterDate = DateTime.Now, CharterName = "Charter 7", CharterDocument = documents[6] },
            };
            context.BankConstants.AddRange(bankConstants);
            context.SaveChanges();
            #endregion

            #region Accounts
            var accounts = new List<Account>
            {
                new Account{ AccountType = AccountTypes.Deposit, IBAN = "d91p006062000", MoneyAmount = 200.13415452m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Deposit, IBAN = "30085i30n3001", MoneyAmount = 12.13m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Other,   IBAN = "20k0000t00002", MoneyAmount = 1m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Savings, IBAN = "0030050040003", MoneyAmount = 0m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Savings, IBAN = "0100g0j200004", MoneyAmount = 3881234.62424m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Savings, IBAN = "0000000000005", MoneyAmount = 22341516163.334141435452m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Loan,    IBAN = "00dr0003j0006", MoneyAmount = 1315135.431452m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Loan,    IBAN = "0d002000f0007", MoneyAmount = 213.13415452m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
                new Account{ AccountType = AccountTypes.Loan,    IBAN = "000050t00k008", MoneyAmount = 1.13415452m, Currency = "BLR", OpenedDate = DateTime.Now, ChangedDate = DateTime.Now, IsClosed = false, IsFrozen = false },
            };
            context.Accounts.AddRange(accounts);
            context.SaveChanges();
            #endregion

            #region Transfers
            var bankTransfers = new List<BankTransfer>
            {
                new BankTransfer { AccountFrom = accounts[0], AccountTo = accounts[1], Amount = 12m, Currency = "BLR", TransferDate = new DateTime(2010, 10, 3), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[1], AccountTo = accounts[2], Amount = 2m, Currency = "BLR", TransferDate = new DateTime(2011, 10, 3), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[3], AccountTo = accounts[4], Amount = 3m, Currency = "BLR", TransferDate = new DateTime(2012, 10, 3), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[4], AccountTo = accounts[5], Amount = 9m, Currency = "BLR", TransferDate = new DateTime(2000, 10, 3), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[6], AccountTo = accounts[7], Amount = 10m, Currency = "BLR", TransferDate = new DateTime(2010, 10, 4), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[0], AccountTo = accounts[2], Amount = 12.123m, Currency = "BLR", TransferDate = new DateTime(2010, 10, 5), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[3], AccountTo = accounts[0], Amount = 122.123m, Currency = "BLR", TransferDate = new DateTime(2010, 10, 8), UserId = Guid.Empty },
                new BankTransfer { AccountFrom = accounts[4], AccountTo = accounts[1], Amount = 11232.123m, Currency = "BLR", TransferDate = new DateTime(2010, 10, 7), UserId = Guid.Empty },
            };
            context.BankTransfers.AddRange(bankTransfers);
            context.SaveChanges();
            #endregion            

            #region Persons
            var persons = new List<Person>
            {
                new Person { IdentificationNumber = "123456789qwert" ,FirstName = "Ivan", LastName = "Ivanonv", MiddleName = "Ivanovich", Address = "Minsk 1938", 
                            PhoneNumber = "+375202341232", MonthlyIncome = 1000m,  UserId = Guid.Empty, AdditionalInfo = "Info", Documents = new Document[] {documents[0], documents[2]} },
                new Person { IdentificationNumber = "123456789qwerg" ,FirstName = "Petr", LastName = "Ivanonv", MiddleName = "Ivanovich", Address = "Minsk 1938", 
                            PhoneNumber = "+375202341232", MonthlyIncome = 1000m,  UserId = Guid.Empty, AdditionalInfo = "Info", Documents = new Document[] {documents[3], documents[4], documents[5] } },
                new Person { IdentificationNumber = "123456789qwerw" ,FirstName = "Nikolay", LastName = "Ivanonv", MiddleName = "Ivanovich", Address = "Minsk 1938", 
                            PhoneNumber = "+375202341232", MonthlyIncome = 1000m,  UserId = Guid.Empty, AdditionalInfo = "Info", Documents = new Document[] {documents[6] } },
            };
            context.Persons.AddRange(persons);
            context.SaveChanges();
            #endregion

            #region CreditHistoryRecords
            var historyRecords = new List<CreditHistoryRecord>
            {
                new CreditHistoryRecord { Person = persons[0], BankConstants = bankConstants[0], Amount = 100m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
                new CreditHistoryRecord { Person = persons[0], BankConstants = bankConstants[0], Amount = 100m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
                new CreditHistoryRecord { Person = persons[0], BankConstants = bankConstants[1], Amount = 100m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
                new CreditHistoryRecord { Person = persons[1], BankConstants = bankConstants[2], Amount = 200m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
                new CreditHistoryRecord { Person = persons[1], BankConstants = bankConstants[3], Amount = 300m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
                new CreditHistoryRecord { Person = persons[1], BankConstants = bankConstants[4], Amount = 500m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
                new CreditHistoryRecord { Person = persons[2], BankConstants = bankConstants[5], Amount = 20m, Currency = "BLR", Interest = 5m, TermStartDate = DateTime.Now, TermEndDate = DateTime.Now },
            };
            context.CreditHistoryRecords.AddRange(historyRecords);
            context.SaveChanges();
            #endregion

            #region Consideration Routes
            var routes = new List<ConsiderationRoute>
            {
                new ConsiderationRoute { AgreementPreparation = 1, CreditCommitee = 2, BailAgreement = 3, Providing = 4, CreditDepartment = 5,
                         SecurityDepartment = 6, SuretyAgreement = 7, LoanAgreement = 8 },
                new ConsiderationRoute { AgreementPreparation = 1, CreditCommitee = 2, BailAgreement = 3, Providing = 4, CreditDepartment = 5,
                         SecurityDepartment = 0, SuretyAgreement = 0, LoanAgreement = 8 },
                new ConsiderationRoute { AgreementPreparation = 1, CreditCommitee = 2, BailAgreement = 3, Providing = 4, CreditDepartment = 5,
                         SecurityDepartment = 6, SuretyAgreement = 0, LoanAgreement = 8 },
            };
            context.ConsiderationRoutes.AddRange(routes);
            context.SaveChanges();
            #endregion

            #region Loans
            var loans = new List<Loan>
            {
                new Loan { ConsiderationRoute = routes[0], LoanGuarantee = LoanGuarantees.Surety, LoanProviding = LoanProvidings.RevolvingCreditLine,
                    LoanRepayment = LoanRepayments.Annuity, LoanType = LoanTypes.DebtConsolidation, MaxAmount = 1000000m, Currency = "BLR", MinIncome = 100000m,
                    MonthlyFee = 5m, IsFixedRateOfInterest = true, ProcessingFee = 0.5m, MaxTerm = 24, RateOfInterest = 5, MinScoringPoint = 5, Name = "Credit++",
                    FineConditions = "Fine conditions credit++.", Description = "Credit++ description", PrepaymentConditions = "Conditions" },
                new Loan { ConsiderationRoute = routes[1], LoanGuarantee = LoanGuarantees.Bail, LoanProviding = LoanProvidings.RevolvingCreditLine,
                    LoanRepayment = LoanRepayments.Annuity, LoanType = LoanTypes.DebtConsolidation, MaxAmount = 1000000m, Currency = "BLR", MinIncome = 100000m,
                    MonthlyFee = 5m, IsFixedRateOfInterest = true, ProcessingFee = 0.5m, MaxTerm = 24, RateOfInterest = 5, MinScoringPoint = 5, Name = "Credit++++",
                    FineConditions = "Fine conditions credit++++.", Description = "Credit++++ description", PrepaymentConditions = "Conditions" },
            };
            context.Loans.AddRange(loans);
            context.SaveChanges();
            #endregion

            #region LoanApplications
            var loanApplications = new List<LoanApplication>
            {
                new LoanApplication { Loan = loans[0], Client = persons[0], Term = 12, Amount = 5000m, Currency = "BLR", Goal = "None", PrivilegesConditions = "None", Sureties = new Person[] { persons[1], persons[2] }},
                new LoanApplication { Loan = loans[0], Client = persons[0], Term = 12, Amount = 5000m, Currency = "BLR", Goal = "None", PrivilegesConditions = "None", Sureties = new Person[] { persons[1], persons[2] }},
                new LoanApplication { Loan = loans[0], Client = persons[0], Term = 12, Amount = 5000m, Currency = "BLR", Goal = "None", PrivilegesConditions = "None", Sureties = new Person[] { persons[1], persons[2] }},
                new LoanApplication { Loan = loans[1], Client = persons[2], Term = 12, Amount = 5000m, Currency = "BLR", Goal = "None", PrivilegesConditions = "None", Sureties = new Person[] { persons[1],}},
                new LoanApplication { Loan = loans[1], Client = persons[2], Term = 12, Amount = 5000m, Currency = "BLR", Goal = "None", PrivilegesConditions = "None", Sureties = new Person[] { persons[1],}},
            };
            context.LoanApplications.AddRange(loanApplications);
            context.SaveChanges();
            #endregion

            #region LoanAgreements
            var loanAgreements = new List<LoanAgreement>
            {
                new LoanAgreement { UserId = Guid.Empty, LoanAccount = accounts[0], RepaymentAccount = accounts[1], BankConstants = bankConstants[0], AgreementDocument = documents[2], LoanApplication = loanApplications[0],
                    LoanType = LoanTypes.DebtConsolidation, LoanGuarantee = LoanGuarantees.Bail, LoanProviding = LoanProvidings.NonrevolvingCreditLine,
                    LoanRepayment = LoanRepayments.Annuity, Date = DateTime.Now, Client = persons[0],
                    Term = 12, Amount = 500000.33333m, Currency = "BLR", ProcessingFee = 0.5m, MonthlyFee = 0.02m, RateOfInterest = 0.04m, IsFixedRateOfInterest = true,
                    FineContidions = "Fine conditions: 1. Abc 2.DBE 3. QWE", PrepaymentConditions = "None", PrivelegesConditions = "None", Goal = "Goal #1" },
                new LoanAgreement { UserId = Guid.Empty, LoanAccount = accounts[1], RepaymentAccount = accounts[2], BankConstants = bankConstants[1], AgreementDocument = documents[2], LoanApplication = loanApplications[1],
                    LoanType = LoanTypes.Personal, LoanGuarantee = LoanGuarantees.Bail, LoanProviding = LoanProvidings.NonrevolvingCreditLine,
                    LoanRepayment = LoanRepayments.Differential, Date = DateTime.Now, Client = persons[1],
                    Term = 24, Amount = 2500000.33333m, Currency = "BLR", ProcessingFee = 0.5m, MonthlyFee = 0.02m, RateOfInterest = 0.04m, IsFixedRateOfInterest = true,
                    FineContidions = "Fine conditions: 1. Abc 2.DBE 3. QWE", PrepaymentConditions = "None", PrivelegesConditions = "None", Goal = "Goal #1" },
                new LoanAgreement { UserId = Guid.Empty, LoanAccount = accounts[3], RepaymentAccount = accounts[2], BankConstants = bankConstants[2], AgreementDocument = documents[2], LoanApplication = loanApplications[2],
                    LoanType = LoanTypes.HomeImprovement, LoanGuarantee = LoanGuarantees.Bail, LoanProviding = LoanProvidings.NoncashTransfer,
                    LoanRepayment = LoanRepayments.Annuity, Date = DateTime.Now, Client = persons[2],
                    Term = 12, Amount = 1500000.33333m, Currency = "BLR", ProcessingFee = 0.5m, MonthlyFee = 0.02m, RateOfInterest = 0.04m, IsFixedRateOfInterest = true,
                    FineContidions = "Fine conditions: 1. Abc 2.DBE 3. QWE", PrepaymentConditions = "None", PrivelegesConditions = "None", Goal = "Goal #1" },
                new LoanAgreement { UserId = Guid.Empty, LoanAccount = accounts[4], RepaymentAccount = accounts[2], BankConstants = bankConstants[3], AgreementDocument = documents[2], LoanApplication = loanApplications[3],
                    LoanType = LoanTypes.Graduate, LoanGuarantee = LoanGuarantees.Bail, LoanProviding = LoanProvidings.NoncashTransfer,
                    LoanRepayment = LoanRepayments.Differential, Date = DateTime.Now, Client = persons[1],
                    Term = 6, Amount = 52200000.33333m, Currency = "BLR", ProcessingFee = 0.5m, MonthlyFee = 0.02m, RateOfInterest = 0.04m, IsFixedRateOfInterest = true,
                    FineContidions = "Fine conditions: 1. Abc 2.DBE 3. QWE", PrepaymentConditions = "None", PrivelegesConditions = "None", Goal = "Goal #1" },
                new LoanAgreement { UserId = Guid.Empty, LoanAccount = accounts[2], RepaymentAccount = accounts[5], BankConstants = bankConstants[5], AgreementDocument = documents[2], LoanApplication = loanApplications[4],
                    LoanType = LoanTypes.Graduate, LoanGuarantee = LoanGuarantees.Bail, LoanProviding = LoanProvidings.NoncashTransfer,
                    LoanRepayment = LoanRepayments.Annuity, Date = DateTime.Now, Client = persons[0],
                    Term = 3, Amount = 21300000.33333m, Currency = "BLR", ProcessingFee = 0.5m, MonthlyFee = 0.02m, RateOfInterest = 0.04m, IsFixedRateOfInterest = true,
                    FineContidions = "Fine conditions: 1. Abc 2.DBE 3. QWE", PrepaymentConditions = "None", PrivelegesConditions = "None", Goal = "Goal #1" },
            };
            context.LoanAgreements.AddRange(loanAgreements);
            context.SaveChanges();
            #endregion

            #region Payout Status
            var payoutStatuses = new List<PayoutStatus>
            {
                new PayoutStatus { LoanAgreement = loanAgreements[0], CurrentFineRateOfInterest = 1, CurrentRateOfInterest = 5, LoanAmount = 20000m,
                    RepaidTotalAmount = 15000m, NextPayoutDeadlineDate = DateTime.Now },
                new PayoutStatus { LoanAgreement = loanAgreements[1], CurrentFineRateOfInterest = 1, CurrentRateOfInterest = 5, LoanAmount = 20000m,
                    RepaidTotalAmount = 15000m, NextPayoutDeadlineDate = DateTime.Now },
                new PayoutStatus { LoanAgreement = loanAgreements[2], CurrentFineRateOfInterest = 1, CurrentRateOfInterest = 5, LoanAmount = 20000m,
                    RepaidTotalAmount = 15000m, NextPayoutDeadlineDate = DateTime.Now },
                new PayoutStatus { LoanAgreement = loanAgreements[3], CurrentFineRateOfInterest = 1, CurrentRateOfInterest = 5, LoanAmount = 20000m,
                    RepaidTotalAmount = 15000m, NextPayoutDeadlineDate = DateTime.Now },
                new PayoutStatus { LoanAgreement = loanAgreements[4], CurrentFineRateOfInterest = 1, CurrentRateOfInterest = 5, LoanAmount = 20000m,
                    RepaidTotalAmount = 15000m, NextPayoutDeadlineDate = DateTime.Now },
            };
            context.PayoutStatuses.AddRange(payoutStatuses);
            context.SaveChanges();
            #endregion

            #region Risk Assesments
            var riskAssesments = new List<RiskAssessment>
            {
                new RiskAssessment { LoanAgreement = loanAgreements[0], Date = DateTime.Now, Description = "Risk assesment description", Point = 5m },
                new RiskAssessment { LoanAgreement = loanAgreements[1], Date = DateTime.Now, Description = "Risk assesment description", Point = 4m },
                new RiskAssessment { LoanAgreement = loanAgreements[2], Date = DateTime.Now, Description = "Risk assesment description", Point = 3m },
                new RiskAssessment { LoanAgreement = loanAgreements[3], Date = DateTime.Now, Description = "Risk assesment description", Point = 2m },
                new RiskAssessment { LoanAgreement = loanAgreements[4], Date = DateTime.Now, Description = "Risk assesment description", Point = 1m },
            };
            context.RiskAssesments.AddRange(riskAssesments);
            context.SaveChanges();
            #endregion

            #region Payouts
            var payouts = new List<Payout>
            {
                new Payout { Account = accounts[0], LoanAgreement = loanAgreements[0], Date = DateTime.Now, LoanAmount = 100220m, TotalAmount = 202930210m,
                    ProcessingFee = 0.5m, Currency = "BLR", PayoutWay = PayoutWays.BankBranch, InterestAmount = 0.04m },
                new Payout { Account = accounts[1], LoanAgreement = loanAgreements[1], Date = DateTime.Now, LoanAmount = 100120m, TotalAmount = 202930210m,
                    ProcessingFee = 0.5m, Currency = "BLR", PayoutWay = PayoutWays.BankBranch, InterestAmount = 0.04m },
                new Payout { Account = accounts[2], LoanAgreement = loanAgreements[2], Date = DateTime.Now, LoanAmount = 1001020m, TotalAmount = 202930210m,
                    ProcessingFee = 0.5m, Currency = "BLR", PayoutWay = PayoutWays.BankBranch, InterestAmount = 0.04m },
                new Payout { Account = accounts[3], LoanAgreement = loanAgreements[3], Date = DateTime.Now, LoanAmount = 10220m, TotalAmount = 202930210m,
                    ProcessingFee = 0.5m, Currency = "BLR", PayoutWay = PayoutWays.BankBranch, InterestAmount = 0.04m },
                new Payout { Account = accounts[4], LoanAgreement = loanAgreements[4], Date = DateTime.Now, LoanAmount = 103120m, TotalAmount = 202930210m,
                    ProcessingFee = 0.5m, Currency = "BLR", PayoutWay = PayoutWays.BankBranch, InterestAmount = 0.04m },
                new Payout { Account = accounts[4], LoanAgreement = loanAgreements[1], Date = DateTime.Now, LoanAmount = 100320m, TotalAmount = 202930210m,
                    ProcessingFee = 0.5m, Currency = "BLR", PayoutWay = PayoutWays.BankBranch, InterestAmount = 0.04m },
            };
            context.Payouts.AddRange(payouts);
            context.SaveChanges();
            #endregion

            #region Fines
            var fines = new List<Fine>
            {
                new Fine { LoanAgreement = loanAgreements[0], IsClosed = false, FineRateOfInterest = 1m, DeadLineDate = DateTime.Now },
                new Fine { LoanAgreement = loanAgreements[0], IsClosed = false, FineRateOfInterest = 1m, DeadLineDate = DateTime.Now },
                new Fine { LoanAgreement = loanAgreements[1], IsClosed = false, FineRateOfInterest = 1m, DeadLineDate = DateTime.Now },
                new Fine { LoanAgreement = loanAgreements[2], IsClosed = false, FineRateOfInterest = 1m, DeadLineDate = DateTime.Now },
                new Fine { LoanAgreement = loanAgreements[3], IsClosed = false, FineRateOfInterest = 1m, DeadLineDate = DateTime.Now },
                new Fine { LoanAgreement = loanAgreements[3], IsClosed = false, FineRateOfInterest = 1m, DeadLineDate = DateTime.Now },
            };
            context.Fines.AddRange(fines);
            context.SaveChanges();
            #endregion

            #region Withdrawals
            var withdrawals = new List<ClientWithdrawal>
            {
                new ClientWithdrawal { ClientAccount = accounts[0], LoanAgreement = loanAgreements[0], MoneyAmount = 204m,
                    WithdrawalWay = WithdrawalWays.NoncashTransfer, Currency = "BLR", Date = DateTime.Now, Addition = "Additional info." },
                new ClientWithdrawal { ClientAccount = accounts[1], LoanAgreement = loanAgreements[1], MoneyAmount = 203m,
                    WithdrawalWay = WithdrawalWays.NoncashTransfer, Currency = "BLR", Date = DateTime.Now, Addition = "Additional info." },
                new ClientWithdrawal { ClientAccount = accounts[2], LoanAgreement = loanAgreements[1], MoneyAmount = 202m,
                    WithdrawalWay = WithdrawalWays.NoncashTransfer, Currency = "BLR", Date = DateTime.Now, Addition = "Additional info." },
                new ClientWithdrawal { ClientAccount = accounts[4], LoanAgreement = loanAgreements[3], MoneyAmount = 201m,
                    WithdrawalWay = WithdrawalWays.NoncashTransfer, Currency = "BLR", Date = DateTime.Now, Addition = "Additional info." },
            };
            context.ClientWithdrawal.AddRange(withdrawals);
            context.SaveChanges();
            #endregion

            #region Surety Agreements
            var suretyAgreements = new List<SuretyAgreement>
            {
                new SuretyAgreement { UserId = Guid.Empty,  BankConstants = bankConstants[0], AgreementDocument = documents[0], LoanApplication = loanApplications[0], 
                    Client = persons[0], Guarantor = persons[2], Amount = 1000m, Currency = "BLR", LoanTerm = 12, Date = DateTime.Now, SuretyTerm = 15, AdditionalInfo = "Info" },
                new SuretyAgreement { UserId = Guid.Empty,  BankConstants = bankConstants[1], AgreementDocument = documents[3], LoanApplication = loanApplications[2], 
                    Client = persons[1], Guarantor = persons[2], Amount = 1002m, Currency = "BLR", LoanTerm = 12, Date = DateTime.Now, SuretyTerm = 15, AdditionalInfo = "Info" },
            };
            context.SuretyAgreements.AddRange(suretyAgreements);
            context.SaveChanges();
            #endregion

            #region Bail Agreements
            var bailAgreements = new List<BailAgreement>
            {
                new BailAgreement { UserId = Guid.Empty, BankConstants = bankConstants[0], AgreementDocument = documents[0], EstimationDocument = documents[1], InsuranceDocument = documents[2], LoanApplication = loanApplications[0],
                     Client = persons[0], EstimationCompanyName = "CreditCompany#1", Amount = 2000m, Currency = "BLR", Date = DateTime.Now, InsuranceCompanyName = "InsuranceComp#1",
                     BailObject = "Bail Object", BailObjectEstimate = "Bail Obj Est", BailObjectHolder = "Holder", BailTerm = 12, InsuranceExpirationDate = DateTime.Now, LoanTerm = 6,  Additional = "Info" },
                new BailAgreement { UserId = Guid.Empty, BankConstants = bankConstants[1], AgreementDocument = documents[5], EstimationDocument = documents[4], InsuranceDocument = documents[3], LoanApplication = loanApplications[1],
                     Client = persons[0], EstimationCompanyName = "CreditCompany#2", Amount = 20000m, Currency = "BLR", Date = DateTime.Now, InsuranceCompanyName = "InsuranceComp#2",
                     BailObject = "Bail Object2", BailObjectEstimate = "Bail Obj Est2", BailObjectHolder = "Holder2", BailTerm = 12, InsuranceExpirationDate = DateTime.Now, LoanTerm = 6,  Additional = "Info2" },
            };
            context.BailAgreements.AddRange(bailAgreements);
            context.SaveChanges();
            #endregion

            #region System Resolutions
            var systemResolutions = new List<SystemResolution>
            {
                new SystemResolution { LoanApplication = loanApplications[0], MaxLoanAmount = 100000000m, ScoringPoint = 10 },
                new SystemResolution { LoanApplication = loanApplications[1], MaxLoanAmount = 100000000m, ScoringPoint = 5 },
                new SystemResolution { LoanApplication = loanApplications[2], MaxLoanAmount = 100000000m, ScoringPoint = 8 },
                new SystemResolution { LoanApplication = loanApplications[3], MaxLoanAmount = 100000000m, ScoringPoint = 7 },
                new SystemResolution { LoanApplication = loanApplications[4], MaxLoanAmount = 100000000m, ScoringPoint = 3 }
            };
            context.SystemResolutions.AddRange(systemResolutions);
            context.SaveChanges();
            #endregion

            #region Security Resolutions
            var securityResolutions = new List<SecurityResolution>
            {
                new SecurityResolution { UserId = Guid.Empty, LoanApplication = loanApplications[0], Bail = "Bail1", BailEstimate = 10, Income = "Income1", IncomeEstimate = 5,
                    PlaceOfWork = "Place1", PlaceOfWorkEstimate = 3, Social = "Social1", SocialEstimate = 10, Property = "Prop1", PropertyEstimate = 2,
                    Convictions = "Conv1", ConvictionsEstimate = 6, Surety = "Surety1", SuretyEstimate = 3, CommonResolution = "Comm", CommonEstimate = 7,},
                new SecurityResolution { UserId = Guid.Empty, LoanApplication = loanApplications[1], Bail = "Bail1", BailEstimate = 10, Income = "Income1", IncomeEstimate = 5,
                    PlaceOfWork = "Place1", PlaceOfWorkEstimate = 3, Social = "Social1", SocialEstimate = 10, Property = "Prop1", PropertyEstimate = 2,
                    Convictions = "Conv1", ConvictionsEstimate = 6, Surety = "Surety1", SuretyEstimate = 3, CommonResolution = "Comm", CommonEstimate = 7,},
                new SecurityResolution { UserId = Guid.Empty, LoanApplication = loanApplications[2], Bail = "Bail1", BailEstimate = 10, Income = "Income1", IncomeEstimate = 5,
                    PlaceOfWork = "Place1", PlaceOfWorkEstimate = 3, Social = "Social1", SocialEstimate = 10, Property = "Prop1", PropertyEstimate = 2,
                    Convictions = "Conv1", ConvictionsEstimate = 6, Surety = "Surety1", SuretyEstimate = 3, CommonResolution = "Comm", CommonEstimate = 7,},
            };
            context.SecurityResolutions.AddRange(securityResolutions);
            context.SaveChanges();
            #endregion

            #region Expert Resolutions
            var expertResolutions = new List<ExpertResolution>
            {
                new ExpertResolution { UserId = Guid.Empty, LoanApplication = loanApplications[0], Bail = "Bail1", BailEstimate = 10, Income = "Income1", IncomeEstimate = 5,
                    Property = "Prop1", PropertyEstimate = 2, Surety = "Surety1", SuretyEstimate = 3, CommonResolution = "Comm", CommonEstimate = 7,},
                new ExpertResolution { UserId = Guid.Empty, LoanApplication = loanApplications[1], Bail = "Bail1", BailEstimate = 10, Income = "Income1", IncomeEstimate = 5,
                    Property = "Prop1", PropertyEstimate = 2, Surety = "Surety1", SuretyEstimate = 3, CommonResolution = "Comm", CommonEstimate = 7,},
                new ExpertResolution { UserId = Guid.Empty, LoanApplication = loanApplications[2], Bail = "Bail1", BailEstimate = 10, Income = "Income1", IncomeEstimate = 5,
                    Property = "Prop1", PropertyEstimate = 2, Surety = "Surety1", SuretyEstimate = 3, CommonResolution = "Comm", CommonEstimate = 7,},
            };
            context.ExpertResolutions.AddRange(expertResolutions);
            context.SaveChanges();
            #endregion

            #region Committee Resolutions
            var committeeResolutions = new List<CommitteeResolution>
            {
                new CommitteeResolution { UserId = Guid.Empty, LoanApplication = loanApplications[0], ProtocolDocument = documents[0], 
                        Resolution = "Application GQC is eligable." },
                new CommitteeResolution { UserId = Guid.Empty, LoanApplication = loanApplications[1], ProtocolDocument = documents[1], 
                        Resolution = "Application QEC is eligable."  },
                new CommitteeResolution { UserId = Guid.Empty, LoanApplication = loanApplications[2], ProtocolDocument = documents[2], 
                        Resolution = "Application DBC is  not eligable."  },
                new CommitteeResolution { UserId = Guid.Empty, LoanApplication = loanApplications[3], ProtocolDocument = documents[3], 
                        Resolution = "Application NBC is  not eligable."  },
                new CommitteeResolution { UserId = Guid.Empty, LoanApplication = loanApplications[4], ProtocolDocument = documents[4], 
                        Resolution = "Application EBC is  not eligable."  },
            };
            context.CommitteeResolutions.AddRange(committeeResolutions);
            context.SaveChanges();
            #endregion
        }
    }
}