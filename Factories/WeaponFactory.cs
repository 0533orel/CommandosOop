using CommandosOop.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Factories
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

        public static List<Firearms> Weapons(int numberOfWeapons)
        {
            List<Firearms> weapons = new List<Firearms>();
            for (int i = 1; i <= numberOfWeapons; i++)
            {
                weapons.Add((Firearms)new Weapon(weaponsNames[Random.Next(0, weaponsNames.Count - 1)], "israel", 100));
            }
            return weapons;
        }

    }
}
