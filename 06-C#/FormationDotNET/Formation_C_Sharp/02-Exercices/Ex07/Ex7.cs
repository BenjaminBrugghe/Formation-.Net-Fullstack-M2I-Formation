float cote1;
float cote2;

Console.WriteLine("Veuillez saisir la longueur du premier côté: ");
cote1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veuillez saisir la longueur du deuxième côté : ");
cote2 = Convert.ToInt32(Console.ReadLine());

float hypothenuse = (float)Math.Sqrt(cote1 * cote1 + cote2 * cote2);

Console.WriteLine($"La longueur de l'hypothènuse est de : {hypothenuse} cm");


Console.WriteLine("Press ENTER to exit...");
Console.Read();