using CommandosOop.Abstracts;
using CommandosOop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Weapons
{
    internal class Stone : ColdWeapon, IBreakable
    {
        private int BeatsLeft = 5;
        private int BeatenBlows = 0;
        public Stone()
        {
            Name = "Stone";
            Weight = 2;
            Color = "White";
        }

        public void GetStatus()
        {
            if(BeatsLeft > 0)
                Console.WriteLine(Status);
            else
            {
                Status = "Broken";
                Console.WriteLine(Status);
            }
        }

        public void GetBeatsLeft()
        {
            Console.WriteLine(BeatsLeft);
        }

        public void GetBeatenBlows()
        {
            Console.WriteLine(BeatenBlows);
        }
    }
}
