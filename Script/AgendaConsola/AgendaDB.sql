CREATE DATABASE AgendaDB;
GO

USE AgendaDB;
GO

CREATE TABLE Contactos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100)
);
