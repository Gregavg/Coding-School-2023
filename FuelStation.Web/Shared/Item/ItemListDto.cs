using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Web.Shared {
    public class ItemListDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; } 
        public decimal Cost { get; set; }
        public ItemType ItemType { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
