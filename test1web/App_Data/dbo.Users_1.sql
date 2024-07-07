CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [fName]    NVARCHAR (50) NOT NULL,
    [lName]    NVARCHAR (50) NOT NULL,
    [email]    NVARCHAR (50) NOT NULL,
    [gender]   NVARCHAR (50) NOT NULL,
    [city]     NVARCHAR (50) NOT NULL,
    [yearBorn] INT           NOT NULL,
    [prefix]   NVARCHAR (50) NOT NULL,
    [phone]    NVARCHAR (50) NOT NULL,
    [pw]       NVARCHAR (50) NOT NULL,
    [about]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

