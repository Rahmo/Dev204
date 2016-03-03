using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dev204
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mod5&6&7
            Student Student1 = new Student();
            Student1.FirstName = "Rahmo";
            Student1.LastName = "Alzahrani ";
            Student1.AddressLine = "CHi";
            Student1.Grades.Push("A");
            Student1.Grades.Push("B");
            Student1.Grades.Push("C");
            Student1.Grades.Push("D");
            Student1.Grades.Push("E");
            Student Student2 = new Student();
            Student2.FirstName = "John";
            Student2.LastName = "Alzahrani ";
            Student2.AddressLine = "CHi";
            Student2.Grades.Push("A");
            Student2.Grades.Push("B");
            Student2.Grades.Push("C");
            Student2.Grades.Push("D");
            Student2.Grades.Push("E");
            Student Student3 = new Student();
            Student3.FirstName = "Samy";
            Student3.LastName = "Alzahrani ";
            Student3.AddressLine = "CHi";
            Student3.Grades.Push("A");
            Student3.Grades.Push("B");
            Student3.Grades.Push("C");
            Student3.Grades.Push("D");
            Student3.Grades.Push("E");
            Teacher Teacher1 = new Teacher();
            Teacher1.FirstName = "Todd";
            Course course1 = new Course();
            course1.CourseName = "Programming with C#";
            course1.Credits = 4;

            course1._students.Add(Student1);
            course1._students.Add(Student2);
            course1._students.Add(Student3);
            course1.teacher = Teacher1;

            Degree degree1 = new Degree();
            degree1.DegreeName = " The Bachelor of Science degree ";
            degree1.course = course1;

            Uprogram program1 = new Uprogram();
            program1.ProgramName = " Information Technology";
            program1.Degree = degree1;



            Console.WriteLine(" The  " + program1.ProgramName + " Program contains" + program1.Degree.DegreeName + " \n " +
                              " " + program1.Degree.DegreeName + " Contains the course " + program1.Degree.course.CourseName + " \n"
                              + " the " + program1.Degree.course.CourseName + " course contains " + Student.NoOfStudentsEnrolled + " Students Enrolled !");
            //This method list the first name and the last name of the student .
            course1.ListStudents();
            #endregion
            Console.ReadLine(); // This line to keep the consol running to veiw the output.
        }
    }
}
