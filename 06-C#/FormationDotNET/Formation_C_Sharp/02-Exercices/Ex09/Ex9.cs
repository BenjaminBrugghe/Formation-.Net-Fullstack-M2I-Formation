double CapitalDepart;
double Taux;
double Duree;

Console.WriteLine("Entrer le capital de départ : ");
CapitalDepart = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrer le taux d'intérêt : ");
Taux = Convert.ToDouble(Console.ReadLine());
double TauxModif = 1 + (Taux / 100);

Console.WriteLine("Entrer la durée de l'épargne: ");
Duree = Convert.ToDouble(Console.ReadLine());

double interets = Convert.ToDouble(CapitalDepart) * (Convert.ToDouble(Math.Pow(TauxModif, Duree))) - CapitalDepart;
double CapitalFinal = Convert.ToDouble(CapitalDepart + interets);

Console.WriteLine($"Le montant des intérêts sera de {interets} Euros");
Console.WriteLine($"Le capital final sera de {CapitalFinal} Euros après {Duree} années");

Console.WriteLine("Press ENTER to exit...");
Console.Read();