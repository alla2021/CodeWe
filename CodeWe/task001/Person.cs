using System;
using System.Collections.Generic;


namespace BasePerson
{
    public abstract class Person
    {
        private int id; 
        private Random random;
        protected string name;

        public Person(string Name)
        {
            this.name = Name;
            this.Id = id;
            this.random = new Random();
        }

        public int Id
        {
            get { return id; }
            set { id = random.Next(1000000); }
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hello, {this.name}");
        }
    }
}
