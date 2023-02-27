using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_06 {

    public class Professor : Person{
        //properties
        public string? Rank { get; set; }
        public Course[]? Courses { get; set; }

        //constructors
        public Professor() {

        }

        public Professor(Guid id) : base(id) {

        }

        public Professor(Guid id, string name) : base(id, name) {

        }

        public Professor(Guid id, string name, int age) : base (id, name, age) {

        }

        public Professor(Guid id, string name, int age, string rank) : base(id, name, age) {
            Rank = rank;
        }

        public Professor(Guid id, string name, int age, string rank, Course[] courses) : base(id, name, age) {
            Rank = rank;
            Courses = courses;
        }


        //methods

        public void Teach(Course course, DateTime datetime) {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grade) {

        }

        //GetName() new method
        public new string GetName() {

            return String.Format("Dr. {0}", Name);
        }


    }
}
