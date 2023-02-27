using Microsoft.AspNetCore.Mvc;
using Session_23.EF;
using Session_23.Model;

namespace Session_23.Controllers {
    public class MonthlyLedgerController : Controller {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        private readonly DateTime _openingDate = new DateTime(2022, 12, 1);

        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }

        // GET: MonthlyLedgerController
        public ActionResult Index() {

            List<MonthlyLedger> monthlyLedgers = new List<MonthlyLedger>();

            DateTime dateTimeNow = DateTime.Now;
            DateTime currentLedger = _openingDate;

            decimal totalSalaries = CalcEmployeesSalaries();

            int totalMonths = ((dateTimeNow.Year - _openingDate.Year) * 12) + dateTimeNow.Month - _openingDate.Month;

            MonthlyLedger ml = new MonthlyLedger();

            for (var i = 0; i < totalMonths + 1; i++) {
                ml = new MonthlyLedger(currentLedger);
                ml.Expenses += totalSalaries;
                ml.AddRent();
                monthlyLedgers.Add(ml);
                currentLedger = currentLedger.AddMonths(1);
            }

            var transactions = _transactionRepo.GetAll();
            foreach (var transaction in transactions) {
                foreach (var monthlyLedger in monthlyLedgers) {
                    if ((transaction.Date.Month == monthlyLedger.Month) && (transaction.Date.Year == monthlyLedger.Year)) {
                        monthlyLedger.Transactions.Add(transaction);
                    }
                }
            }

            foreach (var monthlyLedger in monthlyLedgers) {
                foreach (var transaction in monthlyLedger.Transactions) {

                    monthlyLedger.Expenses += transaction.Pet.Cost;
                    monthlyLedger.Expenses += transaction.PetFood.Cost * transaction.PetFoodQty;

                    monthlyLedger.Income += transaction.Pet.Price;
                    if (transaction.Pet.AnimalType == 0) {
                        monthlyLedger.Income += transaction.PetFood.Price * transaction.PetFoodQty;
                    } else {
                        monthlyLedger.Income += transaction.PetFood.Price * (transaction.PetFoodQty - 1);
                    }
                }
                monthlyLedger.Total = monthlyLedger.Income - monthlyLedger.Expenses;
            }
            return View(model: monthlyLedgers);
        }

        public decimal CalcEmployeesSalaries() {
            decimal totalSalaries = 0;
            var employeeList = _employeeRepo.GetAll();
            foreach (var employee in employeeList) {
                totalSalaries += employee.SalaryPerMonth;
            }
            return totalSalaries;
        }

        // GET: MonthlyLedgerController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: MonthlyLedgerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: MonthlyLedgerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: MonthlyLedgerController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: MonthlyLedgerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: MonthlyLedgerController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: MonthlyLedgerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
