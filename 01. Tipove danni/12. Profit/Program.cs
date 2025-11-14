namespace _12._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rabotni dni(5-30) - ");
            double days = double.Parse(Console.ReadLine());
            Console.Write("Nadnik(10.00-2000.00) - ");
            double payday = double.Parse(Console.ReadLine());
            Console.Write("Kurs na $(0.99-1.99 - ");
            double kurs = double.Parse(Console.ReadLine());

            double zaplata = days * payday;
            double yearSalary = zaplata * 12 + zaplata * 2.5;
            double danuk = yearSalary / 4;
            double goddohod = yearSalary - danuk;
            double godDohodLv = goddohod * kurs;
            double srednoNaDen = godDohodLv / 365;
            Console.WriteLine($"Na den vzima sredno {srednoNaDen:f2}");





        }
    }
}
