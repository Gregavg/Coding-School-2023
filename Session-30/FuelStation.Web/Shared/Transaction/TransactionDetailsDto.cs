using FuelStation.Model.Enums;
using FuelStation.Model;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared {
    public class TransactionDetailsDto {
        // Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer CustomerListDto { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public List<TransactionLineListDto> TransactionLines { get; set; } = new List<TransactionLineListDto>();
    }
}
