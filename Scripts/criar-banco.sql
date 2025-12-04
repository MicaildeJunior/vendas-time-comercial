-- Cria o banco caso ainda não exista
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'VendasTimeComercialDb')
BEGIN
    CREATE DATABASE VendasTimeComercialDb;
END;
GO

-- Seleciona o banco
USE VendasTimeComercialDb;
GO

-- Cria a tabela Vendas caso não exista
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Vendas')
BEGIN
    CREATE TABLE Vendas (
        Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
        Vendedor NVARCHAR(100) NOT NULL,
        Valor DECIMAL(18,2) NOT NULL,
        DataVenda DATETIME2 NOT NULL
    );
END;
GO
