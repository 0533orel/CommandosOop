using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }

        public void CanParachute()
        {
            Console.WriteLine("the soldier can parachute");
        }

        public override void Attack()
        {
            Console.WriteLine("Air commando soldier attacks");
        }
    }
}
