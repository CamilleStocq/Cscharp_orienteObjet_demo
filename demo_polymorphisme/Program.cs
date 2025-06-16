namespace demo_polymorphisme
{
    internal class Program
    {
        private static Equipement equipement;

        static void Main(string[] args)
        {
            Joueur player = new Joueur();

            /*Démo début
            InventaireItem pepite = new InventaireItem("Pépite", 5000);

            player.Loot(pepite);

            Console.WriteLine("Inventaire :");

            foreach (InventaireItem item in player.InventaireItems)
            {
                Console.WriteLine($"\t {item.Nom}");
            }

            player.InventaireItems[0].Vendre(player);
            Console.WriteLine($"votre solde est de {player.Solde}");

            Equipement epee = new Equipement("Epée de véroté", 10000, 2, 5);

            player.Loot(epee);
            if (player.InventaireItems[0] is Equipement equipementInventaire)
            {
                player.Equiper(equipementInventaire, true);
            }


            player.Equiper((Equipement)player.InventaireItems[0], true); */

            /*Démo avec coffres*/

            List<Coffre> coffres = new List<Coffre>();

            for (int i = 0; i < 5; i++)
            {
                coffres.Add(new Coffre([
                    new InventaireItem ("Pépites", 5000),
                    new InventaireItem ("Poussiere de diamant", 1000),
                    new InventaireItem ("Potions", 500),

                    new Equipement("Casque", 1200, 5,0),
                    new Equipement("Epée de vérité", 2500, 2, 5),
                    new Equipement("Masse du chatillement", 2200, 0, 8)
                    ]));
            }

            coffres.Add(new Coffre(new InventaireItem("Clé du donjon",0)));
            coffres.Add(new Coffre(new Equipement("Anneau de pouvoir", 0,10,10)));

            foreach (Coffre c in coffres)
            {
                player.Loot(c.Contenu);
                c.ViderCoffre();
            }


            while (player.InventaireItems.Length > 0)
            {
                Console.Clear();
                Console.WriteLine("Inventaire : ");
               for (int i = 0; i < player.InventaireItems.Length; i++)
                {
                    InventaireItem item = player.InventaireItems[i];
                    Console.WriteLine($"{i} - {item.Nom}");
                }
                Console.WriteLine($"Votre solde est de {player.Solde}");

                Console.WriteLine("Quel objet veux tu utiliser ?");

                int choix = int.Parse(Console.ReadLine());
                InventaireItem objetSelectionne = player.InventaireItems[choix];
                Console.Write("(v)endre");

                if (objetSelectionne is Equipement)
                {
                    Console.WriteLine("(e)quiper");
                }

                switch (Console.ReadKey().KeyChar)
                {
                    case 'v':
                        objetSelectionne.Vendre(player);
                        break;

                    case 'e':
                        if (objetSelectionne is Equipement)
                        {
                            player.Equiper(equipement, true);
                        }
                        break;
                } 
            }

        }
    }
}
