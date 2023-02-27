using System.ComponentModel.DataAnnotations;

namespace Session_16.Model {
    public class Customer : User {
        public string? Phone { get; set; }
        public int TIN { get; set; }

        public Customer() {
            ID = Guid.NewGuid();
        }

        public Customer(string name, string surname, string phone, int tin) {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Phone = phone;
            TIN = tin;
        }


    }
}
