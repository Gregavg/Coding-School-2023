
using FuelStation.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FuelStation.Web.Shared {
    public class EmployeeEditDto {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Surname { get; set; } = null!;

        [Required]
        [Range(0, 9999, ErrorMessage = "The range is from 0 to 9999!")]
        public int SalaryPerMonth { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "You must choose a type!")]
        public EmployeeType EmployeeType { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime HireDateStart { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? HireDateEnd { get; set; }

    }
}
