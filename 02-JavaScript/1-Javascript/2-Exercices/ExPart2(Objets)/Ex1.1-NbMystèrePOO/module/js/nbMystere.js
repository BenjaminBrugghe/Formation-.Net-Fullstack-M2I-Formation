import NumGenerator from "./NumGenerator.js";

export default class nbMystere {
  constructor() {
    this.numMystere = this.GenerateNbMystere();
    this.nbCoups = 0;
    this.Win = false;
  }

  GenerateNbMystere() {
    let generator = new NumGenerator();
    return generator.GenerateNumber(1, 50);
  }

  ValidButton() {
    if (!isNaN(userNum)) {
      this.NbCoups++;

      if (userNum == this.numMystere) {
        this.Win = true;
        return `Bravo ! Vous avez trouvé en ${thi.nbCoups} coups !`;
      }
      else if (userNum > this.numMystere) {
        return `Le nombre mystère est plus petit que ${userNum} `;
      }
      else if (userNum < this.numMystere) {
        return `Le nombre mystère est plus grand que ${userNum} `;
      }
      else {
        return "Veuillez saisir un nombre";
      }
    }
  }
}
