using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {//Employee(ID, Name, Surname, EmployeeType (enum), SallaryPerMonth)
    public class User {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Transaction> Transactions { get; set; }

    }
}



