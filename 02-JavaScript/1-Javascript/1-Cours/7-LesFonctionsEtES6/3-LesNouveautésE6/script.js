// LES NOUVEAUTES E6 (Implentation de la spécification ECMA6)

console.log("-----------Nouveauté ES6---------");

const result = document.querySelector("#result");

// Déclarations de variables
// Avant = var
// Maintenant = let

console.log("---------- Mot clé let -> Remplace var ----------");

// Afficher une variable avant la déclaration

console.log(prenomVar);  // Hoisting (remontée de la déclaration de notre variable) -> Pour le navigateur, la variable existe, seule sa valeur est non initialisée

// console.log(nomLet);       // Affiche une erreur (contrairement à Var)

// Déclaration des variables (var et let)

var prenomVar = "Richard";
let nomLet = "Gear";

// Déclaration d'une constante
const nbMax = 128;
console.log("nbMax vaut : " + nbMax / 2);

// nbMax = 129;          // Erreur, une constante ne peux pas être réaffectée
// console.log(nbMax);

const fruits = ["Pomme"];
// fruits = ["Abricots", "Poire"];   // Erreur, une constante ne peux pas être réaffectée

fruits.push("Abricots", "Poire");  // Ceci n'est pas une modification, mais un ajout de valeurs
console.table(fruits);

// Les nouvelles méthodes apportées à la classe Array (Array = pour une tableau)
// .foreach()
// .map()
// .find()
// .filter()
console.log("-----------les nouvelles méthodes ES6---------");

// Déclaration d'un tableau de légumes (à 2 dimensions)
const vegetables = [
    {
        code: 1,
        name: "Carotte",
        price: 1.99
    },
    {
        code: 2,
        name: "Poivron Rouge",
        price: 4.99
    },
    {
        code: 3,
        name: "Poivron Vert",
        price: 4.99
    },
    {
        code: 4,
        name: "Haricot Vert",
        price: 3.89
    },
    {
        code: 5,
        name: "Courgette",
        price: 2.59
    },
];

// Affichage du tableau dans la console
console.table(vegetables);

// .foreach()
console.log("-----Parcours du tableau Vegetables avec .foreach(vegetable)-----");

// Affichage du tableau avec un .foreach

vegetables.forEach(function (vegetable) {
    console.log(vegetable.name);
    result.innerHTML += `<div>${vegetable.name}</div>`;
});

// Affichage du tableau avec les index

vegetables.forEach(function (vegetable, index) {
    console.log(index + " - " + vegetable.name);
    result.innerHTML += `<div> ${index} - ${vegetable.name}</div>`;
});

// .map()
console.log("-----Parcours du tableau Vegetables avec .map(function() ) {} -----");

const vegetablesNames = vegetables.map(function (vegetable) {
    return vegetable.name;
});
console.table(vegetables); //map() nous retourne un nouveau tableau indéxé
console.table(vegetablesNames); // Affiche uniquement les noms (.Names)

// .find() -> Retourne le premier élément correspondant aux critères

console.log("-----Parcours du tableau Vegetables avec .find(function () {} -----");

const poivron = vegetables.find(function (vegetable) {
    return vegetable.name.includes("Poivron");
});
console.log(poivron);

// .filter() -> Retourne un tableau contenant n occurences correspondant à nos critères

console.log("-----Parcours du tableau Vegetables avec .filter(function () {} -----");

const poivrons = vegetables.filter(function (vegetable) {
    return vegetable.name.includes("Poivron");
});

console.log(poivrons);

// *******************************************************************************************
// Mardi 07/06
// *******************************************************************************************

// LE DESTRUCTURING

console.log("***** LE DESTRUCTURING *****");

// Accès simplifié aux élements d'un tableau... d'un objet.
// Avec des tableaux

const tabNum = [1, 2, 3, 4, 5, 6];
console.table(tabNum);

// En ES5

const A = tabNum[0];
const B = tabNum[1];
console.log(A);
console.log(B);

// En ES6 avec le destructuring

const [a, b] = tabNum;
console.log(a);
console.log(b);

// Avec un tableau associatif (objet)

const user = {
    firstname: "Benjamin",
    lastname: "Brugghe",
    age: 31,
    active: false
}

// En ES5
const firstname = user.firstname;
const lastname = user.lastname;

