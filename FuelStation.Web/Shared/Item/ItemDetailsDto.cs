using FuelStation.Model.Enums;
using System;
using System.Linq;

namespace FuelStation.Web.Shared {
    public class ItemDetailsDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public ItemType ItemType { get; set; }
        //RELATIONS

        public List<ItemTransactionLineDetailsDto> TransactionLines { get; set; } = new();

    }
}
