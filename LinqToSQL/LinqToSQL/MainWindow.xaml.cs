using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSQLDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.DaniilDBConnectionString"].ConnectionString;
            dataContext = new LinqToSQLDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfTonie();
            //GetToniesLectures();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransgenders();
            //GetAllLecturesFromBeijingTech();
            //GetAllLecturesFromBeijingTech();
            //UpdateTonie();
            DeleteJame();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("Delete from University");


            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University beijingTech = new University();
            beijingTech.Name = "Beijing Tech";
            dataContext.Universities.InsertOnSubmit(beijingTech);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities.ToList();
        }

        public void InsertStudents()
        {
            dataContext.ExecuteCommand("Delete from Student");
            
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University beijingTech = dataContext.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tonie", Gender = "male", University = yale });
            students.Add(new Student { Name = "Leyla", Gender = "female", University = beijingTech });
            students.Add(new Student { Name = "Jame", Gender = "trans-gender", University = beijingTech });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students.ToList();
        }

        public void InsertLectures()
        {
            dataContext.ExecuteCommand("Delete from Lecture");

            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures.ToList();
        }

        public void InsertStudentLectureAssociations()
        {
            dataContext.ExecuteCommand("Delete from StudentLecture");

            Student carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));
            Student leyla = dataContext.Students.First(st => st.Name.Equals("Leyla"));
            Student jame = dataContext.Students.First(st => st.Name.Equals("Jame"));

            Lecture math = dataContext.Lectures.First(l => l.Name.Equals("Math"));
            Lecture history = dataContext.Lectures.First(l => l.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = carla, Lecture = math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = tonie, Lecture = history });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = tonie, Lecture = math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = leyla, Lecture = math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = jame, Lecture = history });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures.ToList();
        }

        public void GetUniversityOfTonie()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Tonie"));

            University TonisUniversity = Toni.University;

            List<University> universities = new List<University>();
            universities.Add(TonisUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetToniesLectures()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Tonie"));

            var toniesLectures = from sl in Toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = toniesLectures;

        }

        public void GetAllStudentsFromYale()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));

            var yalesStudents = from st in yale.Students select st;

            MainDataGrid.ItemsSource = yalesStudents;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var universitiesWithTransgenders = from student in dataContext.Students
                                               join university in dataContext.Universities
                                               on student.University equals university
                                               where student.Gender == "trans-gender"
                                               select university;

            MainDataGrid.ItemsSource = universitiesWithTransgenders;
        }

        public void GetAllLecturesFromBeijingTech()
        {
            var lecturesFromBeijingTech = from sl in dataContext.StudentLectures
                                          join student in dataContext.Students on
                                          sl.StudentId equals student.Id
                                          where student.University.Name == "Beijing Tech"
                                          select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromBeijingTech;
        }

        public void UpdateTonie()
        {
            Student Tonie = dataContext.Students.FirstOrDefault(st => st.Name == "Tonie");

            Tonie.Name = "Antonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students.ToList();
        }

        public void DeleteJame()
        {
            Student Jame = dataContext.Students.FirstOrDefault(st => st.Name == "Jame");

            dataContext.Students.DeleteOnSubmit(Jame);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students.ToList();
        }
    }
}
