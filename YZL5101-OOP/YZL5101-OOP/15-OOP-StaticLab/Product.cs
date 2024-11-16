using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_StaticLab
{
    public class Product
    {
        public Product(string name ,double price)
        {
            Name = name;
            Price = price;
            ProductID = GenerateProductId();
        }
        private int GenerateProductId()
        {
            return TotalProductInInvenroy++;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Id:: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine("");
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static int TotalProductInInvenroy { get; set; }
    }
}
