// 1ere déclaration
function Affichage(message:string):string
{
    return "Fonction = " +message;

}
let message=Affichage("hello world");
console.log(message);

// 2eme déclaration

let Affichage2=function (message:string):string{
    return 'Fonction 2 '+message;
}
let message2=Affichage2("Hello world");

// 3eme déclaration Arrow function

let Affichage3=(message:string):string=>{
    return 'Fonction Arrow' + message;
}
let message3=Affichage3("hello world");

let Addition=(a:number,b:number):number=>
{
    return a+b;
}
console.log(Addition(4,5));

let Addition2=():string=>"Addition";
console.log(Addition2());



