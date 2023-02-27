using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Session_23.Model {
    public class Transaction {
        public Transaction(decimal petPrice, int petFoodQty, decimal petFoodPrice, decimal totalPrice) {
            Date = DateTime.Now;
            PetPrice = petPrice;
            PetFoodPrice = petFoodPrice;
            PetFoodQty = petFoodQty;
            TotalPrice = totalPrice;
            TotalPrice = totalPrice;
        }

        public Transaction(DateTime date, decimal petPrice, int petFoodQty, decimal petFoodPrice, 
            decimal totalPrice,  int customerId, int employeeId, int petId, int petFoodId) {
            Date = date;
            PetPrice = petPrice;
            PetFoodQty = petFoodQty;
            PetFoodPrice = petFoodPrice;
            TotalPrice = totalPrice;
            //relations
            CustomerId = customerId;
            EmployeeId = employeeId;
            PetId = petId;
            PetFoodId = petFoodId;
        }




        // Properties
        public int Id { get; set; }

        public DateTime Date { get; set; }

        // Relations
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; } = null!;

        [Display(Name = "Pet")]
        public int PetId { get; set; }
        public Pet? Pet { get; set; } = null!;
        [Display(Name = "Pet Price")]
        public decimal PetPrice { get; set; }//property

        public int PetFoodId { get; set; }
        [Display(Name = "Pet Food")]
        public PetFood? PetFood { get; set; } = null!;

        // Properties
        [Display(Name = "Pet Food Quantity")]
        public int PetFoodQty { get; set; }
        [Display(Name = "Pet Food Price")]
        public decimal PetFoodPrice { get; set; }
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }


    }
}
