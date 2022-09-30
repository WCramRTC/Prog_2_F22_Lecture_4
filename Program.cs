using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_F22_Lecture_4
{
    internal class Program
    {
        static List<SchoolClass> classes = new List<SchoolClass>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            PreloadStudents();

            PreloadClasses();
            Menu();

        } // Main



        public static void Menu()
        {
            // Menu
            bool isRunning = true;

            do
            {

                Console.WriteLine("Renton Tech College Classes and Students");

                // Menu Options
                // 1. Display Classes
                // 2. Add a class
                // 3. Display Students
                // 4. Add a student
                Console.WriteLine("1. Display Classes");
                Console.WriteLine("2. Add A Class");
                Console.WriteLine("3. Display Students");
                Console.WriteLine("4. Add a student");
                Console.WriteLine("5. Exit Application");

                Console.Write("\nEnter an option: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayClasses();
                        break;
                    case "2":
                        AddAClass();
                        break;
                    case "3":
                        DisplayStudents();
                        break;
                    case "4":
                        AddAStudent();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        break;
                }
            } while (isRunning);

            // Note to us: Look up what Environment.Exit(0) does
            Environment.Exit(0);


        } // Menu

        public static void PreloadClasses()
        {
            SchoolClass sc = new SchoolClass("Programming 120", "Josh Emery", students[0]);
           
            classes.Add(sc);

            sc = new SchoolClass("Programming 122", "William Cram");
            classes.Add(sc);

            sc = new SchoolClass("Database 1", "Dimpy Gill");
            classes.Add(sc);
        } // PreloadClasses()

        public static void PreloadStudents()
        {
            Student stu = new Student("Hannah", "Angel");
            students.Add(stu);
        }

        public static void DisplayClasses()
        {
            foreach(SchoolClass sc in classes)
            {
                Console.WriteLine(
                    $"Class Name: {sc.ClassName}\n" +
                    $"Teacher: {sc.Teacher}\n" +
                    $"Student: {sc.Student.FirstName + " " + sc.Student.LastName}\n");
            }
            Console.WriteLine("\n");

        } // DisplayClasses

        public static void AddAClass()
        {
            Console.WriteLine("Displaying Classes");
        } // DisplayClasses

        public static void DisplayStudents()
        {
  

            

        } // DisplayClasses

        public static void AddAStudent()
        {
            Console.WriteLine("Displaying Classes");
        } // DisplayClasses

        public static void AccessModiferExamples()
        {
            // Access Modifers
            // public
            // Everything in our code has access to public items
            SchoolClass sc = new SchoolClass("prog 2");

            // private
            // Only objects in the current class has access to private items


            // protected
            // internal
        } // AccessModifiersExamples

    } // class

} // namespace
