using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Semester>6</Semester>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Semester>1</Semester>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                        <Semester>3</Semester>
                    </Student>
                    <Student>
                        <Name>Frank</Name>
                        <Age>25</Age>
                        <University>Beijing Tech</University>
                        <Semester>10</Semester>
                    </Student>
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach(var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} in {3} Semester", student.Name, student.Age, student.University, student.Semester);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} in {3} Semester", student.Name, student.Age, student.University, student.Semester);
            }


            Console.ReadLine();

            /*
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts
                                          orderby i
                                          select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            

            IEnumerable<int> reversedSortedInts = from i in someInts
                                                  orderby i descending
                                                  select i;

            foreach(int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            



            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();

            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);

                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value");
            }

            Console.ReadKey();


            
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddNumbers(numbers);
            Console.ReadKey();
            */

        }

        class UniversityManager
        {
            public List<University> universities;
            public List<Student> students;

            public UniversityManager()
            {
                universities = new List<University>();
                students = new List<Student>();

                universities.Add(new University { Id = 1, Name = "Yale" });
                universities.Add(new University { Id = 2, Name = "Beijing Tech" });

                students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
                students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
                students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
                students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
                students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
                students.Add(new Student { Id = 2, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            }

            public void MaleStudents()
            {
                IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
                Console.WriteLine("Male- students: ");

                foreach(Student student in maleStudents)
                {
                    student.Print();
                }
            }

            public void FemaleStudents()
            {
                IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
                Console.WriteLine("Female- students: ");

                foreach(Student student in femaleStudents)
                {
                    student.Print();
                }
            }

            public void SortStudentsByAge()
            {
                var sortedStudents = from student in students orderby student.Age select student;
                Console.WriteLine("Sorted students by age");

                foreach (Student student in sortedStudents)
                {
                    student.Print();
                }
            }

            public void AllStudentsFromBeijingTech()
            {
                IEnumerable<Student> bjtStudents = from student in students join university in universities
                                                   on student.UniversityId equals university.Id
                                                   where university.Name == "Beijing Tech"
                                                   select student;
                Console.WriteLine("Students from BeijingTech: ");

                foreach (Student student in bjtStudents)
                {
                    student.Print();
                }
            }

            public void AllStudentsFromThatUni(int Id)
            {
                IEnumerable<Student> myStudents = from student in students join university in universities
                                                   on student.UniversityId equals university.Id
                                                   where university.Id == Id
                                                   select student;
                Console.WriteLine("Students from that uni {0}: ", Id);

                foreach (Student student in myStudents)
                {
                    student.Print();
                }
            }

            public void StudentAndUniversityNameCollection()
            {
                var newCollection = from student in students
                                    join university in universities
                                    on student.UniversityId equals university.Id
                                    orderby student.Name
                                    select new { StudentName = student.Name, UniversityName = university.Name };
                Console.WriteLine("New collection: ");

                foreach(var col in newCollection)
                {
                    Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
                }
            }
        }

        class University
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Print()
            {
                Console.WriteLine("University {0} with id {1}", Name, Id);
            }
        }

        class Student
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Gender { get; set; }

            public int Age { get; set; }

            //Foreign Key
            public int UniversityId { get; set; }

            public void Print()
            {
                Console.WriteLine("Student {0} with Id {1}, gender {2}, age {3}, from university with the id {4}", Name, Id, Gender, Age, UniversityId);
            }
        }

        /*
        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers: ");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
        */
    }
}
