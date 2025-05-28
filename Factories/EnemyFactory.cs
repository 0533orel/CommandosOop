using CommandosOop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Factories
{
    public static class EnemyFactory
    {
        private static Random Random = new Random();

        private static List<string> arabicNames = new List<string>
        {
            "Ahmad",
            "Mohammed",
            "Ali",
            "Omar",
            "Hassan",
            "Hussein",
            "Ibrahim",
            "Khalid",
            "Youssef",
            "Mustafa",
            "Samir",
            "Nasser",
            "Tariq",
            "Salim",
            "Zaid",
            "Bilal",
            "Karim",
            "Anas",
            "Faisal",
            "Imad"
        };
       
        public static List<Enemy> Enemies(int numberOfEnemies)
        {

            List<Enemy> enemies = new List<Enemy>();
            for (int i = 1; i <= numberOfEnemies; i++)
            {
                enemies.Add(new Enemy(arabicNames[Random.Next(0, arabicNames.Count - 1)]));
            }
            return enemies;

        }

    }
}
