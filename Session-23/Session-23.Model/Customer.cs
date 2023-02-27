using System.ComponentModel.DataAnnotations;

namespace Session_23.Model {
    public class Customer {
        public Customer(string name, string surname, string phone, string tin) {
            Name = name;
            Surname = surname;
            Phone = phone;
            Tin = tin;

            Transactions = new List<Transaction>();
        }


        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Tin { get; set; }

        // Relations
        public ICollection<Transaction> Transactions { get; set; }


    }
}
