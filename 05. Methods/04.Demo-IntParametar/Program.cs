namespace _04.Demo_IntParametar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(Sum(x, y)); 
           

        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

    }
}
