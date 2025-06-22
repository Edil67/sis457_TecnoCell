CREATE DATABASE FinalTiendaCelulares;

GO
USE [master]
GO
CREATE LOGIN [usrtiendacelulares] WITH PASSWORD = N'123456',
    DEFAULT_DATABASE = [FinalTiendaCelulares],
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON
GO
USE [FinalTiendaCelulares]
GO
CREATE USER [usrtiendacelulares] FOR LOGIN [usrtiendacelulares]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrtiendacelulares]
GO

-- USE FinalTiendaCelulares
-- GO
-- DROP USER [usrtecnocell]
-- GO
-- DROP LOGIN [usrtecnocell]

DROP TABLE VentaDetalle;
DROP TABLE Venta;
DROP TABLE Producto;
DROP TABLE Categoria;
DROP TABLE Usuario;
DROP TABLE Empleado;
DROP TABLE Cliente;
DROP PROC paProductoListar;
DROP PROC paClienteListar;
DROP PROC paEmpleadoListar;
DROP PROC paUsuarioListar;
DROP PROC paVentaListar;
DROP PROC paCategoriaListar;



-- Crear tablas
CREATE TABLE Categoria (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(100) NOT NULL
);

CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);

-- Tabla PRODUCTO
CREATE TABLE Producto (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCategoria INT NOT NULL,
    nombre VARCHAR(150) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    color   VARCHAR(50) NULL,
    descripcion VARCHAR(250),
    precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
    stock INT NOT NULL DEFAULT 0,
    CONSTRAINT fk_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(id)
);

-- Tabla CLIENTE
CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL UNIQUE,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(180) NOT NULL,
    direccion VARCHAR(250) NOT NULL,
    celular BIGINT NOT NULL,
    correoElectronico VARCHAR(100) NULL
);

-- Tabla USUARIO
CREATE TABLE Usuario (
    id INT PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT NOT NULL,
    usuario VARCHAR(15) NOT NULL UNIQUE,
    clave VARCHAR(255) NOT NULL,
    CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);


-- Tabla VENTA
CREATE TABLE Venta (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCliente INT NOT NULL,
    idUsuario INT NOT NULL,
    documentoCliente VARCHAR(50) NULL,
    montoPago DECIMAL(10,2) NOT NULL CHECK (montoPago >= 0),
    montoCambio DECIMAL(10,2) NOT NULL CHECK (montoCambio >= 0),
    montoTotal AS (montoPago - montoCambio) PERSISTED,
    CONSTRAINT fk_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id),
    CONSTRAINT fk_Venta_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(id)
);

-- Tabla DETALLE_VENTA
CREATE TABLE VentaDetalle (
    id INT PRIMARY KEY IDENTITY(1,1),
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL CHECK (cantidad > 0),
    precioUnitario DECIMAL(10,2) NOT NULL CHECK (precioUnitario > 0),
    subtotal AS (cantidad * precioUnitario) PERSISTED,
    CONSTRAINT fk_VentaDetalle_Venta FOREIGN KEY (idVenta) REFERENCES Venta(id),
    CONSTRAINT fk_VentaDetalle_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

-- Agregar columnas de auditoría

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1;

-- Procedimientos almacenados
GO
CREATE PROC paCategoriaListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Categoria
    WHERE estado <> -1 AND
          descripcion LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY estado DESC, descripcion ASC;
END;

GO
CREATE PROC paProductoListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT p.*, c.descripcion AS categoriaDescripcion
    FROM Producto p
    JOIN Categoria c ON p.idCategoria = c.id
    WHERE p.estado <> -1 AND
          (p.nombre + p.modelo + p.marca + ISNULL(p.color, '') + ISNULL(p.descripcion, '')) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY p.estado DESC, p.nombre ASC, p.modelo ASC;
END;

GO
CREATE OR ALTER PROC paClienteListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Cliente
    WHERE estado <> -1 AND
          (cedulaIdentidad + nombres + apellidos + ISNULL(apellidos, '')) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY estado DESC, nombres ASC, apellidos ASC;
END;

GO
CREATE OR ALTER PROC paEmpleadoListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Empleado
    WHERE estado <> -1 AND
          (nombres + primerApellido + ISNULL(segundoApellido, '')) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY estado DESC, nombres ASC, primerApellido ASC;
END;


GO
CREATE OR ALTER PROC paUsuarioListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT u.*, e.nombres, e.primerApellido, e.segundoApellido
    FROM Usuario u
    JOIN Empleado e ON u.idEmpleado = e.id
    WHERE u.estado <> -1 AND
          (u.usuario + e.nombres + e.primerApellido + ISNULL(e.segundoApellido, '')) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY u.estado DESC, u.usuario ASC;
END;

GO
CREATE OR ALTER PROC paVentaListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT v.*, c.nombres AS clienteNombres, c.apellidos AS clienteApellidos, 
           u.usuario AS usuarioNombre
    FROM Venta v
    JOIN Cliente c ON v.idCliente = c.id
    JOIN Usuario u ON v.idUsuario = u.id
    WHERE v.estado <> -1 AND
          (c.cedulaIdentidad + c.nombres + c.apellidos + u.usuario) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY v.estado DESC, v.fechaRegistro DESC;
END;


EXEC paClienteListar '';
-- Introduccion de datos
INSERT INTO Categoria (descripcion)
VALUES 
('Celulares');

INSERT INTO Empleado (nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES 
('Juan', 'Pérez', 'Gómez', 'Av. Siempre Viva 123', 987654321, 'Vendedor');
INSERT INTO Producto (idCategoria, nombre, modelo, marca, color, descripcion, precioVenta, stock)
VALUES  
(1, 'Samsung Galaxy S21', 'SM-G991B', 'Samsung Electronics Co., Ltd.','Ngro', 'celular negro samsung',500,3);
INSERT INTO Cliente (cedulaIdentidad, nombres, apellidos, direccion, celular, correoElectronico)
VALUES 
('1234567890', 'Ana', 'López', 'Calle Falsa 456', 987654321, 'prueba@gmail.com');
INSERT INTO Usuario (idEmpleado, usuario, clave)
VALUES 
(1, 'jperez', 'Bwk06E2GcnE7m+nHi+A3IA==');
INSERT INTO Venta (idCliente, idUsuario, documentoCliente, montoPago, montoCambio)
VALUES 
(1, 1, '1234567890', 1000, 500);
INSERT INTO VentaDetalle (idVenta, idProducto, cantidad, precioUnitario)
VALUES 
(1, 1, 1, 500);

-- inserta un segundo empleado y su usuario
INSERT INTO Empleado (nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES 
('Jose', 'Pérez', 'Gómez', 'Av. Siempre Viva 123', 98765, 'Vendedor');

INSERT INTO Usuario (idEmpleado, usuario, clave)
VALUES 
(1, 'admin', 'W6ph5Mm5Pz8GgiULbPgzG37mj9g');

-- SELECT * FROM Categoria;
-- SELECT * FROM Empleado;
SELECT * FROM Producto;
-- SELECT * FROM Cliente;
SELECT * FROM Usuario;
SELECT * FROM Venta;
SELECT * FROM VentaDetalle;


ALTER DATABASE TecnoCell_db MODIFY NAME = NuevoNombreDB;