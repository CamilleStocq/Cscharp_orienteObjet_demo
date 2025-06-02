//using Inventaire;
using nameSpace.Inventaire;

namespace nameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item objetInventaire = new Item();
            objetInventaire.Name = " poudre magique";
            objetInventaire.Value = 13;

            Console.WriteLine($"dans mon sac j'ai de la{objetInventaire.Name} de {objetInventaire.Value} de puissace!");
        }
    }
}

