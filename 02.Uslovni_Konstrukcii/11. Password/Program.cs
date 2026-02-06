namespace _11._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("wellcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }


        }
    }
}
