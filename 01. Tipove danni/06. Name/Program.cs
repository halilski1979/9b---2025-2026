namespace _06._Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string city = Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, my name is {name}! I am {age} years old, from {city}");
        }
    }
}
