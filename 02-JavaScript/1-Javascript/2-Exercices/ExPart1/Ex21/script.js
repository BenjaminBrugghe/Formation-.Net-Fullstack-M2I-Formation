const result = document.querySelector(`#Result`);
let Affichage = "";

let i=1;
for(i ; i<=10 ; i++){
    Affichage += `<li>${i}</li>` ;
};
console.log(i);
Affichage += "<br>Je sais compter jusqu'à 10 !";


result.innerHTML = Affichage;
