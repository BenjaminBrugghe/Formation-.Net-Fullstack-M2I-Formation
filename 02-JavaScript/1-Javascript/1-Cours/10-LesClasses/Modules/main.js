// LES CLASSES EN JS

console.log("Je suis dans un module JS");

// IMPORT DES CLASSES 

import EtreVivant from "./JS/EtreVivant.js"
import Vegetaux from "./JS/Vegetaux.js"
import Mammifere from "./JS/Mammiferes.js"
import Chien from "./JS/chien.js"
import Fleurs from "./JS/fleurs.js"

// Instanciation d'un objet EtreVivant
let etreVivant1 = new EtreVivant("Prenom1", "Nom1");
console.log(etreVivant1);

// Execution des méthodes de l'objet EtreVivant
etreVivant1.Naissance();
etreVivant1.Mort();
etreVivant1.Respiration();
etreVivant1.Alimentation();

// Instanciation des objets Mammifere et Vegetaux
console.log(" ******* Mammifere ******* ");
let mammifere1 = new Mammifere("Mammifere1", "typeMamifere");

// Execution des méthodes de l'objet Mammifere
mammifere1.Mort();
mammifere1.Respiration();
mammifere1.Alimentation();

console.log(" ******* Vegetaux ******* ");
let vegetaux1 = new Vegetaux("vegetaux1", "typeVegetaux");

// Execution des méthodes de l'objet Vegetaux
vegetaux1.Naissance();
vegetaux1.Mort();
vegetaux1.Respiration();
vegetaux1.Alimentation();

console.log(" ******* Chien ******* ");
let Medor = new Chien("médor", "Berger Allemand")

// Execution des méthodes de l'objet Chien
Medor.Naissance();
Medor.Aboyer();
Medor.Respiration();
Medor.Alimentation();
Medor.Mort();

console.log(" ******* Fleurs ******* ");
let jolieFleur = new Fleurs("joliefleur", "fleurmoche")

// Execution des méthodes de l'objet Fleurs
jolieFleur.Naissance();
jolieFleur.Respiration();
jolieFleur.Mort();
jolieFleur.Alimentation();

console.log("CLG après deux extends");
console.log(Medor);
console.log(jolieFleur);

console.log(" ***** Création d'une collection de type EtreVivant *****");

let etresVivants = [etreVivant1, mammifere1, vegetaux1, Medor, jolieFleur];

for (let etre of etresVivants) {
    console.log(`----- ${etre.Nom} -----`);
    etre.Naissance();
    etre.Alimentation();
    etre.Respiration();
    etre.Mort();
console.log(`--------------------------------------\n`);
}

