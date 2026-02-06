using System.Drawing;

namespace _03._Color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Color: ");
            string color= Console.ReadLine();

            if (color == "red")
            {
                Console.WriteLine("Qbalka");
                Console.WriteLine("Malina");
            }
            else if (color == "yellow")
            {
                Console.WriteLine("Banan");
                Console.WriteLine("Limon");
            }
            else if (color == "green")
            {
                Console.WriteLine("Chushka");
                Console.WriteLine("Krastavica");
            }
            else
            {
                Console.WriteLine("Nqma cvqt");
            }
        }
    }
}
