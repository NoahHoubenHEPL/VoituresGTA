namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard"};

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine((i+1) + ". " + cars[i]);
        }
        Console.WriteLine("");
        Console.WriteLine("Quel est le nombre de la voiture que vous voulez remplacer?");
        int carSpot = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Quel est le nom de la nouvelle voiture?");
        cars[carSpot-1] = Console.ReadLine();
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + cars[i]);
        }
    }
}