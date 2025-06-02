using demo_static.models;

namespace demo_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            formation games = new formation()
            {
                nom = "Game25",
                eleves = new List<string>(["Camille, ..."])
            };

            formation.centre = "Interface3";

            formation wad = new formation()
            {
                nom = "Wad25",
                eleves = new List<string>(["a","b","c"])
            };

            games.Decrire();
            wad.Decrire();
          
        }
    }
}
