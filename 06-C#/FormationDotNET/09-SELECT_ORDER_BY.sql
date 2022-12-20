-- Requête permettant de connaitre les employés avec une date d'embauche comprise dans un certain interval par ordre croissant

SELECT
Emp.EMP_ID,
Emp.FIRST_NAME,
Emp.LAST_NAME,
Emp.START_DATE,
CONVERT(VARCHAR, Emp.START_DATE, 106) AS START_DATE_CONVERT   -- 106 => Formatage jj-mm-aaaa
FROM Employee AS Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(datetime, '01 MAY 2002', 106)
AND CONVERT(datetime, '30-09-2002', 105)
ORDER BY START_DATE ASC -- ASC => Ordre Croissant (par défaut)



-- Requête permettant de connaitre les employés avec une date d'embauche comprise dans un certain interval par ordre décroissant

SELECT
Emp.EMP_ID,
Emp.FIRST_NAME,
Emp.LAST_NAME,
Emp.START_DATE,
CONVERT(VARCHAR, Emp.START_DATE, 106) AS START_DATE_CONVERT   -- 106 => Formatage jj-mm-aaaa
FROM Employee AS Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(datetime, '01 MAY 2002', 106)
AND CONVERT(datetime, '30-09-2002', 105)
ORDER BY START_DATE DESC -- DESC => Ordre Décroissant (par défaut)


-- Requete Pour trier par Product_Type en ordre croissant
-- Puis par Nom en ordre décroissant
SELECT Pro.Product_CD,
        Pro.PRODUCT_TYPE_CD,
        Pro.NAME
From Product AS Pro
ORDER BY Pro.PRODUCT_TYPE_CD ASC, Pro.NAME DESC

