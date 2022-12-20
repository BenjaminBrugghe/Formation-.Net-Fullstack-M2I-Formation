/**
 * LES TABLEAUX A 2 DIMENSION (= MATRICES) EN JS
 */

// Déclaration de 2 tableaux
var legumes = ["Poireaux", "Concombre", "Epinards"];
var fruits = ["Raisins", "Bananes", "Abricots"];

// Affichage des 2 tableaux
console.table(legumes);
console.table(fruits);

// Création du tableau à 2 dimensions depuis les 2 tableaux numériques
var primeur = [legumes, fruits];
// Affichage du tableau à 2 dimensions
console.table(primeur);

// Afficher un élément (Poireaux)
console.log(primeur[0][0]);

// Afficher Abricots
console.log(primeur[1][2]);  // [Ligne] [Colonne]

//  Avec des tableaux associatifs
var zoo =[
    {
        pseudo:"Simba",
        espece:"Lion",
        continent:"Afrique"
    },
    {
        pseudo:"Tony",
        espece:"Tigre",
        continent:"Asie"
    }
]
console.table(zoo);

// Comment afficher le pseudo du Lion et du Tigre dans la console
console.log(zoo[0]["pseudo"]);
console.log(zoo[1].pseudo);
