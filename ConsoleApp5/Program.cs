using System;

namespace ConsoleApp5
{
    class Notebook
    {
        public string Brand;
        public int Model;
        public int Price;
        

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");
        }

    }

    internal class Program
    {
        static void main(string[] args)
        {
            Notebook ntb1 = new Notebook()
            {
                Brand = "Lenovo",
                Model = 30437863,
                Price = 690,
                
            };
        }
    }
    
}
