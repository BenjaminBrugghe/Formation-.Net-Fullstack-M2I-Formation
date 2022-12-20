<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot; année(s) pour doubler le capital. Le montant sera alors de &quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param nbDecimales="8" arrondiAuto="vrai" epaisseurPoint="2" totalAffichages="1000" totalBoucles="5000000" maxBoucle="500000" epaisseurLigne="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#Ci" algoitem="Ci EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Taux" algoitem="Taux EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Annee" algoitem="Annee EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Cf" algoitem="Cf EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir le capital initial#0" algoitem="AFFICHER &quot;Veuillez saisir le capital initial&quot;"/>
        <item code="2#Ci#pasliste" algoitem="LIRE Ci"/>
        <item code="4#Veuillez saisir le taux d'intérêt#0" algoitem="AFFICHER &quot;Veuillez saisir le taux d'intérêt&quot;"/>
        <item code="2#Taux#pasliste" algoitem="LIRE Taux"/>
        <item code="5#Taux#Taux/100#pasliste" algoitem="Taux PREND_LA_VALEUR Taux/100"/>
        <item code="15#Cf &lt; 2 * Ci" algoitem="TANT_QUE (Cf &lt; 2 * Ci) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="5#Annee#Annee + 1#pasliste" algoitem="Annee PREND_LA_VALEUR Annee + 1"/>
            <item code="5#Cf#round(Ci * pow(1+Taux,Annee))#pasliste" algoitem="Cf PREND_LA_VALEUR round(Ci * pow(1+Taux,Annee))"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
        <item code="4#Il faudra #0" algoitem="AFFICHER &quot;Il faudra &quot;"/>
        <item code="3#Annee#0#pasliste" algoitem="AFFICHER Annee"/>
        <item code="4# année(s) pour doubler le capital. Le montant sera alors de #0" algoitem="AFFICHER &quot; année(s) pour doubler le capital. Le montant sera alors de &quot;"/>
        <item code="3#Cf#0#pasliste" algoitem="AFFICHER Cf"/>
        <item code="4# €.#0" algoitem="AFFICHER &quot; €.&quot;"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
