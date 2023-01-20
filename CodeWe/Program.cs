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
<<<<<<< HEAD
             Git Revert
            Git Revert
            Git Revert
            Git Revert
            Git Revert
            Git Revertkkkkkkkkkkkk
            Git Revertkkkkkkkkkk
            Git Revertkkkkkkkkkk
            Git Revertadadadaadadad
             */

=======
>>>>>>> parent of f1bb653 (git-revert-test)
            ArrHelper helper = new ArrHelper();
            helper.createList(5, 6, 10, 30);
            helper.printList();
            helper.getSize();
            helper.getMax();
            helper.getMin();
            helper.find(12);
<<<<<<< HEAD
<<<<<<< HEAD
            */

=======
            
            //changes11111111111111
>>>>>>> 9fb0330 (test)
=======
            
            //changes11111111111111
>>>>>>> 9fb033023ab1e2f4251030895e5028d485e713f4

            //Password Generator
            //PasswordGenerator pass = new PasswordGenerator();
            //Console.WriteLine(pass.passwordGeneratorFunc(4));

            Person obj = new Student("Harry", "c#");
            obj.PrintInfo();
        }
    }
}


