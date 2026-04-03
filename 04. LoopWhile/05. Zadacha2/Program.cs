namespace _05._Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine()); //5
            int n = int.Parse(Console.ReadLine()); //10

            while (true)
            {
                Console.WriteLine(m);
                m++;
                if (m==n)
                {
                    break;
                }
            }
        }
    }
}
