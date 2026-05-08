namespace _02.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }

        public static void Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int s = a + b;
            Console.WriteLine($"{a}+{b}={s}");
        }
        public static void Multiply()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = a * b;
            Console.WriteLine($"{a}*{b}={s}");
        }
        public static void Minus()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = a - b;
            Console.WriteLine($"{a}-{b}={s}");
        }
    }
}
