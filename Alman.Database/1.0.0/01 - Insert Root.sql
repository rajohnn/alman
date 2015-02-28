﻿SET XACT_ABORT ON
GO

-- Update these values for every new script.
DECLARE @AppVersion NVARCHAR(100) = '1.0 - 01'
DECLARE @GlobalVersion NVARCHAR(100) = '1.0 - 00'
DECLARE @DataUpdateName NVARCHAR(1000) = 'Insert Root Member'

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

-- Chicken before the egg issue.  To successfully insert a root that is entered by a root, you need to disabled null checks for the insert
-- then update the MemberModifiedId foriegn key reference.
	Insert into [Address] (
		AddressType,
		Street1,
		Street2,
		City,
		[State],
		PostalCode,
		IsDeleted
	)
	values
	(
		1,
		'2601 Herdon St',
		'',
		'Valrico',
		'FL',
		'33596',
		0
	)
	
	Insert Into [DataPartition] (
		Name,
		IsDeleted,
		Address_Id
	)
	values(
		'Root',
		0,
		@@IDENTITY
	)

	ALTER Table [User] DROP CONSTRAINT [FK_dbo.User_dbo.User_ModifiedById]

	Insert into [User] (
		UserName, 
		PasswordHash, 
		PasswordSalt, 
		PasswordExpirationDate, 
		DataPartitionId,
		ModifiedById,
		LastModified,
		IsDeleted
	)
	values
	(
		'root', 
		'E97BD522FF9772FAB829AFF96E0A1839CF3C1298', 
		'FhFL3Fws', 
		'01/01/2055', 
		1,
		1,
		getDate(),
		0
	)

	Update [User] set ModifiedById = @@IDENTITY where id = @@IDENTITY

	ALTER Table [User] ADD CONSTRAINT [FK_dbo.User_dbo.User_ModifiedById] UNIQUE(ModifiedById)

commit tran