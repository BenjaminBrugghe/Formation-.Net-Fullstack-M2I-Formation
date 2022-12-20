const result = document.querySelector(`#result`);

var CapitalDepart = Number(prompt("Veuillez entrer le capital de départ :"));
var Taux = Number(prompt("Veuillez entrer le taux d'intéret (en %) : "));
var Duree = Number(prompt("Veuillez saisir la durée de l'épargne : "));

var CapitalFinal = CapitalDepart * Math.pow(1+(Taux/100), Duree);
var Interets = CapitalFinal - CapitalDepart ;

result.innerHTML += `Avec un capital initial de ${CapitalDepart}&#128, placé à ${Taux}% pendant ${Duree} année(s), <br></br>`;
result.innerHTML += `Le montant total des intérêts s'élèvera à ${Math.round(Interets)}&#128 .<br></br>`;
result.innerHTML += `Le capital final sera donc de ${Math.round(CapitalFinal)}&#128  .<br></br>`;
