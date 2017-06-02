
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 22:14:21
-- Generated from EDMX file: C:\Asp.Net\CG\Aula\Trabalho0106\Trabalho0106\Models\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Base];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GeneroJogo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jogo] DROP CONSTRAINT [FK_GeneroJogo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Genero]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genero];
GO
IF OBJECT_ID(N'[dbo].[Jogo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jogo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Genero'
CREATE TABLE [dbo].[Genero] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NULL,
    [Descricao] nvarchar(50)  NULL
);
GO

-- Creating table 'Jogo'
CREATE TABLE [dbo].[Jogo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NULL,
    [Descricao] nvarchar(50)  NOT NULL,
    [Lancamento] nvarchar(50)  NOT NULL,
    [GeneroId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Genero'
ALTER TABLE [dbo].[Genero]
ADD CONSTRAINT [PK_Genero]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jogo'
ALTER TABLE [dbo].[Jogo]
ADD CONSTRAINT [PK_Jogo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GeneroId] in table 'Jogo'
ALTER TABLE [dbo].[Jogo]
ADD CONSTRAINT [FK_GeneroJogo]
    FOREIGN KEY ([GeneroId])
    REFERENCES [dbo].[Genero]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GeneroJogo'
CREATE INDEX [IX_FK_GeneroJogo]
ON [dbo].[Jogo]
    ([GeneroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------