using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityAnotherExample.Before
{
    // in this example, the Student class has two responsibilities
    // 1- Manage the student information
    // 2- Save the student information to the database
    internal class Student
    {
        public Student(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public void Save()
        {
            // Save student to database
            Console.WriteLine("Student saved");
        }
    }
}
