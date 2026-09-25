using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Student Class
    class Student
    {
        // Private Data Members
        private int studentId;
        private string studentName;
        private int age;
        private string course;

        // Constructor
        public Student(int id, string name, int studentAge, string studentCourse)
        {
            studentId = id;
            studentName = name;
            age = studentAge;
            course = studentCourse;
        }

        // Public Method to Display Details
        public void DisplayDetails()
        {
            Console.WriteLine("\n----- Student Admission Details -----");
            Console.WriteLine("Student ID   : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Age          : " + age);
            Console.WriteLine("Course       : " + course);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int id, age;
            string name, course;

            Console.WriteLine("===== Student Admission Management System =====");

            Console.Write("Enter Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            course = Console.ReadLine();

            // Object Creation
            Student student1 = new Student(id, name, age, course);

            // Display Details
            student1.DisplayDetails();

            Console.WriteLine("\nAdmission Successful!");
            Console.ReadKey();
        }
    }
}
