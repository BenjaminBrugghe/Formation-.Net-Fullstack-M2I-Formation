const result = document.querySelector(`#Result`);

let Annee = 2015;
let Population = 96809;
let Affichage = "";

while(Population<=121000) {
    Annee = Annee + 1 ;
    Population = Population * 1.0089;
    Affichage += `En ${Annee}, il y aura ${Population} habitants.<br>`;
}



result.innerHTML += Affichage;
