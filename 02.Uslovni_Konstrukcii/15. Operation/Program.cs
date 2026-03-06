namespace _15._Operation
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
            if (N1 != 0 && N2 != 0)
            {


                if (operaciq == "/")
                {
                    double sol = N1 / N2;

                    Console.WriteLine($"{N1}/{N2}={sol}");
                }
                if (operaciq == "%")
                {
                    double sol = N1 % N2;

                    Console.WriteLine($"{N1}%{N2}={sol}");
                }

            }
            else
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }




            if (operaciq == "+")
            {
                double sol = N1 + N2;
                double even = sol % 2;
                if (even == 0)
                {
                    Console.WriteLine($"{N1}+{N2}={sol} - even");
                }
                else
                {
                    Console.WriteLine($"{N1}+{N2}={sol} - odd");
                }
            }
            if (operaciq == "-")
            {
                double sol = N1 - N2;
                double even = sol % 2;
                if (even == 0)
                {
                    Console.WriteLine($"{N1}-{N2}={sol} - even");
                }
                else
                {
                    Console.WriteLine($"{N1}-{N2}={sol} - odd");
                }

            }
            if (operaciq == "*")
            {
                double sol = N1 * N2;
                double even = sol % 2;
                if (even == 0)
                {
                    Console.WriteLine($"{N1}*{N2}={sol} - even");
                }
                else
                {
                    Console.WriteLine($"{N1}*{N2}={sol} - odd");
                }












            }
        }
    }
}
