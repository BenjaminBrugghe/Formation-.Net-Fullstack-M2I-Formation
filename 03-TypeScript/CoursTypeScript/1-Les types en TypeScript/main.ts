// string

let nom: string;
nom = "Alain";

// number

let account: number = 5;
account = 20;

// boolean

let valable: boolean = true;
valable = false;

// array

let tab: string[] = ["alain", "mark", "Philippe"];
let tab2: number[];
tab2 = [4, 7, 9];
let tab3: boolean[] = [true, false, true];

// any

let variable: any;

variable = 15;
console.log(`${typeof (variable)} : ${variable}`);

variable = "Alain";
console.log(`${typeof (variable)} : ${variable}`);

variable = [1, 5, 7];
console.log(`${typeof (variable)} : ${variable}`);

variable = new Date();
console.log(`${typeof (variable)} : ${variable}`);

//enum
enum color {
    red = 0,
    black = 1,
    white = 2
};
let couleur: color = color.red;
console.log(couleur);

// Function void
function Affichage1(): void {
    console.log("message");
}

// Function string
function Affichage2(): string {
    return "message";
}

console.log(Affichage1());
console.log(Affichage1);

// const
const var1: number = 16;

//var1=2;

const var2 = {
    nom: 'Robin',
    prenom: 'Patrick'
};
var2.prenom = 'Alain';
console.log(var2.prenom);
console.log(`Prenom : ${var2.prenom}`);