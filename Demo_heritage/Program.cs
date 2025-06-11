namespace Demo_heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme f = new Forme() 
            { 
                Color = "Rose", 
                BorderWidth = 2 
            };

            Rectangle r = new Rectangle() 
            { 
                Color = "Jaune", 
                Largeur = 3,
                Longueur = 5, 
                BorderWidth = 4
            };

            Cercle c = new Cercle() 
            { 
                Color = "Vert", 
                Rayon = 5, 
                BorderWidth = 3
            };
        }
    }
}
