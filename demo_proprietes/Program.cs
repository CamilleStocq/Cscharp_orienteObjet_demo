namespace demo_proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();

            p1.Prenom = "Camille";
            p1.Nom = "stocq";

            Console.WriteLine($"bonjour je suis {p1.Prenom} {p1. Nom}");
        }
        
    }
}

