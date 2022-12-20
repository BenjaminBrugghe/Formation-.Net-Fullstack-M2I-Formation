-- Requête pour voir le contenu des données de la table Product_Type

SELECT * FROM Product_Type;

-- Requête pour voir le contenu des données de la table Officer

SELECT * FROM Officer;

-- Possibilité de donner un alias à une table
SELECT Pty.* FROM Product_Type Pty;


-- Requête pour voir le contenu des données de la table Product_Type

SELECT Pty.PRODUCT_TYPE_CD,Pty.NAME FROM Product_Type AS Tpy;