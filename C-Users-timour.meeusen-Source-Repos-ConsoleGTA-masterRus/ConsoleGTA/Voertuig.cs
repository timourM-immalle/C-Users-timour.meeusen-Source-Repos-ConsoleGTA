using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    class Voertuig
    {
        private ConsoleColor kleur;

        public Voertuig(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }

        public virtual void Rij()
        {
            Console2.WriteLine("Het {{voertuig}} rijdt...", ConsoleColor.White, kleur);
        }

        public virtual void Stuur(int graden)
        {
            Console.WriteLine("Ik stuur " + graden + "graden");
        }
    }
}