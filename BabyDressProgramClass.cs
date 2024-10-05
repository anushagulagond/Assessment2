using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Assessment2;
using BabyDressProject;
namespace Assessment2
{
    public class BabyDressUtility 
    {
        public void AddDressToCart(BabyDress dress)
        {
            BabyDressProgramClass.DressCart.Add(dress);
        }
        public bool RemoveDressFromCart(string brand)
        {
            foreach (var DressBrand in BabyDressProgramClass.DressCart)
            {
                if (DressBrand.Brand == brand)
                {
                    BabyDressProgramClass.DressCart.Remove(DressBrand);
                    return true;
                }
            }
                    return false;
            }
        }
    }
    public class BabyDressProgramClass
    {
       public static List<BabyDress> DressCart { get; set; } = new List<BabyDress>();
        public static void Main(string[] args)
        {
        BabyDressUtility babyDressUtility = new BabyDressUtility();
        while (true) { 
            Console.WriteLine("1.Add dress to cart\n2.Remove dress from cart\n3.Exit");
            Console.WriteLine("Enter your choice");
            int Choice=int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    BabyDress babyDress = new BabyDress();
                    Console.WriteLine("Enter the dress size");
                    babyDress.Size = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the dress color");
                    babyDress.Color = Console.ReadLine();

                    Console.WriteLine("Enter the dress brand");
                    babyDress.Brand = Console.ReadLine();

                    Console.WriteLine("Enter the dress price");
                    babyDress.Price = double.Parse(Console.ReadLine());

                    babyDressUtility.AddDressToCart(babyDress);
                    Console.WriteLine("Successfully added to the dress cart");
                    break;

                case 2:
                    Console.WriteLine("Enter the dress brand to remove the dress from cart");
                    string Brand = Console.ReadLine();
                    if (babyDressUtility.RemoveDressFromCart(Brand))
                    {
                        Console.WriteLine("Successfully removed from the cart");
                    }
                    else
                    {
                        Console.WriteLine("Dress not found in the cart");
                    }
                    break;

                case 3:
                    Console.WriteLine("Thank You!");
                    return;

                Default: Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}
