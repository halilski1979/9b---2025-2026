namespace _07._Nay_golqmo_chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine(a);
            }

            else if (b>c && b>a) 
            {
                Console.WriteLine(b);
            }

            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
