namespace _12._AreaFigurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            double lice = 0;


            if (type=="square")
            {
                double a = double.Parse(Console.ReadLine());
                 lice = a * a;
                
            }
            else if (type == "rectangle")
            {
                double a=double.Parse(Console.ReadLine());
                double b=double.Parse(Console.ReadLine());
                lice=a * b;
                
            }
            else if (type == "circle")
            {
                double radius=double.Parse(Console.ReadLine());
                lice=Math.PI*radius*radius;
                

            }
            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha=double.Parse(Console.ReadLine());
                lice = (ha * a) / 2;
               
            }

            Console.WriteLine(lice);
        }
    }
}
