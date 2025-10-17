namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можем да достъпим минималните и максималните стойности на числовите типове с  MinValue / MaxValue:

            Console.Write("A = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            double S = (a + b) / 2 * h;

            Console.WriteLine(S);


        }

    }
}
