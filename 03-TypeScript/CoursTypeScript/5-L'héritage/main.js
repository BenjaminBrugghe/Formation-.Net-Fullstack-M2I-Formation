"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
exports.Etudiant = exports.Personne = void 0;
var Personne = /** @class */ (function () {
    function Personne(Nom, Prenom, Age) {
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.Age = Age;
    }
    Personne.prototype.AffichageInfo = function () {
        console.log("Nom: ", this.Nom);
        console.log("Prénom: ", this.Prenom);
        console.log("Age: ", this.Age);
    };
    return Personne;
}());
exports.Personne = Personne;
var Etudiant = /** @class */ (function (_super) {
    __extends(Etudiant, _super);
    function Etudiant(Nom, Prenom, Age, NumeroCarteEtudiant) {
        var _this = _super.call(this, Nom, Prenom, Age) || this;
        _this.Nom = Nom;
        _this.Prenom = Prenom;
        _this.Age = Age;
        _this.NumeroCarteEtudiant = NumeroCarteEtudiant;
        return _this;
    }
    Etudiant.prototype.AffichageInfo = function () {
        _super.prototype.AffichageInfo.call(this);
        console.log("Numéro de carte étudiant: ", this.NumeroCarteEtudiant);
    };
    return Etudiant;
}(Personne));
exports.Etudiant = Etudiant;
var etudiant1 = new Etudiant("Toto", "Titi", 18, 14598);
etudiant1.AffichageInfo();
