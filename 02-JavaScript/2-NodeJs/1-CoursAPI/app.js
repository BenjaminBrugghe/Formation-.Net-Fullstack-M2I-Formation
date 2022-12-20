const express = require('express');
const morgan = require('morgan');
const favicon = require('serve-favicon');
const { success , getUniqueId } = require(`./helper.js`);
const bodyParser = require('body-parser');

const {readFileSync, writeFileSync} = require('fs');

let coursList = JSON.parse(readFileSync('./data/saveList.json', 'utf-8'));
// let coursList = require('./data/CoursList.js');

// Instanciation de Express
const app = express();

// Définition du port de communication
const port = 7777;

// Déclaration des MiddleWare pour logger des requêtes dans la console
const logger = (req, res, next) => {
    console.log(`URL : ${req.url}`);
    next();
}

app
    .use(favicon(__dirname + `/favicon.ico`)) //_dirname => va chercher tout le chemin automatiquement
    .use(morgan(`dev`))
    .use(bodyParser.json());

// ********** POUR SAUVEGARDER **********

function SaveList(){
    const objectToJson = JSON.stringify(coursList);
    writeFileSync('./data/saveList.json', objectToJson);
    console.log("Données sauvegardées avec succès.");
}






// Mise en place du End Point pour notre Api
app.get('/', (req, res) => res.send("Hello from Node-Js, après maj"));

// app.get('/api/cours/:id', (req, res) => {
//     const id = parseInt(req.params.id);
//     console.log(id);
//     res.send(`Welcome to NodeJs cours n° ${id}`)
// }
// );

app.get('/api/cours/:id/:name', (req, res) => {
    const id = parseInt(req.params.id);
    const cours = req.params.name;
    console.log(cours);
    res.send(`Welcome to NodeJs cours n° ${id} => ${cours}`)
}
);


// ********** EXERCICE 1 **********

// console.table(coursList);

// app.get(`/api/cours`, (req, res) => {
//     res.send(`Il y a ${coursList.length} cours dans notre catalogue`)
// }
// );

// ********** EXERCICE 2 **********

// app.get(`/api/cours/:id`, (req, res) => {
//     const id = parseInt(req.params.id);
//     const cours = coursList.find(cours => cours.id === id);
//     res.send(cours)
// }
// );

// ************ Après création de helper.js ***************

app.get(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const cours = coursList.find(cours => cours.id === id);
    const message = "Un cours a été trouvé";
    if (cours != null) {
        res.json(success(message, cours));
    }
    else {
        res.send("Cette formation n'existe pas!");
    }
}
);

// ********** EXERCICE 3 **********

app.get(`/api/cours`, (req, res) => {
    const message = `Il y a ${coursList.length} cours dans notre catalogue`;
    res.json(success(message, coursList));
}
);

// ******************* POST ********************

// Création du Endpoint pour poster un nouveau cours
app.post(`/api/cours`, (req, res) => {
    const id = getUniqueId(coursList);
    const coursCreated = { ...req.body, ...{ id: id, created: new Date() } };
    coursList.push(coursCreated);
    const message = `Le cours ${coursCreated.name} a bien été ajouté`;
    res.json(success(message, coursCreated));
    SaveList();
})

// ****************** PUT *********************

app.put(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const coursUpdated = { ...req.body, ...{ id: id, updated: new Date() } };
    coursList = coursList.map(cours => {
        return cours.id === id ? coursUpdated : cours;
    })
    const message = `Le cours ${coursUpdated.name} a bien été modifié.`;
    res.json(success(message, coursUpdated));
    SaveList();
})



// ****************** DELETE *********************

app.delete(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === id);
    coursList = coursList.filter(cours => cours.id !== id);
    const message = `Le cours ${coursDeleted.name} a été bien supprimé.`;
    res.json(success(message, coursDeleted));
    SaveList();
})







//
app.listen(port, () => console.log(`L'application est démarrée sur : http://localhost:${port}`));