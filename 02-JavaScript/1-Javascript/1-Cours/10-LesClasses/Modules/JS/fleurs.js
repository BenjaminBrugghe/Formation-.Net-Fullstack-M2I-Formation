import Vegetaux from "./Vegetaux.js";

export default class Fleurs extends Vegetaux {
    constructor(nom, type) {
        super(nom, type);
        this.Naissance();
    }
    Naissance() {
        super.Naissance();
        console.log("Les fleurs viennent d'une graine");
    }
}
