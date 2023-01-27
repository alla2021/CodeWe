using CalculateUserAge;
using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateAge user1 = new CalculateAge();
           try
            {
                user1.inputInfo();
                user1.printInfo();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   

        }
    }
}
