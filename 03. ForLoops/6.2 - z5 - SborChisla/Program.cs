using System.Threading.Channels;

namespace _6._2___z5___SborChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа,
            //въведени от потребителя и ги сумира.

            int s = int.Parse(Console.ReadLine());
            int sum  = 0;

            for (int i = 0; i < s ; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;


            }
            Console.WriteLine(sum);

        }
    }
}
