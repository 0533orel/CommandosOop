using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int NumberOfBullets;

        public Weapon(string name, string manufacturer, int numberOfBullets)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            if (NumberOfBullets > 0)
            {
                NumberOfBullets--;
                Console.WriteLine("Shooting");
            }
            else
                Console.WriteLine("Empty ammu");
        }
    }
}
