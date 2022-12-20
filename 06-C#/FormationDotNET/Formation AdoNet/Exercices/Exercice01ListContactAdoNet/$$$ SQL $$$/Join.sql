
SELECT 
pe.id,
pe.Lastname,
pe.Firstname,
pe.DateOfBirth,
ad.Numero,
ad.Rue,
ad.CodePostal,
ad.Ville,
ad.Pays,
co.Telephone,
co.Email
FROM ADRESSE ad
INNER JOIN PERSONNE pe
ON ad.Id = pe.Id
INNER JOIN CONTACT co
ON co.Id = ad.Id

