using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Session_23.Model {
    public class PetFood {
        public PetFood(AnimalType animalType, decimal price, decimal cost) {
            AnimalType = animalType;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

        // Properties
        public int Id { get; set; }
        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public ICollection<Transaction> Transactions { get; set; }
    }
}
