using ConsoleApp4;
using System;


namespace BaseTelephone
{
    public class Telephone : Item
    {
        protected string communicationStandard;

        public Telephone(string Category, string Brand, string Model, double Price, string Standart) :
            base(Category, Brand, Model, Price)
        {
            this.communicationStandard = Standart;
        }

        public string Standart
        {
            get { return communicationStandard; }
            set { communicationStandard = value; }
        }
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"standart: {this.communicationStandard}");
        }
    }
}
