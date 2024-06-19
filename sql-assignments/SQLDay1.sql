
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND
ListPrice > 0

SELECT Name +' '+ Color
FROM Production.Product
WHERE Color IS NOT NULL 

SELECT 'NAME:'+Name+' '+'--'+'  '+'COLOR:' + Color
FROM Production.Product
WHERE Color IS NOT NULL 

SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('black', 'blue')

SELECT ProductID, Name
FROM Production.Product
WHERE Name LIKE 'S%'

SELECT Name, ListPrice
FROM Production.Product
ORDER BY Name

SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE '[A,S]%'
ORDER BY Name

SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%' 

SELECT DISTINCT Color 
FROM Production.Product
Where Color is not null
ORDER by Color DESC

SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
Where ProductSubcategoryID is not null AND color is not null 
Order by ProductSubcategoryID



