CREATE DATABASE GUARDLLET


-------------------------------
-------------------------------
-- CREACION DE TABLAS ---------
-------------------------------
-------------------------------

CREATE TABLE DATOS(
	ID_DATOS INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(100),
	APELLIDO_P VARCHAR(50),
	APELLIDO_M	VARCHAR(50),
	CELULAR VARCHAR(10),
	BOLETA VARCHAR(10),
	GRUPO VARCHAR(6),
	FOTO IMAGE,	
)

CREATE TABLE MONEDERO(
	ID_MONEDERO INT IDENTITY(1,1) PRIMARY KEY,
	SALDO VARCHAR(MAX),
	NUM_CODIGO VARCHAR(MAX),
	IMG_CODIGO IMAGE
)

CREATE TABLE USUARIO(
	ID_USUARIO INT IDENTITY(1,1) PRIMARY KEY,
	ID_MONEDERO INT,
	ID_DATOS INT,
	CORREO VARCHAR(100),
	CONTRASEŅA VARCHAR(300),
	CELULAR VARCHAR(10),
	TIPO_USUARIO INT,
	ESTADO INT,

	CONSTRAINT fk_DATOS_USUARIO FOREIGN KEY (ID_DATOS) REFERENCES DATOS (ID_DATOS),
	CONSTRAINT fk_MONEDERO_USUARIO FOREIGN KEY (ID_MONEDERO) REFERENCES MONEDERO (ID_MONEDERO)
	
)

CREATE TABLE PRODUCTO(
	ID_PRODUCTO INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(100),
	TIPO_PRODUCTO INT,
	PRECIO VARCHAR(MAX),
	FOTO VARCHAR(MAX),
	CODIGO VARCHAR(MAX),
)

CREATE TABLE MOVIMIENTO(
	ID_MOVIMIENTO INT IDENTITY(1,1) PRIMARY KEY,
	ID_MONEDERO INT,
	ID_PRODUCTO INT,
	TIPO_MOVIMIENTO INT,
	ESTADO INT,
	FECHA DATETIME,
	
	CONSTRAINT fk_MONEDERO_MOVIMIENTO FOREIGN KEY (ID_MONEDERO) REFERENCES MONEDERO (ID_MONEDERO),
	CONSTRAINT fk_PRODUCTO_MOVIMIENTO FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTO (ID_PRODUCTO)
	
)

-------------------------------
-------------------------------
-- CREACION DE PROCEDIMIENTOS -
-------------------------------
-------------------------------



-- PROCEDIMIENTO DE LOGIN-----
------------------------------

CREATE PROCEDURE  [dbo].[LoginUsuario]
    
	@CORREO VARCHAR(100), 
	@CONTRASEŅA VARCHAR(300),
	@RESULTADO BIT OUTPUT

AS

	DECLARE @CONTRASEŅA_CODIFICADA AS VARCHAR(300)
	DECLARE @CONTRASEŅA_DECODIFICADA AS VARCHAR(300)

BEGIN

SELECT @CONTRASEŅA_CODIFICADA = CONTRASEŅA FROM USUARIO WHERE CORREO = @CORREO
SET @CONTRASEŅA_DECODIFICADA = DECRYPTBYPASSPHRASE('password', @CONTRASEŅA_CODIFICADA)

END

BEGIN

IF @CONTRASEŅA_DECODIFICADA = @CONTRASEŅA
    SET @RESULTADO = 1
ELSE
    Set @RESULTADO = 0
    
END

GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

---PROCEDIMIENTO PARA REGISTRAR-----
--------- USUARIO ------------------

CREATE PROCEDURE [dbo].[RegistroUsuario]

@ID_MONEDERO INT,
@ID_DATOS INT,
@CORREO VARCHAR(50),
@CONTRASEŅA VARCHAR(20),
@CELULAR VARCHAR(10),
@TIPO_USUARIO INT,
@ESTADO INT

AS

BEGIN
    
Insert Into USUARIO
(
    ID_MONEDERO,
	ID_DATOS,
	CORREO,
	CONTRASEŅA,
	CELULAR,
	TIPO_USUARIO,
	ESTADO
)

Values

(
	@ID_MONEDERO,
	@ID_DATOS,
	@CORREO,
	ENCRYPTBYPASSPHRASE('password', @CONTRASEŅA),
	@CELULAR,
	@TIPO_USUARIO,
	@ESTADO
)

END

---PROCEDIMIENTO PARA REGISTRAR-----
------------ DATOS -----------------

CREATE PROCEDURE [dbo].[RegistroDatos]

@NOMBRE VARCHAR(100),
@APELLIDO_P VARCHAR(50),
@APELLIDO_M	VARCHAR(50),
@CELULAR VARCHAR(10),
@BOLETA VARCHAR(10),
@GRUPO VARCHAR(6),
@FOTO VARCHAR(MAX)

AS

BEGIN
    
Insert Into DATOS
(
    NOMBRE,
	APELLIDO_P,
	APELLIDO_M,
	CELULAR,
	BOLETA,
	GRUPO,
	FOTO
	
)

Values

(
	@NOMBRE,
	@APELLIDO_P,
	@APELLIDO_M,
	@CELULAR,
	@BOLETA,
	@GRUPO,
	@FOTO
)

END

---PROCEDIMIENTO PARA REGISTRAR-----
----------- MENEDERO ---------------

CREATE PROCEDURE [dbo].[RegistroMonedero]

@SALDO VARCHAR(MAX),
@NUM_CODIGO VARCHAR(MAX),
@IMG_CODIGO IMAGE

AS

BEGIN
    
Insert Into MONEDERO
(
    SALDO,
    NUM_CODIGO,
    IMG_CODIGO
	
)

Values

(
	@SALDO,
	@NUM_CODIGO,
	@IMG_CODIGO
)

END