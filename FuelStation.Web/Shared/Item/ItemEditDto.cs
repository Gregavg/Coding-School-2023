
using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared {
    public class ItemEditDto {

        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Type less than 20 characters")]
        public string Code { get; set; } = null!;

        [Required]
        [MaxLength(150, ErrorMessage = "Type less than 150 characters")]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0, 99999999.99, ErrorMessage = "The range is from 0 to 99999999.99!")]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 99999999.99, ErrorMessage = "The range is from 0 to 99999999.99!")]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal Cost { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "You must choose a type!")]
        public ItemType ItemType { get; set; }



    }
}
