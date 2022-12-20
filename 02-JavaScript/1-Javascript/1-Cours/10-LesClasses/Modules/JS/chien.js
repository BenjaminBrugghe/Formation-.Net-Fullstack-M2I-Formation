import Mammifere from "./Mammiferes.js";

export default class Chien extends Mammifere {
    Alimentation() {
        console.log("Les chiens mangent des croquettes");
    }
    Respiration() {
        console.log("Un chien respire, oui...");
    }
    Aboyer() {
        if(this.heartRate) {
            console.log("Wouaf, wouaf, meh..");
        }
        else {
            console.log("Je suis mort, je ne peux pas aboyer");
        }
    }
}
