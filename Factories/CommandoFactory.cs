using CommandosOop.Models;
using CommandosOop.Soldiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Factories
{
    public static class CommandoFactory
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

        private static List<string> jewishNames = new List<string>
        {
            "Abraham",
            "Isaac",
            "Jacob",
            "David",
            "Solomon",
            "Elijah",
            "Moses",
            "Aaron",
            "Samuel",
            "Isaiah",
            "Menachem",
            "Zvi",
            "Judah",
            "Chaim",
            "Reuben",
            "Benjamin",
            "Meir",
            "Nachum",
            "Elazar",
            "Shimon"
        };

        private static List<string> codeNames = new List<string>
        {
            "Shadow",
            "Falcon",
            "Viper",
            "Phantom",
            "Ghost",
            "Thunder",
            "Eclipse",
            "Titan",
            "Specter",
            "Blaze",
            "Reaper",
            "Nova",
            "Orion",
            "Hunter",
            "Cobra",
            "Raven",
            "Cyclone",
            "Scorpion",
            "Kraken",
            "Saber"
        };


        public static List<Commando> Commandos(string typeOfSoldier, int numOfSoldiers)
        {
            List<Commando> commandos = new List<Commando>();
            switch (typeOfSoldier.ToLower())
            {
                case "commando":
                    for (int i = 1; i <= numOfSoldiers; i++)
                    {
                        commandos.Add(new Commando(jewishNames[Random.Next(0, jewishNames.Count - 1)], codeNames[Random.Next(0, jewishNames.Count - 1)]));
                    }
                    break;
                case "air":
                    for (int i = 1; i <= numOfSoldiers; i++)
                    {
                        commandos.Add(new AirCommando(jewishNames[Random.Next(0, jewishNames.Count - 1)], codeNames[Random.Next(0, jewishNames.Count - 1)]));
                    }
                    break;
                case "sea":
                    for (int i = 1; i <= numOfSoldiers; i++)
                    {
                        commandos.Add(new SeaCommando(jewishNames[Random.Next(0, jewishNames.Count - 1)], codeNames[Random.Next(0, jewishNames.Count - 1)]));
                    }
                    break;
            }
            return commandos;

        }

        //public static List<Commando> Commandos(int numberOfEnemies)
        //{
        //    List<Commando> commandos = new List<Commando>();
        //    for (int i = 1; i <= numberOfEnemies; i++)
        //    {
        //        commandos.Add(new Commando(jewishNames[Random.Next(0, jewishNames.Count - 1)], codeNames[Random.Next(0, jewishNames.Count - 1)]));
        //    }
        //    return commandos;
        //}

        //public static List<AirCommando> airCommandos(int numberOfEnemies)
        //{
        //    List<AirCommando> commandos = new List<AirCommando>();
        //    for (int i = 1; i <= numberOfEnemies; i++)
        //    {
        //        commandos.Add(new AirCommando(jewishNames[Random.Next(0, jewishNames.Count - 1)], codeNames[Random.Next(0, jewishNames.Count - 1)]));
        //    }
        //    return commandos;
        //}

        //public static List<SeaCommando> seaCommandos(int numberOfEnemies)
        //{
        //    List<SeaCommando> commandos = new List<SeaCommando>();
        //    for (int i = 1; i <= numberOfEnemies; i++)
        //    {
        //        commandos.Add(new SeaCommando(jewishNames[Random.Next(0, jewishNames.Count - 1)], codeNames[Random.Next(0, jewishNames.Count - 1)]));
        //    }
        //    return commandos;
        //}

    }
}
