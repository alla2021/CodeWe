using ConsoleApp4;
using System;


namespace BaseTv
{
    public class Tv : Item
    {
        protected bool smartTv;

        public Tv(string Category, string Brand, string Model, double Price, bool SmartTv) : base(Category, Brand, Model, Price)
        {
            this.smartTv = SmartTv;
        }

        public bool SmartTV
        {
            get { return smartTv; }
            set { smartTv = value; }
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"smartTv: {this.smartTv}\n");
        }
    }

}
