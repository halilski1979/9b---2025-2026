namespace _01._AreaSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лице на квадрат

            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());

            double S = a * a;
            Console.WriteLine($"S={S:f2} kv.sm");


        }
    }
}
