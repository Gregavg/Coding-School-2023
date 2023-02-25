
using FuelStation.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FuelStation.Web.Shared {
    public class EmployeeListDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime HireDateStart { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? HireDateEnd { get; set; }
    }
}
