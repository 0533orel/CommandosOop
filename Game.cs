using CommandosOop.Abstracts;
using CommandosOop.Factories;
using CommandosOop.Soldiers;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public class Game
    {
        public List<Commando> Commandos = new List<Commando>();
        public List<Firearms> Weapons = new List<Firearms>();
        public List<Enemy> Enemies = new List<Enemy>();

        public Game()
        {
            Commandos.AddRange(CommandoFactory.Commandos("commando", 5));
            Enemies.AddRange(EnemyFactory.Enemies(5));
            Weapons.AddRange(WeaponFactory.Weapons(5));
        }

        public void AddCommandos(string typeOfSoldier, int numOfSoldiers)
        {
            Commandos.AddRange(CommandoFactory.Commandos(typeOfSoldier, numOfSoldiers));
        }

        public void AddEnemy(int numberOfEnemies)
        {
            Enemies.AddRange(EnemyFactory.Enemies(numberOfEnemies));
        }

        public void AddWeapons(int numberOfEnemies)
        {
            Weapons.AddRange(WeaponFactory.Weapons(numberOfEnemies));
        }







        //public Game()
        //{
        //    bool finish;
        //    do
        //    {
        //        Console.WriteLine("What type of soldiers do you want to create? \n" +
        //        "1. commando \n" +
        //        "2. air commando \n" +
        //        "3. sea commando");
        //        int typeSoldier = int.Parse(Console.ReadLine()!);

        //        Console.WriteLine("How many of them?");
        //        int amountSoldiers = int.Parse(Console.ReadLine()!);
        //        Commandos.AddRange(CommandoFactory.Commandos(typeSoldier, amountSoldiers));

        //        Console.WriteLine("Would you like to choose another type? (yes/no)");
        //        string answer = Console.ReadLine()!;
        //        if (answer.ToLower() == "yes")
        //            finish = false;
        //        else
        //            finish = true;
        //    }while(!finish);

        //    Console.WriteLine("How many weapons would you like?");
        //    int amoutWeapons = int.Parse(Console.ReadLine()!);
        //    Weapons.AddRange(WeaponFactory.Weapons(amoutWeapons));

        //    Console.WriteLine("How many enemies to create?");
        //    int amountEnemy = int.Parse(Console.ReadLine()!);
        //    Enemies.AddRange(EnemyFactory.Enemies(amountEnemy));
        //}
    }
}
