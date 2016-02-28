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

            #region Mod1

            //Mod1
            string FirstName = "Rahmo";
            string LastName = "Alzahrani";
            DateTime Birthdate = new DateTime(
                1987, 06, 28);
            string AddressLine1 = "5445 N Sheridan";
            string AddressLine2 = "Edgewater";
            string City = "Chicago";
            string State = "IL";
            string Province = "East";
            int Zip_Postal = 60640;
            string Country = "USA";

            Console.WriteLine("First Name :" + FirstName + "\n" +
                              "Last Name :" + LastName + "\n" +
                              "Birthdate :" + Birthdate + "\n" +
                              "Address Line 1 :" + AddressLine1 + "\n" +
                              "Address Line 2 :" + AddressLine2 + "\n" +
                              "City :" + City + "\n" +
                              "State :" + State + "\n" +
                              "Province :" + Province + "\n" +
                              "Zip'\'Postal :" + Zip_Postal + "\n" +
                              "Country :" + Country + "\n"


                );

            #endregion

            #region Mod2


            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i%2 == 0)
                    {
                        Console.Write("XO");
                    }
                    else
                    {
                        Console.Write("OX");
                    }
                }
                Console.Write("\n");
            }

            #endregion

            #region Mod3

            GetStudentInformation();
            GetDegreeInformation();
            GetProgramInformation();
            GetTeacherInformation();
            GetCourseInformation();

            //calling the method to throw an exception. 
            //  ValidateStudent();

            #endregion

            //#region Mod4
            //// The index starts from 0 
            //Student[] structStudents = new Student[4];
            //structStudents[0].FirstName = "Rahmo";
            //structStudents[0].Country = "USA";
            //structStudents[0].LastName = "Alzahrani";
            //structStudents[2].FirstName = "John";
            //structStudents[2].Country = "UK";

            //Console.WriteLine("The First assigned student information : \n First Name " + structStudents[0].FirstName
            //    + "\n Last Name : " + structStudents[0].LastName + " \n The Student country is from : " + structStudents[0].Country +
            //    "\n ****** \n " +
            //    "The Second assigned student information : \n First Name " + structStudents[2].FirstName
            //    + " \n The Student country is from : " + structStudents[2].Country
            //    );

            //#endregion

            #region Mod5
            Student Student1 = new Student();
            Student1.FirstName = "Rahmo";
            Student1.LastName = "Alzahrani ";
            Student1.AddressLine = "CHi"; 
            Student Student2 = new Student();
            Student2.FirstName = "John";
            Student2.LastName = "Alzahrani ";
            Student2.AddressLine = "CHi";

            Student Student3 = new Student();
            Student3.FirstName = "Samy";
            Student3.LastName = "Alzahrani ";
            Student3.AddressLine = "CHi";
            Teacher Teacher1 = new Teacher();
            Teacher1.FirstName = "Todd"; 
            Course course1 = new Course();
            course1.CourseName = "Programming with C#";
            course1.Credits = 4;
            course1._students = new Student[3];
            course1._students[0] = Student1;
            course1._students[1] = Student2;
            course1._students[2] = Student3;
            course1.teacher = Teacher1; 

            Degree degree1 = new Degree();
            degree1.DegreeName = " The Bachelor of Science degree ";
            degree1.course = course1;
  
            Uprogram program1 = new Uprogram();
            program1.ProgramName = " Information Technology";
            program1.Degree = degree1; 



            Console.WriteLine(" The  " + program1.ProgramName + " Program contains" + program1.Degree.DegreeName +" \n " +
                              " "+ program1.Degree.DegreeName + " Contains the course " + program1.Degree.course.CourseName +" \n" 
                              +" the " + program1.Degree.course.CourseName +" course contains " + Student.NoOfStudentsEnrolled +" Students Enrolled !");
            #endregion

            Console.ReadLine(); // This line to keep the consol running to veiw the output.



        }

        //#region HelpingMethodsMod4
        //public struct Student
        //{
        //    // This is the student constructor.
        //    public Student(string firstName, string lastName, string birthdate, string country)
        //    {
        //        this.FirstName = firstName;
        //        this.LastName = lastName;
        //        this.Birthdate = birthdate;
        //        this.Country = country;
        //    }
        //    // These statements declare the struct fields
        //    public string FirstName;
        //    public string LastName;
        //    public string Birthdate;
        //    public string Country;
        //}
        //public struct Teacher
        //{
        //    // This is the student constructor.
        //    public Teacher(string firstName, string lastName, string country)
        //    {
        //        this.FirstName = firstName;
        //        this.LastName = lastName;
        //        this.Country = country;
        //    }
        //    // These statements declare the struct fields
        //    public string FirstName;
        //    public string LastName;
        //    public string Country;
        //}
        //public struct program
        //{
        //    // This is the student constructor.
        //    public program(string programName, string departmentHead, string degrees)
        //    {
        //        this.ProgramName = programName;
        //        this.DepartmentHead = departmentHead;
        //        this.Degrees = degrees;

        //    }
        //    // These statements declare the struct fields
        //    public string ProgramName;
        //    public string DepartmentHead;
        //    public string Degrees;

        //}
        //public struct course
        //{
        //    // This is the student constructor.
        //    public course(string courseName, string courseTeacher, string creditsrequired)
        //    {
        //        this.CourseName = courseName;
        //        this.CourseTeacher = courseTeacher;
        //        this.Creditsrequired = creditsrequired;

        //    }
        //    // These statements declare the struct fields
        //    public string CourseName;
        //    public string CourseTeacher;
        //    public string Creditsrequired;

        //}
        //#endregion

        #region Mod3HelpingMethods


        private static void ValidateStudent()
        {
            //an exception will be thrown
            throw new NotImplementedException();
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the student's Birthdate: ");
            string Birthdate = Console.ReadLine();

            Console.WriteLine("Enter the student's Country");
            string Country = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, Birthdate);

        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the Teacher's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the Teacher's last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the Teacher's Country");
            string Country = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, Country);

        }
        static void PrintTeacherDetails(string first, string last, string Country)
        {
            Console.WriteLine("{0} {1} is from: {2}", first, last, Country);
        }

        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the  Program's  name: ");
            string ProgramName = Console.ReadLine();

            Console.WriteLine("Enter the Department Head");
            string DepartmentHead = Console.ReadLine();

            Console.WriteLine("Enter the Degrees: ");
            string Degrees = Console.ReadLine();
            PrinProgramDetails(ProgramName, DepartmentHead, Degrees);

        }
        static void PrinProgramDetails(string name, string head, string degree)
        {
            Console.WriteLine("the program {0} has the head {1} with a degree in {2}", name, head, degree);
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the  Degree's  name: ");
            string DegreeName = Console.ReadLine();

            Console.WriteLine("Enter the Credits required");
            string Creditsrequired = Console.ReadLine();
            PrintDegreeDetails(DegreeName, Creditsrequired.ToString());

        }
        static void PrintDegreeDetails(string name, string Credits)
        {
            Console.WriteLine("The degree name is {0} with  {1} credits to finsih,.", name, Credits);
        }
        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the  Course's  name: ");
            string CourseName = Console.ReadLine();

            Console.WriteLine("Enter the  Course's  Teacher: ");
            string CourseTeacher = Console.ReadLine();

            Console.WriteLine("Enter the course Credits required");
            string Creditsrequired = Console.ReadLine();
            PrintCourseDetails(CourseName, CourseTeacher, Creditsrequired.ToString());

        }

        static void PrintCourseDetails(string name, string courseTeacher, string CreditsReq)
        {
            Console.WriteLine("THe course {0} has the teacher {1} with credits of: {2}", name, courseTeacher, CreditsReq);
        }
        #endregion

        #region HelpingMethodsMod5

      public class Student
      {
          public static int NoOfStudentsEnrolled;
            
          public Student()
          {
              NoOfStudentsEnrolled++;
          }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string AddressLine { get; set; }
        }
        public class Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string AddressLine { get; set; }
        }

        public class Course 
        {
            public string CourseName { get; set; }
            public int Credits { get; set; }
            public Teacher teacher { get; set; }
            public Student[] _students { get; set; }
        }

        public class Degree
        {
            public string DegreeName { get; set; }
            public Course course { get; set; }

        }

        public class Uprogram
        {
            public string ProgramName { get; set; }
            public Degree Degree { get; set; }
        }
            #endregion



        }
}
