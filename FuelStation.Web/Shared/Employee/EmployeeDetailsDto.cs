

using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared {
    public class EmployeeDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime HireDateStart { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? HireDateEnd { get; set; }

        public List<EmployeeTransactionDetailsDto>? Transactions { get; set; } = new();
    }
}
