using Demo_Class.models;

namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture()
            {
                couleur = "rose",
                imattriculation = "2-ABC-123",
                nbRoues = 4
            };

            Voiture laFraise = maFerrari;

            Console.WriteLine($"voici ma voiture {maFerrari.couleur}, immatriculée, {maFerrari.imattriculation}.");

            Console.WriteLine($"voici la voiture de ma fille, c'est une ferrari {maFerrari.couleur}, immatriculée, {maFerrari.imattriculation}.");

            Console.WriteLine($"je roule à pleine vitesse avec mes {maFerrari.nbRoues} roues de ma voitures");

            Console.WriteLine($"Boummm !!!!!!!!!");

            maFerrari.nbRoues--;

            Console.WriteLine($"Ma voiture à maintenant {maFerrari.nbRoues}roues");
            Console.WriteLine($"La voiture de ma fille à maintenant {maFerrari.nbRoues}roues");
        }
    }
}
