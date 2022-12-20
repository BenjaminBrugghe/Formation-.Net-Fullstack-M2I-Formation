const result = document.querySelector(`#Result`);

var chaine = prompt("Veuillez saisir une phrase");
var chaine2 = ""

result.innerHTML += `Vous avez saisis : <b> ${chaine} </b> <br><br> `;

chaine = chaine.toLowerCase();
result.innerHTML += `La chaine en minuscule : <b> ${chaine} </b> <br><br> `;

chaine2 = chaine.split("");
result.innerHTML += `Mise en tableau : <b> ${chaine2} </b> <br><br> `;

chaine = chaine.toLowerCase()  // Minuscules


// Traitement de la chaine avec mise en MAJ des premières lettres de chaque mot

chaineMEF = chaine.toLowerCase().split(" ").map(mot => mot[0].toUpperCase()+mot.slice(1)).join(" ");
result.innerHTML += `La chaine après traitement : <b> ${chaineMEF} </b>`;






// chaine = chaine.replace(/(^\w{1})|(\s{1}\w{1})/g, m => m.toUpperCase());
// result.innerHTML += `La chaine après traitement : <b> ${chaine} </b>`;


// sAlUt cOMmENt çA Va? mOi çA vA bIEn


// chaine = chaine[0].toUpperCase() + chaine.slice(1); // 1ère MAJ
// chaine = chaine.slice(0, chaine.indexOf(" ") +1) + chaine[chaine.indexOf(" ")+1].toUpperCase()+chaine.slice(chaine.indexOf(" ")+2); // 2ème MAJ

// chaine = chaine.slice(0, chaine.indexOf("omment")+7) + chaine[chaine.indexOf("omment")+7].toUpperCase() + chaine.slice(chaine.indexOf("omment")+8); // 3ème MAJ

// chaine = chaine.slice(0, chaine.lastIndexOf(" ")+1) + chaine[chaine.lastIndexOf(" ")+1].toUpperCase() + chaine.slice(chaine.lastIndexOf(" ")+2); // Dernière MAJ

// result.innerHTML += `La chaine après traitement : <b> ${chaine} </b>`;