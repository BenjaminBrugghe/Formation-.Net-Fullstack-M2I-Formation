// var

/*for (var i=0;i<5;i++)
{
    console.log('i = '+i)
}
console.log('après la boucle: i='+i);*/

// let
let i=0;
for (i=0;i<5;i++)
{
    console.log('i = '+i)
}
console.log('après la boucle: i='+i);

function Affichage()
{
    var j=0;
    if(j==0)
    {
        console.log(j);
    }
    j=0;
}

// const
const VAL='452';

const personne={
    nom:'Patrick',
    prenom:'Alain'
};
personne.nom='Robin';

console.log(personne.nom);

