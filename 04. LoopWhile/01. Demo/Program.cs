namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            
            while (true)
            {
                Console.WriteLine($"Hello {a}");
                a++;

                if (a>10)
                {
                    break;
                }
            }

        }
    }
}
