
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/27/2013 16:08:05
-- Generated from EDMX file: D:\Mohtshm\Development\DotNet\MVC\4\NetReviewed\NetReviewed\DbCommentSystem.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DbCommentSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ReviewComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comment] DROP CONSTRAINT [FK_ReviewComment];
GO
IF OBJECT_ID(N'[dbo].[FK_ReviewCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Category] DROP CONSTRAINT [FK_ReviewCategory];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Review]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Review];
GO
IF OBJECT_ID(N'[dbo].[Comment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comment];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Review'
CREATE TABLE [dbo].[Review] (
    [ReviewId] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [IsAnonymous] bit  NOT NULL,
    [Topic] nvarchar(max)  NOT NULL,
    [CategoryId] int  NOT NULL
);
GO

-- Creating table 'Comment'
CREATE TABLE [dbo].[Comment] (
    [CommentId] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [IsAnonymous] bit  NOT NULL,
    [ReviewId] int  NOT NULL
);
GO

-- Creating table 'Category'
CREATE TABLE [dbo].[Category] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ReviewId] in table 'Review'
ALTER TABLE [dbo].[Review]
ADD CONSTRAINT [PK_Review]
    PRIMARY KEY CLUSTERED ([ReviewId] ASC);
GO

-- Creating primary key on [CommentId] in table 'Comment'
ALTER TABLE [dbo].[Comment]
ADD CONSTRAINT [PK_Comment]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'Category'
ALTER TABLE [dbo].[Category]
ADD CONSTRAINT [PK_Category]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ReviewId] in table 'Comment'
ALTER TABLE [dbo].[Comment]
ADD CONSTRAINT [FK_ReviewComment]
    FOREIGN KEY ([ReviewId])
    REFERENCES [dbo].[Review]
        ([ReviewId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReviewComment'
CREATE INDEX [IX_FK_ReviewComment]
ON [dbo].[Comment]
    ([ReviewId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------