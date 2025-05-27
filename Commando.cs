using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public class Commando
    {
        public string Name;
        public string CodeName;
        protected List<string> Tools = new List<string> { "hammer", "Chisel", "rope", "bag", "watery" };
        protected string Status = "";

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
        }

        public void Walk()
        {
            Status = "Going";
            Console.WriteLine($"The soldier is {Status}");
        }

        public void Hide()
        {
            Status = "Hiding";
            Console.WriteLine($"The soldier is {Status}");
        }

        public void Attack()
        {
            Console.WriteLine($"Commando with a code name {CodeName} is attacking");
        }
    }
}
