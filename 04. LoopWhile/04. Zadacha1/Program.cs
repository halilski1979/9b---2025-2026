namespace _04._Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Печат m..n
            int m = int.Parse(Console.ReadLine());  //m=5
            int n = int.Parse(Console.ReadLine());  //n=10

            while (m<=n)
            {
                Console.WriteLine(m);
                m++;
            }

        }
    }
}
