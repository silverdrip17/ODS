USE [master]
GO

-- Si existe BORRO la base de datos   
DROP DATABASE IF Exists  PROYECTOODS
GO

CREATE DATABASE PROYECTOODS
GO
USE PROYECTOODS
GO
CREATE TABLE SOLICITANTE(
	IDSOLICITANTE SMALLINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(40),
)

GO
CREATE TABLE INICIATIVA(
	CODINICIATIVA SMALLINT IDENTITY(1,1) PRIMARY KEY,
	TITULO NVARCHAR(80),
	DESCRIPCION NVARCHAR(50),
	FECHAINICIO DATETIME DEFAULT GETDATE(),
	FECHAFIN DATETIME,
	IDSOLICITANTE SMALLINT NOT NULL
)

GO
ALTER TABLE INICIATIVA
ADD CONSTRAINT FK_INICIATIVA_SOLICITANTE FOREIGN KEY (IDSOLICITANTE)
REFERENCES SOLICITANTE(IDSOLICITANTE)
GO
ALTER TABLE INICIATIVA
ADD CONSTRAINT CK_FECHA_FIN CHECK( FECHAFIN > FECHAINICIO)
GO

CREATE TABLE ODS(
NUMERO SMALLINT PRIMARY KEY,
NOMBRE NVARCHAR(100) NOT NULL,
DESCRIPCION NVARCHAR(300) NOT NULL,
)
GO

CREATE RULE NUMODS AS (@CAMPO BETWEEN 1 AND 17)

GO
CREATE TABLE METAS(
NUMEROODS SMALLINT NOT NULL,
CODMETA NVARCHAR(5) NOT NULL,
NOMBRE NVARCHAR(700) NOT NULL,
DESCRIPCION NVARCHAR(50) NOT NULL,
)

-- El nombre de la meta m�s largo son 618 caracteres.
 GO
ALTER TABLE METAS 
ADD CONSTRAINT FK_NUMEROODS_METAS FOREIGN KEY (NUMEROODS) REFERENCES ODS(NUMERO) 
GO
ALTER TABLE METAS
ADD CONSTRAINT PK_METAS PRIMARY KEY (NUMEROODS, CODMETA)
GO

CREATE TABLE INICIATIVA_METAS (
	CODINICIATIVA SMALLINT NOT NULL,
	NUMEROODS SMALLINT NOT NULL,
	CODMETA NVARCHAR(5) NOT NULL,
)
GO
ALTER TABLE INICIATIVA_METAS
ADD CONSTRAINT PK_INICIATIVA_METAS PRIMARY KEY (CODINICIATIVA, NUMEROODS, CODMETA) 

GO
ALTER TABLE INICIATIVA_METAS
ADD CONSTRAINT FK_INICIATIVAMETAS_INICIATIVA FOREIGN KEY (CODINICIATIVA) REFERENCES INICIATIVA(CODINICIATIVA)

GO
ALTER TABLE INICIATIVA_METAS
ADD CONSTRAINT FK_INICIATIVAMETAS_METAS FOREIGN KEY (NUMEROODS, CODMETA) REFERENCES METAS(NUMEROODS, CODMETA)

GO
CREATE TABLE CURSO(
	CODCURSO SMALLINT PRIMARY KEY,
	NOMBRE NVARCHAR(20) 
)
GO

ALTER TABLE CURSO
ADD CONSTRAINT CK_NOMBRE CHECK (LEFT(NOMBRE, 3) IN ('1� ', '2� '))
GO

CREATE TABLE MODULO(
CODCURSO SMALLINT NOT NULL,
	CODMODULO NCHAR(5) NOT NULL,
	NOMBRE NVARCHAR(30) NOT NULL	
)

GO
ALTER TABLE MODULO
ADD CONSTRAINT PK_MODULO PRIMARY KEY (CODCURSO, CODMODULO)
GO

ALTER TABLE MODULO
ADD CONSTRAINT FK_MODULO FOREIGN KEY (CODCURSO) REFERENCES CURSO(CODCURSO)

GO
CREATE RULE CODMODU AS (@CAMPO LIKE '[A-Z][0-9][0-9][0-9][0-9]')

GO
CREATE TABLE INICIATIVA_MODULOS(
	CODINICIATIVA SMALLINT NOT NULL,
CODCURSO SMALLINT NOT NULL,
CODMODULO NCHAR(5) NOT NULL,
	HORAS SMALLINT
)

GO
ALTER TABLE INICIATIVA_MODULOS
ADD CONSTRAINT PK_INICIATIVA_MODULOS PRIMARY KEY (CODINICIATIVA, CODCURSO, CODMODULO)

GO
ALTER TABLE INICIATIVA_MODULOS
ADD CONSTRAINT FK_INICIATIVAMOD_INICIATIVA FOREIGN KEY (CODINICIATIVA) REFERENCES INICIATIVA(CODINICIATIVA )

