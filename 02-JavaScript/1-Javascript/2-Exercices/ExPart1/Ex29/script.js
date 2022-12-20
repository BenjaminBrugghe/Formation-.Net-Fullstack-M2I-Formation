const result = document.querySelector(`#Result`);
let Affichage = "";

let nbUser = Number(prompt("Veuillez saisir un nombre : "));
let Somme = 0;
let i = 0;
let j = 0;

if (!isNaN(nbUser)) {
    while (i <= nbUser / 2 + 1) {
        i++;
        Somme = i;
        j = i + 1;
        let chaine = `${nbUser} = ${i}`;

        while (j <= nbUser / 2 + 1) {
            Somme = Somme + j;
            chaine += ` + ${j}`;
            j++;

            if (Somme === nbUser) {
                Affichage += `<li> ${chaine} </li>`;
                break;
            }

            else if (Somme > nbUser) {
                break;
            }
        }
    }
}

result.innerHTML += Affichage;