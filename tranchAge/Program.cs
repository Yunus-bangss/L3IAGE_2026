// See https://aka.ms/new-console-template for more information
///Declaration des variables 
int age = 0;
bool rep = false;

Console.WriteLine("Ce programme permet de definir votre tranche d'age");
do {

    ///Recuperation de l'age
    Console.Write("Veuillez entrer votre age : ");
    age = int.Parse(Console.ReadLine());
    ///Condition pour definir la tranche d'age
    if (age < 0)
    {
        Console.WriteLine("Age invalide");
    }
    else if (age <= 12)
    {
        Console.WriteLine("Vous etes un enfant");
    }
    else if (age <= 19)
    {
        Console.WriteLine("Vous etes un adolescent");
    }
    else if (age <= 64)
    {
        Console.WriteLine("Vous etes un adulte");
    }
    else
    {
        Console.WriteLine("Vous etes un senior");
    }
    Console.WriteLine("Voulez vous recommencer.......");
    rep = (Console.ReadLine().ToLower() == "o");

} while (rep);

