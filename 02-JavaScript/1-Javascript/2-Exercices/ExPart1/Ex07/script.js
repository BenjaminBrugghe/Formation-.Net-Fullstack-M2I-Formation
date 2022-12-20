const result = document.querySelector(`#result`);

var hypotenuse;

var longueur1=Number(prompt("Veuillez saisir la 1ère longueur"));
var longueur2=Number(prompt("Veuillez saisir la 2ème longueur"));

hypotenuse=Math.hypot(longueur1,longueur2).toFixed(2);

result.innerHTML += `Les longueurs des côtés adjacents étant de ${longueur1} et de ${longueur2}, <br></br>`;
result.innerHTML += `La longueur de l'hypoténuse est de ${hypotenuse} cm.`;