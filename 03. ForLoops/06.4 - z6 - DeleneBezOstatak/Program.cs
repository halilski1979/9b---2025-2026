namespace _06._4___z6___DeleneBezOstatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double countDve = 0;
            double countTri = 0;
            double countChetiri = 0;


            for (int i = 0; i < n; i++)
            {
                double number=double.Parse(Console.ReadLine());  //600
                if (number%2==0)
                {
                    countDve++;
                }
                if (number % 3 == 0)
                {
                    countTri++;
                }
                if (number%4==0)
                {
                    countChetiri++;
                }
            }

            Console.WriteLine($"{countDve/n*100:f2}%");
            Console.WriteLine($"{countTri / n * 100:f2}%");
            Console.WriteLine($"{countChetiri / n * 100:f2}%");
        }
    }
}
