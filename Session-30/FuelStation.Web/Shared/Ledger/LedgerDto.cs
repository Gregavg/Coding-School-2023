using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared {
    public class LedgerDto {

        // Properties
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public LedgerDto() {
        }

        public LedgerDto(DateTime datetime) {
            Year = datetime.Year;
            Month = datetime.Month;
        }

        public void AddExpense(decimal expense) {
            Expenses += expense;
        }

        public void AddIncome(decimal income) {
            Income += income;
        }

        public void CalcTotal() {
            Total = Income - Expenses;
        }
         
    }
}
