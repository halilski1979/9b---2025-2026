namespace _07._Aritmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

                       
            Console.WriteLine($"{a}+{b}={a+b}");

            int razlika = a - b;
            Console.WriteLine($"{a}-{b}={razlika}");

            int pr = a * b;
            Console.WriteLine($"{a}*{b}={pr}");

            
        }
    }
}
