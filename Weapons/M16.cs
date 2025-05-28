using CommandosOop.Abstracts;
using CommandosOop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Weapons
{
    public class M16 : Firearms 
    {
        public M16()
        {
            Name = "M16";
            Manufacturer = "COLT";
            NumberOfBullets = 29;
        }

        
    }
}
