using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_F22_Lecture_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


        public static void DisplayClasses()
        {
            Console.WriteLine("Displaying Classes");
        } // DisplayClasses

        public static void AddAClass()
        {
            Console.WriteLine("Displaying Classes");
        } // DisplayClasses

        public static void DisplayStudents()
        {
            Console.WriteLine("Displaying Classes");
        } // DisplayClasses

        public static void AddAStudent()
        {
            Console.WriteLine("Displaying Classes");
        } // DisplayClasses

    } // class

} // namespace
