using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared {
    public class TransactionListDto
    {
        // Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public CustomerEmployeeDetailsDto? Employee { get; set; } = null!;

        public List<TransactionLineEditDto> TransactionLines { get; set; } = new ();
    }
}
