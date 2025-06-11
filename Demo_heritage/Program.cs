namespace Demo_heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme f = new Forme("Rose", 2);

            Rectangle r = new Rectangle("jaune", 3, 5, 4);

            Cercle c = new Cercle("vert" , 5 , 4); 
            
            Carre c2 = new Carre("bleu", 5, 1);
        }
    }
}
