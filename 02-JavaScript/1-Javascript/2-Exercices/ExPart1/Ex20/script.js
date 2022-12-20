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

switch(true) {
    case nbEnfant==1 || nbEnfant==2 :
        partsEnfants = nbEnfant * 0.5;
    break;
    case nbEnfant >= 3 :
        partsEnfants = nbEnfant - 1;
    break;
}

nbParts = (nbAdulte + partsEnfants);
revenu = (netImposable / nbParts);

switch(true) {
    case revenu <= 10225 :
        Ech1 = 0;
    break;
    case revenu >= 10226 && revenu <= 26070 :
        Ech2 = ( (revenu-10225) * 0.11);
    break;
    case revenu >= 26071 && revenu <= 74545 :
        Ech3 = ( (revenu-26071) * 0.3);
    break;
    case revenu >= 74546 && revenu <= 160336 :
        Ech4 = ( (revenu-74546) * 0.41);
    break;
    case revenu >= 160336 :
        Ech5 = ( (revenu-160336) * 0.45);
    break;
}

Impots = (Ech1+Ech2+Ech3+Ech4+Ech5) * nbParts;

result.innerHTML += `Le montant de l'impôt sur le revenu pour un foyer composé de ${nbAdulte} adultes et de ${nbEnfant} enfants, avec un revenu fiscal de ${netImposable}&#128 s'élève à ${Impots}&#128.`;

