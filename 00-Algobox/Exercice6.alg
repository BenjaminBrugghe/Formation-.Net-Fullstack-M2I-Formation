<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER Cn" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2lignes="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" totalAffichages="1000" epaisseurLigne="2" nbDecimales="8" maxBoucle="500000" arrondiAuto="vrai" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="c EST_DU_TYPE NOMBRE" code="1#NOMBRE#c"/>
        <item algoitem="t EST_DU_TYPE NOMBRE" code="1#NOMBRE#t"/>
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="Cn EST_DU_TYPE NOMBRE" code="1#NOMBRE#Cn"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir le capital initial : &quot;" code="4#Veuillez saisir le capital initial : #0"/>
        <item algoitem="LIRE c" code="2#c#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le taux&quot;" code="4#Veuillez saisir le taux#0"/>
        <item algoitem="LIRE t" code="2#t#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le nombre d'années&quot;" code="4#Veuillez saisir le nombre d'années#0"/>
        <item algoitem="LIRE n" code="2#n#pasliste"/>
        <item algoitem="Cn PREND_LA_VALEUR round(c * pow(1+(t/100),n))" code="5#Cn#round(c * pow(1+(t/100),n))#pasliste"/>
        <item algoitem="AFFICHER &quot;Le montant total d'une épargne de &quot;" code="4#Le montant total d'une épargne de #0"/>
        <item algoitem="AFFICHER c" code="3#c#0#pasliste"/>
        <item algoitem="AFFICHER &quot; € placé à un taux de &quot;" code="4# € placé à un taux de #0"/>
        <item algoitem="AFFICHER t" code="3#t#0#pasliste"/>
        <item algoitem="AFFICHER &quot; % durant &quot;" code="4# % durant #0"/>
        <item algoitem="AFFICHER n" code="3#n#0#pasliste"/>
        <item algoitem="AFFICHER &quot; années s'éléve à &quot;" code="4# années s'éléve à #0"/>
        <item algoitem="AFFICHER Cn" code="3#Cn#0#pasliste"/>
        <item algoitem="AFFICHER &quot; €.&quot;" code="4# €.#1"/>
        <item algoitem="AFFICHER &quot;Le montant des intérêts s'élève à &quot;" code="4#Le montant des intérêts s'élève à #0"/>
        <item algoitem="AFFICHERCALCUL Cn-c" code="20#Cn-c#0"/>
        <item algoitem="AFFICHER &quot; €.&quot;" code="4# €.#1"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
