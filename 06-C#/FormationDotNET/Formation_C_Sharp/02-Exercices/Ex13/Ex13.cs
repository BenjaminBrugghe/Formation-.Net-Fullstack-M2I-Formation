decimal AB;
decimal BC;
decimal AC;

Console.WriteLine("Veuillez saisir la longueur du segment AB : ");
AB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Veuillez saisir la longueur du segment BC : ");
BC = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Veuillez saisir la longueur du segment AC : ");
AC = Convert.ToDecimal(Console.ReadLine());

if (AB == BC && AB == AC)
{
    Console.WriteLine("Le triangle est équilatéral !");
}
else if (AB == BC)
{
    Console.WriteLine("Le triangle est isocèle en B");
}
else if (BC == AC)
{
    Console.WriteLine("Le triangle est isocèle en C");
}
else if (AB == AC)
{
    Console.WriteLine("Le triangle est isocèle en A");
}
else
{
    Console.WriteLine("Le triangle n'est pas isocèle !");
}


//
Console.WriteLine("Press ENTER to exit...");
Console.Read();