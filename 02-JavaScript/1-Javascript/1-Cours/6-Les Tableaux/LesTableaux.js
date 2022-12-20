/**
 * LES TABLEAUX NUMERIQUES EN JS
 */

// Déclaration d'un tableau numérique en JS (2 façons)
var monTableau = new Array();
var monAutreTableau = [];

// Affecter une valeur à un tableau numérique
monTableau[0]="Pomme"; // Affectation en index 0 (position 1)
monTableau[1]="Poire";

// Affichage du contenu d'un tableau dans la console
console.table(monTableau);

// Affichage d'une valeur/d'un index précis
console.log(monTableau[0]);

// Déclaration et affectation de valeur en même temps
var legumes = ["Carotte", "Choux", "Haricots"];
// Equivalent à :
var legumes = new Array ("Carotte", "Choux", "Haricots")

// Affichage du tableau de légumes
console.table(legumes);

// Réaffecter une valeur dans le tableau
console.log(legumes[2]);
legumes[2]="Epinard";
console.log(legumes[2]);

// Récupérer la taille de la collection
console.log("La longueur du tableau est : " + legumes.length);

// Ajouter un ou plusieurs éléments à un tableau
legumes.push("Courgette");
console.table(legumes);
legumes.push("Potirons", "Aubergines");
console.table(legumes);

// Retirer le dernier élément du tableau
legumes.pop();
console.table(legumes);

// Retirer le premier élément du tableau
legumes.shift();
console.table(legumes);

legumes.push("Courgette");
console.table(legumes);
legumes.push("Potirons", "Aubergines");
console.table(legumes);

// Retirer un ou plusieurs éléments du tableau (à un index donné)
legumes.splice(4,2);  // Retirer 2 éléments, à partir de l'index 4
console.table(legumes);

// Ajouter des éléments à une position donnée
legumes.splice(3,0,"Concombre");  // (index, nb à supprimer, value à insérer)
console.table(legumes);

// Connaitre l'index d'un élément
console.log(legumes.indexOf("Potirons")); // Affiche "-1" si l'élément n'existe pas

// Récupérer un élément du tableau et stockage dans une variable (Choux)
var monLegume;
var index = legumes.indexOf("Choux");
if(index>=0) {
    monLegume = legumes[index];
    console.log(monLegume);
}
else{
    alert("Ce légume n'existe pas");
}
