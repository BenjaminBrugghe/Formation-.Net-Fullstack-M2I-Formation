export default class Personne
{
    Nom:string;
    Prenom:string;
    Age:Number;
    AffichageInfo()
    {
        console.log("Nom: ",this.Nom);
        console.log("Prénom: ",this.Prenom);
        console.log("Age: ",this.Age);
    }
}
let personne1=new Personne();
personne1.Nom='Robin';
personne1.Prenom='Patrick';
personne1.Age=39;
personne1.AffichageInfo();
