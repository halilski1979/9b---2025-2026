namespace _04._GreetrNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine();


            if (b>a)
            {
                Console.WriteLine("b>a");
                Console.WriteLine($"{b} > {a}");
            }
            else
            {
                Console.WriteLine("a>b");
                Console.WriteLine($" {a} > {b}");
            }
        }
    }
}
