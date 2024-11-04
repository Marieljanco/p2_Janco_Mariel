CREATE DATABASE Parcial2Mvajc;
GO

USE Parcial2Mvajc;
GO

USE [master];
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD=N'12345678',
    DEFAULT_DATABASE = Parcial2Mvajc,
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON;
GO
USE Parcial2Mvajc;
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2];
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2];
GO

CREATE TABLE Serie (
    id INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(250),
    sinopsis VARCHAR(5000),
    director VARCHAR(100),
    episodios INT,
    fechaEstreno DATE
);
GO

ALTER TABLE Serie ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO

CREATE PROCEDURE paSerieListar 
    @parametro VARCHAR(50)
AS
BEGIN
    SELECT id, titulo, sinopsis, director, episodios, fechaEstreno
    FROM Serie
    WHERE estado <> -1 AND titulo LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END
GO

INSERT INTO Serie (titulo, sinopsis, director, episodios, fechaEstreno)
VALUES
('Breaking Bad', 'Un profesor de química se convierte en fabricante de metanfetaminas.', 'Vince Gilligan', 62, '2008-01-20'),
('The Walking Dead', 'Un grupo de sobrevivientes lucha por vivir en un mundo post-apocalíptico infestado de zombis.', 'Frank Darabont', 177, '2010-10-31'),
('Okupas', 'La vida de un grupo de jóvenes que ocupa una casa en Buenos Aires y sus desafíos diarios.', 'Jorge Nisco', 11, '2000-08-30');

SELECT * FROM Serie;
