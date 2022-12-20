/**
 * LES OPERATEURS LOGIQUES
 */


// Déclaration d'une constante détenant un élément du DOM
const result = document.querySelector('#result');


// L'opérateur ET = &&

// Exemple de vérification :
// Si un nombre se trouve dans un range de valeur

var resultat="";
var nbUser = Number(prompt("Veuillez saisir un nombre entre 1 et 10: "));

if(nbUser >=1 && nbUser<=10) {
    resultat += `Le nombre ${nbUser} est bien compris entre 1 et 10. `;
}
else {
    resultat += `Le nombre ${nbUser} n'est pas compris entre 1 et 10. `;
}
console.log(resultat);
result.innerHTML = resultat;

// L'opérateur OU = ||      >>>>> Alt Gr + 6

// Exemple de vérification :
// Si un nombre est inférieur à 1 ou supérieur à 10


var nbUser = Number(prompt("Veuillez saisir un nombre : "));

if(nbUser <1 || nbUser>10) {
    resultat += `Le nombre ${nbUser} est correct ! \n`;
}
else {
    resultat += `Le nombre ${nbUser} est incorrect, veuillez rééssayer ! \n`;
}
console.log(resultat);
result.innerHTML = resultat;


// L'opérateur de négation :
// NON = !

var pause = false;
if(!pause) {
    resultat += "Ce n'est pas la pause ! \n";
}
else {
    resultat += "C'est la pause ! \n";
}
console.log(resultat);
result.innerHTML = resultat;
