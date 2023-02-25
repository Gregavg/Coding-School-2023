using FuelStation.Model.Enums;
using FuelStation.Model;
using FuelStation.Web.Shared.StartsWithAValidator;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FuelStation.Web.Shared {
    public class TransactionEditDto {


        // Properties
        public int Id { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }


        public decimal TotalValue { get; set; }
        [Required]
        [Range(1, 2, ErrorMessage = "You must choose a Payment Method!")]
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; } = null!;

        public List<TransactionLineEditDto>? TransactionLines { get; set; } = new List<TransactionLineEditDto>();


    }
}
