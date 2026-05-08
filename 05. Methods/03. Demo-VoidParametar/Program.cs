namespace _03._Demo_VoidParametar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y=int.Parse(Console.ReadLine());

            Sum(x,y);
        }

        public static void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
