/**
 * LES TABLEAUX ASSOCIATIFS EN JS
 */

// Déclaration d'un tableau associatif
var personne = {
    nom:"Dupond",
    prenom:"Jean",
    age:25
};

// Affichage du tableau personne
console.table(personne);

// Affichage de la valeur à la clé prenom
console.log(personne.prenom);
// S'écrit aussi
console.log(personne["prenom"]);

