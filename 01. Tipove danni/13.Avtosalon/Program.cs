namespace _13.Avtosalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carModel=Console.ReadLine();
            double priceCar=double.Parse(Console.ReadLine());
            int days=int.Parse(Console.ReadLine());

            double priceAfterTaxis = priceCar * 0.2 + priceCar + 275;
            double storageCost = days * 20;

            double sumPrice=priceAfterTaxis+storageCost;
            double pechalba = sumPrice * 0.15;

            Console.WriteLine($"„The { carModel } with initial price of {priceCar} BGN will sell for {sumPrice + pechalba} BGN“");
            Console.WriteLine($"„Profit: {pechalba} BGN“");
        }
    }
}
