const result = document.querySelector(`#Result`);
let Affichage = "";
let chaine = "";
let Moy1=0;
let total=0;
let nbNotes=0;

var etudiants = [
    { prenom: "José", nom: "Garcia", matieres: { français: 16, anglais: 7, humour: 14 } },
    { prenom: "Antoine", nom: "De Caunes", matieres: { français: 15, anglais: 6, humour: 16, informatique: 4, sport: 10 } }]

for (let temp of etudiants) 
{
    Affichage += `<br>${temp.prenom} ${temp.nom}</br>`;
    total=0;
    nbNotes=0;

    for(let temp2 in temp.matieres)
    {
        Affichage += `<li> ${temp2} : ${temp.matieres[temp2]}/20 </li>`;
        total += temp.matieres[temp2];
        nbNotes = nbNotes + 1;
    }
    Affichage += `Moyenne général de l'élève : ${Math.round(total/nbNotes)}/20.   <br>`
}

result.innerHTML += Affichage;