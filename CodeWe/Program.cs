using System;
using System.Collections.Generic;
using System.Text;
using GeneratorPass;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator pass = new PasswordGenerator();
            Console.WriteLine(pass.passwordGeneratorFunc(4));
        }
    }
}


