
using LesRegex.Classes;

string test = "Benjamin";
Console.WriteLine(Tools.IsName(test));
Console.WriteLine("--------------------------");

string phone = "+33 6 10 11 12 13";
string phone2 = "33.6.14.85.96.32";
string phone3 = "33-6-14-85-96-32";
string phone4 = "+33 6 14 85 96 32";
string phone5 = "+33.6.14.85.96.32";
string phone6 = "+33-6-14-85-96-32";
string phone7 = "06 14 85 96 32";
string phone8 = "0614859632";

Console.WriteLine(Tools.IsPhone(phone));
Console.WriteLine(Tools.IsPhone(phone2));
Console.WriteLine(Tools.IsPhone(phone3));
Console.WriteLine(Tools.IsPhone(phone4));
Console.WriteLine(Tools.IsPhone(phone5));
Console.WriteLine(Tools.IsPhone(phone6));
Console.WriteLine(Tools.IsPhone(phone7));
Console.WriteLine(Tools.IsPhone(phone8));
Console.WriteLine("--------------------------");

Personne p = new();
p.Firstname = "Benjamin";
p.Lastname = "Brugghe";
p.Email = "What.ev-er45@email.com";
p.Telephone = phone8;

Console.WriteLine(p.Telephone);
Console.WriteLine(p.Email);

Console.WriteLine("--------------------------");

Console.WriteLine(Tools.FormatPhone("06.10.11.12-13"));

Console.WriteLine("\nPress ENTER to exit...");
Console.Read();