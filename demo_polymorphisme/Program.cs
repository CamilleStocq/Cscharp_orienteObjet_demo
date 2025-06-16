namespace demo_polymorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur player = new Joueur();

            InventaireItem pepite = new InventaireItem("Pépite", 5000);

            player.Loot (pepite);

            Console.WriteLine("Inventaire :");

            foreach( InventaireItem item in player.InventaireItems)
            {
                Console.WriteLine($"\t {item.Nom}");
            }

            player.InventaireItems[0].Vendre(player);
            Console.WriteLine($"votre solde est de {player.Solde}");
        }
    }
}
