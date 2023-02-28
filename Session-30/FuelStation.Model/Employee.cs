using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Model {
    public class Employee {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime HireDateStart { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? HireDateEnd { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        // Constructors
        public Employee(string name, string surname, int salaryPerMonth, 
            EmployeeType employeeType, DateTime hireDateStart, DateTime? hireDateEnd) {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
            HireDateStart = hireDateStart;
            HireDateEnd = hireDateEnd;
            Transactions = new List<Transaction>();
        }
    }
}