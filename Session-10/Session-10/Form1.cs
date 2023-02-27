using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Session_10 {
    public partial class Form1 : Form {

        public University university;
        public List<GradeCombine> gradeCombine { get; set; }
        public List<Professor> Professors { get; set; }
        public Serializer serial { get; set; }
        public List<ScheduleCombine> scheduleCombine { get; set; }


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            Loader();


        }

        private void Loader() {
            SetControlProperties();
            CreateUniversity();
            PopulateStudents();
            PopulateProfessors();
            PopulateCourses();
            PopulateGrades();
            PopulateSchedules();
        }


        //POPULATION
        private void CreateUniversity() {

            university = new University() {
                Name = "Hellenic Open University",
                YearsInService = 1999
            };
            labelUni.Text = university.Name;

        }
        private void PopulateStudents() {


            Student student1 = new Student() {
                FirstName = "Dimitris",
                LastName = "Raptodimos",
                Gender = Student.GenderEnum.Male,
                Age = 40,
                Undergraduate = false,
            };
            university.AddStudent(student1);

            Student student2 = new Student() {
                FirstName = "Fotis",
                LastName = "Chrysoulas",
                Gender = Student.GenderEnum.Male,
                Age = 44,
                Undergraduate = true,
            };
            university.AddStudent(student2);


            bsStudents.DataSource = university.Students;

        }
        private void PopulateCourses() {

            Course course = new Course() {
                Subject = "Maths"
            };
            university.AddCourse(course);

            course = new Course() {
                Subject = "Computer Science"
            };

            university.AddCourse(course);
            bsCourses.DataSource = university.Courses;
        }
        private void PopulateGrades() {

            gradeCombine = new List<GradeCombine>();
            Grade grade = new Grade() {
                StudentID = university.Students[0].ID,
                CourseID = university.Courses[0].ID,
                GradeValue = 10
            };
            university.AddGrade(grade);

            grade = new Grade() {
                StudentID = university.Students[0].ID,
                CourseID = university.Courses[1].ID,
                GradeValue = 9
            };
            university.AddGrade(grade);

            grade = new Grade() {
                StudentID = university.Students[1].ID,
                CourseID = university.Courses[0].ID,
                GradeValue = 8
            };
            university.AddGrade(grade);

            grade = new Grade() {
                StudentID = university.Students[1].ID,
                CourseID = university.Courses[1].ID,
                GradeValue = 7
            };
            university.AddGrade(grade);


            SetGradeCombiner();


        }
        private void PopulateProfessors() {

            Professors = new List<Professor>();
            Professor professor1 = new Professor() {
                FirstName = "Grigoris",
                LastName = "Avgenikos",
                Gender = Professor.GenderEnum.Male,
                Age = 32,
            };
            Professors.Add(professor1);

            professor1 = new Professor() {
                FirstName = "Konstantinos",
                LastName = "Ioannou",
                Gender = Professor.GenderEnum.Male,
                Age = 28,
            };
            Professors.Add(professor1);
        }
        private void PopulateSchedules() {


            Schedule schedule = new Schedule() {
                CourseID = university.Courses[0].ID,
                ProfessorID = Professors[0].ID
            };
            university.AddSchedule(schedule);
            schedule = new Schedule() {
                CourseID = university.Courses[1].ID,
                ProfessorID = Professors[1].ID
            };
            university.AddSchedule(schedule);

            SetScheduleCombiner();
        }

        //COMBINERS
        private void SetGradeCombiner() {

            List<GradeCombine> gradeCombines = new List<GradeCombine>();
            foreach (var g in university.Grades) {

                var firstName = "";
                var lastName = "";
                var subject = "";
                var gradeValue = 0;

                foreach (var z in university.Students) {
                    if (z.ID == g.StudentID) {
                        firstName = z.FirstName;
                        lastName = z.LastName;
                    }
                }
                foreach (var z in university.Courses) {
                    if (z.ID == g.CourseID) {
                        subject = z.Subject;
                    }
                    gradeValue = g.GradeValue;

                }
                gradeCombines.Add(new GradeCombine(firstName, lastName, subject, gradeValue));
            }

            bsGrades.DataSource = gradeCombines;

        }
        private void SetScheduleCombiner() {

            List<ScheduleCombine> scheduleCombines = new List<ScheduleCombine>();

            foreach (var g in university.ScheduledCourses) {

                var firstName = "";
                var lastName = "";
                var subject = "";
                DateTime calendar = new DateTime();

                foreach (var z in Professors) {
                    if (z.ID == g.ProfessorID) {
                        firstName = z.FirstName;
                        lastName = z.LastName;
                    }
                }
                foreach (var z in university.Courses) {
                    if (z.ID == g.CourseID) {
                        subject = z.Subject;
                    }
                    calendar = g.Calendar;

                }
                scheduleCombines.Add(new ScheduleCombine(firstName, lastName, calendar, subject));
            }
            bsSchedule.DataSource = scheduleCombines;
        }

        //CONTROL PROPERTIES
        private void SetControlProperties() {

            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = bsStudents;

            grvCourses.AutoGenerateColumns = false;
            grvCourses.DataSource = bsCourses;

            grvGrades.AutoGenerateColumns = false;
            grvGrades.DataSource = bsGrades;

            grvScheldule.AutoGenerateColumns = false;
            grvScheldule.DataSource = bsSchedule;

            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Student.GenderEnum.Male);
            colGender.Items.Add(Student.GenderEnum.Female);
            colGender.Items.Add(Student.GenderEnum.Other);

            grvStudents.CellContentClick += GrvStudents_CellContentClick;

        }

        //STUDENT COMBOBOX
        private void GrvStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e) {

            var grv = (DataGridView)sender;


            DataGridViewButtonColumn col = grv.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (col != null && col.Name == "colShowID" && e.RowIndex >= 0) {
                Student student = grv.CurrentRow.DataBoundItem as Student;
                MessageBox.Show($"The ID of student {student.LastName} {student.FirstName} is {student.ID}");
            }
        }

        //CLEAR
        private void buttonClear_Click(object sender, EventArgs e) {
            ClearForm();
        }
        private void ClearForm() {

            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = null;

            grvCourses.AutoGenerateColumns = false;
            grvCourses.DataSource = null;

            grvGrades.AutoGenerateColumns = false;
            grvGrades.DataSource = null;

            grvScheldule.AutoGenerateColumns = false;
            grvScheldule.DataSource = null;

            bsCourses.DataSource = null;
            bsStudents.DataSource = null;
            bsGrades.DataSource = null;
            bsSchedule.DataSource = null;

        }

        //SERIALIZER
        private void btnRefresh_Click(object sender, EventArgs e) {
            Serializer serial = new Serializer();

            serial.SerializeToFile(university, "University.json");
            serial.SerializeToFile(Professors, "Professors.json");

        }

        private void button1_Click(object sender, EventArgs e) {
            Serializer serial = new Serializer();

            university = new University();
            Professors = new List<Professor>();

            university = serial.DeserializeFromFile<University>("University.json");


            Professors = serial.DeserializeFromFile<List<Professor>>("Professors.json");

            SetNewSources();
            SetControlProperties();

        }

        private void SetNewSources() {

            if (university.ScheduledCourses != null && university.Courses != null && university.Students != null && university.Grades != null) {
                bsStudents.DataSource = university.Students;
                bsCourses.DataSource = university.Courses;
                SetGradeCombiner();
                SetScheduleCombiner();

            } else if (university.ScheduledCourses != null && university.Courses != null && university.Students != null) {
                bsStudents.DataSource = university.Students;
                bsCourses.DataSource = university.Courses;
                SetScheduleCombiner();

            } else if (university.Students != null) {
                bsStudents.DataSource = university.Students;
            }


        }

    }
}
