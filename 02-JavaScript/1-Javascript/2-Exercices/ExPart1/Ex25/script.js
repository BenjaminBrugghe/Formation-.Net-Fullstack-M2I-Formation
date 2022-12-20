const result = document.querySelector(`#Result`);
let Affichage = "";

let nbUser = 45; //Number(prompt("Veuillez saisir un nombre : "));
let Somme = 0;
// let i = 0;
// let j = 0;

if(!isNaN(nbUser)) { // Pour vérifier que l'utilisateur a bien rentré un nombre
    Affichage += `<p>Voici la liste des entiers dont la somme est égale à ${nbUser} : </p>`;
    for (let i = 1; i <= nbUser / 2; i++) {
        Somme = i;
        let chaine = `${nbUser} = ${i}`;  //********************* */
    
        for (let j = i + 1; j <= (nbUser/2)+1; j++) {
            Somme = Somme + j;
            chaine += ` + ${j}`; //***************************** */
    
            if (Somme === nbUser) {
                Affichage += `<li> ${chaine} </li>`;
                break;
            }
            else if (Somme > nbUser) {
                break;
            }
        }
    }
};



result.innerHTML += Affichage;

// 45 = 1 >>> i
// +2 +3... >>> j 