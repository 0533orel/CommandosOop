using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosOop.Models
{
    public class Commando
    {
        private string _name;
        public string CodeName { get; set; }
        protected List<string> Tools = new List<string> { "hammer", "Chisel", "rope", "bag", "watery" };
        protected string Status = "";

        public Commando(string name, string codeName)
        {
            _name = name;
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

        public virtual void Attack()
        {
            Console.WriteLine("Ground commando soldier attacks");
        }


        public void SayName(string commanderRank)
        {
            if (commanderRank.ToUpper() == "GENERAL")
                Console.WriteLine(_name);
            else if (commanderRank.ToUpper() == "COLONEL")
                Console.WriteLine(CodeName);
            else
                Console.WriteLine("This information is classified.");
        }
    }
}
