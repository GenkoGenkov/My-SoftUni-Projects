ALTER TABLE Minions.dbo.Users
DROP CONSTRAINT PK__Users__3214EC076D324B9D
ALTER TABLE Minions.dbo.Users
ADD CONSTRAINT PK_IdUsername PRIMARY KEY(Id, Username)