GO
CREATE PROC InsertDoc(
@docname nvarchar(50))
AS
INSERT Doctors VALUES (@docname)
GO

GO
CREATE PROC InsertPat(
@patname nvarchar(50))
AS
INSERT Patients VALUES (@patname)
GO

GO
CREATE PROC InsertApp(
@apptime datetime,
@appdocid int,
@apppatid int)
AS
INSERT Appointments VALUES (@apptime,@apppatid,@appdocid)
GO

GO
CREATE PROC RemoveApp(
@appid int)
AS
DELETE FROM Appointments WHERE AppID = @appid
GO

GO
CREATE PROC ListApp
AS
SELECT AppID, DocFName, PatFName, AppTime FROM Appointments
INNER JOIN Doctors ON AppDocID = DocID
INNER JOIN Patients ON AppPatID = PatID
GO