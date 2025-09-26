namespace _02._AreaRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());

            double s = a * b;
            Console.WriteLine($"S={s}");

        }
    }
}
