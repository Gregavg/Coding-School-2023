using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.EF;
using Session_23.EF.Repositories;
using Session_23.Model;
using Session_23.Models.Customer;

namespace Session_23.Controllers {
    public class CustomerController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;


        public CustomerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _customerRepo = customerRepo;
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }


        // GET: CustomerController
        public ActionResult Index() {

            var customers = _customerRepo.GetAll();
            return View(model: customers);
        }


        // GET: CustomerController/Details/5 
        public ActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var customer = _customerRepo.GetById(id.Value);
            if (customer == null) {
                return NotFound();
            }

            try { 
            GetDataForCustomer(customer);
            }
            catch {

            }

            var viewCustomer = new CustomerDetailsDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin,
                Transactions = customer.Transactions.ToList()
            };
            return View(model: viewCustomer);
        }


        // GET: CustomerController/Create
        public ActionResult Create() {

            return View();
        }


        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = new Customer(customer.Name, customer.Surname, customer.Phone, customer.Tin);

            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");

        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id) {

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerEditDto() {
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin,
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;

            _customerRepo.Update(id, dbCustomer);

            return RedirectToAction("Index");
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id) {

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDeleteDto() {
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin,
                Id = dbCustomer.Id
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            try {
                _customerRepo.Delete(id);
            }
            catch {
                 return View("~/Views/Shared/ErrorDelete.cshtml");
            }


            return RedirectToAction("Index");
        }


        //helpers
        public void GetDataForCustomer(Customer customer) {
            foreach (var transaction in customer.Transactions.ToList()) {
                transaction.Employee = _employeeRepo.GetById(transaction.EmployeeId);
                transaction.Pet = _petRepo.GetById(transaction.PetId);
                transaction.PetFood = _petFoodRepo.GetById(transaction.PetFoodId);
            }
        }
    }
}
