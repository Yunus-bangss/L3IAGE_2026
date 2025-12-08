using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome
/// <summary>
/// Programme pour s'initier en csharp
/// </summary>
{
    internal class Program
        ///Methode de depart
    {
        static void Main(string[] args)
        {
            ///Declaration des variable nom,prenom, et email
            string nom, prenom, email;
            bool rep = false;

            Console.WriteLine("Bienvenue dans le monde du C#");
            do
            {
                Console.WriteLine("Donner votre nom : ");
                nom = Console.ReadLine();

                Console.WriteLine("Donner votre prenom : ");
                prenom = Console.ReadLine();

                Console.WriteLine("Donner votre email : ");
                email = Console.ReadLine();

                Console.WriteLine("Bonjour " + prenom + " " + nom + ", votre email est : " + email);

                Console.WriteLine("Voulez-vous recommencer ? (o/n) : ");
                rep = (Console.ReadLine().ToLower() == "o");

            } while (rep);

            
        }
    }
}
