namespace _06.Zadacha6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сбор m..n

            int m = int.Parse(Console.ReadLine()); //m=5
            int n = int.Parse(Console.ReadLine()); //n=10

            int s = 0;

            while (m<=n)
            {
                s += m;
                m++;
            }

            Console.WriteLine(s);
        }
    }
}
