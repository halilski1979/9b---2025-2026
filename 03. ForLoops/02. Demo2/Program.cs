namespace _02._Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <='z'; i++)
            {
                Console.WriteLine($"{i} => {(int)i}");
            }
        }
    }
}
