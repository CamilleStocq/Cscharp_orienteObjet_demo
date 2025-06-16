namespace demo_Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //option1
           //Animal opossum = new Walking ("Ellie");
           //Console.WriteLine(opossum);
           // opossum.SeDeplacer();

           // Animal clown = new Swimming("Némo");
           // Console.WriteLine(clown);
           // clown.SeDeplacer();

           // Animal Serpent = new Animal("Kaha");
           // Console.WriteLine(Serpent);
           // Serpent.SeDeplacer();

            //option2 en utilisant la liste
            List<Animal> zoo = new List<Animal>()
            {
                new Walking("Ellie"),
                new Swimming("Némo"),
                new Animal("Kaha"),
            };

            foreach (Animal a in zoo) 
            {
                Console.WriteLine(a);
                a.SeDeplacer();
            }

        }
    }
}
