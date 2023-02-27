using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class Transaction {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid? CustomerID { get; set; }
        public Guid? EmployeeID { get; set; }
        public Guid? PetID { get; set; }
        public Guid? PetFoodID { get; set; }

        public decimal? PetPrice { get; set; }
        public decimal? PetFoodQty { get; set; }
        public decimal? PetFoodPrice { get; set; }
        public decimal? TotalPrice { get; set; }

        public Pet? pet { get; set; }
        public Customer? customer { get; set; } 
        public Employee? employee { get; set; }
        public PetFood? petFood { get; set; }

        //CTOR
        public Transaction() {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
            PetID = Guid.Empty;
            PetPrice = 0;
            PetFoodQty = 0;
            PetFoodPrice = 0;
            TotalPrice = 0;
        }


        //CTOR with pet

        public Transaction(DateTime date, Guid customerID, Guid employeeID, Guid petID, decimal petFoodQty, List<Pet> pets, List<PetFood> foods) {
            ID = Guid.NewGuid();
            Date = date;
            CustomerID = customerID;
            EmployeeID = employeeID;
            AddPetAndFood(petID, petFoodQty, foods, pets);

        }

        //Without pet
        public Transaction(DateTime date, Guid customerID, Guid employeeID, AnimalType? animalType, decimal petFoodQty, List<PetFood> foods) {
            ID = Guid.NewGuid();
            PetID = null;
            Date = date;
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetFoodID = AddPetFood(animalType, petFoodQty, foods);
        }


        //METHODS
        public void AddPet(Pet pet) {
            if (PetID != null) {

            }
        }
        //addPet
        public void AddPetAndFood(Guid id, decimal petFoodQty, List<PetFood> foods, List<Pet> pets) {
            AnimalType? foodType;
            foreach (Pet pet in pets) {
                if (pet.ID == id) {
                    PetID = pet.ID;
                    PetPrice = pet.Price;
                    foodType = pet.Animaltype;
                    //pet.SetTransactionID(ID);
                    AddPetFood(foodType, petFoodQty, foods);

                    PetFoodQty++;
                    break;
                }
            }
        }


        //addFood 
        public Guid? AddPetFood(AnimalType? foodType, decimal petFoodQty, List<PetFood> foods) {
            foreach (var food in foods) {
                if (foodType == food.Animaltype) {
                    PetFoodPrice = food.Price;
                    PetFoodID = food.ID;
                    PetFoodQty = petFoodQty;
                    break;
                }
            }
            SetTotalPrice();
            return PetFoodID;
        }


        //SetTotalPrice
        public void SetTotalPrice() {

            if (this.PetID != null) {
                this.TotalPrice = PetPrice + (PetFoodQty * PetFoodPrice);
            } else {
                this.TotalPrice = (PetFoodQty * PetFoodPrice);
            }
        }

        public decimal FindPetPrice(List<Pet> pets) {

            decimal price = 0;
            foreach (var pet in pets) {
                if (pet.ID == PetID) {
                    price = pet.Price;
                    break;
                }
            }
            return price;
        }

        public decimal FindPetFoodPrice(List<PetFood> foods) {
            decimal price = 0;
            foreach (var food in foods) {
                if (food.ID == PetFoodID) {
                    price = food.Price;
                    break;
                }
            }
            return price;
        }
    }
}
