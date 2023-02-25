

using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared {
    public class CustomerEmployeeDetailsDto
    {
        public int Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
