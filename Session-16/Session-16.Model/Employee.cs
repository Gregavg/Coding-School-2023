using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public enum EmployeeType {
        Manager,
        Staff
    }
    public class Employee : User {



        public EmployeeType EmpType { get; set; }
        public decimal SalaryPerMonth { get; set; }

        public Employee() {
            ID = Guid.NewGuid();
        }

        public Employee(string name, string surname, EmployeeType employeeType, decimal salary) {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            EmpType = employeeType;
            SalaryPerMonth = salary;
        }


    }
}
