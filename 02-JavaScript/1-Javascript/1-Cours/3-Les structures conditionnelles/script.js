/**
 * LES STRUCTURES CONDITIONNELLES
 */

/* L'instruction IF (Si...Alors), else (Sinon)

    if(condition)
    {
        Instructions...si vrai
    }
    else{
        Instructions...si faux
    }
*/

// Récupération de l'age de l'utilisateur et stockage de la valeur dans une variable (age)
var age
// var age = Number(prompt("Veuillez saisir votre age : "));
console.log(typeof (age));

if (age >= 18) {
    console.log(`A ${age} ans, vous êtes majeur`);
}
else {
    console.log(`A ${age} ans, vous êtes mineur`);
}
// EQUIVALENCE :

// if( age >= 18)
//     console.log(`A ${age} ans, vous êtes majeur`);
// else
//     console.log(`A ${age} ans, vous êtes mineur`);

// Avec un nouveau test logique (Sinon...Si)

var solde = 0;

if (solde > 0) {
    console.log(`Vous êtes créditeur !`);
}
else if (solde < 0) {
    console.log(`Vous êtes débiteur !`);
}
else {
    console.log(`Votre solde est nul`);
}

/**
 *  Le SwitchCase :
 * 
 * switch(expression condition)
{
    case valeur1 :
        Instructions(...);
        break;
    case valeur2 :
        Instructions(...);
        break;  
    case valeur3 :
        Instructions(...);
        break;
    default:
        Instructions(...);         >>> Si aucune correspondance avec les "case"
}
 * 
 *  */

// AVEC UNE CHAINE

var myCondition;
// myCondition = prompt("Veuillez saisir le nom d'un fruit :")

switch (myCondition) {
    case 'orange':
        console.log("Vous avez saisi orange...");
        break;

    case 'abricots':
        console.log("Vous avez saisi abricots...");
        break;

    case 'cerise':
        console.log("Vous avez saisi cerise...");
        break;

    default:
        console.log(`Vous n'avez saisi aucun fruit prédéfinit...Votre choix était ${myCondition} `);
        break;
}

// AVEC UN NOMBRE, ET DES CONDITIONS

var myNumber;
myNumber = Number (prompt("Veuillez saisir un nombre :"));

switch (true) {                 // Pour une condition, il faut mettre TRUE
    case myNumber < 0:
        console.log("Votre nombre est négatif");
        break;

    case myNumber > 0:
        console.log("Votre nombre est positif");
        break;

    default:
        console.log("Vous avez saisi un nombre nul");
        break;
}