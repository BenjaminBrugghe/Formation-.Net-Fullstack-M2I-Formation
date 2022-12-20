// 1- Création d'un élément React (JSX)

const nom = "Benjamin Brugghe";
const elementReact = <h2> Bonjour, {nom} </h2>;

// Création d'un composant React
function MyFirstComponent() {
    return (
        <h3> Bonjour, {nom} , from "MyFirstComponent"</h3>
    )
};

// Création d'un composant React avec paramètres
function MySecondComponent({nom,prenom}) {
    return (
        <h3>Bonjour, {nom} {prenom} , from "MySecondComponent"</h3>
    )
};

// Création d'un composant React avec paramètres et fonctions
const user = {firstname: "Benjamin",lastname: "Brugghe"};

function formatName(user) {
    return `
    ${user.firstname} ${user.lastname}`;
};
function MyThirdComponent({user}) {
    return (
        <h3>Bonjour, {formatName(user)} , from "MyThirdComponent"</h3>)
};


// *******************************
// Rendu de l'élément React
ReactDOM.render(
    elementReact,
    document.getElementById('idApp')
);

// Rendu avec un composant React
// Sans paramètre
ReactDOM.render(
    <React.Fragment>
        <MyFirstComponent></MyFirstComponent>
        <MyFirstComponent />
    </React.Fragment>,
    // <>
    //     <MyFirstComponent></MyFirstComponent>
    //     <MyFirstComponent />
    //     <MyFirstComponent />
    // </>,
    document.getElementById('idRoot')
);

// Rendu avec un composant React
// Avec paramètres
ReactDOM.render(
    <MySecondComponent nom="Mister" prenom="Bean"/>,
    document.getElementById('idRoot2')
);

// Rendu avec un composant React
// Avec paramètres et fonction
ReactDOM.render(
    <MyThirdComponent user={user} />,
    document.getElementById('idRoot3')
);