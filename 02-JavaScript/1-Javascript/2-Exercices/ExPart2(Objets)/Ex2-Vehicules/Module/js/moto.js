export default class moto {
    constructor(marque, modele, kilometrage, annee, clim) {
        this.Marque = marque;
        this.Modele = modele;
        this.Kilometrage = kilometrage;
        this.Anne = annee;
        this.Clim = clim;
    }
    display() {
        return `
        ${this.Marque} - ${this.Modele} - ${this.Kilometrage} - ${this.Anne} - ${this.Clim ? "Climatisée" : "Non climatisée"}
        `        
    }
}