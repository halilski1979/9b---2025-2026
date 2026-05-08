namespace LicePravoagalnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaRectangle();
        }

        public static void AreaRectangle()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double s = a * b;
            Console.WriteLine(s);
        }
    }
}
