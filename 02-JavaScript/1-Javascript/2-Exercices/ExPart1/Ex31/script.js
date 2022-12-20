const result = document.querySelector(`#Result`);
const tableau = document.querySelector(`#Tableau`);
let Affichage = "";

var Annuaire = [
    {
        nom: "Dupont",
        prenom: "Jean",
        age: 15
    },
    {
        nom: "Durant",
        prenom: "Pierre",
        age: 16
    },
    {
        nom: "Martin",
        prenom: "Jean",
        age: 17
    }
];
tableau.innerHTML += `
<caption><b>List de contacts</b></caption>
                    <thead>
                        <th class="Title">Prénom </th>
                        <th class="Title">Nom </th>
                        <th class="Title">Age </th>
                    </thead>`;

for (let contact of Annuaire) {
    tableau.innerHTML += `<tr>
                            <td>${contact.prenom}</td> 
                            <td>${contact.nom}</td> 
                            <td>${contact.age}</td> 
                        </tr>`;
}

Affichage += `<br></br>La personne en <b> 2ème position </b> de l'annuaire est :<br></br> <b>${Annuaire[1].prenom} ${Annuaire[1].nom}</b> </br>`;

//
result.innerHTML = Affichage;