using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    class Brommer : Voertuig
    {
        public Brommer() : base(ConsoleColor.DarkRed)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De brommer rijdt...", ConsoleColor.Cyan);
        }

        public override void Stuur(int graden)
        {
            base.Stuur(graden);
        }
    }
}
