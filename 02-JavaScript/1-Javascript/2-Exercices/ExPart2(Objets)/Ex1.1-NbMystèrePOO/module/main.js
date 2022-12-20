import NumGenerator from "./js/NumGenerator.js";
import nbMystere from "./js/nbMystere.js";

const Ligne1 = document.querySelector(`#Ligne1`);
const Ligne2 = document.querySelector(`#Ligne2`);
const Ligne3 = document.querySelector(`#Ligne3`);
const IDinput = document.querySelector(`#IDinput`);
// const IDvalid = document.querySelector(`#IDvalid`);
const UserInput = parseInt(document.querySelector(`#IDinput`));
const NBcoups = document.querySelector(`#NBcoups`);
const validerBtn = document.querySelector(`#IDvalid`);
const rejouerBtn = document.querySelector(`#Rejouer`);

validerBtn.onclick = () => jeu.ValidButton();
rejouerBtn.onclick = () => Replay();

// Déclaration des variables globale
let jeu = new nbMystere();

function Init() {
  NBcoups.textContent = " " + jeu.NbCoups;
  Ligne1.textContent = "J'ai généré un nombre entre 1 et 50 inclus";
  Ligne2.textContent = "Essayez de le deviner en proposant ci-dessous";
  IDvalid.disabled = false;
  IDinput.value = "";
  jeu = new nbMystere();
}

function EndGame() {
  Ligne1.textContent = `Bravo ! Vous avez trouvé en ${NbCoups} coups ! `;
  Ligne2.textContent = `Le nombre mystère était ${nbRandom} ! `;
  IDvalid.disabled = true;
  IDinput.value = "";
}

function Valider() {
  let nbTmp = parseInt(UserInput.value);
  
}

function updateNbCoups() {
  NBcoups.textContent = " " + NbCoups;
}

function Replay() {
  Init();
}

// Permet de Valider en appuyant sur "Enter"
document.addEventListener("keyup", function (event) {
  if (event.key === "Enter" && IDinput.value !== "") {
    ValidButton();
  }
});

//
window.onload = Init();
