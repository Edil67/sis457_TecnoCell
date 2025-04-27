CREATE DATABASE TecnoCell_db;

GO
USE [master]
GO
CREATE LOGIN [usrtecnocell] WITH PASSWORD = N'123456',
    DEFAULT_DATABASE = [TecnoCell_db],
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON
GO
USE [TecnoCell_db]
GO
CREATE USER [usrtecnocell] FOR LOGIN [usrtecnocell]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrtecnocell]
GO

DROP TABLE DetalleCompra;
DROP TABLE Compra;
DROP TABLE Cliente;
DROP TABLE Producto;
DROP TABLE Modelo;

-- Crear tablas

CREATE TABLE Modelo (
  id_Modelo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombreModelo VARCHAR(100) NOT NULL,
  modeloProducto VARCHAR(20) NOT NULL,
  marca Varchar(30) NOT NULL,
  descripcion VARCHAR(250) NULL,
  color VARCHAR(50) NULL
);

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idModelo INT NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  precioVenta DECIMAL(10,2) NOT NULL CHECK (precioVenta > 0),
  stock INT NOT NULL CHECK (stock >= 0),
  CONSTRAINT fk_Producto_Modelo FOREIGN KEY (idModelo) REFERENCES Modelo(id_Modelo)
);

CREATE TABLE Cliente (
  id_Cliente INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombres VARCHAR(100) NOT NULL,
  primerApellido VARCHAR(100) NOT NULL,
  segundoApellido VARCHAR(100) NULL,
  direccion VARCHAR(250) NULL,
  celular VARCHAR(30) NULL
);

CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCliente INT NOT NULL,
  fechaCompra DATE NOT NULL DEFAULT GETDATE(),
  totalCompra DECIMAL(10,2) NOT NULL DEFAULT 0,
  CONSTRAINT fk_Compra_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(id_Cliente)
);

CREATE TABLE DetalleCompra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad INT NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL(10,2) NOT NULL CHECK (precioUnitario > 0),
  total DECIMAL(10,2) NOT NULL CHECK (total > 0),
  CONSTRAINT fk_DetalleCompra_Compra FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_DetalleCompra_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

-- Agregar columnas de auditoría

ALTER TABLE Modelo ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Modelo ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Modelo ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1:Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE DetalleCompra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleCompra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleCompra ADD estado SMALLINT NOT NULL DEFAULT 1;

-- Procedimientos almacenados

GO
CREATE OR ALTER PROC paProductoListar @parametro VARCHAR(100)
AS
BEGIN
  SELECT p.*, m.nombreModelo
  FROM Producto p
  INNER JOIN Modelo m ON p.idModelo = m.id_Modelo
  WHERE p.estado <> -1 
    AND (p.descripcion + m.nombreModelo + m.marca) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
  ORDER BY p.estado DESC, p.descripcion ASC;
END;
GO


GO
CREATE OR ALTER PROC paClienteListar @parametro VARCHAR(100)
AS
BEGIN
  SELECT * 
  FROM Cliente
  WHERE estado <> -1 
    AND (nombres + primerApellido + celular) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
  ORDER BY estado DESC, nombres ASC, primerApellido ASC;
END;
GO



-- Introduccion de datos


-- Insertamos un modelo de celular
INSERT INTO Modelo (nombreModelo, modeloProducto, marca, descripcion, color)
VALUES ('Galaxy A20s','SM-A2070', 'SAMSUNG', 'Smartphone de gama media Samsung', 'Negro');

INSERT INTO Modelo (nombreModelo, modeloProducto, marca, descripcion, color)
VALUES ('Galaxy A20s','SM-A207F', 'SAMSUNG', 'Smartphone de gama media Samsung', 'Negro');

INSERT INTO Modelo (nombreModelo, modeloProducto, marca, descripcion, color)
VALUES ('Galaxy A20s','SM-A207M', 'SAMSUNG', 'Smartphone de gama media Samsung', 'Negro');


-- Actualizar el precioVenta de un producto
UPDATE Producto
SET precioVenta = 1000.00
WHERE idModelo IN (SELECT id FROM Modelo);


-- Insertar en Cliente
INSERT INTO Cliente (nombres, primerApellido, segundoApellido, direccion, celular)
VALUES ('Juan', 'Pérez',' López', 'Av. Las Flores #123', '71717171');

-- Insertar en Compra
INSERT INTO Compra (idCliente, totalCompra)
VALUES (1, 1499.98);



-- Consultas finales
SELECT * FROM Producto;
SELECT * FROM Cliente;
SELECT * FROM Compra;
SELECT * FROM Modelo;