GO
ALTER TABLE INICIATIVA_MODULOS
ADD CONSTRAINT FK_INICIATIVAMOD_MODULOS FOREIGN KEY (CODCURSO, CODMODULO) REFERENCES MODULO(CODCURSO, CODMODULO)

GO
ALTER TABLE INICIATIVA_MODULOS
ADD CONSTRAINT CK_HORAS CHECK (HORAS>0)

GO
CREATE TABLE PROFESORADO(
IDPROF SMALLINT IDENTITY(1,1) PRIMARY KEY,
NOMBRECOMPLETO NVARCHAR(30) NOT NULL,
)

GO
CREATE TABLE PROFESORADO_MODULO(
	IDPROF SMALLINT NOT NULL,
	CODCURSO SMALLINT NOT NULL,
	CODMODULO NCHAR(5) NOT NULL
)

GO
ALTER TABLE PROFESORADO_MODULO
ADD CONSTRAINT PK_PROFESORADO_MODULO PRIMARY KEY (IDPROF, CODCURSO, CODMODULO)

GO
ALTER TABLE PROFESORADO_MODULO
ADD CONSTRAINT FK_PROFESORADOMOD_PROFESORADO FOREIGN KEY (IDPROF) REFERENCES PROFESORADO(IDPROF)

GO
ALTER TABLE PROFESORADO_MODULO
ADD CONSTRAINT FK_PROFESORADOMOD_MODULO FOREIGN KEY (CODCURSO, CODMODULO) REFERENCES MODULO(CODCURSO, CODMODULO)

GO
CREATE TABLE INICIATIVA_PROFESORADO(
IDPROF SMALLINT NOT NULL,
CODINICIATIVA SMALLINT NOT NULL,
)
GO

ALTER TABLE INICIATIVA_PROFESORADO
ADD CONSTRAINT PK_INICIATIVA_PROFESORADO PRIMARY KEY (IDPROF, CODINICIATIVA)
GO

ALTER TABLE INICIATIVA_PROFESORADO	
ADD CONSTRAINT FK_INICIATIVAPROF_PROFESORES FOREIGN KEY (IDPROF) REFERENCES PROFESORADO(IDPROF)
GO

ALTER TABLE INICIATIVA_PROFESORADO
ADD CONSTRAINT FK_INICIATIVAPROF_INICIATIVA FOREIGN KEY (CODINICIATIVA) REFERENCES INICIATIVA(CODINICIATIVA)
GO


SP_BINDRULE NUMODS, 'ODS.NUMERO'
EXEC SP_BINDRULE NUMODS, 'METAS.NUMEROODS'
EXEC SP_BINDRULE NUMODS, 'INICIATIVA_METAS.NUMEROODS'

GO
SP_BINDRULE CODMODU, 'MODULO.CODMODULO'
EXEC SP_BINDRULE CODMODU, 'INICIATIVA_MODULOS.CODMODULO'
EXEC SP_BINDRULE CODMODU, 'PROFESORADO_MODULO.CODMODULO'
GO
CREATE PROCEDURE MODULOSDEUNCURSO
@CURSO  SMALLINT
AS
SELECT MODULO.CODCURSO, MODULO.CODMODULO, MODULO.NOMBRE
FROM MODULO
WHERE MODULO.CODCURSO = (SELECT CURSO.CODCURSO FROM CURSO WHERE CURSO.CODCURSO=@CURSO)
GO
CREATE PROCEDURE DATOSCURSO
	@CURSO  SMALLINT
AS	
		SELECT INICIATIVA.TITULO AS 'INICIATIVA', METAS.NOMBRE AS 'META', ODS.NOMBRE AS 'ODS', MODULO.NOMBRE AS 'MODULO', PROFESORADO.NOMBRECOMPLETO AS 'PROFESOR/A'
		FROM CURSO INNER JOIN 
		(MODULO INNER JOIN 
			(PROFESORADO_MODULO INNER JOIN 
				(PROFESORADO INNER JOIN 
					(INICIATIVA_PROFESORADO INNER JOIN 
						(INICIATIVA INNER JOIN 
							(INICIATIVA_METAS INNER JOIN 
								(METAS INNER JOIN ODS ON ODS.NUMERO = METAS.NUMEROODS) 
							ON METAS.NUMEROODS = INICIATIVA_METAS.NUMEROODS AND METAS.CODMETA = INICIATIVA_METAS.CODMETA)
						ON INICIATIVA.CODINICIATIVA = INICIATIVA_METAS.CODINICIATIVA)
					ON INICIATIVA.CODINICIATIVA = INICIATIVA_PROFESORADO.CODINICIATIVA)
				ON PROFESORADO.IDPROF = INICIATIVA_PROFESORADO.IDPROF)
			ON PROFESORADO.IDPROF = PROFESORADO_MODULO.IDPROF)
		ON MODULO.CODCURSO = PROFESORADO_MODULO.CODCURSO AND MODULO.CODMODULO = PROFESORADO_MODULO.CODMODULO)
		ON CURSO.CODCURSO = MODULO.CODCURSO
		WHERE CURSO.CODCURSO = @CURSO

