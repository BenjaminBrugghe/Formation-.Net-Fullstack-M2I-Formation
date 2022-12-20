const result = document.querySelector(`#Result`);
let Affichage = ``;


for (let i=1 ; i<=10 ; i++) 
{
    Affichage += `<div class="tab"> Table de <b> ${i} </b> : `;
    for (let j=1 ; j<=10 ; j++) 
    {
        Affichage += `<li> ${i} x ${j} = <b>${i*j} </li>`;
    }
    Affichage += `</div>`;
}

result.innerHTML += Affichage;