import vehicules from "./vehicules";

let auto = new vehicules
    ("Renault", "Kangoo", "240000", "2003", true);
let moto = new vehicules
    ("BMW", "R1150R Rockstar", "65000", "2005", false);

let affichage: string;
affichage = `Exercice n°2 - Héritage Véhicule.\n\nVoiture : ${auto.marque} - ${auto.modele} - ${auto.kilometrage} - ${auto.annee} - ${auto.clim ? "Climatisée" : "Non climatisée"}\nMoto : ${moto.marque} - ${moto.modele} - ${moto.kilometrage} - ${moto.annee} - ${moto.clim ? "Climatisée" : "Non climatisée"}`

console.log(affichage);