export class Personne
{
   constructor( public Nom?:string, public Prenom?:string, public Age?:number)
   {
    
   }
   AffichageInfo()
   {
       console.log("Nom: ",this.Nom);
       console.log("Prénom: ",this.Prenom);
       console.log("Age: ",this.Age);
   }
}
export class Etudiant extends Personne{

    constructor( public Nom?:string, public Prenom?:string, public Age?:number, public NumeroCarteEtudiant?:number)
    {
        super(Nom,Prenom,Age);
    }
    AffichageInfo()
    {
      super.AffichageInfo();
      console.log("Numéro de carte étudiant: ",this.NumeroCarteEtudiant);
    }
}
let etudiant1=new Etudiant("Toto","Titi",18,14598);
etudiant1.AffichageInfo();