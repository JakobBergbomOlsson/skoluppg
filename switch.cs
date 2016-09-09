using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Gjord av Jakob Bergbom Olsson, 9/9 - 16, switch övning! 
             
            int tal = int.Parse(Console.ReadLine());

            switch(tal)
            {
                case 1: Console.WriteLine("1: Ett");                         break;
                case 2: Console.WriteLine("2: Två");                         break;
                case 3: Console.WriteLine("3: Tre");                         break;
                case 4: Console.WriteLine("4: Fyra");                        break;
                default: Console.WriteLine("Ogiltigt nummer, försök igen!"); break;
            }
            

            char tal = char.Parse(Console.ReadLine());

            switch (tal)
            {
                case 'N':               
                case 'n': Console.WriteLine("You walk north.");                  break;
                case 'S': 
                case 's': Console.WriteLine("You walk south.");                  break;
                case 'W': 
                case 'w': Console.WriteLine("You walk west.");                   break;
                case 'E': 
                case 'e': Console.WriteLine("You walk east.");                   break;
                default: Console.WriteLine("Invalid entry, I don't understand"); break;
            }
            */

            Console.WriteLine("Mata in 2 heltal + valfritt räknesätt.");

            int tal1 = int.Parse(Console.ReadLine());
            char sätt = char.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            

            switch (sätt)
            {
                case '+': Console.WriteLine("Addidtion: " + (tal1 + tal2));         break;
                case '-': Console.WriteLine("Subtraktion: " + (tal1 - tal2));       break;
                case '/': Console.WriteLine("Divisoin: " + (tal1 / (tal2*1.0)));    break;
                case '*': Console.WriteLine("Multiplikation: " + (tal1 * tal2));    break; 
            }
        }
    }
}
