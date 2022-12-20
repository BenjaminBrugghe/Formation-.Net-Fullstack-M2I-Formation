# Créer les fichiers
index.html
main.js

# Ajouter dans le body
<!-- Rendu des éléments React  -->
<div id="idApp"></div>

<!-- Liens vers les ressources ext -->
<script src="./app.js" type="text/babel"></script>

# Initialisation du repos npm
$ npm init

# Installation des package React et Babel
$ npm install react --save
$ npm install react-dom --save
$ npm install --save-dev @babel/preset-react
$ npm install nodemon --save-dev

# Création du composant parent de tout les composants React de notre application
App.js

# Contenu du fichier main.js
import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';

ReactDOM.render (
    <React.StrictMode>
        <App/>
    </React.StrictMode>,
    document.getElementById('#idRoot')
)

# Settings .json
"emmet.includeLanguages": { "javascript": "javascriptreact" },
"emmet.triggerExpansionOnTab": true,