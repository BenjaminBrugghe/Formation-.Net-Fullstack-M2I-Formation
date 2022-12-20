<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER &quot;Saisie Correcte!&quot;"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2defaut="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param maxBoucle="500000" totalBoucles="5000000" epaisseurPoint="2" nbDecimales="8" epaisseurLigne="2" arrondiAuto="vrai" totalAffichages="1000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="userNum EST_DU_TYPE NOMBRE" code="1#NOMBRE#userNum"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre&quot;" code="4#Veuillez saisir un nombre#0"/>
        <item algoitem="LIRE userNum" code="2#userNum#pasliste"/>
        <item algoitem="TANT_QUE (userNum &lt;1 OU userNum > 3) FAIRE" code="15#userNum &lt;1 OU userNum > 3">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="AFFICHER &quot;Saisie Incorrecte, veuillez réessayer...&quot;" code="4#Saisie Incorrecte, veuillez réessayer...#0"/>
            <item algoitem="LIRE userNum" code="2#userNum#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;Saisie Correcte!&quot;" code="4#Saisie Correcte!#0"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
