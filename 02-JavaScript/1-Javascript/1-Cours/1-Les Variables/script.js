// Commentaire sur une ligne

/* Commentaires multilignes
Encore des commentaires 
*/

/** Rajoutes automatiquement une ligne
 * 
 */

// Déclaration d'une variable en JS (Jusqu'à ES5) :
// ES = ECMA Script
var prenom; 

// Affichage dans la console
// Click droit -> Inspecter -> Console
console.log(prenom);

// Afficharge du type de la variable dans la console
// Type de base : Undefined
console.log(typeof(prenom))

//

// Affectation de valeur à la variable :
prenom  = "Benjamin";

// Affichage dans la console
// Click droit -> Inspecter -> Console
console.log(prenom);

// Afficharge du type de la variable dans la console
// Type de base : Undefined
console.log(typeof(prenom))

//

// Déclaration et Affectation de valeur à la variable :
var nom = "Brugghe";

// Affichage dans la console
// Click droit -> Inspecter -> Console
console.log(nom);

// Affichage du type de la variable dans la console
// Type de base : Undefined
console.log(typeof(nom))

// Déclaration variable Age et affectation de la valeur
var age = 20;

// Concaténation des deux variables :
console.log(nom + prenom);
console.log(nom + " " + prenom);
console.log("je m'appelle " + nom + " " + prenom + " et j'ai " + age + " ans.");

// Alt Gr + 7 (backtick)
console.log(`

Affichage console

en multilignes

`)

console.log(`Je m'appelle ${nom} ${prenom} et j'ai ${age} ans.`)

// Récupération de valeurs issues de saisies utilisateurs

// nom = prompt("Veuillez saisir votre nom :");
// prenom = prompt("Veuillez saisir votre prénom :");
// age = Number(prompt("Veuillez saisir votre age :"));

console.log("je m'appelle " + nom + " " + prenom + " et j'ai " + age + " ans.");
console.log(age+1);

// Type booléenne
var myBool = true;
console.log(typeof(myBool));
