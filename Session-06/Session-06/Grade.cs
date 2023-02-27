using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_06 {
    public class Grade {
        //properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }


        //constructors
        public Grade() {
        }

        public Grade(Guid id) {
            ID = id;
        }

        public Grade(Guid id, Guid studentID) {
            ID = id;
            StudentID = studentID;
        }

        public Grade(Guid id, Guid studentID, Guid courseID) {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
        }

        public Grade(Guid id, Guid studentID, Guid courseID, int gradeValue) {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
            GradeValue = gradeValue;
        }

        //methods

    }
}
