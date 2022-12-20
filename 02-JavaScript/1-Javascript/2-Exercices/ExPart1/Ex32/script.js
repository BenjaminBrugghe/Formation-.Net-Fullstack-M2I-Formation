const result = document.querySelector(`#Result`);
let Affichage ="";

function Perimetre(titi, toto){
   let perimetre = (titi + toto)*2 ;
    return perimetre;
}

function Aire(pika, chu) {
    let aire = pika * chu;
    return aire;
}

nb1 = Number(prompt("Veuillez saisir la longueur : "))
nb2 = Number(prompt("Veuillez saisir la largeur : "))

let resultat = Perimetre(nb1, nb2);
Affichage += `Le périmètre est de : ${resultat} cm.`;

let resultat2 = Aire(nb1,nb2);
Affichage += `<br></br>L'aire est de : ${resultat2} cm². <br></br>`;

//
result.innerHTML = Affichage;