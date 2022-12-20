const result = document.querySelector (`#Result`);
const result2 = document.querySelector (`#Result2`);

import auto from "./js/auto.js";
import moto from "./js/moto.js";

let voiture1 = new auto ("Renault", "Kangoo", "240.000km", "2003", true);
let moto1 = new moto ("BMW", "R1150R Rockster", "65.000km", "2005", false);

console.log(voiture1);
console.log(moto1);

result.innerHTML = "<b>Voiture</b> : " + voiture1.display();
result2.innerHTML = "<b>Moto</b> : " + moto1.display();