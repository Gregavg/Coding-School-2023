using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_16.Model {
    public class MonthlyLedger {

        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? Income { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? Total { get; set; }

        public MonthlyLedger() {
        }

        public MonthlyLedger(List<Transaction> transactions, List<PetFood> foods, List<Pet> pets, List<Employee> employees, decimal totalSalaries, DateTime datetime) {
            decimal? rent = 2000;
            Expenses = rent;
            Income = 0;
            Total = 0;
            Expenses = totalSalaries;
            Month = datetime.Month;
            Year = datetime.Year;

            ExpenseCalculatePetFoodCost(foods);
            ExpenseCalculatePets(pets);
            IncomeCalculateTransactions(transactions);
            Total = Income - Expenses;

        }
        public void ExpenseCalculatePetFoodCost(List<PetFood> foods) {
            //foreach (var food in foods) {
            //    foreach (var petFoodTransaction in food.PetFoodTransactions) {
            //        if (petFoodTransaction.Date.Month == Month) {
            //            Expenses += petFoodTransaction.Qty * food.Cost;
            //        }
            //    }
            //}
        }

        public void ExpenseCalculatePets(List<Pet> pets) {
            foreach (var pet in pets) {
                if (pet.Bought.Month == Month) {
                    Expenses += pet.Cost;
                }
            }
        }

        public void IncomeCalculateTransactions(List<Transaction> transactions) {
            foreach (var transaction in transactions) {
                if (transaction.Date.Month == Month) {
                    Income += transaction.TotalPrice;
                }
            }
        }








    }
}
