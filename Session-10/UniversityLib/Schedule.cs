using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10 {
    public class Schedule {
        //properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }


        //constructors
        public Schedule() {
            ID = Guid.NewGuid();
            Calendar = DateTime.Now;

        }

        

        //methods


    }
}
