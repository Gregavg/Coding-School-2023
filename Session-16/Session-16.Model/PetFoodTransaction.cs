using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class PetFoodTransaction {
        public Guid ID { get; set; }
        public decimal Qty { get; set; }
        public DateTime Date { get; set; }

        public PetFood Petfood { get; set; }

        public PetFoodTransaction() {

        }

        public PetFoodTransaction(DateTime date, decimal qty) {
            Qty = qty;
            Date = date;
        }



    }
}
