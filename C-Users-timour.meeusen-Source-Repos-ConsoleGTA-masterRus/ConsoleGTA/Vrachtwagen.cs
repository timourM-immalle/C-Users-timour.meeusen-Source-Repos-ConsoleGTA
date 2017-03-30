using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen() : base(ConsoleColor.Green)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De vrachtwagen rijdt...", ConsoleColor.Red);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De vrachtwagenchauffeur kijkt in zijn dodehoekspiegel");
            base.Stuur(graden);
        }

        public void LaadLeeg()
        {
        }
    }
}