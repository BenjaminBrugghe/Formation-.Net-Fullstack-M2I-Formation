// 1ere déclaration
function Affichage(message) {
    return "Fonction = " + message;
}
var message = Affichage("hello world");
console.log(message);
// 2eme déclaration
var Affichage2 = function (message) {
    return 'Fonction 2 ' + message;
};
var message2 = Affichage2("Hello world");
// 3eme déclaration Arrow function
var Affichage3 = function (message) {
    return 'Fonction Arrow' + message;
};
var message3 = Affichage3("hello world");
var Addition = function (a, b) {
    return a + b;
};
console.log(Addition(4, 5));
var Addition2 = function () { return "Addition"; };
console.log(Addition2());
