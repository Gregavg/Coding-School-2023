using Microsoft.AspNetCore.Mvc;
using Session_23.EF;
using Session_23.EF.Repositories;
using Session_23.Model;
using Session_23.Models.Employee;
using Session_23.Models.Pet;

namespace Session_23.Controllers {
    public class PetController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;


        public PetController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _customerRepo = customerRepo;
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }



        // GET: PetController
        public ActionResult Index() {

            var pets = _petRepo.GetAll();
            return View(model: pets);
        }


        // GET: PetController/Details/5 
        public ActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var pet = _petRepo.GetById(id.Value);
            if (pet == null) {
                return NotFound();
            }

            try { GetDataForPet(pet); } catch { }

            var viewPet = new PetDetailsDto {
                Id = pet.Id,
                AnimalType= pet.AnimalType,
                Breed= pet.Breed,
                Cost= pet.Cost,
                PetStatus= pet.PetStatus,
                Price= pet.Price,
                Transactions = pet.Transactions.ToList()
            };
            return View(model: viewPet);
        }


        // GET: PetController/Create
        public ActionResult Create() {

            return View();
        }


        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetCreateDto pet) {

            if (!ModelState.IsValid) {
                return View();
            }
            var dbPet = new Pet(pet.Breed, pet.AnimalType, pet.PetStatus, pet.Price, pet.Cost);
            _petRepo.Add(dbPet);
            return RedirectToAction("Index");

        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int id) {

            var dbPet = _petRepo.GetById(id);
            if (dbPet == null) {
                return NotFound();
            }

            var viewPet = new PetEditDto() {
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost
            };
            return View(model: viewPet);
        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetEditDto pet) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbPet = _petRepo.GetById(id);
            if (dbPet == null) {
                return NotFound();
            }
            dbPet.Breed = pet.Breed;
            dbPet.AnimalType = pet.AnimalType;
            dbPet.PetStatus = pet.PetStatus;
            dbPet.Price = pet.Price;
            dbPet.Cost = pet.Cost;


            _petRepo.Update(id, dbPet);

            return RedirectToAction("Index");
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id) {

            var dbPet = _petRepo.GetById(id);
            if (dbPet == null) {
                return NotFound();
            }

            var viewPet = new PetDeleteDto() {
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost,
                Id = dbPet.Id

            };
            return View(model: viewPet);
        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {


            try {
                _petRepo.Delete(id);
            }
            catch {

                return View("~/Views/Shared/ErrorDelete.cshtml");
            }


            return RedirectToAction("Index");
        }

        public void GetDataForPet(Pet pet) {
            foreach (var transaction in pet.Transactions.ToList()) {
                transaction.Customer = _customerRepo.GetById(transaction.CustomerId);
                transaction.Employee = _employeeRepo.GetById(transaction.EmployeeId);
                transaction.PetFood = _petFoodRepo.GetById(transaction.PetFoodId);
            }
        }
    }
}
