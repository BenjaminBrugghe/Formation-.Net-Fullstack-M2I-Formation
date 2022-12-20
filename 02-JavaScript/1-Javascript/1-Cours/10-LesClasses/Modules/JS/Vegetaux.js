import EtreVivant from "./EtreVivant.js";

export default class Vegetaux extends EtreVivant {
    constructor (ParamNom, ParamType) {
        super(ParamNom,ParamType);
        this.photosynthese = false;
    }

    Naissance() {
        this.photosynthese = true;
        console.log("Quand un végétal va naitre, il va pousser vers le haut");
    }
    Mort() {
        this.photosynthese = false;
        console.log("Quand un végétal meurt, il meurt");
    }
    Respiration() {
        console.log("Un végétal respire");
    }
    Alimentation() {
        console.log("Un végétal se nourrit d'eau et de soleil");
    }
}