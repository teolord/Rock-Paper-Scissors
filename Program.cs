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

                Console.Write("Zadej znak: ");
                char t = Char.Parse(Console.ReadLine());

                if (t == '#')
                {
                    if (cislo == 0)
                    {
                        Console.WriteLine("Remíza počitač použil kámen");
                    }

                    else if (cislo == 1)
                    {
                        Console.WriteLine("Vyhral jsi počítač použil nůžky");
                    }

                    else
                    {
                        Console.WriteLine("Prohrál jsi počítač použil papír");
                    }
                }

                else if (t == 'V')
                {
                    if (cislo == 0)
                    {
                        Console.WriteLine("Prohral jsi pocitac pouzil kamen");
                    }

                    else if (cislo == 1)
                    {
                        Console.WriteLine("Remizoval jsi počítač použil nůžky");
                    }

                    else
                    {
                        Console.WriteLine("Vyhral jsi počítač použil papír");
                    }
                }

                else if (t == '-')
                {
                    if (cislo == 0)
                    {
                        Console.WriteLine("Vyhral jsi počitač použil kámen");
                    }

                    else if (cislo == 1)
                    {
                        Console.WriteLine("Prohral jsi počítač použil nůžky");
                    }

                    else
                    {
                        Console.WriteLine("Remiza počítač použil papír");
                    }
                }
            }
        }
    }
}
