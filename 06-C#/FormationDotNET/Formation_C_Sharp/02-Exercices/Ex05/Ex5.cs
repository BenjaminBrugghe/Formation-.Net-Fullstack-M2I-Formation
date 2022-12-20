// See https://aka.ms/new-console-template for more information

decimal nb1;
decimal nb2;

Console.WriteLine("Veuillez saisir un premier nombre : ");
nb1= Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Veuillez saisir un deuxième nombre : ");
nb2= Convert.ToDecimal(Console.ReadLine());

decimal nb3 = nb1 + nb2;

Console.WriteLine("La somme de ces deux nombres est de : " + nb3);


Console.WriteLine("Press ENTER to exit...");
Console.Read();