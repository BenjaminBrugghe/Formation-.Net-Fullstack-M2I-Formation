import personne from "./js/personne.js";

const Infos = document.querySelector(`#Infos`);
const Valider = document.querySelector(`#btnValider`);
Valider.onclick = () => Ajouter();

let titre = "";
let lastname = "";
let firstname = "";
let naissance = "";
let telephone = "";
let email = "";

function Ajouter() {
    // titre = document.getElementById('Mr').checked ?"Mr":"Mme";
    // Récupération des valeurs des inputs
    titre = document.querySelector('input[name="Gender"]:checked').value;
    lastname = document.querySelector(`#lastname`).value;
    firstname = document.querySelector(`#firstname`).value;
    naissance = document.querySelector(`#naissance`).value;
    telephone = document.querySelector(`#telephone`).value;
    email = document.querySelector(`#Email`).value;

    let NewPerson = new personne(titre, lastname, firstname, naissance, telephone, email);

    Infos.innerHTML += NewPerson.Display();
    ClearInput();
}

function ClearInput() {
    lastname = document.querySelector(`#lastname`).value = "";
    firstname = document.querySelector(`#firstname`).value = "";
    //  naissance = document.querySelector(`#naissance`).value="";
    telephone = document.querySelector(`#telephone`).value = "";
    email = document.querySelector(`#Email`).value = "";
}

document.addEventListener("keyup", function (event) {
    if (event.key === "Enter") {
        Ajouter();
    }
})
