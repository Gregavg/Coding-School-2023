using FuelStation.Model.Enums;

namespace FuelStation.Model {
    public class Item {

        // Properties
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }


        // Constructors
        public Item(string code, string description, decimal price, decimal cost, ItemType itemType) {
            Code = code;
            Description = description;
            Price = price;
            Cost = cost;
            ItemType = itemType;

            TransactionLines = new List<TransactionLine>();
        }


        // Relations

        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}