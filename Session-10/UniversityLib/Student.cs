using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10 {

    public class Student : Person {

        //properties

        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }
        public bool Undergraduate { get; set; }
        public Guid UniversityID { get; set; }
        




        //constructors
        public Student() { 
        
        }



        //methods

        public void Attend(Course course, DateTime datetime) {

        }

        public void WriteExam(Course course, DateTime datetime) {

        }
    }
}
