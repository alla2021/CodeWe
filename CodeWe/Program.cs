using System;
using System.Collections.Generic;
using System.Text;
using GeneratorPass;
using BaseArray;
using BaseStudent;
using BasePerson;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            /*
            ArrHelper helper = new ArrHelper();
            helper.createList(5, 6, 10, 30);
            helper.printList();
            helper.getSize();
            helper.getMax();
            helper.getMin();
            helper.find(12);
            */


            //Password Generator
            //PasswordGenerator pass = new PasswordGenerator();
            //Console.WriteLine(pass.passwordGeneratorFunc(4));

            Person obj = new Student("Harry", "c#");
            obj.PrintInfo();
        }
    }
}


