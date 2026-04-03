namespace _07._Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Число в диапазон

            while (true)
            {
                Console.Write("n=");
                int n=int.Parse(Console.ReadLine());

                if (n>=1 && n<=100)
                {
                    Console.WriteLine("END");
                    break;
                }
                Console.WriteLine("Invalid number");
            }
        }
    }
}
