using Session_23.Model;
using Session_23.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Session_23.Model {
    public class MonthlyLedger {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        private const decimal _rent = 2000; 
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public MonthlyLedger() {
        }

        public MonthlyLedger(DateTime datetime) {
            Year = datetime.Year;
            Month = datetime.Month;
        }

        public void AddRent() {
            Expenses += _rent;
        }
    }
}
