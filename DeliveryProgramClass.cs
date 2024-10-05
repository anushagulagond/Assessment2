using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class ProductOutOfStockExcepyion : Exception
    {
        public string Mesg=string.Empty;
        public override string Message => "Product is out of stock";

    }
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }

        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }
    }
    public class DeliveryService :Product
    {
        public DeliveryService(string name, int stock) : base(name, stock)
        {
        }

        public bool PlaceOrder(Product product)
        {
            if (Stock > 0)
            {
                return true;
            }
            else
            {
                throw new ProductOutOfStockExcepyion();
            }
        }
    }
    public class DeliveryProgramClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the number of stocks");
            int Stock = int.Parse(Console.ReadLine());
            Product product = new Product(Name, Stock);
            DeliveryService ProgramClass = new DeliveryService(Name, Stock);
            try
            {
                ProgramClass.PlaceOrder(product);
                Console.WriteLine("Order placed Successfully");
            }
            catch (ProductOutOfStockExcepyion ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
