const result = document.querySelector(`#Result`);
const menu = document.querySelector(`#Menu`);
const notes = document.querySelector(`#Notes`);

let Affichage = "";
let noteMax = 0;
let noteMin = 20;
let moyennne = 0;
let somme = 0;
let nbUser = 0;
let nbNotes = 0;

function Menu() {
    return `<button onClick="SetNotes()" class="btn btn-primary"> Saisir les notes </button>
            <button onClick="Best()" class="btn btn-success"> Voir la meilleure note </button>
            <button onClick="Worse()" class="btn btn-danger"> Voir la moins bonne note </button>
            <button onClick="Moyenne()" class="btn btn-secondary"> Voir la moyenne </button>`
}

function ResetAll() {
    noteMax = 0;
    noteMin = 20;
    moyennne = 0;
    somme = 0;
    nbUser = 0;
    nbNotes = 0;
    result.innerHTML = "";
    notes.innerHTML = "";
}

function SetNotes() {
    ResetAll();
    while (nbUser != 777) {
        nbUser = Number(prompt("Veuillez entrer une note entre 0 et 20 (ou 777 pour sortir) : "));
        if (nbUser != 777) {
            if (nbUser >= 0 && nbUser <= 20) {
                somme += nbUser;
                nbNotes++;
                result.innerHTML += `<li> En note <b>${nbNotes}</b>, vous avez saisi <b>${nbUser}/20.</b></li>`;
                if (noteMax < nbUser && nbUser != 777) {
                    noteMax = nbUser;
                }
                if (noteMin > nbUser && nbUser != 777) {
                    noteMin = nbUser;
                }
            }
            else {
                alert("ERREUR! Veuillez entrer un nombre valide : ");
            }
        }
    }
}

function Best() {
    notes.innerHTML =  `<li class="Green"> La meilleure note est de <b>${noteMax}/20.</b> </li>`;
}
function Worse() {
    notes.innerHTML = `<li class="Red"> La moins bonne note est de <b>${noteMin}/20.</b> </li>`;
}
function Moyenne() {
    moyenne = somme/nbNotes;
    notes.innerHTML = Affichage += `<li class="Blue"> La moyenne est de <b>${Math.round(moyenne)}/20.</b> </li>`;
}

function Init() {
    menu.innerHTML = Menu();
}

window.onload = Init(); // Déclenche la fonction Init() au lancement de la page

//
result.innerHTML = Affichage;