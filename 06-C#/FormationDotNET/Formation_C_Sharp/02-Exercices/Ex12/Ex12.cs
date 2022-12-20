Console.WriteLine("*** Dans quelle catégorie se trouve votre enfant ? ***");

Console.WriteLine("Veuillez saisir l'âge de votre enfant :");

int age = Convert.ToInt32(Console.ReadLine());

if (age < 3)
{
    Console.WriteLine("Votre enfant est trop jeune !");
}
else
    if (age >= 3 && age <= 6)
{
    Console.WriteLine("Votre enfant est dans la catégorie Baby !");
}
else
    if (age >= 7 && age <= 8)
{
    Console.WriteLine("Votre enfant est dans la catégorie Poussin !");
}
else
    if (age >= 9 && age <= 10)
{
    Console.WriteLine("Votre enfant est dans la catégorie Pupille !");
}
else
    if (age >= 11 && age <= 12)
{
    Console.WriteLine("Votre enfant est dans la catégorie Minime !");
}
else
    if (age >= 13 && age <= 18)
{
    Console.WriteLine("Votre enfant est dans la catégorie Cadet !");
}
else
    if (age > 18)
{
    Console.WriteLine("Votre enfant est trop vieux pour les catégories enfants !");
}



Console.WriteLine("Press ENTER to exit...");
Console.Read();