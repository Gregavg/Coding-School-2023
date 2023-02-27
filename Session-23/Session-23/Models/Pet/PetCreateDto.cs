using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.Pet
{
    public class PetCreateDto
    {
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Breed { get; set; } = null!;

        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }

        [Display(Name = "Pet Status")]
        public PetStatus PetStatus { get; set; }

        [Range(0, 999999.99, ErrorMessage = "The range is from 0 to 999999.99!")]
        public decimal Price { get; set; }
        [Range(0, 999999.99, ErrorMessage = "The range is from 0 to 999999.99!")]
        public decimal Cost { get; set; }
    }
}       
