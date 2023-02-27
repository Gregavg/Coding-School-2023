using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared {
    public class TransactionLineEditDto {


        public int Id { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "You must type a discount!")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, 99999999.99, ErrorMessage = "Price range is 0 to 99999999.99!")]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal ItemPrice { get; set; }

 

        [Required]
        [Range(0, 99999999.99)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal NetValue { get; set; }

        [Required]
        [Range(0, 100.00, ErrorMessage = "Range 0% to 100%!")]
        public decimal DiscountPercentage { get; set; }

        [Required]
        [Range(0, 99999999.99)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal DiscountValue { get; set; }


        [Required]
        [Range(0, 99999999.99)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public ItemListDto? Item { get; set; } = null!;
    }
}
