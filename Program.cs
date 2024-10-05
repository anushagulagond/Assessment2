namespace Assessment2
{
    public class Fish
    {
        public string Species { get; set; }
        public double PricePerFish { get; set; }
    }

    public class FishUtility : Fish
    {
        public void Add(string species,double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;
        }
        public bool BuyFish()
        {
            if(Species=="Clownfish" || Species == "Goldfish")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculatePrice(int numberOfFishes)
        {
            double AdditionalCharges=0;
            if (Species == "Clownfish")
            {
                AdditionalCharges = 100;
            }
            if (Species == "Goldfish")
            {
                AdditionalCharges = 150;
            }
            return (numberOfFishes * PricePerFish) + AdditionalCharges;
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the species to buy");
                string Species = Console.ReadLine();

                Console.WriteLine("Enter the price per fish");
                double PricePerFish = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of fishes you need to buy");
                int numberOfFishes=int.Parse(Console.ReadLine());

                FishUtility fishUtility = new FishUtility();

                fishUtility.Add(Species,PricePerFish);
               
                if (fishUtility.BuyFish())
                {
                    double TotalPrice=fishUtility.CalculatePrice(numberOfFishes);
                    Console.WriteLine(TotalPrice);
                }
                else
                {
                    Console.WriteLine($"{Species} species not found");
                }
            }
        }
    }
}