const result = document.querySelector(`#Result`);

var netImposable = Number(prompt("Veuillez saisir votre net imposable :"));
var nbAdulte = Number(prompt("Veuillez saisir le nombre d'adultes :"));
var nbEnfant = Number(prompt("Veuillez saisir le nombre d'enfants :"));
var partsEnfants = 0;
var nbParts = 0;
var revenu = 0;
var Ech1 = 0 ;
var Ech2 = 0 ;
var Ech3 = 0 ;
var Ech4 = 0 ;
var Ech5 = 0 ;
var Impots = 0;

if (nbEnfant==1 || nbEnfant==2)
{
    partsEnfants = nbEnfant * 0.5;
}
else if (nbEnfant >= 3)
{
    partsEnfants = nbEnfant - 1;
};

nbParts = (nbAdulte + partsEnfants);
revenu = (netImposable / nbParts);

if (revenu <= 10225)
{
    Ech1 = 0;
}
else if (revenu >= 10226 && revenu <= 26070)
{
    Ech2 = ( (revenu-10225) * 1.11) - (revenu-10225);  // = (revenu-10225) * (11/100)
}
else if (revenu >= 26071 && revenu <= 74545)
{
    Ech3 = ( (revenu-26071) * 1.3) - (revenu-26071);  // = (revenu-26071) * (30/100)
}
else if (revenu >= 74546 && revenu <= 160336)
{
    Ech4 = ( (revenu-74546) * 1.41) - (revenu-74546);  // = (revenu-74546) * (41/100)
}
else if (revenu >= 160336)
{
    Ech5 = ( (revenu-160336) * 1.45) - (revenu-160336);  // = (revenu-160336) * (45/100)
};

Impots = (Ech1+Ech2+Ech3+Ech4+Ech5) * nbParts;

result.innerHTML += `Le montant de l'impôt sur le revenu pour un foyer composé de ${nbAdulte} adultes et de ${nbEnfant} enfants, avec un revenu fiscal de ${netImposable}&#128 s'élève à ${Impots}&#128.`;

console.log (`${Ech1} `);
console.log (`${Ech2} `);
console.log (`${Ech3} `);
console.log (`${Ech4} `);
console.log (`${Ech5} `);







// Diviser le revenu par le nb de parts
// Appliquer les taux (0%, 11%, 30%,...)
// Additioner les résultats
// Multiplier par le nb de parts


