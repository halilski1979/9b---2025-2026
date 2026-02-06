namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double lice = 0;

            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                lice = a * a;
            }
            else if (type == "triangle")
            {
                double a = double.Parse((Console.ReadLine()));
                double ah = double.Parse(((Console.ReadLine())));

                lice = (ah * a) / 2;
            }
            else if (type == "circle")
            {
                double r = double.Parse((Console.ReadLine()));

                lice = (Math.PI * r * r);

            }
            else if (type == "rectangle")
            {
                double a = double.Parse ((Console.ReadLine()));
                double b = double.Parse((Console.ReadLine()));

                lice = (a * b); 
                
            }
            Console.WriteLine(lice);

        }
    }
}
