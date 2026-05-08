namespace z01___LicePerimetarPravoagalnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perimetar();
        }

        public static void Lice()
        {
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());

            Console.Write("B=");
            double b=double.Parse(Console.ReadLine());

            double s = a * b;
            Console.WriteLine($"Lilce: {s}");
        }

        public static void Perimetar()
        {
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());

            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());

            double p = 2 * a + 2 * b;
            Console.WriteLine($"Perimetar: {p}");
        }
    }
}
