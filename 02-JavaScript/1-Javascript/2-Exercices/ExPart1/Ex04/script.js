const result = document.querySelector(`#Result`);

var mot = "";
var motReverse;
mot=prompt("Veuillez saisir un mot : ");

result.innerHTML += `Vous avez saisis ${mot} : <br></br>`;
motReverse = mot.split("").reverse().join("");
// function reverse(mot){return mot.replace};

result.innerHTML += `Le mot inversé est : "${motReverse} " <br></br>`;

if (mot == motReverse) {
    result.innerHTML += `Le mot "${mot}" est un palindrome. <br></br>`;
} else{
    result.innerHTML += `Le mot "${mot}" n'est pas un palindrome. <br></br>`;
}
