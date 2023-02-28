using FuelStation.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FuelStation.Web.Shared {
    public class ItemDetailsDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal Cost { get; set; }

        public ItemType ItemType { get; set; }
        //RELATIONS

        public List<ItemTransactionLineDetailsDto> TransactionLines { get; set; } = new();

    }
}
