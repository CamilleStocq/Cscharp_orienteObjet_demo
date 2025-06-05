namespace demo_proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();

            p1.Prenom = "Camille";
            p1.Nom = "stocq";
            p1.DateNaissance =  new DateOnly(2003,1,17);
            

            Console.WriteLine($"bonjour je suis {p1.Prenom} {p1. Nom}");
            Console.WriteLine($"j'ai {p1.Age} ans");
            p1.HB();
        }
        
    }
}

