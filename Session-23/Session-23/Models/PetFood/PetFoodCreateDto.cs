﻿using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.PetFood {
    public class PetFoodCreateDto
    {
        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }

        [Range(0, 9999.99, ErrorMessage = "The range is from 0 to 9999.99!")]
        public decimal Price { get; set; }
        [Range(0, 9999.99, ErrorMessage = "The range is from 0 to 9999.99!")]
        public decimal Cost { get; set; }
    }
}       
