namespace zadcha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Метод, връщащ резултат с параметър

            Console.WriteLine(AreaCircle(10));
        }

        public static double AreaCircle(double r)
        {
            return Math.PI * r * r;
        }
    }
}
