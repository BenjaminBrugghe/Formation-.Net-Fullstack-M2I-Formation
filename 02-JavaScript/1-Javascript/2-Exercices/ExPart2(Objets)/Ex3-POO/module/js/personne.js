export default class personne {
    constructor(param1, param2, param3, param4, param5, param6) {
        this.Genre = param1;
        this.Nom = param2;
        this.Prenom = param3;
        this.Naissance = param4;
        this.Telephone = param5;
        this.Email = param6;
    }
    Display = () => {
        return `
        <tr>
        <td>${this.Genre}</td>
        <td>${this.Nom}</td>
        <td>${this.Prenom}</td>
        <td>${this.Naissance}</td>
        <td>${this.Telephone}</td>
        <td>${this.Email}</td>  
        </tr> 
        `
    }
}