<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="FIN_POUR"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2lignes="" F2para="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" totalAffichages="1000" maxBoucle="500000" epaisseurPoint="2" epaisseurLigne="2" nbDecimales="8" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nbUser EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbUser"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="Affichage EST_DU_TYPE CHAINE" code="1#CHAINE#Affichage"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir une nombre : &quot;" code="4#Veuillez saisir une nombre : #0"/>
        <item algoitem="LIRE nbUser" code="2#nbUser#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 1 A nbUser" code="12#i#1#nbUser">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="Affichage PREND_LA_VALEUR Affichage + &quot; &quot; + i" code="5#Affichage#Affichage + &quot; &quot; + i#pasliste"/>
            <item algoitem="AFFICHER Affichage" code="3#Affichage#1#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
