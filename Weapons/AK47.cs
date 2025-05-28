using CommandosOop.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Weapons
{
    public class AK47 : Firearms
    {
        public AK47()
        {
            Name = "AK47";
            Manufacturer = "KALASHNIKOV";
            NumberOfBullets = 30;
        }
    }
}
