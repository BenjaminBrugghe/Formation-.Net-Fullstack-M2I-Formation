// string
var nom;
nom = "Alain";
// number
var account = 5;
account = 20;
// boolean
var valable = true;
valable = false;
// array
var tab = ["alain", "mark", "Philippe"];
var tab2;
tab2 = [4, 7, 9];
var tab3 = [true, false, true];
// any
var variable;
variable = 15;
console.log("".concat(typeof (variable), " : ").concat(variable));
variable = "Alain";
console.log("".concat(typeof (variable), " : ").concat(variable));
variable = [1, 5, 7];
console.log("".concat(typeof (variable), " : ").concat(variable));
variable = new Date();
console.log("".concat(typeof (variable), " : ").concat(variable));
//enum
var color;
(function (color) {
    color[color["red"] = 0] = "red";
    color[color["black"] = 1] = "black";
    color[color["white"] = 2] = "white";
})(color || (color = {}));
;
var couleur = color.red;
console.log(couleur);
// Function void
function Affichage1() {
    console.log("message");
}
// Function string
function Affichage2() {
    return "message";
}
console.log(Affichage1());
console.log(Affichage1);
// const
var var1 = 16;
//var1=2;
var var2 = {
    nom: 'Robin',
    prenom: 'Patrick'
};
var2.prenom = 'Alain';
console.log(var2.prenom);
console.log("Prenom : ".concat(var2.prenom));
