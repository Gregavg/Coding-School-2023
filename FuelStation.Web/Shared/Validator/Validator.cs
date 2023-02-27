

using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Web.Shared.Validator {
    public class Validator : IValidator {
        public readonly MinMax ManagersLimits;
        public readonly MinMax CashiersLimits;
        public readonly MinMax StaffLimits;
        public readonly MinMax WaitersLimits;

        public Validator() {
            ManagersLimits = new MinMax() { Min = 0, Max = 3 };
            CashiersLimits = new MinMax() { Min = 0, Max = 4 };
            StaffLimits = new MinMax() { Min = 0, Max = 10 };
        }

        //TODO MAKE METHODS SMALLER
        public bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage, Employee employee) {
            errorMessage = "Succeed ";
            bool ret = true;
            var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier && e.HireDateEnd == null);
            var staff = employees.Where(e => e.EmployeeType == EmployeeType.Staff && e.HireDateEnd == null);
            var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager && e.HireDateEnd == null);
            if (type == EmployeeType.Manager && managers.Count() == ManagersLimits.Max) {
                ret = false;
                errorMessage = $"You already have {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
            }
            if (type == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                ret = false;
                errorMessage = $"You already have {CashiersLimits.Max} Cashiers. Max number of Cashiers is {CashiersLimits.Max}";
            }
            if (type == EmployeeType.Staff && staff.Count() >= StaffLimits.Max) {
                ret = false;
                errorMessage = $"You already have {StaffLimits.Max} Staff. Max number of Staff is {StaffLimits.Max}";
            }
            if (employee.HireDateStart > employee.HireDateEnd) {
                ret = false;
                errorMessage = $"Hire end date must be greater than start.";
            } else if (employee.HireDateStart <= employee.HireDateEnd) {
                ret = true;
                errorMessage = "Succeed ";
            }

            return ret;
        }

        public bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out string errorMessage) {
            errorMessage = "Succeed ";
            bool ret = true;
            if (dbEmployee == null) {
                ret = false;
            } else {
                var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier && e.HireDateEnd == null);
                var staff = employees.Where(e => e.EmployeeType == EmployeeType.Staff && e.HireDateEnd == null);
                var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager && e.HireDateEnd == null);


                if (NewType == EmployeeType.Manager && (managers.Any(manager => manager.Id == dbEmployee.Id) ? managers.Count() - 1 : managers.Count()) >= ManagersLimits.Max) {
                    
                    errorMessage = $"You already have {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
                    ret = false;
                }
                if (NewType == EmployeeType.Cashier && (cashiers.Any(cashier => cashier.Id == dbEmployee.Id) ? cashiers.Count() - 1 : cashiers.Count()) >= CashiersLimits.Max) {
                    errorMessage = $"You already have {CashiersLimits.Max} cashiers. Max number of cashiers is {CashiersLimits.Max}";
                    ret = false;
                }
                if (NewType == EmployeeType.Staff && (staff.Any(staf => staf.Id == dbEmployee.Id) ? staff.Count() - 1 : staff.Count()) >= StaffLimits.Max) {
                    errorMessage = $"You already have {StaffLimits.Max} Staff. Max number of Staff is {StaffLimits.Max}";
                    ret = false;
                }
                if (dbEmployee.HireDateStart > dbEmployee.HireDateEnd) {
                    ret = false;
                    errorMessage = $"Hire end date must be greater than start.";
                } else if (dbEmployee.HireDateStart < dbEmployee.HireDateEnd) {
                    ret = true;
                    errorMessage = "Succeed ";
                }
            }
            return ret;
        }

        public bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage) {
            bool ret = true;
            errorMessage = "Succeed ";
            var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier && e.HireDateEnd == null);
            var staff = employees.Where(e => e.EmployeeType == EmployeeType.Staff && e.HireDateEnd == null);
            var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager && e.HireDateEnd == null);
            if (type == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
                errorMessage = $"You only have {ManagersLimits.Min} Manager. Min number of Managers is {ManagersLimits.Min}.";
                ret = false;
            }
            if (type == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
                errorMessage = $"You only have {CashiersLimits.Min} Cashier. Min number of Cashiers is {CashiersLimits.Min}.";
                ret = false;
            }
            if (type == EmployeeType.Staff && staff.Count() <= StaffLimits.Min) {
                errorMessage = $"You only have {StaffLimits.Min} Staff. Min number of Staff is {StaffLimits.Min}.";
                ret = false;
            }

            return ret;
        }

        public bool ValidateAddTransaction(Transaction transaction, IList<Item> items, out string errorMessage) {
            bool ret = true;
            int fuelNumber = 0;

            decimal tempWholeTotalValue = 0;
            foreach (var tl in transaction.TransactionLines) {
                decimal tempDiscountPercentage = 0;
                decimal tempDiscountValue = 0;

                var tempNetValue = tl.ItemPrice * tl.Quantity; if (tempNetValue != tl.NetValue) ret = false;
                foreach (var item in items) {
                    if (tl.ItemId == item.Id) {
                        if (item.ItemType == ItemType.Fuel) {

                            fuelNumber++;
                            tempDiscountPercentage = tempNetValue > 20 ? 10 : 0;
                            if (tempDiscountPercentage != tl.DiscountPercentage) ret = false;
                        }
                    }
                }

                tempDiscountValue = (tempNetValue * tempDiscountPercentage) / 100; if (tempDiscountValue != tl.DiscountValue) ret = false;
                tempWholeTotalValue += tempNetValue - tempDiscountValue;
            }

            if (tempWholeTotalValue != transaction.TotalValue) {
                ret = false;
            }
            if (fuelNumber > 1) {
                ret = false;
            }

            if (ret == false) errorMessage = $"Not correct values!";
            else errorMessage = "Transaction valid!";

            return ret;
        }
    }

    public struct MinMax {
        public int Min;
        public int Max;
    }
}
