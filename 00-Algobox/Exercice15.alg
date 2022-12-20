<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_POUR" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" arrondiAuto="vrai" nbDecimales="8" totalBoucles="5000000" epaisseurLigne="2" maxBoucle="500000" epaisseurPoint="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#j" algoitem="j EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="12#i#1#10" algoitem="POUR i ALLANT_DE 1 A 10">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="4#Table de #0" algoitem="AFFICHER &quot;Table de &quot;"/>
            <item code="3#i#1#pasliste" algoitem="AFFICHER i"/>
            <item code="4# #1" algoitem="AFFICHER &quot; &quot;"/>
            <item code="12#j#1#10" algoitem="POUR j ALLANT_DE 1 A 10">
                <item code="13#debutpour" algoitem="DEBUT_POUR"/>
                <item code="3#i#0#pasliste" algoitem="AFFICHER i"/>
                <item code="4# x #0" algoitem="AFFICHER &quot; x &quot;"/>
                <item code="3#j#0#pasliste" algoitem="AFFICHER j"/>
                <item code="4# = #0" algoitem="AFFICHER &quot; = &quot;"/>
                <item code="20#i*j#1" algoitem="AFFICHERCALCUL i*j"/>
                <item code="14#finpour" algoitem="FIN_POUR"/>
            </item>
            <item code="4# #1" algoitem="AFFICHER &quot; &quot;"/>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
