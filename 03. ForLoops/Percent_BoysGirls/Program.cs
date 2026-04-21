namespace Percent_BoysGirls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boys: ");
            double boys=double.Parse(Console.ReadLine());

            Console.Write("Girls: ");
            double girls = double.Parse(Console.ReadLine());

            double total=boys+girls;
            Console.WriteLine($"Total: {total}");

            double percentBoys = boys / total * 100;
            Console.WriteLine($"Percent boys: {percentBoys:f2}");
            double percentGirls = girls / total * 100;
            Console.WriteLine($"Percent girls: {percentGirls:f2}");

        }
    }
}
