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
            var result = await Task.Run(() => { return _transactionRepo.GetAll(); });

            List<Ledger> monthlyLedgers = new List<Ledger>();

            if (result == null) {
                return null;
            }

            var transactionList = _transactionRepo.GetAll();

            var employees = _employeeRepo.GetAll();

            DateTime dateTimeNow = DateTime.Now;

            var currentLedger = transactionList.Min(t => t.Date);

            int totalMonths = ((dateTimeNow.Year - currentLedger.Year) * 12) + dateTimeNow.Month - currentLedger.Month;

            for (var i = 0; i < totalMonths + 1; i++) {
                var ledger = new Ledger(currentLedger);
                ledger.AddExpense(rent);
                monthlyLedgers.Add(ledger);
                currentLedger = currentLedger.AddMonths(1);
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
            
            var ledgerDto = monthlyLedgers.Select(item => new LedgerDto {
                Month = item.Month,
                Year = item.Year,
                Expenses= item.Expenses,
                Income= item.Income,
                Total= item.Income - item.Expenses,
            });
            return ledgerDto;
        }
    }
}
