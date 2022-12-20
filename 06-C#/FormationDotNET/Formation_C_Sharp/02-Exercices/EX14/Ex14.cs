int taille;
int poids;

Console.WriteLine("Veuillez saisir votre taille (en cm) : ");
taille = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veuillez saisir votre poids 'en Kg) : ");
poids = Convert.ToInt32(Console.ReadLine());

if (taille >= 145 && taille <= 169 && poids >= 43 && poids <= 47)
{
    Console.WriteLine("Prenez la taille 1 !");
}
else if (taille >= 145 && taille <= 166 && poids >= 48 && poids <= 53)
{
    Console.WriteLine("Prenez la taille 1 !");
}
else if (taille >= 145 && taille <= 163 && poids >= 54 && poids <= 59)
{
    Console.WriteLine("Prenez la taille 1 !");
}
else if (taille >= 145 && taille <= 160 && poids >= 60 && poids <= 65)
{
    Console.WriteLine("Prenez la taille 1 !");
}


else if (taille >= 169 && taille <= 178 && poids >= 48 && poids <= 53)
{
    Console.WriteLine("Prenez la taille 2 !");
}
else if (taille >= 166 && taille <= 175 && poids >= 54 && poids <= 59)
{
    Console.WriteLine("Prenez la taille 2 !");
}
else if (taille >= 163 && taille <= 172 && poids >= 60 && poids <= 65)
{
    Console.WriteLine("Prenez la taille 2 !");
}
else if (taille >= 160 && taille <= 169 && poids >= 66 && poids <= 71)
{
    Console.WriteLine("Prenez la taille 2 !");
}


else if (taille >= 178 && taille <= 183 && poids >= 54 && poids <= 59)
{
    Console.WriteLine("Prenez la taille 3 !");
}
else if (taille >= 175 && taille <= 183 && poids >= 60 && poids <= 65)
{
    Console.WriteLine("Prenez la taille 3 !");
}
else if (taille >= 172 && taille <= 183 && poids >= 66 && poids <= 71)
{
    Console.WriteLine("Prenez la taille 3 !");
}
else if (taille >= 163 && taille <= 183 && poids >= 72 && poids <= 77)
{
    Console.WriteLine("Prenez la taille 3 !");
}
else
{
    Console.WriteLine("Aucune taille ne vous correspond");
}


//
Console.WriteLine("Press ENTER to exit...");
Console.Read();