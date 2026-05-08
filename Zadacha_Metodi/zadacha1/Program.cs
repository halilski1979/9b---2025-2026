namespace zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void без параметър
            AreaCircle();
        }

        public static void AreaCircle()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.PI*r*r);
        }
    }
}
