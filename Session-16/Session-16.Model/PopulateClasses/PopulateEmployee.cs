using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_16.Model.Employee;

namespace Session_16.Model.PopulateClasses {
    public class PopulateEmployee {
        public List<Employee> Employees { get; set; }
        public PopulateEmployee() { }
        //functions

        public List<Employee> PopulateEmployees() {
            //Employee(ID, Name, Surname, EmployeeType (enum), SallaryPerMonth)

            Employees = new List<Employee>();
            Employee employee;


            employee = new Employee("Kwstantinos", "Dimitropoulos", EmployeeType.Manager, 1500);
            Employees.Add(employee);

            employee = new Employee("Giannis", "Dimitrakopoulopoulos", EmployeeType.Manager, 1300);
            Employees.Add(employee);

            employee = new Employee("George", "Paulidis", EmployeeType.Staff, 800);
            Employees.Add(employee);

            employee = new Employee("Panos", "Kamenos", EmployeeType.Staff, 900);
            Employees.Add(employee);

            employee = new Employee("Telis", "Praxitelis", EmployeeType.Staff, 600);
            Employees.Add(employee);

            employee = new Employee("Alexandros", "Alexandrou", EmployeeType.Staff, 900);
            Employees.Add(employee);

            return Employees;

        }


    }
}
