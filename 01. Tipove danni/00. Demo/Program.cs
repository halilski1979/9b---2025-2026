using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> names = Console.ReadLine().Split(' ').ToList();

            numbers.Remove(0);

        }

    }
}
