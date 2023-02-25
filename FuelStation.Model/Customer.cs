
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Model {
    public class Customer {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        [MaxLength(100)]        
        public string CardNumber { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        // Constructors
        public Customer(string name, string surname, string cardNumber) {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;

            Transactions = new List<Transaction>();
        }

    }
}