using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Controllers
{
    class StudentController
    {
        public List<Student> students = new List<Student> ();
        public void PrintListStudent(List<Student> students)
        {
            Console.WriteLine("----------------------------Student List-----------------------------");
            int i = 1;
            foreach (var student in students)
            {
                if (student.IsNewStudent() && !student.IsDeactive())
                {
                    Console.WriteLine(String.Format("|{0,5}|{1,30}|{2,10}|{3,10}|", i, student.RollNumber, student.FullName, student.Status.ToString()));
                    ++i;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        public void GenerateMenu()
        {
            Console.WriteLine("-------------------MENU-------------------");
            Console.WriteLine("1. Create a new student record");
            Console.WriteLine("2. Show student list");
            Console.WriteLine("3. Exit");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please select your options 1 | 2 | 3: ");
            int menu = Convert.ToInt16(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Student student = CreateStudent();
                    students.Add(student);
                    break;
                case 2:
                    PrintListStudent(students);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        public Student CreateStudent()
        {
            Student student = new Student();

            Console.WriteLine("Please insert Roll Number: ");
            string rollNumber = Console.ReadLine();
            Console.WriteLine("Please insert Student's Full Name: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Please insert Birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please insert Phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Please insert created at time: ");
            DateTime createdAt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please insert status ( 1: Active, 0: Deactive ): ");
            int status = Convert.ToInt16(Console.ReadLine());

            student.RollNumber = rollNumber;
            student.FullName = fullName;
            student.Birthday = birthday;
            student.Phone = phone;
            student.CreatedAt = createdAt;

            if (status == 1)
            {
                student.Status = Student.StudentStatus.Active;
            } else if (status == 0)
            {
                student.Status = Student.StudentStatus.Deactive;
            } else
            {
                Console.WriteLine("Unexpected input.");
            }
            return student;
        }
    }
}
