const result = document.querySelector(`#Result`);

var boisson = prompt(`***** DISTRIBUTEUR DE BOISSONS *****

        1) Eau
        2) Jus d'oranges
        3) Limonade
        4) Café
        5) Thé

        Faites votre choix :`);

switch(boisson){
    case "1":
        boisson = "Eau",
        result.innerHTML += `Votre ${boisson} est servi(e) !`;
    break;
    case "2":
        boisson = "Jus d'orange",
        result.innerHTML += `Votre ${boisson} est servi(e) !`;
    break;
    case "3":
        boisson = "Limonade",
        result.innerHTML += `Votre ${boisson} est servi(e) !`;
    break;
    case "4":
        boisson = "Café",
        result.innerHTML += `Votre ${boisson} est servi(e) !`;
    break;
    case "5":
        boisson = "Thé",
        result.innerHTML += `Votre ${boisson} est servi(e) !`;
    break;
    default:
        result.innerHTML += "ERREUR! Veuillez entrer un nombre valide.";
    break;
}
