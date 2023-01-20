using System;

namespace ConsoleApp4
{
    public class Item
    {
        private int id;
        private Random random;
        protected string category;
        protected string brand;
        protected string model;
        protected double price;

        public Item(string Category, string Brand, string Model, double Price)
        {
            this.category = Category;
            this.brand = Brand;
            this.model = Model;
            this.price = Price;
            this.random = new Random();
            this.Id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = random.Next(1000000); }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"category: {this.category}\nname: {this.brand}\nprice = {this.price}\n------------------------- ");
        }
    }
    
    
   
}
