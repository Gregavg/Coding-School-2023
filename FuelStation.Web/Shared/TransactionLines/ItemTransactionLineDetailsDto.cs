using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared {
    public class ItemTransactionLineDetailsDto {


        public int Id { get; set; }

        public int ItemId { get; set; }

        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal ItemPrice { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal NetValue { get; set; }

        public decimal DiscountPercentage { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal DiscountValue { get; set; }
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }
    }
}
