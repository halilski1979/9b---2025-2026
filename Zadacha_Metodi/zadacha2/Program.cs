namespace zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Метод без параметър, връщащ резултат
            Console.WriteLine(AreaCircle());

        }

        public static double AreaCircle()
        {
            double r=double.Parse(Console.ReadLine());
            return Math.PI * r * r;
        }
    }
}
