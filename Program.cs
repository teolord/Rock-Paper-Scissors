using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            while (true)
            {
                int cislo = r.Next(0, 3);

                Console.WriteLine("0 = rock");
                Console.WriteLine("V = Scissors");
                Console.WriteLine("- = paper");

                Console.Write("Enter symbol: ");
                char t = Char.Parse(Console.ReadLine());

                if (t == '#')
                {
                    if (cislo == 0)
                    {
                        Console.WriteLine("Draw computer used a stone");
                    }

                    else if (cislo == 1)
                    {
                        Console.WriteLine("You won computer used scissors");
                    }

                    else
                    {
                        Console.WriteLine("You lost computer used paper");
                    }
                }

                else if (t == 'V')
                {
                    if (cislo == 0)
                    {
                        Console.WriteLine("You lost computer used rock");
                    }

                    else if (cislo == 1)
                    {
                        Console.WriteLine("Draw computer used scissors");
                    }

                    else
                    {
                        Console.WriteLine("You won computer used paper");
                    }
                }

                else if (t == '-')
                {
                    if (cislo == 0)
                    {
                        Console.WriteLine("You won computer used rock");
                    }

                    else if (cislo == 1)
                    {
                        Console.WriteLine("You lost computer used rock scissors");
                    }

                    else
                    {
                        Console.WriteLine("Draw computer used paper");
                    }
                }
            }
        }
    }
}
