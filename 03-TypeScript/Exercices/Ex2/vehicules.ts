export default class vehicules {
    marque: string;
    modele: string;
    kilometrage: number;
    annee: number;
    clim:boolean = true;

    constructor(
        public Marque?: string,
        public Modele?: string,
        public Kilometrage?: number,
        public Annee?: number,
        public Clim?: boolean = true,
        ) {
            this.marque = Marque;
            this.modele = Modele;
            this.kilometrage = Kilometrage;
            this.annee = Annee;
            this.clim = Clim;
        }
}
