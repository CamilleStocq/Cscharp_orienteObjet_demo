using Demo_abstract;

namespace Demo_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> pnj = new List<Animal>()
           {
               new Chien ("rouky"),
               new Pigeons ("Bob"),
               new Poule ("Ginger"),
               new Mesanges ("Le piaf")
           };
            Console.Write("En me promenant, j'ai entendu ");
            pnj[new Random().Next(pnj.Count)].Crier();
        }
    }
}
