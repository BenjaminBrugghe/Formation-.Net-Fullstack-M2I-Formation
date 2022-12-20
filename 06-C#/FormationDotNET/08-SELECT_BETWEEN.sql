

SELECT * FROM Employee

-- Requete pour retourner les employés dont l'id est compris entre 5 et 10

SELECT * FROM Employee
WHERE EMP_ID BETWEEN 5 AND 10

-- Equivalent à :

SELECT * FROM Employee
WHERE EMP_ID >= 5 
AND EMP_ID <= 10

-- Requête permettant de connaitre les employés avec une date d'embauche comprise dans un certain interval

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
