USE MASTER 
GO

CREATE DATABASE MapeoDB
GO

USE MapeoDB
GO

CREATE TABLE Genero(
	id int PRIMARY KEY IDENTITY(1,1),
	nombre varchar (120),
	fecha_reg DATETIME DEFAULT GETDATE(),
)
GO