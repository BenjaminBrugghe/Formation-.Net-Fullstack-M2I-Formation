const result = document.querySelector('#Result')

var nom=""
var prenom=""

var nom = (prompt("Veuillez entrer votre nom"));
result.innerHTML += `Votre nom est <strong> ${nom}</strong>. <br></br>`;

var prenom = (prompt("Veuillez entrer votre prenom"));
result.innerHTML += `Votre prenom est <strong>${prenom}</strong>. <br></br> `;

result.innerHTML += `Bonjour <strong> Mr. ${nom} ${prenom}</strong>! `;
