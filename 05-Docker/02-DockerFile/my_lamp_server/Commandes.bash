##  Construire une image docker depuis le Dockerfile
$ docker build -t my_lamp .

## Demarrer une instance
$ docker run -d --name my_lamp_c -p 8080:80 my_lamp