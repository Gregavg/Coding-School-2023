using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateClassLibrary {
    public class PopulatePetFood {

        public PopulatePetFood() {

        }

        public List<PetFood> PopulatePetFoods() {

            List<PetFood> petFood = new List<PetFood>();
            int transactionNumber = 30;
            DateTime date;
            decimal qty;
            PetFood pf;

            //populate
            foreach (AnimalType type in Enum.GetValues(typeof(AnimalType))) {
                pf = new PetFood(type, RandomPriceCost(2, 5), RandomPriceCost(7, 12));
                date = RandomDate();
                qty = RandomQty();

                //PetShopTransactions - How many the PetShop bought (not customer)
                for (int i = 0; i < transactionNumber; i++) {
                    pf.PetFoodTransactions.Add(new PetFoodTransaction(date, qty));
                }
                pf.SetQty();
                petFood.Add(pf);
            }
            return petFood;
        }



        public decimal RandomPriceCost(int lower, int upper) {
            var random = new Random();
            int number = random.Next(lower, upper);
            return number;
        }


        //random quantity for PetFoodTransactions
        public decimal RandomQty() {
            var random = new Random();
            int employee = random.Next(20, 60);
            return employee;
        }
        //random date for PetFoodTransactions
        public DateTime RandomDate() {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
