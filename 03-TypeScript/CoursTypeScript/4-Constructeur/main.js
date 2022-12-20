"use strict";
exports.__esModule = true;
exports.Personne = void 0;
var Personne = /** @class */ (function () {
    function Personne(Nom, Prenom, Age) {
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.Age = Age;
        this.nom = Nom;
        this.prenom = Prenom;
        this.age = Age;
    }
    Personne.prototype.AffichageInfo = function () {
        console.log("Nom: ", this.Nom);
        console.log("Prénom: ", this.Prenom);
        console.log("Age: ", this.Age);
    };
    return Personne;
}());
exports.Personne = Personne;
var personne1 = new Personne("Robin", "Patrick", 39);
personne1.Nom = "";
personne1.AffichageInfo();
