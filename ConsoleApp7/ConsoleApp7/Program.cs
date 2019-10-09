using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int gen = rand.Next(1, 101);
            int försök = 0;
            Console.WriteLine("skriv ett tal mellan 1 och 100 : ");
            int tal;
            do
            {
                tal = int.Parse(Console.ReadLine());
                försök++;
                if (tal > gen)
                    Console.WriteLine("för högt");
                else if (tal < gen)
                    Console.WriteLine("för lågt");
                else
                    Console.WriteLine("du hade rätt!! gratis glas");



            }
            while (tal != gen) ;
            Console.WriteLine("du tog " + försök + " försök på dig");
            Console.ReadLine();

        }
    }
}
