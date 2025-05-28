using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Soldiers
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        public void CanSwim()
        {
            Console.WriteLine("The soldier can swim");
        }

        public override void Attack()
        {
            Console.WriteLine("Sea commando soldier attacks");
        }
    }
}
