using ClassLibrary1;
using ClassLibrary1.PopulateClasses;
using PopulateClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateClassLibrary {
    public class PopulateTransaction {

        public PopulateTransaction() {

        }

        public List<Transaction> PopulateTransactions(List<PetFood> foods, List<Pet> pets, List<Employee> employees, List<Customer> customers) {

            List<Transaction> transactions = new List<Transaction>();
            Transaction tr;
            int petIndex = 0;
            int customerIndex = 0;
            var random = new Random();

            //with pet populate


            while (petIndex < 5) {
                tr = new Transaction(RandomDate(), customers[customerIndex].ID, employees[random.Next(employees.Count)].ID, pets[petIndex].ID, RandomQty(), pets, foods);
                transactions.Add(tr);
                customerIndex++;
                petIndex++;
            }
            //only pet food
            while (customerIndex < customers.Count) {
                tr = new Transaction(RandomDate(), customers[customerIndex].ID, employees[random.Next(employees.Count)].ID, GetRandomType(), RandomQty(), foods);
                transactions.Add(tr);
                customerIndex++;
            }
            tr = new Transaction(RandomDate(), customers[0].ID, employees[0].ID, GetRandomType(), RandomQty(), foods);
            transactions.Add(tr);
            return transactions;
        }


        public Transaction SetPetAndFood(Transaction tr, List<Pet> pets, List<PetFood> foods, int petIndex) {
            var newPet = pets[petIndex];
            if (tr.PetID != Guid.Empty) {
                foreach (var food in foods) {
                    if (food.Animaltype == newPet.Animaltype) {
                        tr.PetFoodID = food.ID;
                        break;
                    }
                }
            } else {
                tr.PetFoodID = RandomPetFood(foods);
            }
            return tr;
        }



        public int RandomEmployee(List<Employee> employees) {
            var random = new Random();
            int employee = random.Next(1, employees.Count);
            return employee;
        }

        public int RandomQty() {
            var random = new Random();
            int qty = random.Next(1, 20);
            return qty;
        }

        public Guid RandomPetFood(List<PetFood> foods) {
            var random = new Random();
            var pf = foods[random.Next(0, foods.Count)].ID;
            return pf;
        }

        public DateTime RandomDate() {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range));
        }

        public AnimalType GetRandomType() {
            Array values = Enum.GetValues(typeof(AnimalType));
            Random random = new Random();
            AnimalType randomType = (AnimalType)values.GetValue(random.Next(values.Length));
            return randomType;
        }

    }
}
