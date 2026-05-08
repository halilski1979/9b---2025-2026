namespace _0.Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum()); 
        }

        public static int Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            return a + b;
        }
    }
}
