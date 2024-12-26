using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityAnotherExample.After
{
    // in this example, the Student class has one responsibility which is to manage the student information
    // the Save method is moved to the StudentRepository class
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
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Save(this);
        }
    }
}
