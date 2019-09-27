using System;

namespace backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            string items = " ";
            bool loop = true;

            //Switch-meny
            Console.WriteLine("Välkommen till ryggsäcken!");
            while (loop)
            {
                Console.WriteLine("\n[1] Lägg till föremål");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Töm ryggsäcken");
                Console.WriteLine("[0] Avsluta ryggsäcken");
                Console.Write("Vad vill du göra? ");
                int menyVal = Convert.ToInt32(Console.ReadLine());

                switch (menyVal)
                {
                    case 1:
                        Console.Write("\nVilket föremål vill du lägga till? ");
                        items += Console.ReadLine() + " | ";
                        break;

                    case 2:
                        Console.WriteLine("\nI din ryggsäck finns: " + items);
                        break;

                    case 3:
                        items = " ";
                        Console.WriteLine("\nDin ryggsäck är nu tom!");
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
        }
    }
}
