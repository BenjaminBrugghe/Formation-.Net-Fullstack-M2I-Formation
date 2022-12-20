const result = document.querySelector(`#Result`);

// BOUCLE TANT QUE = while

let i = 1;
while(i<=10) {
    console.log(`La boucle while s'est executée ${i} fois.`);
    i++; // i = i+1
};
console.log("A la sortie de la boucle while, i vaut : "+i);

// BOUCLE FAIRE TANT QUE = do...while

do {
    console.log(`La boucle do...while s'est executée ${i} fois.`);
    i++;
}
while (i<=10);
console.log("A la sortie de la boucle do....while, i vaut : "+i);

// BOUCLE POUR = for(var itération ; condition de sortie ; incrémentation)

i = 1;
for(let j = 1 ; j <=10 ; j++ ) {
    console.log(`La boucle for() s'est executée ${j} fois`);
}
// console.log(`${j}`);     >>> La variable n'existe plus après la boucle


/**
 * EXERCICE
 * A partir du tableau numérique suivant :
 * 
 * let names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];
 * 
 * 1/ Gràce à une boucle for, afficher la liste des prenoms du tableau
 * 2/ Gràce à une boucle while, afficher la liste des prenoms du tableau
 */
let names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];

for(let n = 0 ; n < names.length ; n++) {
    console.log(names[n]);
};
// ***** Est egal à : *****
let m=0;
while( m < names.length) {
    console.log(names[m]);
    m++;
};

// BOUCLES pour...dans = for...in
    // Parfait pour les tableaux associatifs

let contact = {
    nom: "Papier-ciseaux",
    prenom: "Pierre",
    telephone : "0320123123",
    email : "PPC@gmail.com"
};

for(let key in contact) {
//    console.log(key);  >>> Permet d'afficher la clé
//    console.log(contact[key]); >>> Permet d'afficher les valeurs pour chaque clé
    console.log(key + " : " + contact[key]);
};

// BOUCLES pour...de  = for...of
    // boucle for "classique"

names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];

for(let n = 0 ; n < names.length ; n++) {
    console.log(names[n]);
};

for(let name of names) {  // Utiliser let ou const (mais pas var)
    console.log(`Avec la boucle for...of, names contient ${name}`);
};

// INSTRUCTIONS BREAK

let z;
for(let z = 1 ; z <= 100 ; z++) {
    console.log(z);
    if (z === 50) {
        break;
    }
}
console.log(z);

// INSTRUCTION CONTINUE

for(let z = 1 ; z <= 100 ; z++) {
    console.log(z);
    if (z === 50) {
        continue;     // Permet d'ignorer 1 action dans la boucle (pour z=50) et de continuer ensuite
    }
    console.log(z);
}
console.log(z);
