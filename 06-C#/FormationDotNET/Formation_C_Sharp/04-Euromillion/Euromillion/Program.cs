


Random aleatoire = new Random();
int nbMystere = 0;
int nbMystere2 = 0;

Console.WriteLine("********** EUROMILLION **********\n");

for (int i = 0; i < 5; i++)
{
    nbMystere = aleatoire.Next(1, 51);
    Console.WriteLine(nbMystere);
}

Console.WriteLine("**********************************");

for (int i = 0; i < 2; i++)
{
    nbMystere2 = aleatoire.Next(1, 13);
    Console.WriteLine(nbMystere2);
}

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();