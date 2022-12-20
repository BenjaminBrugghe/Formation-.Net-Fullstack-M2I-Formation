const result : any = document.querySelector('#result');

// let compte:number = 300;

// if (compte < 0)
//     console.log("Votre compte est débiteur");
// else if (compte = 0)
//     console.log("Votre solde est nul");
// else
//     console.log("Votre solde est créditeur");

result.innerhtml="<code>----- Table Multiplication -----\n";
for (let i = 1; i<=10 ; i++){
    result.innerhtml=`\n\tTable de ${i} : `;
    for (let j = 1 ; j <=10; j++)
    result.innerhtml=`\t\t- ${i} x ${j} = ${i*j}`;    
}
result.innerhtml="</code>";


/**
 * Array
 */
const legume = {
    code:Number,
    nom:String,
    prix:Number
}

const legumes=[
    {
        code:1,
        nom:"Carotte",
        prix:1.99
    },
    {
        code:2,
        nom:"Betterave",
        prix:0.99
    },
    {
        code:3,
        nom:"Laitue",
        prix:1.49
    },
    {
        code:4,
        nom:"Poivron Rouge",
        prix:4.99
    },
    {
        code:5,
        nom:"Poivron Vert",
        prix:4.99
    }
];

console.log("A la 3 eme position se trouve : "+legumes[2].nom);

function logLegume(legume:any){
    console.log(`- ${legume.nom} : ${legume.prix}€`);
}


legumes.forEach(logLegume);