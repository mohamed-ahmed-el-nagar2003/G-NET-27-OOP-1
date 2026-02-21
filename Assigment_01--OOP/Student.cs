using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_01__OOP
{
    internal class Student
    {
        public string Name { get; set; }
        internal int Id { get; set; }
        public string Faculty { get; set; }
        private string Password { get; set; }
        public Student(string name, int id, string faculty, string password)
        {
            Name = name;
            Id = id;
            Faculty = faculty;
            Password = password;
        }
    }
}
