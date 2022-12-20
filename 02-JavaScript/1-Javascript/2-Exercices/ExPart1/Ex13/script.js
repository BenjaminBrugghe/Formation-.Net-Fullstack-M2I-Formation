const result = document.querySelector(`#Result`);

var age=Number(prompt("Veuillez saisir l'age de votre enfant : "));


if (age>=3 && age<=6)
{
    result.innerHTML += `Votre enfant est dans la catégorie Baby`
}
else if (age>=7 && age<=8)
{
    result.innerHTML += `Votre enfant est dans la catégorie Poussin`
}
else if (age>=9 && age<=10)
{
    result.innerHTML += `Votre enfant est dans la catégorie Pupille`
}
else if (age>=11 && age<=12)
{
    result.innerHTML += `Votre enfant est dans la catégorie Minime`
}
else if (age>=13)
{
    result.innerHTML += `Votre enfant est dans la catégorie Cadet`
}
else 
{
    result.innerHTML += `ERREUR! Votre enfant est trop jeune !`
};
