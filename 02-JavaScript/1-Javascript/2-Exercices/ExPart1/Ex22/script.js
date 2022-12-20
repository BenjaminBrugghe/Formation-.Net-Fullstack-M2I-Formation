const result = document.querySelector(`#Result`);

for (let i = 1 ; i<=3 ; i++) 
{
    result.innerHTML += ` Chapitre<b> ${i}`;
        for(let j = 1 ; j <= 3 ; j++) 
        {
            result.innerHTML += `<li> -Partie <b> ${i} .<b> ${j} </li>`;
        }
}
