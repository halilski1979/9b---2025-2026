namespace _13._KvartalenMagazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string stoka=Console.ReadLine();
           string grad=Console.ReadLine();
           double kol=double.Parse(Console.ReadLine());
            double totalPrice = 0;
           
           if( grad=="Sofia")
            {
                if (stoka == "coffee")
                {
                    totalPrice = kol * 0.50;
                }

                else if (stoka== "water")
                {
                    totalPrice = kol * 0.80;
                }
                else if (stoka == "beer")
                {
                    totalPrice = kol * 1.20;
                }
                else if (stoka == "sweets")
                {
                    totalPrice = kol * 1.45;
                }
                else if (stoka == "peanuts")
                {
                    totalPrice = kol * 1.60;
                }

                Console.WriteLine($"{totalPrice:f2}");
            }

            if (grad == "Plovdiv")
            {
                if (stoka == "coffee")
                {
                    totalPrice = kol * 0.40;
                }

                else if (stoka == "water")
                {
                    totalPrice = kol * 0.70;
                }
                else if (stoka == "beer")
                {
                    totalPrice = kol * 1.15;
                }
                else if (stoka == "sweets")
                {
                    totalPrice = kol * 1.35;
                }
                else if (stoka == "peanuts")
                {
                    totalPrice = kol * 1.5;
                }

                Console.WriteLine($"{totalPrice:f2}");
            }

            if (grad == "Varna")
            {
                if (stoka == "coffee")
                {
                    totalPrice = kol * 0.45;
                }

                else if (stoka == "water")
                {
                    totalPrice = kol * 0.70;
                }
                else if (stoka == "beer")
                {
                    totalPrice = kol * 1.15;
                }
                else if (stoka == "sweets")
                {
                    totalPrice = kol * 1.35;
                }
                else if (stoka == "peanuts")
                {
                    totalPrice = kol * 1.55;
                }

                Console.WriteLine($"{totalPrice:f2}");
            }



        }
    }
}
