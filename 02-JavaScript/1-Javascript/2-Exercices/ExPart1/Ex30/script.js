const result = document.querySelector(`#Result`);
let Affichage = "";

let Somme = 0;
let best = 0;
let worst = 20;
let nbNotes = 0;
let nbUser = 0;

Affichage += `La série contient <b>les notes suivantes</b> : <br></br>`

while (nbUser != 777) {
    nbUser = Number(prompt("Veuillez entrer une note entre 0 et 20 (ou 777 pour sortir) : "));
    if (nbUser != 777) {
        if (nbUser >= 0 && nbUser <= 20) {
            Somme = Somme + nbUser;
            nbNotes++;
            Affichage += `<li> En note <b>${nbNotes}</b>, vous avez saisi <b>${nbUser}/20.</b></li>`;
            if (best < nbUser && nbUser != 777) {
                best = nbUser;
            }
            if (worst > nbUser && nbUser != 777) {
                worst = nbUser;
            }
        }
        else {
            alert("ERREUR! Veuillez entrer un nombre valide : ");
        }
    }   
}
Affichage += `<hr> Sur l'ensemble des <b>${nbNotes}</b> notes :<br></br>`
Affichage += `<li class="Green"> La meilleure note est de <b>${best}/20.</b> </li>`;
Affichage += `<li class="Red"> La moins bonne note est de <b>${worst}/20.</b> </li>`;
console.log(`${Somme}`);
let moyenne = Somme / nbNotes;
Affichage += `<li class="Blue"> La moyenne est de <b>${Math.round(moyenne)}/20.</b> </li>`;
//
result.innerHTML = Affichage;