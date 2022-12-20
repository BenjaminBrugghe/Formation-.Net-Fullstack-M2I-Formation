const result = document.querySelector(`#Result`);
let Affichage = "";
let Somme = 0;
let best = 0;
let worst = 20;

let nbNotesUser = Number(prompt("Combien de notes devez-vous saisir ? "))
    Affichage += `La série contient ${nbNotesUser} notes :`
for (let nbNotes = 0; nbNotes < nbNotesUser; nbNotes++) 
{
    let note = Number(prompt("Veuillez saisir une note : "));
    Somme = Somme + note;
    Affichage += `<li> En note ${nbNotes+1}, vous avez saisi ${note}/20. </li>`;
    if (best<note) 
    {
       best = note;
    }
    if (worst>note) 
    {
        worst = note;
    }
}
Affichage += `<hr> Sur l'ensemble des ${nbNotesUser} notes :<br></br>`
Affichage += `<li> La meilleure note est de ${best}/20. </li>`;
Affichage += `<li> La moins bonne note est de ${worst}/20. </li>`;
let moyenne = Somme / nbNotesUser;
Affichage += `<li> La moyenne est de ${moyenne}/20. </li>`;

result.innerHTML += Affichage;