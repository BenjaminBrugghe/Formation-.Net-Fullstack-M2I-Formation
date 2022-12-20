const result = document.querySelector('#Result')

var nb1=0;
var nb2=0;
var resultat=0 ;

var nb1 = Number(prompt("Veuillez entrer un premier nombre"));
result.innerHTML += `Vous avez saisis ${nb1}. <br></br>` ;

var nb2 = Number(prompt("Veuillez entrer un deuxième nombre"));
result.innerHTML += `Vous avez saisis ${nb2}. <br></br>`;

resultat = nb1 + nb2;

result.innerHTML += `La somme de ${nb1} + ${nb2} = ${resultat}. `;