// En ES6 avec le destructuring
const { Firstname, Lastname } = user;

console.log(`Avec le destructuring de l'objet user : ${firstname} ${lastname}`);

// Avec des fonctions
// SANS destructuring

getFullName = (user) => {
    return `
    ${user.firstname} ${user.lastname};
    `}

console.log("Sans destructuring de methode getFullName() :" + getFullName(user));

// AVEC destructuring

getFullName = (firstname, lastname) => {
    return `
        ${user.firstname} ${user.lastname};
        `}

console.log("Avec destructuring de methode getFullName() :" + getFullName(user));

// OPERATEUR REST >>> ...

console.log("***** OPERATEUR REST *****");

let haricot = { ...vegetables[3] };   // ... > Récupère l'ensemble des clés/valeurs à l'index 3 de vegetables

console.table(vegetables);
console.log(vegetables);
console.log(haricot);

// Modifier la valeur du prix des haricots verts
haricot.price = 2.99;

console.table(vegetables); // = 3.89
console.log(vegetables[3]); // = 3.89
console.log(haricot); // = 2.99

// Autre exemple avec notre tableau numérique tabNum

console.table(tabNum);

// En ES5
// const A = tabNum[0];
// const B = tabNum[1];

// En ES6 avec destructuring

const [c, d, ...e] = tabNum;

console.log(c);
console.log(d);
console.table(e);

// LES FONCTIONS FLECHEES > ArrowFunction()

// Pour écrire une fonction fléchée, nous allons utiliser un opérateur nommé 
// fat Arrow => 

// Cas 1 : Sans paramètres

test = () => {
    return "Toto";
}
console.log(test);

// Simplification, seulement si la fonction ne fait qu'un return

test = () => "Toto";

console.log(test);

// Cas 2 : Avec paramètres

let test2 = function (vegetable) {
    return vegetable.name;
}

console.log(test2);

// Cas 3 : Avec au moins 2 paramètres

test3 = (firstname, lastname) => {
    return `
    ${firstname},  ${lastname};
    `}

// Equivalent à 

// test3 = (firstname, lastname) => ` ${firstname},  ${lastname}; `

console.log(test3);

// Valeur des paramètres par défaut d'une fonction ()

AireCarre = (nb = 3) => {
    return nb * nb ;
}

console.log(AireCarre(5)); // = 25
console.log("Paramètres par défaut : " + AireCarre()); // = 9

// LES CLASSES > L'ES6 introduit les classes, et donc le paradigme orienté Objet
// LES CLASSES > L'ES6 introduit les classes, et donc le paradigme orienté Objet
// LES CLASSES > L'ES6 introduit les classes, et donc le paradigme orienté Objet
// LES CLASSES > L'ES6 introduit les classes, et donc le paradigme orienté Objet

class Personne {
    
    constructor(Param1, Param2) {   // C'est le moule qui définit les caractéristiques de nos objets
        this.firstname = Param1;
        this.lastname = Param2;
    }
    getFullname () {        // methode = une fonction dans une class
        return `${this.firstname} ${this.lastname}`;
    }
}

let personne1 = new Personne("Mister","Bean");
console.log(personne1);
console.log(personne1.firstname);

// 2 méthodes pour accèder aux méthodes d'une classe
    // 1. Par une instance de classe
// Personne.getFullname();

    // 2. Par une instance objet => new Personne(Param1, Param2)
console.log(personne1.getFullname());

// L'HERITAGE EN JAVASCRIPT
    // Avec le mot clé "extends" suivi du nom de la classe de laquelle on souhaite hériter

class Cadre extends Personne {
    // Ajout d'un constructeur pour nos cadre
    constructor (Param1, Param2, ParamJob="Cadre") {
        super(Param1, Param2);
        this.job = ParamJob;
    }
    getJob() {
        return this.job;
    }
    display() {
        return `
        ${super.getFullname()} - ${this.job}
        `;
    }
}

let cadre1 = new Cadre("Jacques", "Chirac", "Président");
let cadre2 = new Cadre("François", "Mitterand");

console.log(cadre1);
console.log(cadre2);
console.log(cadre1.getJob());
console.log(cadre2.getJob());

console.log(cadre1.display());
console.log(cadre2.display());