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

if (montant <= 10084)
{
    impots = 0;
}
else if (montant > 10084 && montant <= 25710)
{
    impots = ((montant-10084) * 0.11);
}
else if (montant > 25710 && montant <= 73516)
{
    impots = ((montant - 10084) * 0.11) + ((montant - 25710) * 0.30);
}
else if (montant > 73516 && montant <= 158122)
{
    impots = ((montant - 10084) * 0.11) + ((montant -25710) * 0.30) + ((montant - 73516) * 0.45);
}

Console.WriteLine($"Vous allez payer {Math.Round(impots * nbParts, 0)} euros.");




//
Console.WriteLine("Press ENTER to exit...");
Console.Read();

// nbParts = nbAdultes + (nbEnfants - 1)
// netImposable / nb parts
// calcul des taux
// taux * nbParts