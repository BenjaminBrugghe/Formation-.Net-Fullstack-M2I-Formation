<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="Response PREND_LA_VALEUR &quot;Ce n'est plus un enfant!&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" arrondiAuto="vrai" nbDecimales="8" epaisseurPoint="2" epaisseurLigne="2" maxBoucle="500000" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="Age EST_DU_TYPE NOMBRE" code="1#NOMBRE#Age"/>
        <item algoitem="Response EST_DU_TYPE CHAINE" code="1#CHAINE#Response"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir l'age de votre enfant : &quot;" code="4#Veuillez saisir l'age de votre enfant : #0"/>
        <item algoitem="LIRE Age" code="2#Age#pasliste"/>
        <item algoitem="SI (Age &lt; 3) ALORS" code="6#Age &lt; 3">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est trop jeune&quot;" code="5#Response#&quot;Votre enfant est trop jeune&quot;#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI (Age >=3 ET Age &lt;=6) ALORS" code="6#Age >=3 ET Age &lt;=6">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Baby.&quot;" code="5#Response#&quot;Votre enfant est dans la catégorie Baby.&quot;#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI (Age ==7 OU Age ==8) ALORS" code="6#Age ==7 OU Age ==8">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Poussin.&quot;" code="5#Response#&quot;Votre enfant est dans la catégorie Poussin.&quot;#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="SI (Age ==9 OU Age ==10) ALORS" code="6#Age ==9 OU Age ==10">
                                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                    <item algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Pupille.&quot;" code="5#Response#&quot;Votre enfant est dans la catégorie Pupille.&quot;#pasliste"/>
                                    <item algoitem="FIN_SI" code="8#finsi"/>
                                    <item algoitem="SINON" code="9#sinon">
                                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                        <item algoitem="SI (Age ==11 OU Age ==12) ALORS" code="6#Age ==11 OU Age ==12">
                                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                            <item algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Minime.&quot;" code="5#Response#&quot;Votre enfant est dans la catégorie Minime.&quot;#pasliste"/>
                                            <item algoitem="FIN_SI" code="8#finsi"/>
                                            <item algoitem="SINON" code="9#sinon">
                                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                                <item algoitem="SI (Age >=13 ET Age &lt;18) ALORS" code="6#Age >=13 ET Age &lt;18">
                                                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                                    <item algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Cadet.&quot;" code="5#Response#&quot;Votre enfant est dans la catégorie Cadet.&quot;#pasliste"/>
                                                    <item algoitem="FIN_SI" code="8#finsi"/>
                                                    <item algoitem="SINON" code="9#sinon">
                                                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                                        <item algoitem="Response PREND_LA_VALEUR &quot;Ce n'est plus un enfant!&quot;" code="5#Response#&quot;Ce n'est plus un enfant!&quot;#pasliste"/>
                                                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                                                    </item>
                                                </item>
                                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                                            </item>
                                        </item>
                                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                                    </item>
                                </item>
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
