using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_10 {
    public class Grade {
        //properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }


        //constructors
        public Grade() {
            ID= Guid.NewGuid();
        }

        public Grade(Guid id) {
            ID = id;
        }

        public Grade(Guid studentID, Guid courseID) {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
        }

        public Grade(Guid studentID, Guid courseID, int gradeValue) {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            GradeValue = gradeValue;
        }

        //methods

    }
}
