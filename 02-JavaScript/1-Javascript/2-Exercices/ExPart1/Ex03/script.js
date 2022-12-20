const result = document.querySelector(`#Result`);

// const pi = math.PI
var pi = 3.141592653589793;
var diametre =0;
var perimetre=0;
var aire=0;

var diametre = Number(prompt("Veuillez saisir le diametre (en cm) : "));
result.innerHTML += `Diamètre = ${diametre}. <br></br> `;

perimetre = diametre * pi;
aire = pi * (diametre/2) * (diametre/2); // = pi * Math.pow(diametre/2, 2)
var perimetre2= Math.round(`${perimetre}`);
var aire2= Math.round(`${aire}`);

result.innerHTML += `Périmètre = ${perimetre} cm. <br></br> `;
result.innerHTML += `Aire = ${aire} cm. <br></br>`;
result.innerHTML += `Périmètre arrondi = ${perimetre2} cm.<br></br>`;
// result.innerHTML += `Périmètre arrondi = ${Math.round(perimetre2)} cm.<br></br>`;
result.innerHTML += `Aire arrondie = ${aire2}cm. <br></br>`;
