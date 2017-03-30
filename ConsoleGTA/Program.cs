using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Voertuig camion = new Vrachtwagen();
            Voertuig brommerke = new Brommer();

            v.Rij();
            camion.Rij();
            Console.WriteLine();

            brommerke.Rij();
            brommerke.Stuur(45);

            //lol
            Console2.Write("lol", ConsoleColor.Green, ConsoleColor.DarkRed);

            //geen Master
        }
    }
}