namespace _06._4_Histograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;


            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number<200)
                {
                    count1++;
                }
                else if (number<400)
                {
                    count2++;
                }
                else if (number < 600)
                {
                    count3++;
                }
                else if (number < 800)
                {
                    count4++;
                }
                else
                {
                    count5++;
                }
            }

            Console.WriteLine($"{(count1/n)*100:f2}%");
            Console.WriteLine($"{(count2 / n) * 100:f2}%");
            Console.WriteLine($"{(count3 / n) * 100:f2}%");
            Console.WriteLine($"{(count4 / n) * 100:f2}%");
            Console.WriteLine($"{(count5 / n) * 100:f2}%");

        }
    }
}
