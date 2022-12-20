let Annee : number;
Annee = 2005;

let Population : number;
Population = 96809;

let Affichage : string;
Affichage = "Accroissement de la population de Tourcoing \n\nEn 2005, il a été recensé 96809 habitants. \nLe taux d'accroiseement de la population étant de 0.89%. \n\nCombiens faudra-t-il d'années pour atteindre une population de 120.000 habitants ? \n"

let Affichage2 : string;
let Affichage3 : string;

console.log(Affichage);

for (Population ; Population <= 121000 ; Population = Population * 1.0089) {
    Affichage2 = `En ${Annee}, il y aura ${Population} habitants.`;
    console.log(Affichage2);
    Annee++;
}

Affichage3 = `\nAvec un taux d'accroissement de la population de 0.89%, en ${Annee},\nil y aura ${Population} habitants dans la ville de Tourcocing.\nIl aura fallu ${Annee} années.`
console.log(Affichage3);