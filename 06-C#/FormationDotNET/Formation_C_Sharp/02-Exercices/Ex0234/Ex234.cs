// See https://aka.ms/new-console-template for more information

string nom;
string prenom;
int age;


Console.WriteLine("Veuillez saisir votre nom : ");
nom = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre prénom : ");
prenom = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre age : ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Bonjour Mr.{prenom} {nom}, vous avez {age} ans.");



Console.WriteLine("Press ENTER to exit...");
Console.Read();