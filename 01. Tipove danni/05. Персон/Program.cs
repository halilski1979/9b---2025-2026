namespace _05._Персон
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            string city=Console.ReadLine();
            double salary=double.Parse(Console.ReadLine());

            Console.WriteLine($"Kazvam se {name}. Na {age} godini. Ot {city}. Zaplata {salary} lv.");
        }
    }
}
