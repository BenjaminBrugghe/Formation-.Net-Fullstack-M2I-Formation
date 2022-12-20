const result = document.querySelector(`#Result`);

var Letter = prompt("Veuillez saisir une lettre :").toLowerCase() ;

if (Letter === "a" || Letter === "e" || Letter === "i" || Letter === "o" || Letter === "u" || Letter === "y")
{
    result.innerHTML += `La lettre ${Letter} est une voyelle !`;
}
else
{
    result.innerHTML += `ERREUR. La lettre ${Letter} n'est pas une voyelle, c'est une consonne !`
};
