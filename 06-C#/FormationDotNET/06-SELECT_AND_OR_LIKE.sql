-- Requêtes pour tout les champs de la table Employee
SELECT * From EMPLOYEE

-- Requête de recherche des employés donc le prénom commence par S
SELECT Emp.EMP_ID,
        Emp.FIRST_NAME,
        Emp.LAST_NAME,
        Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'


-- Requête de recherche des employés donc le prénom commence par S
-- Et qui travaillent dans le département Opération (1)
SELECT Emp.EMP_ID,
        Emp.FIRST_NAME,
        Emp.LAST_NAME,
        Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID = 1


-- Requête de recherche des employés donc le prénom commence par S
-- Et qui travaillent dans le département Opération (1)
-- Et occupe le poste de caissier (Teller)
SELECT Emp.EMP_ID,
        Emp.FIRST_NAME,
        Emp.LAST_NAME,
        Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID = 1
AND Emp.TITLE = 'Teller'

-- Requête de recherche des employés donc le prénom commence par S ou par J
SELECT Emp.EMP_ID,
        Emp.FIRST_NAME,
        Emp.LAST_NAME,
        Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
OR Emp.FIRST_NAME LIKE 'J%'

-- Requête de recherche des employés donc le prénom se termine par AN
SELECT Emp.EMP_ID,
        Emp.FIRST_NAME,
        Emp.LAST_NAME,
        Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE '%AN'

-- Requête de recherche des employés donc le prénom est Susan
-- Et le nom est 'Barker'
SELECT Emp.EMP_ID,
        Emp.FIRST_NAME,
        Emp.LAST_NAME,
        Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME = 'Susan'
AND Emp.LAST_NAME = 'Barker'

