using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class PetFood {
        public Guid ID { get; set; }
        public AnimalType Animaltype { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CurrentStock { get; set; }
        public List<Transaction> Transactions { get; set; }
        //public List<PetFoodTransaction> PetFoodTransactions { get; set; } = new List<PetFoodTransaction>();
       

        public PetFood() {
            Qty = 0;
            ID = Guid.NewGuid();
        }

        public PetFood(AnimalType type, decimal cost, decimal price) {
            Qty = 0;
            ID = Guid.NewGuid();
            Animaltype = type;
            Cost = cost;
            Price = price;
        }




        public void SetQty() {

            
            //foreach (var trans in PetFoodTransactions) {
            //    Qty += trans.Qty;
            //}
        }

    }
}
