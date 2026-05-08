namespace krug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Per()}");
            
        }
        public static double Lice()
        {
            double r = double.Parse(Console.ReadLine());
            double s = Math.PI * r *r;
            return s;
        }
        public static double Per()
        {
            double r = double.Parse(Console.ReadLine());
            double h = 2*Math.PI * r;
            return h;

        }
    }    
}
