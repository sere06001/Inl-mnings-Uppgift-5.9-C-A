using System;
using System.Diagnostics.SymbolStore;
namespace Uppgift5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett namn: ");
            int i = 0;
            int j = 1;
            string svar;
            List<string> list = new List<string>();
            Console.WriteLine();
            do
            {
                string[] allaNamn = new string[j];
                allaNamn[i] = Console.ReadLine();
                list.Add(allaNamn[i]);
                Console.WriteLine();
                Console.Write("Vill du skriva in ett till namn?");
                Console.WriteLine();
                Console.Write("'j' för ja och 'n' för nej: ");
                svar = Console.ReadLine();
                if (svar == "j")
                {
                    Console.WriteLine();
                    Console.Write("Skriv in ditt nya namn: ");
                }
                i++;
                j++;
            } while (svar == "j");
            Console.WriteLine();
            Console.Write("Skriv in namn du vill söka efter: ");
            string namn = Console.ReadLine();
            int b = 0;
            for (int a = 0; a < list.Count; a++)
            {
                if (list[a].Contains(namn))
                {
                    b++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Namnet förekommer {b} antal gånger");
            Console.ReadKey();
        }
    }
}