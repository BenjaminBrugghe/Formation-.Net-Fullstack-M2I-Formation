######################################################################
#               Serveur Node.js
######################################################################
$ docker start -it container -p 8080:80 bash

# Création d'un conteneur Docker basé sur une image Linux Debian et redirigeant le port 8080 de l'hôte vers le port 80 du conteneur

$ docker run -it --name=container_web_server -p 8080:80 debian:latest bash

# Mise à jour du conteneur

$ apt update && apt upgrade -y    => (-y accepte la MAJ automatiquement)

# Installation de node.js, NPM, nano

$ apt install nodejs -y && apt install npm -y && apt install nano -y

# Création du fichier index.js

$ nano index.js

# Copier les instructions suivantes :

const express = require("express")
const http = require ("http")
const app = express()

app.get('/', (req,res)=> {
    res.end("Bonjour depuis mon serveur node.js...")
    http.request('http://'+process.env.ADRESS_APACHE4)
})

app.listen(80,()=> {
    console.log("app is running")
})

# Initialisation d'un projet npm

$ npm init

# installation de Express

$ npm install -g express

# Alexandre :
Créer un dossier => cd 'nom du dossier' => npm init => npm install express => node index.js

