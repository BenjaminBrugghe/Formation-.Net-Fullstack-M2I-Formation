const result = document.querySelector(`#result`);
const result2 = document.querySelector(`#result2`);

var longueur;
var longueur2;
var largeur;
var perimetreC;
var perimetreR;
var aireC;
var aireR;


longueur=Number(prompt("Veuillez saisir la longueur d'un côté"));

perimetreC= (longueur*2)*2;
aireC= longueur*longueur;

result.innerHTML += `Les longueurs des côtés du carré étant de ${longueur},<br></br>` 
result.innerHTML += `Le périmètre est de ${perimetreC} cm.<br></br>`;
result.innerHTML += `L'aire de ce carré est de ${aireC} cm².`;

longueur2=Number(prompt("Veuillez saisir la longueur"));
largeur=Number( prompt("Veuillez saisir la largeur"));

// var perimetreR= (longueur2*2) + (largeur*2);
perimetreR=(longueur2+largeur)*2;
aireR= longueur2*largeur;

result2.innerHTML += `Les longueurs des côtés du rectangle étant de ${longueur2} cm pour la longueur et de ${largeur} cm pour la largeur, <br></br>` 
result2.innerHTML += `Le périmètre est de ${perimetreR} cm.<br></br>`;
result2.innerHTML += `L'aire de ce carré est de ${aireR} cm².`;

