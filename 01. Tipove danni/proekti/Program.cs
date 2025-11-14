namespace proekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int brProekti=int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {brProekti*3} " +
                $"hours to complete {brProekti} project/s.");
        }
    }
}
