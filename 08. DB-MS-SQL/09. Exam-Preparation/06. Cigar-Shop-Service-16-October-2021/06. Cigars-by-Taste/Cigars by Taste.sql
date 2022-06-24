SELECT c.Id, c.CigarName, c.PriceForSingleCigar, t.TasteType, t.TasteStrength 
	FROM Cigars AS c
	JOIN Tastes AS t ON t.Id = c.TastId
WHERE TasteType = 'Earthy' OR TasteType = 'Woody'
ORDER BY PriceForSingleCigar DESC