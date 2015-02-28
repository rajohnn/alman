-- Made Azure friendly by removing the ON PRIMARY

CREATE TABLE [dbo].[DatabaseUpdate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationDataVersion] [nvarchar](100) NOT NULL,
	[ExecutionTime] [datetime2](7) NOT NULL,
	[GlobalDataVersion] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[UserName] [nvarchar](1000) NOT NULL,
	CONSTRAINT [PK_DataUpdate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))



