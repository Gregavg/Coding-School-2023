using FuelStation.Model.Enums;
using FuelStation.Model;

namespace FuelStation.Web.Shared {
    public class TransactionDetailsDto {
        // Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
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
