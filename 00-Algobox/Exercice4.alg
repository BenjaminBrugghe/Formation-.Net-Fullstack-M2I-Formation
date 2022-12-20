<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot; n'est pas divisible par 3&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" epaisseurPoint="2" maxBoucle="500000" totalAffichages="1000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#X" algoitem="X EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir un nombre : #0" algoitem="AFFICHER &quot;Veuillez saisir un nombre : &quot;"/>
        <item code="2#X#pasliste" algoitem="LIRE X"/>
        <item code="6#X % 3 == 0" algoitem="SI (X % 3 == 0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="4#le nombre #0" algoitem="AFFICHER &quot;le nombre &quot;"/>
            <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
            <item code="4# est divisible par 3#0" algoitem="AFFICHER &quot; est divisible par 3&quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="4#le nombre #0" algoitem="AFFICHER &quot;le nombre &quot;"/>
                <item code="3#X#0#pasliste" algoitem="AFFICHER X"/>
                <item code="4# n'est pas divisible par 3#0" algoitem="AFFICHER &quot; n'est pas divisible par 3&quot;"/>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
