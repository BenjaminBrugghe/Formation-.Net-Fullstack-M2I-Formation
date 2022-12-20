var Annee;
Annee = 2005;
var Population;
Population = 96809;
var Affichage;
Affichage = "Accroissement de la population de Tourcoing \n\nEn 2005, il a été recensé 96809 habitants. \nLe taux d'accroiseement de la population étant de 0.89%. \n\nCombiens faudra-t-il d'années pour atteindre une population de 120.000 habitants ? \n";
var Affichage2;
var Affichage3;
console.log(Affichage);
for (Population; Population <= 121000; Population = Population * 1.0089) {
    Affichage2 = "En ".concat(Annee, ", il y aura ").concat(Population, " habitants.");
    console.log(Affichage2);
    Annee++;
}
Affichage3 = "\nAvec un taux d'accroissement de la population de 0.89%, en ".concat(Annee, ",\nil y aura ").concat(Population, " habitants dans la ville de Tourcocing.\nIl aura fallu ").concat(Annee, " ann\u00E9es.");
console.log(Affichage3);
