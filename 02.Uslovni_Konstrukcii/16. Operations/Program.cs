using System.ComponentModel.Design;

namespace _16._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1 - ");
            double N1 = double.Parse(Console.ReadLine());
            Console.Write("Number 2 - ");
            double N2 = double.Parse(Console.ReadLine());
            Console.Write("Operaciq - ");
            string operaciq = Console.ReadLine();

            if (operaciq == "+")
            {
                double res = N1 + N2;
                if (res %2==0)
                    Console.WriteLine($"{N1} + {N2} = {res} - even");
                else
                    Console.WriteLine($"{N1} + {N2} = {res} - odd");
            }

            else if (operaciq == "-")
            {

            }
            else if (operaciq == "*")
            {

            }
            else if (operaciq == "/")
            {

            }
             
        }
    }
}
