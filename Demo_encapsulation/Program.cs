using Demo_encapsulation.models;

namespace Demo_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login monLogin = new Login();

            monLogin.email = "blabla.com";
            monLogin.ChangePassword("popo\r");
            
            Console.WriteLine("veuillez introduire votre email");
            string email = Console.ReadLine();

            Console.WriteLine("veuillez entrer votre mdp");

            ConsoleKeyInfo keyinfo;

            string password = "";
            do
            {
                keyinfo = Console.ReadKey(true);
                password += keyinfo.KeyChar;
                Console.Write("*");

            }
            while (keyinfo.Key != ConsoleKey.Enter);

            bool isConnected = monLogin.CheckUser(email,password);

            if (isConnected)
            {
                Console.WriteLine("connecté");
            }
            else
            {
                Console.WriteLine("bloqué ");
            }
        }
    }
}
