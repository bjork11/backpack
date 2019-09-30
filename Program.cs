using System;
using System.Linq;
using System.Collections.Generic;

namespace backpack
{
    class Program
    {
        //Skapar backpack som tar in 5 föremål(string)
        static string[] backpack = new string[5];

        //Metod för att skriva ut menyalternativen
        static int WriteOutMeny()
        {
            Console.WriteLine("\n[1] Lägg till föremål");
            Console.WriteLine("[2] Skriv ut innehållet");
            Console.WriteLine("[3] Töm ryggsäcken");
            Console.WriteLine("[0] Avsluta ryggsäcken");
            Console.Write("Vad vill du göra? ");
            int menyVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return menyVal;
        }

        //Metod för att lägga till saker i ryggsäcken
        //Ryggsäcken är skitkass för man måste fylla den med 5 förmål som programmet ser ut just nu.
        static string[] AddItemToBackpack()
        {
            for (int i = 0; i < backpack.Length; i++)
            {
                Console.Write("Vilket föremål vill du lägga till? ");
                string addItem = Console.ReadLine();
                backpack[i] = addItem;

                if (i == (backpack.Length - 1))
                {
                    Console.WriteLine("Din ryggsäck är nu full!");
                }
            }
            return backpack;
        }
        //Skriver ut innehållet i ryggplatsen och på vilket plats de ligger.
        //Inte indexplats utan index+1 för att det blir mer rimligt för användaren att platsten börjar på 1 och inte 0
        static void PrintOutItemsInBackpack(string[] backpack)
        {
            int i = 1;

            foreach (string element in backpack)
            {
                Console.WriteLine("Plats " + i + ": " + element);
                i++;
            }
        }
        //Tömmer ryggsäcken genom att ge varje indexplats värdet null
        static void EmptyBackPack()
        {
            for (int i = 0; i < backpack.Length; i++)
            {
                backpack[i] = null;
            }

            Console.WriteLine("Din ryggsäck är nu tom!");
        }
        static void Main(string[] args)
        {
            bool loop = true;
            int menyVal = 0;

            //Switch-meny
            Console.WriteLine("Välkommen till ryggsäcken!");

            //Loop som låter programmet köra på till användaren vill avsluta.
            while (loop)
            {
                //De flesta inmatningar hanteras av default som säger åt användaren att göra ett val mellan 0-3.
                //Uppstår det ändå ett fel som tex en inmatning som överstiger värdet av en int så hanteras felet med try&catch
                try
                {
                    menyVal = WriteOutMeny();

                    switch (menyVal)
                    {
                        case 1:
                            AddItemToBackpack();
                            break;

                        case 2:
                            PrintOutItemsInBackpack(backpack);
                            break;

                        case 3:
                            EmptyBackPack();
                            break;

                        case 0:
                            Console.WriteLine("\nDu avslutar nu Ryggsäcken!");
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("Gör ett val mellan 0-3!");
                            Console.ReadKey();
                            continue;
                    }
                }

                catch
                {
                    Console.WriteLine("Något gick fel, försök igen!");
                    Console.ReadKey();
                }
            }
        }
    }
}
