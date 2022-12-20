<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;Le plus grand nombre est &quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2lignes="" F2etat="inactif" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" totalAffichages="1000" totalBoucles="5000000" epaisseurLigne="2" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#Tmp" algoitem="Tmp EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#noteMax" algoitem="noteMax EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#noteMax#0#pasliste" algoitem="noteMax PREND_LA_VALEUR 0"/>
        <item code="12#i#1#6" algoitem="POUR i ALLANT_DE 1 A 6">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="4#Veuillez saisir le nombre n°#0" algoitem="AFFICHER &quot;Veuillez saisir le nombre n°&quot;"/>
            <item code="3#i#1#pasliste" algoitem="AFFICHER i"/>
            <item code="2#Tmp#pasliste" algoitem="LIRE Tmp"/>
            <item code="6#Tmp > noteMax" algoitem="SI (Tmp > noteMax) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#noteMax#Tmp#pasliste" algoitem="noteMax PREND_LA_VALEUR Tmp"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="4#Le plus grand nombre est #0" algoitem="AFFICHER &quot;Le plus grand nombre est &quot;"/>
        <item code="3#noteMax#1#pasliste" algoitem="AFFICHER noteMax"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
