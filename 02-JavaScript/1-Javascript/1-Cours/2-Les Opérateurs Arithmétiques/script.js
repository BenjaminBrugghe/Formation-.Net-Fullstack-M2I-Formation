/**
 * Les opérateurs arithmétiques
 */

// Déclaration des variables :
var nb1=10, nb2=5, resultat;

console.log(typeof(nb1));
console.log(typeof(nb2));
console.log(typeof(resultat));

// L'addition :

resultat = nb1 + nb2 ;
console.log(`L'addition : \n${nb1} + ${nb2} = ${resultat}`);
// console.log(`${nb1} + ${nb2} = ${nb1 + nb2}`);

// La soustraction :

resultat = nb1 - nb2 ;
console.log(`La soustraction : \n${nb1} - ${nb2} = ${resultat}`);

// La multiplication :

resultat = nb1 * nb2 ;
console.log(`La multiplication : \n${nb1} x ${nb2} = ${resultat}`);

// La division :

resultat = nb1 / nb2 ;
console.log(`La division : \n${nb1} / ${nb2} = ${resultat}`);

// Le modulo :

resultat = nb1 % nb2 ;
console.log(`Le reste de : \n${nb1} modulo ${nb2} = ${resultat}`);

// \n >>> Permet de faire un retour à la ligne

/**
 * Les opérateurs combinés :
 */

// L'addition
nb1  = nb1 + 5;
console.log(`Nb1 vaut : ${nb1} `)
// Opérateurs combinés :
nb1 += 5;
console.log(`Nb1 vaut : ${nb1} `)

// La soustraction
nb1  = nb1 - 4;
console.log(`Nb1 vaut : ${nb1} `)
// Opérateurs combinés :
nb1 -= 6;
console.log(`Nb1 vaut : ${nb1} `)

// Les opérateurs d'incrémentation et de décrémentation

// Incrémentation

console.log(`Valeur avant incrémentation : ${nb1}`)

nb1 = nb1 + 1 ;
console.log(`Valeur après incrémentation "classique" : ${nb1}`)

// Peux se simplifier en :
nb1 +=1;
console.log(`Valeur après incrémentation avec l'opérateur combiné (+=) : ${nb1}`)

// Avec l'opérateur d'incrémentation :
nb1++;
console.log(`Valeur après incrémentation avec l'opérateur d'incrémentation (++) : ${nb1}`)

// Décrémentation

console.log(`Valeur avant décrémentation : ${nb1}`)

nb1 = nb1 - 1 ;
console.log(`Valeur après décrémentation "classique" : ${nb1}`)

// Peux se simplifier en :
nb1 -=1;
console.log(`Valeur après décrémentation avec l'opérateur combiné (-=) : ${nb1}`)

// Avec l'opérateur d'décrémentation :
nb1--;
console.log(`Valeur après décrémentation avec l'opérateur d'incrémentation (--) : ${nb1}`)

/**
 * Positionnement de l'opérateur d'incrémentation
 */

nb1=1;
console.log(nb1++); // La variable est lue avant d'être incrémentée
console.log(`Après l'incrémentation, nb1 vaut : ${nb1}`);

nb1=1;
console.log(++nb1); // La variable est incrémentée avant sa lecture
console.log(`Après les 2 incrémentations, nb1 vaut : ${nb1}`);

