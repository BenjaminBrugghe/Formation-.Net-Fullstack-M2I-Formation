<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" epaisseurPoint="2" maxBoucle="500000" totalAffichages="1000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#Nom" algoitem="Nom EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#Prenom" algoitem="Prenom EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#NomComplet" algoitem="NomComplet EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir votre nom :  : #1" algoitem="AFFICHER &quot;Veuillez saisir votre nom :  : &quot;"/>
        <item code="2#Nom#pasliste" algoitem="LIRE Nom"/>
        <item code="4#Veuillez saisir votre prénom : #0" algoitem="AFFICHER &quot;Veuillez saisir votre prénom : &quot;"/>
        <item code="2#Prenom#pasliste" algoitem="LIRE Prenom"/>
        <item code="5#NomComplet#Nom + &quot; &quot; + Prenom#pasliste" algoitem="NomComplet PREND_LA_VALEUR Nom + &quot; &quot; + Prenom"/>
        <item code="4#Votre nom complet est : #0" algoitem="AFFICHER &quot;Votre nom complet est : &quot;"/>
        <item code="3#NomComplet#1#pasliste" algoitem="AFFICHER NomComplet"/>
        <item code="103#commentaire" algoitem=""/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
