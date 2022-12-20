<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER plus_grand" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2para="" F2defaut="" F2lignes=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" arrondiAuto="vrai" nbDecimales="8" maxBoucle="500000" totalAffichages="1000" epaisseurPoint="2" epaisseurLigne="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES">
        <item code="201#plusGrand#A, B" algoitem="FONCTION plusGrand(A, B)">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION"/>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="6#A > B" algoitem="SI (A > B) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="205#A" algoitem="RENVOYER A"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="205#B" algoitem="RENVOYER B"/>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
    </item>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#x" algoitem="x EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#y" algoitem="y EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#plus_grand" algoitem="plus_grand EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#donner le premier nombre#0" algoitem="AFFICHER &quot;donner le premier nombre&quot;"/>
        <item code="2#x#pasliste" algoitem="LIRE x"/>
        <item code="4#donner le deuxieme nombre#0" algoitem="AFFICHER &quot;donner le deuxieme nombre&quot;"/>
        <item code="2#y#pasliste" algoitem="LIRE y"/>
        <item code="5#plus_grand#plusGrand(x,y)#pasliste" algoitem="plus_grand PREND_LA_VALEUR plusGrand(x,y)"/>
        <item code="3#plus_grand#0#pasliste" algoitem="AFFICHER plus_grand"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
