
using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Web.Shared.Validator {
    public interface IValidator {
        bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage, Employee employee);
        bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out string errorMessage);
        bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage);
        bool ValidateAddTransaction(Transaction transaction, IList<Item> items, out string errorMessage);
        bool ValidateUpdateItem(List<TransactionLine> transactionLines, Item updatedItem, Item item, out string errorMessage);

    }
}
