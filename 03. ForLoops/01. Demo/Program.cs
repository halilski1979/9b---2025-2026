namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char ch= 'A';

            Console.WriteLine(ch);
            
            //Кастване -  преминаване от един тип към друг
            Console.WriteLine((int)ch);

            int a = 33;
            Console.WriteLine(a);
            Console.WriteLine((char)a);
        }
    }
}
