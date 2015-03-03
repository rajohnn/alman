SET XACT_ABORT ON
GO

-- Update these values for every new script.
DECLARE @AppVersion NVARCHAR(100) = '1.0 - 02'
DECLARE @GlobalVersion NVARCHAR(100) = '1.0 - 00'
DECLARE @DataUpdateName NVARCHAR(1000) = 'Add virtual hosts, template, and demo partitions.'

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

	INSERT INTO [dbo].[DataPartition]
           ([Name]
           ,[Description]
           ,[IsDeleted])
     VALUES
           ('Template'
           ,'Used to store template data elements used to generate a starting point for new data partitions.'
           ,0)

	DECLARE @id int = @@IDENTITY

	INSERT INTO [dbo].[VirtualHost]
           ([DomainName]
           ,[Description]
           ,[DataPartitionId]
           ,[LastModified]
           ,[ModifiedById]
           ,[IsDeleted])
     VALUES
           ('Template'
           ,'Partition used to manage a template for user data element lists.'
           ,@id
           ,getDate()
           ,1
           ,0)

	INSERT INTO [dbo].[DataPartition]
           ([Name]
           ,[Description]
           ,[IsDeleted])
     VALUES
           ('Demo'
           ,'ALMAN demonstration site'
           ,0)

	set @id = @@IDENTITY

	INSERT INTO [dbo].[VirtualHost]
           ([DomainName]
           ,[Description]
           ,[DataPartitionId]
           ,[LastModified]
           ,[ModifiedById]
           ,[IsDeleted])
     VALUES
           ('Demo'
           ,'The ALMAN demonstration site.'
           ,@id
           ,getDate()
           ,1
           ,0)





commit tran
