namespace zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void с параметър
            double radius=double.Parse(Console.ReadLine());
            AreaCircle(radius);

        }

        public static void AreaCircle(double r)
        {
            Console.WriteLine(Math.PI*r*r);
        }
    }
}
