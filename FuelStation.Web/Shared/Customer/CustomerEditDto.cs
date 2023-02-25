using FuelStation.Model;
using FuelStation.Web.Shared.StartsWithAValidator;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FuelStation.Web.Shared {
    public class CustomerEditDto {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Surname { get; set; } = null!;

        [Required]
        [MaxLength(100, ErrorMessage = "Type less than 100 characters")]
        [StartsWithA(ErrorMessage = "The card number must start with the letter A.")]
        public string CardNumber { get; set; } = null!;

        //public List<Transaction> Transactions { get; set; } = new();
    }
}
