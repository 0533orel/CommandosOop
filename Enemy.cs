using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public class Enemy
    {
        public string Name;
        protected int HealthBar = 100;
        protected string LifeStatus = "alive";

        public Enemy(string name)
        {
            Name = name;
        }

        public string GetLifeStatus()
        {
            if (HealthBar > 0)
                return "alive";
            else
                return "dead";
        }

        public void Yell()
        {
            Console.WriteLine("I'm enemy!!!");
        }
    }
}
