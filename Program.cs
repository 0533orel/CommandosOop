using CommandosOop.Models;

namespace CommandosOop
{
    class Program
    {
        static void Main()
        {
            Commando commando = new Commando("orel", "Od");
            Weapon weapon = new Weapon("m-16", "KOLT", 10);
            AirCommando airCommando = new AirCommando("Nati", "Nk");
            
        }
    }
}