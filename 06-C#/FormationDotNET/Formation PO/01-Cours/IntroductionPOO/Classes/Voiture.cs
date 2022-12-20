using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voiture
    {
        #region Attributs (Privé)
        private string modele;
        private string couleur;
        private int reservoir;
        private int autonomie;
        private bool demarree;
        private bool arretee;
        private bool roule;
        private bool stoppe;
        private string klaxonne;
        #endregion

        #region Constructeur

        // ctor + tab + tab => Générer le constructeur vide
        // Necessaire à la création d'une newVoiture sans paramètres
        public Voiture()
        {
            Demarree = false;
            Arretee = true;
            Roule = false;
            Stoppe = true;
            Klaxonne = "";
        }

        //Generation automatique du constructeur :
        //selectionner les champs => Alt+Enter ""

        public Voiture(string modele, string couleur, int reservoir, int autonomie) : this() //Appelle les props du constructeur vide
        {
            Modele = modele;  // = this.modele = modele;
            Couleur = couleur;
            Reservoir = reservoir;
            Autonomie = autonomie;
        }
        #endregion

        #region Propriétés (Publiques)

        //Generation automatique des propriétés :
        //selectionner les champs => Alt+Enter "encapsuler les champs et utiliser la propriété"

        public string Modele { get => modele; set => modele = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }
        public bool Demarree { get => demarree; set => demarree = value; }
        public bool Arretee { get => arretee; set => arretee = value; }
        public bool Roule { get => roule; set => roule = value; }
        public bool Stoppe { get => stoppe; set => stoppe = value; }
        public string Klaxonne { get => klaxonne; set => klaxonne = value; }
        #endregion

        #region Methodes (Fonction appartenant à une classe)

        public string Demarrer()
        {
            string response = "";
            if (!Demarree)
            {
                Demarree = true;
                response = "La voiture vient de démarrer";
            }
            else
            {
                response = "Le moteur tourne déjà";
            }
            return response;
        }

        public string Arreter()
        {
            string response = "";
            if (Demarree)
            {
                if (!roule)
                {
                    Demarree = false;
                    response = "Le moteur est arrêté";
                }
                else
                {
                    response = "Impossible d'arrêter le moteur tant que la voiture roule !";
                }
            }
            else
            {
                response = "Le moteur est déjà arrêté.";
            }
            return response;
        }

        public string Rouler()
        {
            string response = "";
            if (Demarree)
            {
                Roule = true;
                reservoir -= 10;
                autonomie -= 130;
                response = $"La voiture roule ! Il vous reste {Reservoir}L pour une autonomie de {autonomie}km.";
            }
            else
            {
                response = "Le moteur est arrêté, impossible de rouler";
            }
            return response;
        }

        public string Stopper()
        {
            string response = "";
            if (Roule)
            {
                Roule = false;
                Stoppe = true;
                response = "La voiture vient de s'arrêter";
            }
            else
            {
                response = "La voiture est déjà arrêtée.";
            }
            return response;
        }

        public string Klaxonner()
        {
            string response = "Tut tut !";
            return response;
        }


        public override string ToString()
        {
            return $"La voiture est une {Modele} de couleur {Couleur}.\n" +
                    $"Elle a un réservoir de {Reservoir} litres et une autonomie de {Autonomie}km.";
        }

        #endregion


    }
}
