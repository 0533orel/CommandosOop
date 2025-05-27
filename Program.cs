using CommandosOop.Models;

namespace CommandosOop
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("m-16", "KOLT", 10);
            Commando commando = new Commando("orel", "Od");
            AirCommando airCommando = new AirCommando("Nati", "Nk");
            SeaCommando seaCommando = new SeaCommando("Arye", "Ae");
            
        }
    }
}