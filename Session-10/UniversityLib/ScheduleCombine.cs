using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_10 {
    public class ScheduleCombine {
        //properties
        public Guid ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Subject { get; set; }
        public DateTime Calendar { get; set; }


        //constructors
        public ScheduleCombine() {

        }

        public ScheduleCombine(string firstName, string lastname, DateTime calendar, string subject) {

            FirstName = firstName;
            LastName = lastname;
            Subject = subject;
            Calendar = calendar;
        }

        //methods

    }
}
