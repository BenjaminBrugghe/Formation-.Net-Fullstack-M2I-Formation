"use strict";
exports.__esModule = true;
var vehicules = /** @class */ (function () {
    function vehicules(Marque, Modele, Kilometrage, Annee, Clim) {
        if (Clim === void 0) { Clim = true; }
        this.Marque = Marque;
        this.Modele = Modele;
        this.Kilometrage = Kilometrage;
        this.Annee = Annee;
        this.Clim = Clim;
        this.clim = true;
        this.marque = Marque;
        this.modele = Modele;
        this.kilometrage = Kilometrage;
        this.annee = Annee;
        this.clim = Clim;
    }
    return vehicules;
}());
exports["default"] = vehicules;
