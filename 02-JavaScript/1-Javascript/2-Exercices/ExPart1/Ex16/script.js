const result = document.querySelector(`#Result`);

var age = Number(prompt("Veuillez saisir votre age :"));
var ancienneté = Number(prompt("Veuillez saisir votre ancienneté :"));
var salaire = Number(prompt("Veuillez saisir votre dernier salaire : "));
var prime;

if (ancienneté <=10)
{
    prime = (salaire/2) * ancienneté;
}
else if (ancienneté>10)
{
    prime = ( (salaire/2) * 10 ) + (salaire * (ancienneté-10));
};

if (age>=46 && age<=49)
{
    prime = prime + (2*salaire),
    result.innerHTML += `Le montant de l'indemnité pour un salarié de ${age} et avec ${ancienneté} années d'ancienneté sera de ${prime}&#128`;
}
else if (age>=50)
{
    prime = prime + (5*salaire),result.innerHTML += `Le montant de l'indemnité pour un salarié de ${age} et avec ${ancienneté} années d'ancienneté sera de ${prime}&#128`;
}
else 
{
    result.innerHTML += `Le montant de l'indemnité pour un salarié de ${age} ans et avec ${ancienneté} années d'ancienneté sera de ${prime}&#128`;
};


