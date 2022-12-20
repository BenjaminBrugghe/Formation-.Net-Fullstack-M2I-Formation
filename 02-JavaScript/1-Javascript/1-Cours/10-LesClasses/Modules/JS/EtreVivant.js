export default class EtreVivant {

        constructor(ParamPrenom, ParamNom) {
            this.Nom = ParamNom;
            this.Prenom = ParamPrenom;
        }
        Naissance() {
            console.log("Tous les êtres vivants naissent...");
        }
        Mort() {
            console.log("Tous les êtres vivants meurent...");
        }
        Respiration (){
            console.log("Tous les êtres vivants respirent");
        }
        Alimentation() {
            console.log("Tous les êtres vivants s'alimentent...à leur manière");
        }
    }