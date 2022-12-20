<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER Response" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" arrondiAuto="vrai" nbDecimales="8" epaisseurPoint="2" epaisseurLigne="2" maxBoucle="500000" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="AB EST_DU_TYPE NOMBRE" code="1#NOMBRE#AB"/>
        <item algoitem="BC EST_DU_TYPE NOMBRE" code="1#NOMBRE#BC"/>
        <item algoitem="CA EST_DU_TYPE NOMBRE" code="1#NOMBRE#CA"/>
        <item algoitem="Response EST_DU_TYPE CHAINE" code="1#CHAINE#Response"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir la longeur du segment AB : &quot;" code="4#Veuillez saisir la longeur du segment AB : #0"/>
        <item algoitem="LIRE AB" code="2#AB#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir la longeur du segment BC : &quot;" code="4#Veuillez saisir la longeur du segment BC : #0"/>
        <item algoitem="LIRE BC" code="2#BC#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir la longeur du segment CA : &quot;" code="4#Veuillez saisir la longeur du segment CA : #0"/>
        <item algoitem="LIRE CA" code="2#CA#pasliste"/>
        <item algoitem="SI (AB == BC) ALORS" code="6#AB == BC">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="SI (BC == CA) ALORS" code="6#BC == CA">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="Response PREND_LA_VALEUR &quot;Le triangle est équilatéral&quot;" code="5#Response#&quot;Le triangle est équilatéral&quot;#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
                <item algoitem="SINON" code="9#sinon">
                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                    <item algoitem="Response PREND_LA_VALEUR &quot;Le triangle est isolcèle en B.&quot;" code="5#Response#&quot;Le triangle est isolcèle en B.&quot;#pasliste"/>
                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                </item>
            </item>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI (BC == CA) ALORS" code="6#BC == CA">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="Response PREND_LA_VALEUR &quot;Le triangle est isocèle en C.&quot;" code="5#Response#&quot;Le triangle est isocèle en C.&quot;#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI (AB == CA) ALORS" code="6#AB == CA">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="Response PREND_LA_VALEUR &quot;Le triangle est isocèle en A.&quot;" code="5#Response#&quot;Le triangle est isocèle en A.&quot;#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="Response PREND_LA_VALEUR &quot;Le triangle n'est isocèle ni en A, ni en B, ni en C.&quot;" code="5#Response#&quot;Le triangle n'est isocèle ni en A, ni en B, ni en C.&quot;#pasliste"/>
                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                            </item>
                        </item>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
        <item algoitem="AFFICHER Response" code="3#Response#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
