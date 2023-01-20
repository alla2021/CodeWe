using System;
using BaseTelephone;

namespace BaseMobile
{
    public class BasicMobile : Telephone
    {
        protected string bodyShape;

        public BasicMobile(string Category, string Brand, string Model, double Price, string Standart, string BodyShape) : base(Category, Brand, Model, Price, Standart)
        {
            this.bodyShape = BodyShape;
        }

        public string BodyShape
        {
            get { return bodyShape; }
            set { bodyShape = value; }
        }
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"bodyShape: {this.bodyShape}\n");
        }
    }
}
