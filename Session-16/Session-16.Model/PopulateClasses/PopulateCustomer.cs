using Session_16.Model;
using System.Numerics;
using System.Xml.Linq;

namespace Session_16.Model.PopulateClasses {
    public class PopulateCustomer {
        public List<Customer> Customers { get; set; }
        public PopulateCustomer() { }

        //Customer(ID, Name, Surname, Phone, TIN)

        public List<Customer> PopulateCustomers() {
            Customers = new List<Customer>();
            int randomUpper = 999999999;
            int randomLower = 000000001;

            Customer customer;

            customer = new Customer("John", "Papajohn", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Charis", "Charoulis", "175-124-56", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Zisis", "Zisakos", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Kostas", "Mitrogol", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Panos", "Korgialas", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Betty", "Tzanabetty", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Kiki", "Chainoglou", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Katerina", "Papoutsaki", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Margarita", "Margarw", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Kostas", "Prekas", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Rita", "Ritaki", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Petros", "Petran", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Tasos", "Stotoglou", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Christos", "Christakis", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Makis", "Dimakis", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Nikitas", "Avramopoulos", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Marina", "Marteli", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Marios", "Marinos", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Mitsos", "Karamanlis", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Filos", "Filou", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customer("Paris", "Pateras", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);


            //bsCustomer.DataSource = Customers;
            return Customers;
        }

        public int RandomTin(int lower, int upper) {
            var random = new Random();
            int number = random.Next(lower, upper);
            return number;
        }





    }
}