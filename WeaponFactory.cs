using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public static class WeaponFactory
    {
        private static Random Random = new Random();

        private static List<string> weaponsNames = new List<string>
        {
            "M16",
            "AK-47",
            "Glock 17",
            "Uzi",
            "MP5",
            "M4A1",
            "Desert Eagle",
            "FN SCAR",
            "Beretta M9",
            "Remington 870"
        };       

        public static List<Weapon> Weapons(int numberOfWeapons)
        {
            List<Weapon> weapons = new List<Weapon>();
            for (int i = 1; i <= numberOfWeapons; i++)
            {
                weapons.Add(new Weapon(weaponsNames[Random.Next(0, weaponsNames.Count - 1)], "israel", 100));
            }
            return weapons;
        }

    }
}
