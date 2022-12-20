export class Personne {
    nom: string;
    prenom: string;
    age: number;

    constructor(public Nom?: string, public Prenom?: string, public Age?: number) {
        this.nom = Nom;
        this.prenom = Prenom;
        this.age = Age;
    }
    AffichageInfo() {
        console.log("Nom: ", this.Nom);
        console.log("Prénom: ", this.Prenom);
        console.log("Age: ", this.Age);
    }
}
let personne1 = new Personne("Robin", "Patrick", 39);
personne1.Nom = "";
personne1.AffichageInfo();