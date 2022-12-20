import EtreVivant from "./EtreVivant.js";

export default class Mammifere extends EtreVivant {
    constructor (ParamNom, ParamType) {
        super(ParamNom,ParamType);
        this.heartRate = false;
        this.Naissance();
    }

    Naissance() {
        this.heartRate = true;
        console.log("Quand un mammifère va naitre, il nait");
    }
    Mort() {
        this.heartRate = false;
        console.log("Quand un mammifère meurt, il meurt");
    }
    Respiration() {
        console.log("Un mammifère respire de l'oxygène");
    }
    Alimentation() {
        console.log("Un mammifère se nourrit de nourriture");
    }   
}