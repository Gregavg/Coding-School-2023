using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class Schedule {
        //properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }


        //constructors
        public Schedule() {

        }

        public Schedule(Guid id) {
            ID = id;
        }

        public Schedule(Guid id, Guid courseID) {
            ID = id;
            CourseID = courseID;
        }

        public Schedule(Guid id, Guid courseID, Guid professorID) {
            ID = id;
            CourseID = courseID;
            ProfessorID = professorID;
        }

        public Schedule(Guid id, Guid courseID, Guid professorID, DateTime calendar) {
            ID = id;
            CourseID = courseID;
            ProfessorID = professorID;
            Calendar = calendar;
        }

        //methods


    }
}
