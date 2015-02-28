SET XACT_ABORT ON
GO

-- Update these values for every new script.
DECLARE @AppVersion NVARCHAR(100) = ''
DECLARE @GlobalVersion NVARCHAR(100) = '1.0 - 00'
DECLARE @DataUpdateName NVARCHAR(1000) = ''

IF (SELECT COUNT(*) FROM DatabaseUpdate WHERE ApplicationDataVersion = @AppVersion) > 0 BEGIN
	RAISERROR('This data update script has already run.', 20, 1) WITH SETERROR, LOG
	RETURN
END

IF (SELECT COUNT(*) FROM DatabaseUpdate) != 0 AND (SELECT COUNT(*) FROM DatabaseUpdate WHERE GlobalDataVersion >= @GlobalVersion) = 0 BEGIN
	RAISERROR('This data update script depends on a newer global version.', 20, 1) WITH SETERROR, LOG
	RETURN
END

BEGIN TRAN

INSERT INTO DatabaseUpdate (ApplicationDataVersion, GlobalDataVersion, Name, ExecutionTime, UserName) 
VALUES(@AppVersion, @GlobalVersion, @DataUpdateName, getdate(), suser_sname())

-- Insert your SQL HERE


commit tran
