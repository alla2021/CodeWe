using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePerson;

namespace BaseStudent
{
    class Student : Person
    {
        protected string course;

        public Student(string Name, string Course) : base(Category, Brand, Model, Price, Standart)
        {
            this.course = Course;
        }
        public string Course
        {
            get => this.course;
            set => this.course = value;
        }
    }
}
