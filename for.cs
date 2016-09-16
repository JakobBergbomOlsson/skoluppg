using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //Övning 1
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            
            //Övning 2
            for (int i = 20; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            
            //Övning 3
            for (int i = 0; i <= 50; i=i+2)
            {
                Console.WriteLine(i);
            }
            
            //Övning 1. Sid 2
            Console.Write("Mata in start: ");
            int inmatat = int.Parse(Console.ReadLine());
            Console.Write("Mata in stopp: ");
            int inmatat2 = int.Parse(Console.ReadLine());
            Console.Write("Mata in steg: ");
            int inmatat3 = int.Parse(Console.ReadLine());

            for (int i = inmatat; i <= inmatat2; i=i+inmatat3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            
            // Övning 3. Sid 2
            Console.Write("Mata in ett heltal: ");
            int inmatat = int.Parse(Console.ReadLine());


            int y = 0;
            for (int i = 0; i <= inmatat; i++)
            {
                y = y + i;
                if (i == inmatat)
                {
                    Console.WriteLine(y);
                }
                
            //Övning 4. Sid 2

            Console.Write("Mata in ett heltal: ");
            int inmatat = int.Parse(Console.ReadLine());

            int y = 0;
            for (int i = 1; i <= inmatat; i++)
            {
                if(i%3==0 && i%7==0)
                {
                    Console.WriteLine("Talet: "+i+" är delbart med 3 och 7");
                }
                else if(inmatat < 21 && i == 1)
                {
                    Console.WriteLine("Inga tal hittades");
                }
            }
            
            //Övning 5. Sid 2

            Console.Write("Mata in ett heltal: ");
            int inmatat = int.Parse(Console.ReadLine());
            int x = 0; int y = 1;

            for (int z = 0; z <= inmatat; )
            {
                z++;
                if (z % 2 == 0)
                {
                    Console.WriteLine(y);
                    y = x + y;
                }
                else
                {
                    Console.WriteLine(x);
                    x = x + y;
                }
            }
            */
            //Övning 6. Sid 6
            Console.Write("Ange ett tal: ");
            double inmatat = double.Parse(Console.ReadLine());
            

            

        }
    }
}
