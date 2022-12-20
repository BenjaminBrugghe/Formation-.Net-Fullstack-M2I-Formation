// LES FONCTIONS EN JAVASCRIPT
const result = document.querySelector(`#Result`);
// LES FONCTIONS NATIVES

alert("ERREUR! Veuillez saisir un nombre correct."); // Affiche un pop-up d'alerte

var userName = prompt("Veuillez saisir votre nom : ") // Permet de récupérer une saisie utilisateur

console.log(`Votre nom est : ${userName}`); // Affichage la variable dans la console

// LES FONCTIONS NON NATIVES (USER)

    // Fonctions sans paramètres

function hello() {
    // Lors de l'appel à cette fonction, les instructions ci-dessous seront executées
    alert("hello, hi, salut, bonjour !");
}
    // Appeler la fonction hello ():
hello();

    // Fonctions avec des paramètres

function helloParams(firstname) {
    console.log(firstname);
}
    // Appeler la fonction helloParams ():
helloParams("Benjamin");
let firstname = prompt("Veuillez saisir votre nom");
helloParams(firstname); // Affiche ce qu'on a saisi dans le Prompt (L.29)

function AfficherAge(age) {
    console.log(`J'ai ${age} ans.`);
    console.log(`Dans un an, j'aurai ${age+1} ans.`);
};

let age = Number(prompt("Veuillez saisir votre age :"));
AfficherAge(age);
console.log(age);

    // Fonctions avec retours

function helloReturn(FirstName) {
    // Création de variable locale à la fonction
    let helloDisplay = `Hello ${FirstName}`;
    return helloDisplay;
};

// Appel de fonction avec retour
console.log(helloReturn("Benjamin"));
let chaine = helloReturn(prompt("Veuillez saisir un prenom"));
console.log(chaine);

// Fonction Display

function Display(toto){
    result.innerHTML+= `<div>${toto}</div>`;
}

Display(chaine);
chaine = helloReturn(prompt("Veuillez saisir un prenom : "));
Display(chaine);