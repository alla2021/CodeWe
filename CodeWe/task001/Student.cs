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

        public Student(string Name, string Course) : base(Name)
        {
            this.course = Course;
        }

        public string Course
        {
            get => this.course;
            set => this.course = value;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"You learn: {this.course}");
        }
    }
}
