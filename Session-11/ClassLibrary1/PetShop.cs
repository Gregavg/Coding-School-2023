using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class PetShop {

        //PROPERTIES
        public string Name { get; set; }
        public List<PetFood>? Foods { get; set; }
        public List<Pet>? Pets { get; set; }
        public List<Employee>? Employees { get; set; }
        public List<Customer>? Customers { get; set; }
        public List<Transaction>? Transactions { get; set; }
        public List<MonthlyLedger>? MonthlyLedgers { get; set; }
        private DateTime _openingDate { get; set; } = new DateTime(2022, 1, 1);




        //CTOR
        public PetShop() {
            Transactions = new List<Transaction>();
            Foods = new List<PetFood>();
            Pets = new List<Pet>();
            Employees = new List<Employee>();
            Customers = new List<Customer>();
        }

        public PetShop(string name, List<PetFood> foods, List<Pet>? pets, List<Employee>? employees, List<Customer>? customers, List<Transaction> transactions) {
            Name = name;

            Foods = foods;
            Pets = pets;
            Employees = employees;
            Customers = customers;
            Transactions = transactions;
            FindMonthlyLedger(Transactions, Foods, Pets, Employees);
        }





        public List<PetFood> GetPetFood() {

            decimal currentStock = 0;
            foreach (var food in Foods) {
                food.CurrentStock = currentStock + food.Qty;
                foreach (var transaction in Transactions) {
                    var foodID = transaction.PetFoodID;
                    if (food.ID == foodID) {
                        currentStock -= transaction.PetFoodQty;
                    }
                }
            }
            return Foods;
        }


        //METHOD DELETE FUNCTION
        public void DeleteTransaction(Transaction input) { //or guid??

            foreach (var trans in Transactions) {
                if (trans.ID == input.ID) {
                    if (trans.PetID == Guid.Empty)
                        //EnablePet(trans.PetID);  //set disable pet??????????
                        UpdatePetFoodQty(trans.PetFoodID, trans.PetFoodQty);
                    Transactions.Remove(trans);
                    break;
                }

            }
        }

        public void UpdatePetFoodQty(Guid? input, decimal foodupdate) {
            foreach (var food in Foods) {
                if (food.ID == input) {
                    food.Qty += foodupdate;
                }
            }

        }

        //DELETE PET FOOD
        public void DeletePetFood(Guid? input) {
            foreach (var food in Foods) {
                if (food.ID == input) {
                    Foods.Remove(food);
                }
            }
        }

        //DELETE PET
        public void DeletePet(Guid? input) {
            foreach (var pet in Pets) {
                if (pet.ID == input) {
                    Pets.Remove(pet);
                }
            }
        }

        //MONTHLY LEDGER
        public void FindMonthlyLedger(List<Transaction> transactions, List<PetFood> foods, List<Pet> pets, List<Employee> employees) {

            List<MonthlyLedger> monthlyLedgers = new List<MonthlyLedger>();
            DateTime dateTimeNow = DateTime.Now;
            DateTime currentLedger = _openingDate;

            decimal totalSalaries = CalcEmployeesSalary(employees);



            int totalMonths = ((dateTimeNow.Year - _openingDate.Year) * 12) + dateTimeNow.Month - _openingDate.Month;
            MonthlyLedger ml = new MonthlyLedger();

            for (var i = 0; i < totalMonths+1; i++) {


                ml = new MonthlyLedger(transactions, foods, pets, employees, totalSalaries, currentLedger);
                monthlyLedgers.Add(ml);
                currentLedger = currentLedger.AddMonths(1);

            }
            MonthlyLedgers = monthlyLedgers;
        }

        decimal CalcEmployeesSalary(List<Employee> employees) {
            decimal totalSalaries = 0;
            foreach (var employee in employees) {
                totalSalaries += employee.SalaryPerMonth;
            }
            return totalSalaries;
        }






    }
}
