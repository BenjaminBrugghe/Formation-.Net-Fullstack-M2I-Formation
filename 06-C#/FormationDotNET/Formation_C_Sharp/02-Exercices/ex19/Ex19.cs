Console.WriteLine("*** Quel sera le montant de vos impôts ? ***");

int netImposable;
int nbAdultes;
int nbEnfants;
int nbParts;
int montant;
double impots = 0;

Console.WriteLine("Entrer le montant net imposable (en Euros) : ");
netImposable = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrer le nombre d'adultes : ");
nbAdultes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrer le nombre d'enfants : ");
nbEnfants = Convert.ToInt32(Console.ReadLine());

nbParts = nbAdultes + (nbEnfants - 1);
montant = netImposable / nbParts;

switch (montant)
{
    case <= 10084:
        impots = 0;
        break;

    case int n when n >= 10084 && n <= 25710:
        impots = ((montant - 10084) * 0.11);
        break;
    case int n when n >= 25710 && n <= 73516:
        impots = ((montant - 10084) * 0.11) + ((montant - 25710) * 0.30);
        break;
    case int n when n >= 73516 && n <= 158122:
        impots = ((montant - 10084) * 0.11) + ((montant - 25710) * 0.30) + ((montant - 73516) * 0.45);
        break;

    default:
        break;
}
Console.WriteLine($"Vous allez payer {Math.Round(impots * nbParts, 0)} euros.");

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();