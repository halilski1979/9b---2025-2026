namespace _4._VlojenCikal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"i={i}");
                for (char j = 'a'; j < 'f'; j++)
                {                   
                    Console.WriteLine($"j={j}");                   
                }
                Console.WriteLine();
            }
        }
    }
}
