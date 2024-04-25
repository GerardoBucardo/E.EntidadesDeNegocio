CREATE DATABASE EDB
USE EDB

CREATE TABLE PersonaE(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	NombreE VARCHAR(100),
	ApellidoE VARCHAR(100),
	FechaNacimientoE DATETIME,
	SueldoE DECIMAL(5,2),
	EstatusE VARCHAR(100),
	ComentarioE VARCHAR(100)
);

INSERT INTO PersonaE (NombreE, ApellidoE, FechaNacimientoE, SueldoE, EstatusE, ComentarioE) 
VALUES ('a','b','12/3/24',1.12,'Out of line','comentario')

SELECT * FROM PersonaE

DROP TABLE PersonaE