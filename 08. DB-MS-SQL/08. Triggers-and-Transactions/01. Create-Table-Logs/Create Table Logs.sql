CREATE TRIGGER tr_AddingLog ON Accounts FOR UPDATE
AS
DECLARE @newSum DECIMAL(15, 2) = (SELECT Balance FROM inserted)
DECLARE @oldSum DECIMAL(15, 2) = (SELECT Balance FROM deleted)
DECLARE @accountId INT = (SELECT Id FROM inserted)

INSERT INTO Logs (AccountId, NewSum, OldSum) VALUES
(@accountId, @newSum, @oldSum)

UPDATE Accounts
SET Balance += 10
WHERE Id = 1