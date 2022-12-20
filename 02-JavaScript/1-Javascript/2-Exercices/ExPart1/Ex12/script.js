const result = document.querySelector(`#Result`);

var chiffre1 = Number(prompt("Veuillez saisir le 1er chiffre : "));
var chiffre2 = Number(prompt("Veuillez saisir le 2ème chiffre : "));

if (chiffre1 % chiffre2 == 0)
{
    result.innerHTML += `Le nombre ${chiffre1} est divisible par ${chiffre2}`
}
else{
    result.innerHTML += `ERREUR !`

}