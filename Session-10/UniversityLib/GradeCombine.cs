using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_10 {
    public class GradeCombine {
        //properties
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Subject { get; set; }
        public int? GradeValue { get; set; }


        //constructors
        public GradeCombine() {
            
        }

        public GradeCombine(string firstName, string lastname, string subject,int gradeValue) {
            FirstName = firstName;
            LastName = lastname;
            Subject = subject;
            GradeValue = gradeValue;
        }

        //methods

    }
}
