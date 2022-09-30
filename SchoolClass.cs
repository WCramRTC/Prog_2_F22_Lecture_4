using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_F22_Lecture_4
{
    public class SchoolClass
    {
        // fields
        string _className;
        string _teacher;
        Student _student;

        // Constructor
        // Access Modifier - Name of Class - Properties
        public SchoolClass(string className)
        {
            _className = className;
            _teacher = "No Teacher";
            _student = new Student("No", "Name");
        } // constructor

        // Overload a constructor
        public SchoolClass(string className, string teacher)
        {
            _className = className;
            _teacher = teacher;
            _student = new Student("No", "Name");
        } // SchoolClass

        public SchoolClass(string className, string teacher, Student student)
        {
            _className = className;
            _teacher = teacher;
            _student = student;
        } // SchoolClass

        // Properties
        // Give access to the users.
        // Prevent them from doing unwanted actions
        // Getters = Return the value in the field
        // Setters = Change the value

        // A property 
        // Access Modifier - Return Type ( same as the field ) - Name ( same as field )
        public string ClassName
        {
            get
            {
                return _className;
            } // get
            set
            {
                _className = value;
            }
        } // ClassName

        public string Teacher // <----- No Parentheses
        {
            get
            {
                // Returns the teacher field
                return _teacher;
            } // get
            set
            {
                _teacher = value;
            }
        } // Teacher

        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        } // Student


        // Methods

    } //
}
