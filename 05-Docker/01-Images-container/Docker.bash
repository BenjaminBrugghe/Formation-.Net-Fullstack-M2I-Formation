######################################################################
#               Tp1 - Premier conteneur Debian
######################################################################

## => Démarer un conteneur à partir d'une image debian:latest
## => Se connecter au bash du conteneur
## => mise à jour de ce conteneur
## => Installer l'editeur nano (vim)
## => Ecrire un fichier texte contenant du texte nommé texte.txt
## => Afficher le contenu du fichier texte.txt

########################### CORRECTION ###############################

## Rechercher l'image debian latest
$ docker search debian --filter "is-official = true"

## téléchargeement de l'image
$ docker pull debian:latest

## Instancier un conteneur à partir de l'image (avec bash pour connection directe)
$ docker run -ti --name=container_debian debian:latest bash

## Mise à jour du conteneur
$ apt update && apt upgrade

## Instalation de nano
$ apt install nano -y  

## Création du fichier texte (ecrire du contenu puis ctrl + x pour fermer)
$ nano text.txt

## execution du fichier texte.txt
$ cat text.txt

######################################################################
# Afficher les containers
docker ps -a     =>  (-a : affiche toutes les images, sinon affiche seulement celles actives)
# Afficher les images
docker images
# Supprimer
docker rm 'name'     (rmi pour une image)


