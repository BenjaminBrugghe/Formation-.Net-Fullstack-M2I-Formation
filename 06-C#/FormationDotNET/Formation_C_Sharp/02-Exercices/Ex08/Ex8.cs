decimal prixHT;
decimal TVA;

Console.WriteLine("Veuillez entrer le prix HT de l'objet : ");
prixHT = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Veuillez entrer le taux de TVA : ");
TVA = Convert.ToDecimal(Console.ReadLine());

decimal montantTVA = prixHT * TVA/100;

decimal prixTTC = prixHT + montantTVA;

Console.WriteLine($"Le montant de la TVA est de : {montantTVA} Euros");
Console.WriteLine($"Le prix TTC de l'objet est de : {prixTTC} Euros");


Console.WriteLine("Press ENTER to exit...");
Console.Read();