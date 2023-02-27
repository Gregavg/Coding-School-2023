using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Model {
    public class Employee {
        public Employee(string name, string surname, EmployeeType employeeType, int salaryPerMonth) {
            Name = name;
            Surname = surname;
            EmployeeType = employeeType;
            SalaryPerMonth = salaryPerMonth;

            Transactions = new List<Transaction>();
        }

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Employee Type")]
        public EmployeeType EmployeeType { get; set; }
        [Display(Name = "Salary Per Month")]
        public int SalaryPerMonth { get; set; }

        // Relations
        public ICollection<Transaction> Transactions { get; set; }
    }
}
