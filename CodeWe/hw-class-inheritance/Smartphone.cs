using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTelephone;

namespace Smart
{
    public class Smartphone : Telephone
    {
        protected string operatingSystem;

        public Smartphone(string Category, string Brand, string Model, double Price, string Standart, string OperatingSystem) :
            base(Category, Brand, Model, Price, Standart)
        {
            this.operatingSystem = OperatingSystem;
        }

        public string OperatingSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"operatingSystem: {this.operatingSystem}\n");
        }
    }

}
