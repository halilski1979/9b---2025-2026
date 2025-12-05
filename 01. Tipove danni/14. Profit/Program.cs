namespace _14._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string Carmodel=Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
          double Carprice = double.Parse(Console.ReadLine());
            double taksa = Carprice * 0.2 + 275;
            double daysprice = Carprice * 20;
            double profit = taksa * 0.5;

            Console.WriteLine($"„The { Carmodel } with initial price of { Carprice} BGN will sell for{Carprice} BGN“");

        }
    }
}
