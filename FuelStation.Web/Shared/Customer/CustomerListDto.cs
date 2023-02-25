using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared {
    public class CustomerListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string CardNumber { get; set; } = null!;

        public List<TransactionListDto> Transactions { get; set; } = new();
    }
}
