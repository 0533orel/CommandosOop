using CommandosOop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Abstracts
{
    public abstract class Firearms : IShootable
    {
        protected string Name;
        protected string Manufacturer;
        protected int NumberOfBullets;


        public void Shoot()
        {
            if (NumberOfBullets > 0)
            {
                NumberOfBullets--;
                Console.WriteLine("Boooooom");
            }
            else
                Console.WriteLine("Empty ammu");
        }

        public void Ammu()
        {
            Console.WriteLine($"You have {NumberOfBullets} in your gun");
        }
    }
}
