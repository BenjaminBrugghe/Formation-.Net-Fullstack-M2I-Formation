const result = document.querySelector(`#Result`);

var A = Number(prompt("Veuillez saisir la longueur du segment A : "));
var B = Number(prompt("Veuillez saisir la longueur du segment B : "));
var C = Number(prompt("Veuillez saisir la longueur du segment C : "));

if (A===B && A===C)
{
    result.innerHTML += "Le triangle est équilatéral !"
}
else if (A===B)
{
    result.innerHTML += "Le triangle est isocèle en B !"
}
else if (A===C)
{
    result.innerHTML += "Le triangle est isocèle en A !"
}
else if (B===C)
{
    result.innerHTML += "Le triangle est isocèle en C!"
}
else
{
    result.innerHTML += "ERREUR! Le triangle n'est ni isocèle, ni équilatéral !"
};