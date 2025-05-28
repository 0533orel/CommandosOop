using CommandosOop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Abstracts
{
    public abstract class ColdWeapon
    {
        protected string Name;
        protected int Weight;
        protected string Color;
        protected string Status = "Whole";
    }
}
