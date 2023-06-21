IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Exercicios] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Repeticao] int NOT NULL,
    [Execucao] int NOT NULL,
    [TempoMin] int NOT NULL,
    [Classe] int NOT NULL,
    CONSTRAINT [PK_Exercicios] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Execucao', N'Nome', N'Repeticao', N'TempoMin') AND [object_id] = OBJECT_ID(N'[Exercicios]'))
    SET IDENTITY_INSERT [Exercicios] ON;
INSERT INTO [Exercicios] ([Id], [Classe], [Execucao], [Nome], [Repeticao], [TempoMin])
VALUES (1, 2, 12, N'Agachamento', 3, 0),
(2, 1, 15, N'Supino', 3, 0),
(3, 7, 0, N'Prancha', 0, 1),
(4, 8, 0, N'Esteira', 0, 30),
(5, 5, 12, N'Bíceps Rosca', 4, 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Execucao', N'Nome', N'Repeticao', N'TempoMin') AND [object_id] = OBJECT_ID(N'[Exercicios]'))
    SET IDENTITY_INSERT [Exercicios] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230621012357_InitialCreate', N'7.0.7');
GO

COMMIT;
GO

