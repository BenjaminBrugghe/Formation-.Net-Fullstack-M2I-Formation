"use strict";
exports.__esModule = true;
var Personne = /** @class */ (function () {
    function Personne() {
    }
    Personne.prototype.AffichageInfo = function () {
        console.log("Nom: ", this.Nom);
        console.log("Prénom: ", this.Prenom);
        console.log("Age: ", this.Age);
    };
    return Personne;
}());
exports["default"] = Personne;
var personne1 = new Personne();
personne1.Nom = 'Robin';
personne1.Prenom = 'Patrick';
personne1.Age = 39;
personne1.AffichageInfo();
