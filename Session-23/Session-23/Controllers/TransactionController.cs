using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Session_23.EF;
using Session_23.EF.Repositories;
using Session_23.Model;
using Session_23.Model.Enums;
using Session_23.Models.PetFood;
using Session_23.Models.Transaction;
using System.Data.Common;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_23.Controllers {
    public class TransactionController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }


        // GET: TransactionController
        public ActionResult Index() {

            var transactions = _transactionRepo.GetAll();
            return View(model: transactions);
        }


        // GET: TransactionController/Details/5 
        public ActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var transaction = _transactionRepo.GetById(id.Value);
            if (transaction == null) {
                return NotFound();
            }

            try { GetDataForTransaction(transaction); } catch { }

            var viewTransaction = new TransactionDetailsDto {
                Id = transaction.Id,
                Date = transaction.Date,
                PetPrice = transaction.PetPrice,
                PetFoodQty = transaction.PetFoodQty,
                PetFoodPrice = transaction.PetFoodPrice,
                TotalPrice = transaction.TotalPrice,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
                PetId = transaction.PetId,
                PetFoodId = transaction.PetFoodId,
                Customer = transaction.Customer,
                Employee = transaction.Employee,
                Pet = transaction.Pet,
                PetFood = transaction.PetFood,
            };
            return View(model: viewTransaction);
        }

        // GET: TransactionController/Create
        public ActionResult Create() {
            var newTransaction = GetDataForCreateCombo();
            return View(model: newTransaction);
        }


        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction) {

            if (!ModelState.IsValid) {
                return View();
            }
            Pet? pet = _petRepo.GetById(transaction.PetId);
            PetFood? petFood = _petFoodRepo.GetById(transaction.PetFoodId);
            var petFoodQty = transaction.PetFoodQty;
            decimal totalPrice = 0;
            
            try {
                if (pet.AnimalType != 0) {
                    totalPrice = pet.Price + petFoodQty * petFood.Price;
                    petFoodQty++;
                } else {
                    totalPrice = petFoodQty * petFood.Price;
                }
            }catch {}



            var dbTransaction = new Transaction(
                transaction.Date,
                pet.Price,
                petFoodQty,
                petFood.Price,
                totalPrice,
                transaction.CustomerId,
                transaction.EmployeeId,
                transaction.PetId,
                transaction.PetFoodId
                );

            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");

        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var viewTransaction = GetDataForEditCombo();

            viewTransaction.Date = dbTransaction.Date;
            viewTransaction.PetPrice = dbTransaction.PetPrice;
            viewTransaction.PetFoodQty = dbTransaction.PetFoodQty;
            viewTransaction.PetFoodPrice = dbTransaction.PetFoodPrice;
            viewTransaction.TotalPrice = dbTransaction.TotalPrice;
            viewTransaction.CustomerId = dbTransaction.CustomerId;
            viewTransaction.EmployeeId = dbTransaction.EmployeeId;
            viewTransaction.PetId = dbTransaction.PetId;
            viewTransaction.PetFoodId = dbTransaction.PetFoodId;

            return View(model: viewTransaction);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var pet = _petRepo.GetById(transaction.PetId);
            var petFood = _petFoodRepo.GetById(transaction.PetFoodId);
            var petFoodQty = transaction.PetFoodQty;
            decimal totalPrice;

            if ((pet.AnimalType != 0)) {
                totalPrice = pet.Price + (petFoodQty - 1) * petFood.Price;
            } else {
                totalPrice = petFoodQty * petFood.Price;
            }


            dbTransaction.Date = transaction.Date;
            dbTransaction.PetPrice = pet.Price;
            dbTransaction.PetFoodQty = petFoodQty;
            dbTransaction.PetFoodPrice = petFood.Price;
            dbTransaction.TotalPrice = totalPrice;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PetId = transaction.PetId;
            dbTransaction.PetFoodId = transaction.PetFoodId;

            _transactionRepo.Update(id, dbTransaction);

            return RedirectToAction("Index");
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var viewTransaction = new TransactionDeleteDto() {

                Date = dbTransaction.Date,
                PetPrice = dbTransaction.PetPrice,
                PetFoodQty = dbTransaction.PetFoodQty,
                PetFoodPrice = dbTransaction.PetFoodPrice,
                TotalPrice = dbTransaction.TotalPrice,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId,
                PetId = dbTransaction.PetId,
                PetFoodId = dbTransaction.PetFoodId,
            };
            viewTransaction.Customer = _customerRepo.GetById(viewTransaction.CustomerId);
            viewTransaction.Employee = _employeeRepo.GetById(viewTransaction.EmployeeId);
            viewTransaction.Pet = _petRepo.GetById(viewTransaction.PetId);
            viewTransaction.PetFood = _petFoodRepo.GetById(viewTransaction.PetFoodId);


            return View(model: viewTransaction);

        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _transactionRepo.Delete(id);
            }
            catch {
                return View("~/Views/Shared/ErrorDelete.cshtml");
            }


            return RedirectToAction("Index");
        }

        //HELPERS
        //comboboxes
        public TransactionCreateDto GetDataForCreateCombo() {
            var transaction = new TransactionCreateDto();
            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var pets = _petRepo.GetAll().Where(pet => pet.PetStatus != PetStatus.Unhealthy);
            var petFoods = _petFoodRepo.GetAll();


            foreach (var customer in customers) {
                transaction.Customers.Add(new SelectListItem(customer.Surname + " " + customer.Name, customer.Id.ToString()));
            }
            foreach (var employee in employees) {
                transaction.Employees.Add(new SelectListItem(employee.Surname + " " + employee.Name, employee.Id.ToString()));
            }
            foreach (var pet in pets) {
                transaction.Pets.Add(new SelectListItem(pet.Breed + ", " + pet.AnimalType + " - " + pet.Price + "€", pet.Id.ToString()));
            }
            foreach (var petFood in petFoods) {
                transaction.PetFoods.Add(new SelectListItem(petFood.AnimalType.ToString() + " - " + petFood.Price + "€", petFood.Id.ToString()));
            }
            return transaction;
        }

        public TransactionEditDto GetDataForEditCombo() {
            var transaction = new TransactionEditDto();
            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var pets = _petRepo.GetAll().Where(pet => pet.PetStatus != PetStatus.Unhealthy);
            var petFoods = _petFoodRepo.GetAll();


            foreach (var customer in customers) {
                transaction.Customers.Add(new SelectListItem(customer.Surname + " " + customer.Name, customer.Id.ToString()));
            }
            foreach (var employee in employees) {
                transaction.Employees.Add(new SelectListItem(employee.Surname + " " + employee.Name, employee.Id.ToString()));
            }
            foreach (var pet in pets) {
                transaction.Pets.Add(new SelectListItem(pet.Breed + ", " + pet.AnimalType + " - " + pet.Price + "€", pet.Id.ToString()));
            }
            foreach (var petFood in petFoods) {
                transaction.PetFoods.Add(new SelectListItem(petFood.AnimalType.ToString() + " - " + petFood.Price + "€", petFood.Id.ToString()));
            }
            return transaction;
        }

        public void GetDataForTransaction(Transaction transaction) {

            transaction.Customer = _customerRepo.GetById(transaction.CustomerId);
            transaction.Employee = _employeeRepo.GetById(transaction.EmployeeId);
            transaction.Pet = _petRepo.GetById(transaction.PetId);
            transaction.PetFood = _petFoodRepo.GetById(transaction.PetFoodId);

        }




    }
}
