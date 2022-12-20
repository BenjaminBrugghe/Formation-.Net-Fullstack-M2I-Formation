const result = document.querySelector(`#Result`);

var Taille = prompt("Veuillez saisir votre taille : ");
var Poids = prompt("Veuillez saisir votre poids : ");

if ((Poids>=43 && Poids<= 47) && (Taille>=145 && Taille<=169)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 1.`;
}
else if ((Poids>=48 && Poids<= 53) && (Taille>=145 && Taille<=166)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 1.`;
}
else if ((Poids>=54 && Poids<= 59) && (Taille>=145 && Taille<=163)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 1.`;
}
else if ((Poids>=60 && Poids<= 65) && (Taille>=145 && Taille<=160)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 1.`;
}

else if ((Poids>=48 && Poids<= 53) && (Taille>=169 && Taille<=178)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 2.`;
}
else if ((Poids>=54 && Poids<= 59) && (Taille>=166 && Taille<=175)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 2.`;
}
else if ((Poids>=60 && Poids<= 65) && (Taille>=163 && Taille<=172)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 2.`;
}
else if ((Poids>=66 && Poids<= 571) && (Taille>=160 && Taille<=175)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 2.`;
}
else if ((Poids>=54 && Poids<= 59) && (Taille>=178 && Taille<=183)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 3.`;
}
else if ((Poids>=60 && Poids<= 65) && (Taille>=175 && Taille<=183)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 3.`;
}
else if ((Poids>=66 && Poids<= 71) && (Taille>=172 && Taille<=183)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 3.`;
}
else if ((Poids>=72 && Poids<= 77) && (Taille>=163 && Taille<=183)) {
    result.innerHTML += `Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, prenez la taille 3.`;
}
else
{
    result.innerHTML += `ERREUR! Pour une taille de ${Taille}cm et un poids de ${Poids}Kg, il n'y a pas de taille.`;

};
