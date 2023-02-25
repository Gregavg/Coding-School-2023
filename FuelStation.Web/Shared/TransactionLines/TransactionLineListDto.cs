using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared {
    public class TransactionLineListDto {


        public int Id { get; set; }


        public int Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal TotalValue { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public ItemListDto Item { get; set; } = null!;
    }
}
