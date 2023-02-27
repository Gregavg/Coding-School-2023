using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.EF;
using Session_23.EF.Repositories;
using Session_23.Model;
using Session_23.Model.Enums;
using Session_23.Models.Customer;
using Session_23.Models.Employee;

namespace Session_23.Controllers {
    public class EmployeeController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;


        public EmployeeController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _customerRepo = customerRepo;
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }


        // GET: EmployeeController
        public ActionResult Index() {

            var employees = _employeeRepo.GetAll();
            return View(model: employees);
        }


        // GET: EmployeeController/Details/5 
        public ActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var employee = _employeeRepo.GetById(id.Value);
            if (employee == null) {
                return NotFound();
            }

            try {GetDataForEmployee(employee);} catch {}

            var viewEmployee = new EmployeeDetailsDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                SalaryPerMonth = employee.SalaryPerMonth,
                EmployeeType = employee.EmployeeType,
                Transactions = employee.Transactions.ToList()
            };
            return View(model: viewEmployee);
        }


        // GET: EmployeeController/Create
        public ActionResult Create() {

            return View();
        }


        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbEmployee = new Employee(employee.Name, employee.Surname, employee.EmployeeType, employee.SalaryPerMonth);

            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Index");

        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id) {

            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeEditDto() {
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                EmployeeType = dbEmployee.EmployeeType,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                Id = dbEmployee.Id
            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEditDto employee) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.EmployeeType = employee.EmployeeType;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;

            _employeeRepo.Update(id, dbEmployee);

            return RedirectToAction("Index");
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id) {

            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeDeleteDto() {
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                EmployeeType = dbEmployee.EmployeeType,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                Id = dbEmployee.Id
            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            try {
                _employeeRepo.Delete(id);
            }
            catch {

                return View("~/Views/Shared/ErrorDelete.cshtml");
            }


            return RedirectToAction("Index");
        }


        //helpers
        public void GetDataForEmployee(Employee employee) {
            foreach (var transaction in employee.Transactions.ToList()) {
                transaction.Customer = _customerRepo.GetById(transaction.CustomerId);
                transaction.Pet = _petRepo.GetById(transaction.PetId);
                transaction.PetFood = _petFoodRepo.GetById(transaction.PetFoodId);
            }
        }
    }
}
