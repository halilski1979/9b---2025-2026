namespace z2___LicePerPravoagalnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Метод, който връща резултат            
            Console.WriteLine(Perimetur());

        }

        public static double Lice()
        {
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());

            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());

            double s = a * b;
            return s;
        }

        public static double Perimetur()
        {
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());
            double s = 2* a + 2*b;
            return s;
        }
        public static double 
    }
}
