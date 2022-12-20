// LES INPUT ET AFFICHAGE

//Création des constantes permettant de récupérer les éléments du DOM

const result = document.querySelector(`#Result`);
const btnValider = document.querySelector(`#btnValider`);

// Déclaration des variables
let firstname = "",
    lastname = "",
    personne = "",
    age = 0;

// Fonction pour vider les inputs

ClearInput = () => {
    document.querySelector(`#firstname`).value="";
    document.querySelector(`#lastname`).value="";
    document.querySelector(`#age`).value="";
}

// Fonction Valider sur Button click

// function Valid () {}
// EQUIVALENT A
Valid = () => {
    // Récupération des valeurs des inputs
    firstname = document.querySelector(`#firstname`).value;
    lastname = document.querySelector(`#lastname`).value;
    age = parseInt(document.querySelector(`#age`).value);

    // Affichage des valeurs dans la console
    console.log(firstname);
    console.log(lastname);
    console.log(age);

    // Appel de la fonction pour vider le contenu des inputs
    ClearInput();
    MyDisplay(firstname, lastname, age);
}

// Fonction pour l'affichage et la concaténation des valeurs
MyDisplay = (Paramfirstname, Paramlastname, Paramage) => {
    let chaine = `<div>Je m'appelle ${Paramfirstname} ${Paramlastname} et j'ai ${Paramage} ans. </div>`;
    result.innerHTML += chaine;
}