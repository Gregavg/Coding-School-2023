using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.Customer
{
    public class CustomerDetailsDto
    {

        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Name { get; set; } = null!;
        [MaxLength(100, ErrorMessage = "Type less than 100 characters")]
        public string Surname { get; set; } = null!;
        [MaxLength(15, ErrorMessage = "Type less than 15 characters")]
        public string Phone { get; set; } = null!;
        [MaxLength(15, ErrorMessage = "Type less than 15 characters")]
        public string Tin { get; set; } = null!;

        public List<Session_23.Model.Transaction> Transactions { get; set; } = new List<Session_23.Model.Transaction>();
    }
}
