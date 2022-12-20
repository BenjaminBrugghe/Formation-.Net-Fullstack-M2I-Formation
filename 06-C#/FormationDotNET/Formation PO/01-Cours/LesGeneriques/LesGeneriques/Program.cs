using LesGeneriques.Classes;

#region Class Opération<T>

Console.WriteLine("***** Les éléments génériques *****");
Console.WriteLine("Avec les types int : ");
Operations<int> obj1 = new();
Console.WriteLine(obj1.EstEquivalent(2,2));

Console.WriteLine("\nAvec les types double : ");
Operations<double> obj2 = new();
Console.WriteLine(obj2.EstEquivalent(2.23, 1.56));

Console.WriteLine("\nAvec les types string : ");
Operations<string> obj3 = new();
Console.WriteLine(obj3.EstEquivalent("Bonjour", "Bonjour"));

#endregion

#region Les queues<T>  => FIFO (1st in, 1st out)

Console.WriteLine("\n***** La class Queue<T> *****");
Console.WriteLine("Avec les types int : ");
Queue<int> file = new Queue<int>();
file.Enqueue(1);
file.Enqueue(2);
file.Enqueue(3);
file.Enqueue(4);

int valeur = file.Dequeue();
Console.WriteLine(valeur);

valeur = file.Dequeue();
Console.WriteLine(valeur);

valeur = file.Dequeue();
Console.WriteLine(valeur);

valeur = file.Dequeue();
Console.WriteLine(valeur);


Console.WriteLine("\nAvec les types string : ");
Queue<string> file2 = new Queue<string>();
file2.Enqueue("chaine 1");
file2.Enqueue("chaine 2");
file2.Enqueue("chaine 3");
file2.Enqueue("chaine 4");

string valeur2 = file2.Dequeue();
Console.WriteLine(valeur2);

valeur2 = file2.Dequeue();
Console.WriteLine(valeur2);

valeur2 = file2.Dequeue();
Console.WriteLine(valeur2);

valeur2 = file2.Dequeue();
Console.WriteLine(valeur2);

#endregion

#region Les Piles<T>  => LIFO (Last in, 1st out)

Console.WriteLine("\n***** Les Piles<T> *****");
Console.WriteLine("Avec les types int : ");
Piles<int> pileEntier= new Piles<int>(3);

pileEntier.Empiler(1);
pileEntier.Empiler(25);
pileEntier.Empiler(55);
pileEntier.Empiler(145);

Console.WriteLine($"L'élément en position n°1 de la pile est : {pileEntier.Get(0)}");
Console.WriteLine($"L'élément en position n°2 de la pile est : {pileEntier.Get(1)}");
Console.WriteLine($"L'élément en position n°3 de la pile est : {pileEntier.Get(2)}");
Console.WriteLine("******************************************************");

pileEntier.Depiler();
Console.WriteLine($"L'élément en position n°1 de la pile est : {pileEntier.Get(0)}");
Console.WriteLine($"L'élément en position n°2 de la pile est : {pileEntier.Get(1)}");
Console.WriteLine($"L'élément en position n°3 de la pile est : {pileEntier.Get(2)}");
#endregion

#region Les Dictionnaires

Console.WriteLine("\n***** Les Dictionnaires *****");
Console.WriteLine("Avec un type Personne : \n");

Dictionary<string, Personnes> annuaire = new Dictionary<string, Personnes>();

annuaire.Add("06 10 11 12 13", new Personnes { Prenom = "Benjamin", Telephone = "06 10 11 12 13" } );
annuaire.Add("06 20 21 22 23", new Personnes { Prenom = "Nicolas", Telephone = "06 20 21 22 23" } );

Personnes p = annuaire["06 10 11 12 13"];

Console.WriteLine(p);

#endregion

#region Les List<T>

Console.WriteLine("\n***** Les List<T> *****");
Console.WriteLine("Avec les types Int : \n");

List<int> listeEntiers = new();

listeEntiers.Add(10);
listeEntiers.Add(20);
listeEntiers.Add(30);

Console.WriteLine($"La liste contient {listeEntiers.Count} entiers\n");
Console.WriteLine("********** Contenu de la liste d'entiers **********");
foreach (int i in listeEntiers)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nAvec les types Personnes : \n");

List<string> listePersonnes = new();

listePersonnes.Add("Pers 1");
listePersonnes.Add("Pers 2");
listePersonnes.Add("Pers 3");

Console.WriteLine($"La liste contient {listePersonnes.Count} personnes\n");

foreach (string i in listePersonnes)
{
    Console.WriteLine(i);
}


#endregion


Console.WriteLine("\nPress ENTER to exit...");
Console.Read();