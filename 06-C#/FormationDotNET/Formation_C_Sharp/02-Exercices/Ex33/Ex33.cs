string[] alphabet;
alphabet = new string[26];

int i;
string space = "";
char ascii = Convert.ToChar(65);

#region Remplissage du tableau "alphabet"

for (i = 0; i < 26; i++)
{
    alphabet[i] = Convert.ToString(ascii);
    ascii++;
    Console.WriteLine($"{space}{alphabet[i]}");
    space += "  ";
}
#endregion

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();

// A 65
// Z 90