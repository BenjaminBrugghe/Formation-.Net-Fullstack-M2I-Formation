<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER y" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" epaisseurPoint="2" maxBoucle="500000" totalAffichages="1000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#x" algoitem="x EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#y" algoitem="y EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Entrez un réel : #0" algoitem="AFFICHER &quot;Entrez un réel : &quot;"/>
        <item code="2#x#pasliste" algoitem="LIRE x"/>
        <item code="5#y#x#pasliste" algoitem="y PREND_LA_VALEUR x"/>
        <item code="6#x&lt;0" algoitem="SI (x&lt;0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#y#-x#pasliste" algoitem="y PREND_LA_VALEUR -x"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
        </item>
        <item code="4#La valeur absolue de #0" algoitem="AFFICHER &quot;La valeur absolue de &quot;"/>
        <item code="3#x#0#pasliste" algoitem="AFFICHER x"/>
        <item code="4# est #0" algoitem="AFFICHER &quot; est &quot;"/>
        <item code="3#y#0#pasliste" algoitem="AFFICHER y"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
