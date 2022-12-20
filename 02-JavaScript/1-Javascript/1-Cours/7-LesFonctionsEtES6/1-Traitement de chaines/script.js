/**
 * LE TRAITEMENT DES CHAINES
 */

// Déclaration des variables :
var chaine = "Bonjour, comment allez-vous ?"
var arrayChaine = chaine.split(" ").reverse();
var nomComplet = "BrUgGhE BeNjAmIn";
var nomComplet2 = "BrUgGhE BeNjAmIn SeBaStIeN";


// La fonction split()

console.table(chaine.split(""));
console.table(chaine.split(" "));
console.table(chaine.split(","));

// La fonction reverse()

console.table(chaine.split(" ").reverse());

// La fonction join()

console.table(arrayChaine.join("-")); // Regroupe les caractères avec des - entre chaque
console.table(arrayChaine.join(" ")); // Regroupe les caractères avec des " " entre chaque
console.table(arrayChaine.join("")); // Regroupe les caractères sans espacements

// Upper / Lower case

console.log(nomComplet.toLowerCase()); // Affiche tout en minuscule
console.log(nomComplet.toUpperCase()); // Affiche tout en majuscule

// La propriété lenght -> Longueur de la chaine

console.log(nomComplet.length);
console.log(nomComplet[0]);
console.log(nomComplet[15]);

// IndexOf() -> Retourne l'index d'un élément

console.log(nomComplet.indexOf(" ")); // Affiche l'index de l'espace
console.log(nomComplet.lastIndexOf(" ")); // Affiche l'index du dernier espace de la chaine
console.log(nomComplet.indexOf("B")); // Index 0
console.log(nomComplet.lastIndexOf("B")); // Index 8

// Slice() -> Extraire des bouts de chaine

if(nomComplet.indexOf("BeN") > -1) {
    console.log(nomComplet.slice(nomComplet.indexOf("BeN"),11));  // 11 = Index de fin. Si vide, va jusqu'à la fin
}

if(nomComplet.indexOf("BeN") > -1) {
    console.log(nomComplet.slice(nomComplet2.indexOf(" "),nomComplet2.lastIndexOf(" ")));
}

// Replace -> Remplace la valeur d'une chaine

console.log(nomComplet.replace("BeNjAmIn","Benjamin")); // ("Morceau à modifier", "modification")

// CharAt() -> Retourne le caractère à un index donné

console.log(nomComplet.charAt(0));

// Exercice : Mettre en forme la variable nomComplet
// BrUgGhE BeNjAmIn = Brugghe Benjamin

// console.log(nomComplet.replace("BrUgGhE BeNjAmIn","Brugghe Benjamin"));
// console.log(nomComplet.replace(nomComplet,"Brugghe Benjamin"));
// console.log(nomComplet.replace(nomComplet,nomComplet.toLowerCase()));

console.log(nomComplet2);

nomComplet2 = nomComplet2.toLowerCase();

console.log(nomComplet2);

nomComplet2 = nomComplet2[0].toUpperCase() + nomComplet2.slice(1);

console.log(nomComplet2);

nomComplet2 =nomComplet2.slice(0 , nomComplet2.indexOf(' ') +1 ) + nomComplet2[nomComplet2.indexOf(' ') + 1].toUpperCase() + nomComplet2.slice(nomComplet2.indexOf(' ') + 2);

console.log(nomComplet2);

nomComplet2 =nomComplet2.slice(0 , nomComplet2.lastIndexOf(' ') +1 ) + nomComplet2[nomComplet2.lastIndexOf(' ') + 1].toUpperCase() + nomComplet2.slice(nomComplet2.lastIndexOf(' ') + 2);

console.log(nomComplet2);
