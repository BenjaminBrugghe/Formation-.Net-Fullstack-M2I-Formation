const Ligne1 = document.querySelector(`#Ligne1`);
const Ligne2 = document.querySelector(`#Ligne2`);
const Ligne3 = document.querySelector(`#Ligne3`);
const IDinput = document.querySelector(`#IDinput`);
const IDvalid = document.querySelector(`#IDvalid`);
const UserInput = parseInt(document.querySelector(`#IDinput`));
const NBcoups = document.querySelector(`#NBcoups`);


// Generation de l'aléatoire

function entierAleatoire(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
let NbCoups = 0;
let nbMystere = 0;

Init = () => {
    Ligne1.textContent = "J'ai généré un nombre entre 1 et 50 inclus";
    Ligne2.textContent = "Essayez de le deviner en proposant ci-dessous";
    IDinput.value = "";
    IDvalid.disabled = false;
    NbCoups = 0;
    nbMystere = entierAleatoire(1,50);
    NBcoups.textContent = " " + NbCoups;
}

EndGame = () => {
    Ligne1.textContent = `Bravo ! Vous avez trouvé en ${NbCoups} coups ! `
    Ligne2.textContent = `Le nombre mystère était ${nbRandom} ! `
    IDvalid.disabled = true;
    IDinput.value = "";
}

ValidButton = () => {
    let NbTmp = parseInt(IDinput.value);
    SoftReset();

    if (NbTmp == nbMystere) {
        IDinput.value = "";
        EndGame();
    }
    else if (NbTmp > nbMystere) {
        Ligne1.textContent = `Le nombre mystère est plus petit que ${NbTmp} `
    }
    else if (NbTmp < nbMystere) {
        Ligne1.textContent = `Le nombre mystère est plus grand que ${NbTmp} `
    }
    IDinput.value = "";
}

SoftReset = () => {
    NbCoups++;
    NBcoups.textContent = " " + NbCoups;
}

Replay = () => {
    Init();
}

// Permet de Valider en appuyant sur "Enter"
document.addEventListener("keyup", function (event) {
    if (event.key === "Enter" && IDinput.value !== "") {
        ValidButton();
    }
})

//
window.onload = Init();