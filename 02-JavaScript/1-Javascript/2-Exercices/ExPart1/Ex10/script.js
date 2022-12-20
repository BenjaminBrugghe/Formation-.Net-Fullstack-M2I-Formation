const result = document.querySelector(`#Result`);

var email = "contact@teamjs.fr",
    mdp = "leLundiAuSoleil";

var emailUser = prompt("Veuillez saisir votre adresse mail : ");
var mdpUser = prompt("Veuillez saisir votre mot de passe : ");

if(email == emailUser && mdp == mdpUser ) 
{
    result.innerHTML += "Bienvenue sur votre espace sécurisé."
}
else
{
    result.innerHTML += "Erreur ! Veuillez saisir les informations correctes."
};
