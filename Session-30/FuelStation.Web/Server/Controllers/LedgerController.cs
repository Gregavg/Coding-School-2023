using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FuelStation.Model;
using FuelStation.EF.Repositories;
using FuelStation.Web.Shared;

namespace FuelStation.Web.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase {
        // Properties
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;


        // Constructors
        public LedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo) {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
        }

        // GET: api/<TransactionController>
        //[Route("/ledgerlist/{Rent}")]
        [HttpGet("{rent}")]
        public async Task<IEnumerable<LedgerDto>> Get(int rent) {
            var transactionList = await Task.Run(() => { return _transactionRepo.GetAll(); });

            if (transactionList == null) {
                return null;
            }
            List<LedgerDto> monthlyLedgers = new List<LedgerDto>();

            var employees = _employeeRepo.GetAll();


            DateTime dateTimeNow = DateTime.Now;

            var startingLedger = transactionList.Min(t => t.Date);

            int totalMonths = ((dateTimeNow.Year - startingLedger.Year) * 12) + dateTimeNow.Month - startingLedger.Month;

            for (var i = 0; i < totalMonths + 1; i++) {
                var ledger = new LedgerDto(startingLedger);
                ledger.AddExpense(rent);
                monthlyLedgers.Add(ledger);
                startingLedger = startingLedger.AddMonths(1);
            }

            foreach (var ledger in monthlyLedgers) {
                foreach (var employee in employees) {
                    if ((employee.HireDateStart.Month <= ledger.Month && employee.HireDateStart.Year <= ledger.Year) && ((employee.HireDateEnd?.Month >= ledger.Month && employee.HireDateEnd?.Year >= ledger.Year) || employee.HireDateEnd == null)) {
                        ledger.AddExpense(employee.SalaryPerMonth);
                    }
                }
                foreach (var transaction in transactionList) {
                    if (transaction.Date.Month == ledger.Month && transaction.Date.Year == ledger.Year) {
                        foreach (var tline in transaction.TransactionLines) {
                            ledger.AddExpense(tline.Item.Cost * tline.Quantity);
                            
                        }
                        ledger.AddIncome(transaction.TotalValue);
                    }
                }

            }

            return monthlyLedgers;
        }
    }
}
