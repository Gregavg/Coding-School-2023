using Session_23.Model;
using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Session_23.Model {
    public class Pet {
        public Pet(string breed, AnimalType animalType, PetStatus petStatus, decimal price, decimal cost) {
            Breed = breed;
            AnimalType = animalType;
            PetStatus = petStatus;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

        // Properties
        public int Id { get; set; }
        public string Breed { get; set; }
        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }
        [Display(Name = "Pet Status")]
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public ICollection<Transaction> Transactions { get; set; }
    }
}
