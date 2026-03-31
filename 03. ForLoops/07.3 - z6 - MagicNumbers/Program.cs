namespace _07._3___z6___MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicN = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    for (int k = 1; k < 9; k++)
                    {
                        for (int l = 1; l < 9; l++)
                        {
                            for (int m = 1; m < 9; m++)
                            {
                                for (int n = 1; n < 9; n++)
                                {
                                    if (i*j*k*l*m*n==magicN)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{l}{m}{n}");
                                        counter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Count: {counter}");
        }
    }
}
