using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudBank.BusinessComponents;
using StudBank.BusinessEntities;
using StudBank.DataAccessLayer;

namespace StudBank.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var studContext = new StudBankContext(true))
            {
                var AccountService = new AccountService(studContext);
                Console.WriteLine("Accounts:");
                foreach(var account in AccountService.Get())
                {
                    System.Console.WriteLine(string.Format("{0} {1} {2} {3} Transfers From: {4}  Transfers To:{5}",
                        account.IBAN, account.AccountType, account.MoneyAmount, account.Currency, account.BankTransfersFrom.Count, account.BankTransfersTo.Count));
                }

                var BankTransferService = new BankTransferService(studContext);
                Console.WriteLine("Transfers:");
                foreach (var transfer in BankTransferService.Get(includeProperties: "AccountFrom,AccountTo"))
                    Console.WriteLine(string.Format("From: {0} To: {1} {2} {3} {4}", transfer.AccountFrom.IBAN, transfer.AccountTo.IBAN,
                        transfer.Amount, transfer.Currency, transfer.TransferDate.ToShortDateString()));

                var LoanAgreementService = new LoanAgreementService(studContext);
                Console.WriteLine("Loan Agreements:");
                foreach (var loanAgreement in LoanAgreementService.Get(includeProperties: "PayoutStatus"))
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6}", loanAgreement.Client.FirstName, loanAgreement.LoanType,
                        loanAgreement.LoanProviding, loanAgreement.LoanRepayment, loanAgreement.Term, loanAgreement.Amount, loanAgreement.Currency));

                var PayoutService = new PayoutService(studContext);
                Console.WriteLine("Payouts:");
                foreach (var payout in PayoutService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5}", payout.PayoutWay, payout.LoanAmount, payout.ProcessingFee,
                        payout.InterestAmount, payout.TotalAmount, payout.Currency));

                var FineService = new FineService(studContext);
                Console.WriteLine("Fines:");
                foreach (var fine in FineService.Get(includeProperties: "LoanAgreement"))
                    Console.WriteLine(string.Format("{0} {1} {2} {3}", fine.LoanAgreement.Id,
                        fine.DeadLineDate.ToShortDateString(), fine.FineRateOfInterest, fine.IsClosed));

                var WithdrawalService = new WithdrawalService(studContext);
                Console.WriteLine("Withdrawals:");
                foreach (var withdrawal in WithdrawalService.Get(includeProperties: "ClientAccount,LoanAgreement"))
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4}", withdrawal.ClientAccount.Id, withdrawal.MoneyAmount,
                        withdrawal.Currency, withdrawal.WithdrawalWay, withdrawal.Date.ToShortDateString()));

                var PersonService = new PersonService(studContext);
                Console.WriteLine("Persons:");
                foreach (var person in PersonService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} Documents: {3} Records: {4}", person.FirstName, person.IdentificationNumber,
                        person.MonthlyIncome, person.Documents.Count, person.CreditHistoryRecords.Count));

                var HistoryService = new CreditHistoryRecordService(studContext);
                Console.WriteLine("Records:");
                foreach (var record in HistoryService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4}", record.Person.FirstName, record.BankConstants.BIC,
                        record.Amount, record.Currency, record.Interest));

                var LoanService = new LoanService(studContext);
                Console.WriteLine("Loan programs:");
                foreach (var program in LoanService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5}", program.Name, program.LoanProviding,
                        program.LoanGuarantee, program.LoanRepayment, program.LoanType, program.MaxAmount));

                var LoanApplicationService = new LoanApplicationService(studContext);
                Console.WriteLine("Loan applications:");
                foreach (var loanApplication in LoanApplicationService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} First surety:{5}", loanApplication.Client.FirstName, loanApplication.Loan.Name,
                        loanApplication.Amount, loanApplication.Currency, loanApplication.Term, loanApplication.Sureties.FirstOrDefault().FirstName));

                var SuretyAgreementService = new SuretyAgreementService(studContext);
                Console.WriteLine("Surety agreements:");
                foreach (var suretyAgreement in SuretyAgreementService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5}", suretyAgreement.Client.FirstName, suretyAgreement.Guarantor.FirstName,
                        suretyAgreement.Amount, suretyAgreement.Currency, suretyAgreement.LoanTerm, suretyAgreement.SuretyTerm));

                var BailAgreementService = new BailAgreementService(studContext);
                Console.WriteLine("Bail agreements:");
                foreach (var bailAgreement in BailAgreementService.Get())
                    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5}", bailAgreement.Client.FirstName, bailAgreement.BailObject,
                        bailAgreement.Amount, bailAgreement.Currency, bailAgreement.LoanTerm, bailAgreement.BailTerm));

                var SystemService = new SystemResolutionService(studContext);
                Console.WriteLine("System resolutions:");
                foreach (var resolution in SystemService.Get())
                    Console.WriteLine(string.Format("Application: {0} {1} {2}", resolution.LoanApplication.Id, resolution.MaxLoanAmount,
                        resolution.ScoringPoint));

                var SecurityService = new SecurityResolutionService(studContext);
                Console.WriteLine("Security resolutions:");
                foreach (var resolution in SecurityService.Get())
                    Console.WriteLine(string.Format("Application: {0} {1} {2}", resolution.LoanApplication.Id, resolution.Property,
                        resolution.PropertyEstimate));

                var ExpertService = new ExpertResolutionService(studContext);
                Console.WriteLine("Expert resolutions:");
                foreach (var resolution in ExpertService.Get())
                    Console.WriteLine(string.Format("Application: {0} {1} {2}", resolution.LoanApplication.Id, resolution.Property,
                        resolution.PropertyEstimate));

                var CommitteeService = new CommitteeResolutionService(studContext);
                Console.WriteLine("Committee resolutions:");
                foreach (var resolution in CommitteeService.Get())
                    Console.WriteLine(string.Format("Link: {0} {1}", resolution.ProtocolDocument.Link, resolution.Resolution));
            }

            Console.WriteLine("\nAuthentification: ");
            using (var authContext = new StudAuthorizeContext(true))
            {
                var userService = new EntityService<User>(authContext);
                var roleService = new EntityService<Role>(authContext);
                foreach (var user in userService.Get(includeProperties: "Roles"))
                {
                    System.Console.WriteLine(string.Format("{0} {1} {2} {3}", user.FirstName,
                        user.MiddleName, user.LastName, user.Roles.First().Name));
                }
                System.Console.WriteLine();

                userService.Get(user => user.FirstName == "Ivan").First().FirstName = "Vano";
                authContext.SaveChanges();

                foreach (var user in userService.Get(includeProperties: "Roles"))
                {
                    System.Console.WriteLine(string.Format("{0} {1} {2} {3}", user.FirstName,
                        user.MiddleName, user.LastName, user.Roles.First().Name));
                }
            }

            System.Console.ReadKey(true);            
        }
    }
}
