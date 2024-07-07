CREATE TABLE [dbo].[Users] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [uName]   NVARCHAR (50) DEFAULT ('so') NOT NULL,
    [fName]   NVARCHAR (50) NOT NULL,
    [lName]   NVARCHAR (50) NOT NULL,
    [email]   NVARCHAR (50) NOT NULL,
    [isAdmin] BIT           DEFAULT ((0)) NULL,
    [networth] INT NULL, 
    [phone] NVARCHAR(50) NULL, 
    [birthdate] DATE NULL,  
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

