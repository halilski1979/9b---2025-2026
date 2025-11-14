namespace _09.Delene_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());

            double result = a / b;
            Console.WriteLine(result);

        }
    }
}
