SELECT c.LastName, AVG(s.Length) AS CiagrLength, CEILING(AVG(s.RingRange)) AS CigarRingRange
	FROM Clients AS c
	JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
	JOIN Cigars AS cig ON cig.Id = cc.CigarId
	JOIN Sizes AS s ON s.Id = cig.SizeId
	WHERE c.Id IN (SELECT ClientId FROM ClientsCigars)
GROUP BY c.LastName
ORDER BY CiagrLength DESC