--DDL
CREATE DATABASE LabAmc;

USE [master]
GO

CREATE LOGIN [usrlabamc] WITH PASSWORD=N'123456', 
   DEFAULT_DATABASE=[LabAmc], 
   CHECK_EXPIRATION=OFF, 
   CHECK_POLICY=ON
GO

USE [LabAmc]
GO

CREATE USER [usrlabamc] FOR LOGIN [usrlabamc]
GO
USE [LabAmc]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrlabamc]
GO

-- Creacion de las tablas
DROP TABLE Usuario;
DROP TABLE Detalle;
DROP TABLE Factura;
DROP TABLE Cliente;
DROP TABLE Articulo;
DROP TABLE Vendedor;

CREATE TABLE Vendedor (
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nombre  VARCHAR (20)  NOT NULL,
apellidoPaterno   VARCHAR (20)  NOT NULL,
apellidoMaterno   VARCHAR (20)  NOT NULL,
sexo CHAR (1)   NOT NULL,
fechaContrato DATE  NOT NULL,
objetivoventa  NUMERIC (8,2) CHECK (objetivoVenta > 2000),
telefono  VARCHAR (10),

usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME(),
fechaRegistro DATETIME NULL DEFAULT GETDATE(),
registroActivo BIT NULL DEFAULT 1
)

CREATE TABLE Articulo (
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
codigo VARCHAR(10) NOT NULL,
descripcion  VARCHAR(30)  NOT NULL,
precio DECIMAL NOT NULL CHECK (precio > 0),
unidad VARCHAR(20)   NOT NULL,
existenciaMaxima  INT    NOT NULL,
existenciaMinima  INT    NOT NULL,

usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME(),
fechaRegistro DATETIME NULL DEFAULT GETDATE(),
registroActivo BIT NULL DEFAULT 1
)


CREATE TABLE Cliente(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR(20) NOT NULL,
apellidoPaterno VARCHAR(20) NOT NULL,
apellidoMaterno VARCHAR(20) NOT NULL,
cedulaIdentidad VARCHAR(10),
direccion  VARCHAR(30),
limiteCredito DECIMAL NOT NULL, 
FechaAsig  DATE  NOT NULL,
idVendedor INT NOT NULL,

CONSTRAINT fk_Cliente_Vendedor FOREIGN KEY(idVendedor) REFERENCES Vendedor(id),

usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME(),
fechaRegistro DATETIME NULL DEFAULT GETDATE(),
registroActivo BIT NULL DEFAULT 1
)


CREATE TABLE Factura (
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
fecha   DATE   NOT NULL,
idVendedor INT NOT NULL,
idCliente INT NOT NULL,

CONSTRAINT fk_Factura_Vendedor FOREIGN KEY(idVendedor) REFERENCES Vendedor(id),
CONSTRAINT fk_Factura_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),

usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME(),
fechaRegistro DATETIME NULL DEFAULT GETDATE(),
registroActivo BIT NULL DEFAULT 1
)

CREATE TABLE Detalle(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
idFactura INT NOT NULL,
idArticulo INT NOT NULL, 
Cantidad  DECIMAL NOT NULL CHECK (Cantidad > 0),

CONSTRAINT fk_Detalle_Factura FOREIGN KEY(idFactura) REFERENCES Factura(id),
CONSTRAINT fk_Detalle_Articuo FOREIGN KEY(idArticulo) REFERENCES Articulo(id),

usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME(),
fechaRegistro DATETIME NULL DEFAULT GETDATE(),
registroActivo BIT NULL DEFAULT 1
)   

CREATE TABLE Usuario(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idVendedor INT NOT NULL,
	usuario VARCHAR(12) NOT NULL,
	clave VARCHAR(250) NOT NULL,
	CONSTRAINT fk_Usuario_Vendedor FOREIGN KEY(idVendedor) REFERENCES Vendedor(id)
);


--Procedimiento Almacenado para Articulo

INSERT INTO Articulo(codigo,descripcion,precio,unidad,existenciaMaxima,existenciaMinima)
VALUES ('AC45', 'Barra de Acero', 50,'kilo',3,10);


CREATE PROC paArticuloListar @parametro VARCHAR(50)
AS
  SELECT id, codigo, descripcion, precio, unidad, existenciaMaxima, existenciaMinima
		 usuarioRegistro, fechaRegistro
  FROM Articulo
  WHERE registroActivo=1 AND 
		codigo+descripcion+unidad LIKE '%'+REPLACE(@parametro,' ','%')+'%'



EXEC paArticuloListar 'Barra de Acero'

SELECT * FROM Usuario;
SELECT * FROM Vendedor;

INSERT INTO Articulo(codigo,descripcion,precio,unidad,existenciaMaxima,existenciaMinima)
VALUES ('AC45', 'Barra de Acero', 50,'kilo',3,10);

INSERT INTO Vendedor(nombre,apellidoPaterno,apellidoMaterno,sexo,fechaContrato,objetivoventa,telefono)
VALUES ('Carlos', 'Gomez', 'Sanches','H','2023-06-09',4000,'63426369');

INSERT INTO Usuario(idVendedor,usuario,clave)
VALUES (1,'sacha','123456');