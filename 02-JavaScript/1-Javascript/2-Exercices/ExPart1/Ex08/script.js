const result = document.querySelector(`#result`);


var prixHT =Number( prompt("Veuillez saisir le prix HT : "));
var Taux =Number( prompt("Veuillez saisir le Taux (en %) : "));
var montant = prixHT*(Taux/100);
var prixTTC = prixHT + montant; 



result.innerHTML += `Le prix HT de l'objet étant de ${prixHT}euros, avec un taux à ${Taux}%, <br></br>`;
result.innerHTML += `Le montant de la TVA s'élève à ${montant} euros. <br></br>`;
result.innerHTML += `Le prix TTC de l'objet sera de ${prixTTC} euros`;