using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_challenge
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}
