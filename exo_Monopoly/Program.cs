using exo_Monopoly.Enums;

namespace exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CasePropriete[] cases = //créations des cases avec leurs différentes variables
            {
                new CasePropriete("Patio", Couleurs.Marron, 20),
                new CasePropriete("Accueil", Couleurs.Marron, 23),

                new CasePropriete("Ascenceur Gauche", Couleurs.BleuCiel, 26),
                new CasePropriete("Ascenceur Droit", Couleurs.BleuCiel, 26),
                new CasePropriete("Toilette RDC", Couleurs.BleuCiel, 30),

                new CasePropriete("Couloir 4ième étage", Couleurs.Violet, 32),
                new CasePropriete("Couloir 5ième étage", Couleurs.Violet, 32),
                new CasePropriete("Toilette 5ième étage", Couleurs.Violet, 38),

                new CasePropriete("Classe des WAD", Couleurs.Orange, 42),
                new CasePropriete("Classe des WEB", Couleurs.Orange, 42),
                new CasePropriete("Classe des Games", Couleurs.Orange, 48),

                new CasePropriete("Bureau Sonia", Couleurs.Bleu, 56),
                new CasePropriete("Bureau Nicole", Couleurs.Bleu, 56),
                new CasePropriete("Bureau Laure", Couleurs.Bleu, 60)

            };

            Jeu monopoly = new Jeu(cases); // creation du jeu dans le programme

            Console.WriteLine($"Votre plateau compte {monopoly.Plateau.Length} cases.");

            int nbJoueurs;
            do Console.WriteLine("Combien de joueur jouent ? (entre 2 t 6 joueurs) :");
            while (!int.TryParse(Console.ReadLine(), out nbJoueurs) || nbJoueurs < 2 || nbJoueurs > 6); // pour savoir le nombre de joueurs ( on doit en avoir entre 2 et 6 . si pas on redemande 

            do
            {
                Console.WriteLine("Entrez votre nom");
                string userName = Console.ReadLine();

                Console.WriteLine($"Creation d'un joueur. Choisir un pion: ");
                string[] pionNames = Enum.GetNames<Pions>();// on va chercher les pions dans l'enum

                foreach (string pionName in pionNames) // choix du pion
                {
                    Console.WriteLine($"\t- {pionName}");
                }

                Console.WriteLine($"Quel pion choisissez vous ? ");
                string userInput = Console.ReadLine();

                Pions choice = Enum.Parse<Pions>(userInput); // associe le pion et le joueur (recoit les deux infos)

                monopoly.AjouterJoueur(userName, choice); // ajout du joueur avec son nom et son pion dans le jeu

                Joueur j1 = new Joueur(userName, choice);

            } while (monopoly.Joueurs.Length < nbJoueurs);

            int tourJoueur = 0;
            while (tourJoueur < 40)
            {
                Joueur joueurActuel = monopoly.Joueurs[tourJoueur % monopoly.Joueurs.Length];
                CasePropriete caseActuel = monopoly[joueurActuel.Position]; //permet de recuperer la case sur laquelle mon joueur se trouve


                Console.WriteLine($"Le joueur {joueurActuel.Nom} avec le pion {joueurActuel.Pion} se trouve à la case {caseActuel.Nom}.");

                bool isDouble = joueurActuel.Avancer();

                //CasePropriete caseActuel = monopoly[joueurActuel.Position]; 
                while (isDouble) // pour savoir si le joueur fait un double et lui faire relancer les dé si c'est le cas sinon il sort de la boucle
                {
                    Console.WriteLine("Vous avez obtenu un double !!! Relancer le dé.");

                    joueurActuel = joueurActuel + 200;

                    Console.WriteLine($"Le joueur {joueurActuel.Nom} avec le pion {joueurActuel.Pion} se trouve à la case {caseActuel.Nom}.");
                    isDouble = joueurActuel.Avancer();
                    caseActuel = monopoly[joueurActuel.Position];
                }
                Console.WriteLine($"Le joueur {joueurActuel.Nom} avec le pion {joueurActuel.Pion} se trouve à la case {caseActuel.Nom}.");
                
                tourJoueur++; // pour permettre de changer de joueur 
            }


        }
    }
}