using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_F22_Lecture_4
{
    public class Student
    {

        // fields
        string _firstName;
        string _lastName;

        // constructor
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        } // constructor

        // properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        } // LastName

        // methods

    } // class

} // namespace
