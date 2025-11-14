namespace _10._Zakraglqne_Na_Drobni_Chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.345678;

            //Закръгляне до следващо (по-голямо) цяло число:
            Console.WriteLine(Math.Ceiling(a));
            Console.WriteLine(Math.Floor(a));

            Console.WriteLine(Math.Round(a, 1));
            Console.WriteLine(Math.Round(a,2));
            Console.WriteLine(Math.Round(a, 3));
        }
    }
}
