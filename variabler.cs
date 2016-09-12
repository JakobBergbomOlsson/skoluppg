using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Console.WriteLine("Mata in tal 1: ");
            string inmatat = Console.ReadLine();
            int tal1 = int.Parse(inmatat);    
            Console.WriteLine("Mata in tal 2: ");
            string inmatat2 = Console.ReadLine();
            int tal2 = int.Parse(inmatat2);
            Console.WriteLine("Summa: " + (tal1 + tal2));
            Console.WriteLine("Produkt: " + (tal1 * tal2));
            Console.WriteLine("Kvot: " + (tal1 / tal2));
            */

            Console.WriteLine("Mata in ditt förnamn: ");
            string inmatat = Console.Readline();
            string för = string.Parse(inmatat);
            Console.WriteLine("Mata in ditt efternamn: ");
            string inmatat2 = Console.ReadLine();
            string efter = string.Parse(inmatat2);

            Console.WriteLine("Hejsan, " + för + efter);      
             
             
        }
    }
}
