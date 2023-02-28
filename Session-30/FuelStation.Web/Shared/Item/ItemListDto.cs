using FuelStation.Model;
using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared {
    public class ItemListDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;

        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal Cost { get; set; }
        public ItemType ItemType { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
