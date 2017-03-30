using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGTA
{
    class Persoon
    {
        private ConsoleColor kleur;

        public Persoon(ConsoleColor kleur)
        {
            Console2.WriteLine("Ik ben een persoon", ConsoleColor.DarkBlue);
        }

        public virtual void Lopen()
        {
            Console.WriteLine("Ik loop door de stad");
        }
    }
}
