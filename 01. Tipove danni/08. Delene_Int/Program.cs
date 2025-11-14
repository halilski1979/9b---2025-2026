namespace _08._Delene_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            //Целочислено делене на числа от тип int
            int result = a / b;
            Console.WriteLine(result);

            //Модулно делене на числа от тип int
            int modDelene = a % b;
            Console.WriteLine(modDelene);


        }
    }
}
