Console.WriteLine("*** Quelle sera le montant de l'indemnité de licenciement ? ***");

int salaire;
int age;
int anciennete;
int indemnite = 0;
int bonus = 0;
int total;

Console.WriteLine("Veuillez saisir le dernier salaire (en Euros) : ");
salaire = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veuillez saisir votre âge : ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veuillez saisir le nombre d'années d'ancienneté : ");
anciennete = Convert.ToInt32(Console.ReadLine());

if (anciennete <= 10)
{
    indemnite = (salaire / 2) * anciennete;
}
else if (anciennete > 10)
{
    indemnite = ((salaire / 2) * 10) + ((anciennete - 10) * salaire);
}

if (age >= 46 && age <= 49)
{
    bonus = (2 * salaire);
}
else if (age > 50)
{
    bonus = (5 * salaire);
}

total = indemnite + bonus;

Console.WriteLine($"Votre indemnité est de : {total} Euros");




//
Console.WriteLine("Press ENTER to exit...");
Console.Read();