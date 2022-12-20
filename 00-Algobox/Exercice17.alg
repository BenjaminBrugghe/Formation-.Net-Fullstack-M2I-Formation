<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="POUR i ALLANT_DE 1 A 20"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2etat="inactif" F2lignes="" F2para=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" nbDecimales="8" totalBoucles="5000000" epaisseurLigne="2" totalAffichages="1000" maxBoucle="500000" epaisseurPoint="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#NoteTMP" algoitem="NoteTMP EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Max" algoitem="Max EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Min" algoitem="Min EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Notes" algoitem="Notes EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#NbNotes" algoitem="NbNotes EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#choix" algoitem="choix EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#Notes#0#pasliste" algoitem="Notes PREND_LA_VALEUR 0"/>
        <item code="5#NbNotes#0#pasliste" algoitem="NbNotes PREND_LA_VALEUR 0"/>
        <item code="19#Récupération des saisies utilisateur" algoitem="//Récupération des saisies utilisateur"/>
        <item code="12#i#1#20" algoitem="POUR i ALLANT_DE 1 A 20">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="4#Veuillez saisir la note  #0" algoitem="AFFICHER &quot;Veuillez saisir la note  &quot;"/>
            <item code="3#i#0#pasliste" algoitem="AFFICHER i"/>
            <item code="4# comprise entre 0 et 20 :#0" algoitem="AFFICHER &quot; comprise entre 0 et 20 :&quot;"/>
            <item code="2#NoteTMP#pasliste" algoitem="LIRE NoteTMP"/>
            <item code="6#NoteTMP >=0 ET NoteTMP&lt;=20" algoitem="SI (NoteTMP >=0 ET NoteTMP&lt;=20) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="6#i == 1" algoitem="SI (i == 1) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#Max#NoteTMP#pasliste" algoitem="Max PREND_LA_VALEUR NoteTMP"/>
                    <item code="5#Min#NoteTMP#pasliste" algoitem="Min PREND_LA_VALEUR NoteTMP"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="6#NoteTMP &lt; Min" algoitem="SI (NoteTMP &lt; Min) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#Min#NoteTMP#pasliste" algoitem="Min PREND_LA_VALEUR NoteTMP"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                        </item>
                        <item code="6#NoteTMP > Max" algoitem="SI (NoteTMP > Max) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#Max#NoteTMP#pasliste" algoitem="Max PREND_LA_VALEUR NoteTMP"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                        </item>
                        <item code="8#finsi" algoitem="FIN_SI"/>
                    </item>
                </item>
                <item code="5#Notes#Notes + NoteTMP#pasliste" algoitem="Notes PREND_LA_VALEUR Notes + NoteTMP"/>
                <item code="5#NbNotes#NbNotes + 1#pasliste" algoitem="NbNotes PREND_LA_VALEUR NbNotes + 1"/>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="19#Affichage du menu" algoitem="//Affichage du menu"/>
        <item code="5#choix#-1#pasliste" algoitem="choix PREND_LA_VALEUR -1"/>
        <item code="15#choix != 0" algoitem="TANT_QUE (choix != 0) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="6#choix == 1" algoitem="SI (choix == 1) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="4#La plus petite note est : #0" algoitem="AFFICHER &quot;La plus petite note est : &quot;"/>
                <item code="3#Min#0#pasliste" algoitem="AFFICHER Min"/>
                <item code="4#/20.#1" algoitem="AFFICHER &quot;/20.&quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="6#choix == 2" algoitem="SI (choix == 2) ALORS">
                        <item code="7#debutsi" algoitem="DEBUT_SI"/>
                        <item code="4#La plus grande note est : #0" algoitem="AFFICHER &quot;La plus grande note est : &quot;"/>
                        <item code="3#Max#0#pasliste" algoitem="AFFICHER Max"/>
                        <item code="4#/20.#1" algoitem="AFFICHER &quot;/20.&quot;"/>
                        <item code="8#finsi" algoitem="FIN_SI"/>
                        <item code="9#sinon" algoitem="SINON">
                            <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                            <item code="6#choix == 3" algoitem="SI (choix == 3) ALORS">
                                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                <item code="4#La moyenne des notes est : #0" algoitem="AFFICHER &quot;La moyenne des notes est : &quot;"/>
                                <item code="20#round(Notes/NbNotes)#0" algoitem="AFFICHERCALCUL round(Notes/NbNotes)"/>
                                <item code="4#/20.#1" algoitem="AFFICHER &quot;/20.&quot;"/>
                                <item code="8#finsi" algoitem="FIN_SI"/>
                                <item code="9#sinon" algoitem="SINON">
                                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                    <item code="4#Erreur, merci de choisr entre 0 et 3#1" algoitem="AFFICHER &quot;Erreur, merci de choisr entre 0 et 3&quot;"/>
                                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                                </item>
                            </item>
                            <item code="11#finsinon" algoitem="FIN_SINON"/>
                        </item>
                    </item>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="4#\t1) Afficher la plus petite note\n\t2) Afficher la plus grande note\n\t3) Afficher la moyenne des notes\n\t0) Quitter#1" algoitem="AFFICHER &quot;\t1) Afficher la plus petite note\n\t2) Afficher la plus grande note\n\t3) Afficher la moyenne des notes\n\t0) Quitter&quot;"/>
            <item code="4#\nVeuillez faire votre choix : #0" algoitem="AFFICHER &quot;\nVeuillez faire votre choix : &quot;"/>
            <item code="2#choix#pasliste" algoitem="LIRE choix"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
