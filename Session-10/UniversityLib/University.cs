using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10 {
    public class University : Institute {
        //properties
        public List<Student>? Students { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Grade>? Grades { get; set; }
        public List<Schedule>? ScheduledCourses { get; set; }

        //added properties
        public string Region { get; set; }



        //constructors
        public University() {

            ID = Guid.NewGuid();
            Students = new List<Student>();
            Courses= new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();    
        }

        public University(Guid id){
            ID= id;
        }


        //methods
        public void AddStudent(Student student) {
            Students.Add(student);

        }
        public void AddCourse(Course course) {
            Courses.Add(course);

        }
        public void AddGrade(Grade grade) {
            Grades.Add(grade);

        }
        public void AddSchedule(Schedule schedule) {
            ScheduledCourses.Add(schedule);

        }


        public void GetStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime datetime) {

        }
    }
}
