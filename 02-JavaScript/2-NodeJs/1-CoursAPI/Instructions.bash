# Création d'un fichier app.js et mettre les instructions
console.log("Hello from NodeJs");

# Executer le fichier app.js, il faut saisir dans la console :
$ node app.js

# Initialiser
$ npm init

# Executer le script contenu dans le .json
$ npm run start

# Installation de Express
$ npm install express --save (--save : référence dans le .json)

# Restaurer les packages (il faut supprimer le package-lock.json, et le dossier node_modules)
$ npm install

# Installation de nodemon (permet de ne pas devoir redémarrer quand on fait des modifications (il suffit de rafraichir la page) )
$ npm install nodemon --save-dev

# Modifier le script "start"
"scripts": {
    "start": "node app.js"
    "dev": "nodemon app.js"
}

# Executer la commande et ouvrir le navigateur (modificer le fichier app.js, sauvegarder puis rafraichir le navigateur)
$ npm run dev

# création d'un end point pour notre api, rajouter (dans app.js)
app.get('/api/cours/1', (req, res) => res.send("Welcome to NodeJs cours"));

# Visiter la route
http://localhost:3000/api/cours/1

# EXERCICE 1 => mettre en place une route /api/cours qui retournera le nombre de formations contenues dans la liste Courslist.js

# EXERCICE 2 => Modifier le Endpoint /api/cours/:id afin de retourner la formation ayant cet ID

# Plug-in .Json pour Chrome
https://chrome.google.com/webstore/detail/json-viewer/gbmdgpbipfallnflgajpaliibnhdgobh

# EXERCICE 3 => Modifier le Endpoint /api/cours afin qu'il retourne la liste des formations au format .Json

# Installer Morgan (Middleware déjà existant) pour logger dans la console
$ npm install morgan --save-dev

# Installer serve-favicon (middleware)
$ npm install serve-favicon --save

# Installer plug-in Thunder Client / Postman (sur google)

# Création du Endpoint pour poster un nouveau cours:

# app.post(`/api/cours`,(req,res) =>  {
#   const id = coursList.length+1;
#   const coursCreated = {...req.body, ...{id:id, created:new Date() } };
#   courtsList.push(coursCreated);
#   const message = `Le cours ${coursCreated.name} a bien été ajouté`;
#   res.json(success(message, coursCreated) );
# })


# PUT => UPDATE

app.put(`/api/cours/:id`, (req, res) => {
    const id = parseInt(req.params.id);
    const coursUpdated = { ...req.body, ...{ id: id, created: new Date() } };
    coursList = coursList.map(cours => {
        return cours.id === id ? coursUpdated : cours;
    })
    const message = `Le cours ${coursUpdated.name} a été modifié.`;
    res.json(success(message, coursUpdated));
})

# DELETE

app.delete(`/api/cours/:id`,, (req, res) => {
    const id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === id);
    coursList = coursList.filter(cours => cours.id !== id);
    const message = `Le cours ${coursDeleted.name} a été bien supprimé.`;
    res.json(success(message, coursDeleted));
})

# Persistance des données en .Json

