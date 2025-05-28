using CommandosOop.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Weapons
{
    internal class Knife : ColdWeapon
    {
        private string MetalType = "iron";
        private string Manufacturer = "israel";
        public Knife()
        {
            Name = "Knife";
            Color = "Black";
            Weight = 1;
        }
    }
}
