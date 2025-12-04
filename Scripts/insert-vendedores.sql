-- Insert do vendedor(a) João Silva
INSERT INTO Vendas (Id, Vendedor, Valor, DataVenda) VALUES
(NEWID(), 'João Silva', 1200.50, GETDATE()),
(NEWID(), 'João Silva', 950.75, GETDATE()),
(NEWID(), 'João Silva', 1800.00, GETDATE()),
(NEWID(), 'João Silva', 1400.30, GETDATE()),
(NEWID(), 'João Silva', 1100.90, GETDATE()),
(NEWID(), 'João Silva', 1550.00, GETDATE()),
(NEWID(), 'João Silva', 1700.80, GETDATE()),
(NEWID(), 'João Silva', 250.30, GETDATE()),
(NEWID(), 'João Silva', 480.75, GETDATE()),
(NEWID(), 'João Silva', 320.40, GETDATE());

-- Insert do vendedor(a) Maria Souza
INSERT INTO Vendas (Id, Vendedor, Valor, DataVenda) VALUES
(NEWID(), 'Maria Souza', 2100.40, GETDATE()),
(NEWID(), 'Maria Souza', 1350.60, GETDATE()),
(NEWID(), 'Maria Souza', 950.20, GETDATE()),
(NEWID(), 'Maria Souza', 1600.75, GETDATE()),
(NEWID(), 'Maria Souza', 1750.00, GETDATE()),
(NEWID(), 'Maria Souza', 1450.90, GETDATE()),
(NEWID(), 'Maria Souza', 400.50, GETDATE()),
(NEWID(), 'Maria Souza', 180.20, GETDATE()),
(NEWID(), 'Maria Souza', 90.75, GETDATE());

-- Insert do vendedor(a) Carlos oliveira
INSERT INTO Vendas (Id, Vendedor, Valor, DataVenda) VALUES
(NEWID(), 'Carlos Oliveira', 800.50, GETDATE()),
(NEWID(), 'Carlos Oliveira', 1200.00, GETDATE()),
(NEWID(), 'Carlos Oliveira', 1950.30, GETDATE()),
(NEWID(), 'Carlos Oliveira', 1750.80, GETDATE()),
(NEWID(), 'Carlos Oliveira', 1300.60, GETDATE()),
(NEWID(), 'Carlos Oliveira', 300.40, GETDATE()),
(NEWID(), 'Carlos Oliveira', 500.00, GETDATE()),
(NEWID(), 'Carlos Oliveira', 125.75, GETDATE());

-- Insert do vendedor(a) Ana Lima
INSERT INTO Vendas (Id, Vendedor, Valor, DataVenda) VALUES
(NEWID(), 'Ana Lima', 1000.00, GETDATE()),
(NEWID(), 'Ana Lima', 1100.50, GETDATE()),
(NEWID(), 'Ana Lima', 1250.75, GETDATE()),
(NEWID(), 'Ana Lima', 1400.20, GETDATE()),
(NEWID(), 'Ana Lima', 1550.90, GETDATE()),
(NEWID(), 'Ana Lima', 1650.00, GETDATE()),
(NEWID(), 'Ana Lima', 75.30, GETDATE()),
(NEWID(), 'Ana Lima', 420.90, GETDATE()),
(NEWID(), 'Ana Lima', 315.40, GETDATE());

SELECT * FROM VENDAS