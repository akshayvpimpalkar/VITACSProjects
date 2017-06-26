
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/17/2017 13:58:09
-- Generated from EDMX file: C:\Users\Akshay-VITA\VitaCSProjectsRepo\modelFirst\modelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClubPlayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Players] DROP CONSTRAINT [FK_ClubPlayer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Players]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Players];
GO
IF OBJECT_ID(N'[dbo].[Clubs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clubs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Score] int  NOT NULL,
    [ClubId] int  NOT NULL
);
GO

-- Creating table 'Clubs'
CREATE TABLE [dbo].[Clubs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Owner] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clubs'
ALTER TABLE [dbo].[Clubs]
ADD CONSTRAINT [PK_Clubs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClubId] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [FK_ClubPlayer]
    FOREIGN KEY ([ClubId])
    REFERENCES [dbo].[Clubs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubPlayer'
CREATE INDEX [IX_FK_ClubPlayer]
ON [dbo].[Players]
    ([ClubId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------