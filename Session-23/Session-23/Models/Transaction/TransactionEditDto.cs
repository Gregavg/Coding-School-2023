using Microsoft.AspNetCore.Mvc.Rendering;
using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.Transaction {
    public class TransactionEditDto
    {
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        [Display(Name = "Pet")]
        public int PetId { get; set; }
        [Display(Name = "Pet Food")]
        public int PetFoodId { get; set; }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Display(Name = "Quantity")]
        [Range(0, 1000, ErrorMessage = "The range is from 0 to 999!")]
        public int PetFoodQty { get; set; }

        [Display(Name = "Pet Price")]
        [Range(0, 9999.99, ErrorMessage = "The range is from 0 to 9999.99!")]
        public decimal PetPrice { get; set; }

        [Display(Name = "Pet Food Price")]
        [Range(0, 9999.99, ErrorMessage = "The range is from 0 to 9999.99!")]
        public decimal PetFoodPrice { get; set; }

        [Display(Name = "Total Price")]
        [Range(0, 9999.99, ErrorMessage = "The range is from 0 to 99999.99!")]
        public decimal TotalPrice { get; set; }


        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Employees { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Pets { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PetFoods { get; set; } = new List<SelectListItem>();

    }
}
