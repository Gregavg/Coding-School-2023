namespace FuelStation.Model {
    public class TransactionLine {

        // Properties
        public int Id { get; set; }

        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        // Constructors
        public TransactionLine(
            int quantity, 
            decimal ItemPrice, 
            decimal netValue,
            decimal discountPercentage, 
            decimal discountValue, 
            decimal totalValue, 
            int ItemId) {

            this.Quantity = quantity;
            this.NetValue = netValue;
            this.DiscountPercentage = discountPercentage;
            this.DiscountValue = discountValue;
            this.TotalValue = totalValue;
            this.ItemId = ItemId;
            this.ItemPrice = ItemPrice;

        }


    }
}