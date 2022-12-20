const result = document.querySelector(`#Result`);

let Annee = 2015;
let Population = 0;
let Affichage = "";

for (Population = 96809 ; Population<=121000 ; Population = Population * 1.0089) {
    Affichage += `En ${Annee}, il y aura ${Population} habitants.<br>`,
    Annee = Annee + 1 ;
};


result.innerHTML += Affichage;