"use strict";
exports.__esModule = true;
var vehicules_1 = require("./vehicules");
var auto = new vehicules_1["default"]("Renault", "Kangoo", "240000", "2003", true);
var moto = new vehicules_1["default"]("BMW", "R1150R Rockstar", "65000", "2005", false);
var affichage;
affichage = "Exercice n\u00B02 - H\u00E9ritage V\u00E9hicule.\n\nVoiture : ".concat(auto.marque, " - ").concat(auto.modele, " - ").concat(auto.kilometrage, " - ").concat(auto.annee, " - ").concat(auto.clim ? "Climatisée" : "Non climatisée", "\nMoto : ").concat(moto.marque, " - ").concat(moto.modele, " - ").concat(moto.kilometrage, " - ").concat(moto.annee, " - ").concat(moto.clim ? "Climatisée" : "Non climatisée");
console.log(affichage);
