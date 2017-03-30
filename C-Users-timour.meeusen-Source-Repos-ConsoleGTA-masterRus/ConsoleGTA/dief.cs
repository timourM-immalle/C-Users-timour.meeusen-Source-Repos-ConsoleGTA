using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    class Dief : Persoon
    {
        public Dief() : base(ConsoleColor.DarkRed){ }

        public override void Lopen()
        {
            Console.WriteLine("Ik loop om te stelen");
        }

        public void Stelen(Voertuig voertuig)
        {
            Console.WriteLine("Ik heb een {0} gestolen, whoehahaha", voertuig);
        }
    }
}
