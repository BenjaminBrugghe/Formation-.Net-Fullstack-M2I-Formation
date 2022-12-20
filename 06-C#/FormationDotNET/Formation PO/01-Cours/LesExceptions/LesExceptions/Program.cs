using LesExceptions.Classes;

double a = 0, b = 0, result = 0;

Console.WriteLine("********** LES EXCEPTIONS **********");

Console.WriteLine("Veuillez saisir un nombre à diviser : ");

while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("\nErreur de saisie !");
}

Console.WriteLine("Veuillez saisir un nombre diviseur : ");

while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("\nErreur de saisie !");
}

try
{
    result = ExceptionsTest.SafeDivision(a, b);
    Console.WriteLine($"{a} divisé par {b} est égal à : {result}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("'Finally' s'execute quelque soit l'issue du Try/Catch");
}





Console.WriteLine("\nPress ENTER to exit...");
Console.Read();