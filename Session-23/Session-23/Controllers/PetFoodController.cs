using Microsoft.AspNetCore.Mvc;
using Session_23.EF;
using Session_23.Model;
using Session_23.Models.PetFood;

namespace Session_23.Controllers {
    public class PetFoodController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;


        public PetFoodController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _customerRepo = customerRepo;
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }


        // GET: PetFoodController
        public ActionResult Index() {

            var petFoods = _petFoodRepo.GetAll();
            return View(model: petFoods);
        }


        // GET: PetFoodController/Details/5 
        public ActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var petFood = _petFoodRepo.GetById(id.Value);
            if (petFood == null) {
                return NotFound();
            }

            try { GetDataForPetFood(petFood); } catch { }

            var viewPetFood = new PetFoodDetailsDto {
                Id = petFood.Id,
                AnimalType = petFood.AnimalType,
                Cost = petFood.Cost,
                Price = petFood.Price,
                Transactions = petFood.Transactions.ToList()
            };
            return View(model: viewPetFood);
        }


        // GET: PetFoodController/Create
        public ActionResult Create() {

            return View();
        }


        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFoodCreateDto petFood) {

            if (!ModelState.IsValid) {
                return View();
            }
            var dbPetFood = new PetFood(petFood.AnimalType, petFood.Price, petFood.Cost);

            var petFoodType = petFood.AnimalType;
            var existingPetFoods = _petFoodRepo.GetAll();
            bool petFoodExists = false;

            foreach(var food in existingPetFoods) {
                if (food.AnimalType == petFoodType) {
                    petFoodExists = true;
                }
            }
            if (!petFoodExists) {
                _petFoodRepo.Add(dbPetFood);
                return RedirectToAction("Index");
            } else {
                return View("~/Views/Shared/ErrorMessage.cshtml");
            }

        }

        // GET: PetFoodController/Edit/5
        public ActionResult Edit(int id) {

            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodEditDto() {
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost
            };
            return View(model: viewPetFood);
        }

        // POST: PetFoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetFoodEditDto petFood) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null) {
                return NotFound();
            }
            dbPetFood.AnimalType = petFood.AnimalType;
            dbPetFood.Price = petFood.Price;
            dbPetFood.Cost = petFood.Cost;


            _petFoodRepo.Update(id, dbPetFood);

            return RedirectToAction("Index");
        }

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id) {

            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodDeleteDto() {
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost,
                Id = dbPetFood.Id

            };
            return View(model: viewPetFood);
        }

        // POST: PetFoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _petFoodRepo.Delete(id);
            }
            catch {

                return View("~/Views/Shared/ErrorDelete.cshtml");
            }


            return RedirectToAction("Index");
        }


        //HELPERS
        public void GetDataForPetFood(PetFood petFood) {
            foreach (var transaction in petFood.Transactions.ToList()) {
                transaction.Customer = _customerRepo.GetById(transaction.CustomerId);
                transaction.Employee = _employeeRepo.GetById(transaction.EmployeeId);
                transaction.Pet = _petRepo.GetById(transaction.PetId);
            }
        }
    }
}
