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

DROP TABLE VentaDetalle;
DROP TABLE Venta;
DROP TABLE CompraDetalle;
DROP TABLE Compra;
DROP TABLE Usuario;
DROP TABLE Cliente;
DROP TABLE Producto;
DROP TABLE Empleado;
DROP TABLE Proveedor;
DROP TABLE Categoria;
DROP PROC paProductoListar;
DROP PROC paClienteListar;
DROP PROC paEmpleadoListar;


-- Crear tablas
CREATE TABLE Categoria (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250) NOT NULL
);

CREATE TABLE Proveedor (
    id INT PRIMARY KEY IDENTITY(1,1),
    nit BIGINT NOT NULL,
    nombre VARCHAR(150) NOT NULL,
    correoElectronico VARCHAR(100)NOT NULL,
    telefono VARCHAR(50) NOT NULL,
    direccion VARCHAR(250) NOT NULL
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
    idProveedor INT NOT NULL,
    nombre VARCHAR(150) NOT NULL,
    producto VARCHAR(50) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    color   VARCHAR(50) NULL,
    descripcion VARCHAR(250),
    precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
    stock INT NOT NULL DEFAULT 0,
    CONSTRAINT fk_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(id),
    CONSTRAINT fk_Producto_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);

-- Tabla CLIENTE
CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL UNIQUE,
    nombres VARCHAR(100) NOT NULL,
    primerApellido VARCHAR(100) NOT NULL,
    segundoApellido VARCHAR(100) NULL,
    direccion VARCHAR(250) NOT NULL,
    celular BIGINT NOT NULL
);

-- Tabla USUARIO
CREATE TABLE Usuario (
    id INT PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT NOT NULL,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    clave VARCHAR(255) NOT NULL,
    CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);

-- Tabla Compra
CREATE TABLE Compra(
    id INT PRIMARY KEY IDENTITY(1,1),
    idProveedor INT NOT NULL,
    fecha DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);

-- Tabla DETALLE_COMPRA
CREATE TABLE CompraDetalle (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCompra INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL CHECK (cantidad > 0),
    precioUnitario DECIMAL NOT NULL CHECK (precioUnitario > 0),
    total DECIMAL NOT NULL,
    CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY (idCompra) REFERENCES Compra(id),
    CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

-- Tabla VENTA
CREATE TABLE Venta (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCliente INT NOT NULL,
    idUsuario INT NOT NULL,
    fecha DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_Venta_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(id),
    CONSTRAINT fk_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id)
);

-- Tabla DETALLE_VENTA
CREATE TABLE VentaDetalle (
    id INT PRIMARY KEY IDENTITY(1,1),
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL CHECK (cantidad > 0),
    precioUnitario DECIMAL(10,2) NOT NULL CHECK (precioUnitario > 0),
    total AS (cantidad * precioUnitario) PERSISTED,
    CONSTRAINT fk_VentaDetalle_Venta FOREIGN KEY (idVenta) REFERENCES Venta(id),
    CONSTRAINT fk_VentaDetalle_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

-- Agregar columnas de auditoría

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1;

-- Procedimientos almacenados

GO
CREATE OR ALTER PROC paProductoListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT p.id, p.nombre, p.producto, p.marca, p.descripcion,
           c.nombre AS categoria, pr.nombre AS proveedor,
           p.precioVenta, p.stock,
           p.usuarioRegistro, p.fechaRegistro, p.estado
    FROM Producto p
    INNER JOIN Categoria c ON c.id = p.idCategoria
    INNER JOIN Proveedor pr ON pr.id = p.idProveedor
    WHERE p.estado <> -1 AND
          (p.nombre + p.producto + p.marca + ISNULL(p.descripcion, '') + c.nombre + pr.nombre)
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY p.estado DESC, p.nombre ASC;
END;


GO
CREATE OR ALTER PROC paClienteListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Cliente
    WHERE estado <> -1 AND
          (cedulaIdentidad + nombres + primerApellido + ISNULL(segundoApellido, '')) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY estado DESC, nombres ASC, primerApellido ASC;
END;


GO
CREATE PROC paEmpleadoListar @parametro VARCHAR(100)
AS
  SELECT ISNULL(u.usuario,'--') AS usuario,e.* 
  FROM Empleado e
  LEFT JOIN Usuario u ON e.id = u.idEmpleado
  WHERE e.estado<>-1 
	AND e.nombres+ISNULL(e.primerApellido,'')+ISNULL(e.segundoApellido,'') LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY e.estado DESC, e.nombres ASC, e.primerApellido ASC;


-- Introduccion de datos

-- Insertar en Categoria
INSERT INTO Categoria (nombre, descripcion)
VALUES ('Tablets', 'Tablets negras');
-- Insertar en Proveedor
INSERT INTO Proveedor (nombre, nit, correoElectronico, telefono, direccion)
VALUES ('Jose', 12345 ,'jose@gmail.com', '33-555','call san juan');

-- Insertar en Empleado
INSERT INTO Empleado (nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('Juan', 'Perez', 'Lopez', 'Calle Falsa 123', 123456789, 'Vendedor');
-- Insertar en Producto
INSERT INTO Producto (idCategoria, idProveedor, nombre, producto, marca, descripcion, precioVenta, stock)
VALUES (1, 1, 'Tablet Samsung', 'Galaxy Tab S7', 'Samsung', 'Tablet de alta gama con pantalla de 11 pulgadas', 500, 10);
-- Insertar en Cliente
INSERT INTO Cliente (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular)
VALUES ('12345678', 'Maria', 'Gomez', 'Lopez', 'Avenida Siempre Viva 456', 987654321);
-- Insertar en Usuario
INSERT INTO Usuario (idEmpleado, usuario, clave)
VALUES (1, 'jose123', 'hashed_password_example'); -- Asegúrate de usar un hash seguro para la contraseña
-- Insertar en Compra
INSERT INTO Compra (idProveedor, fecha)
VALUES (1, GETDATE());
-- Insertar en CompraDetalle
INSERT INTO CompraDetalle (idCompra, idProducto, cantidad, precioUnitario, total)
VALUES (1, 1, 5, 500, 2500);
-- Insertar en Venta
INSERT INTO Venta (idCliente, idUsuario, fecha)
VALUES (1, 1, GETDATE());
-- Insertar en VentaDetalle
INSERT INTO VentaDetalle (idVenta, idProducto, cantidad, precioUnitario)
VALUES (1, 1, 2, 500);

SELECT * FROM Categoria;
SELECT * FROM Proveedor;
SELECT * FROM Empleado;
SELECT * FROM Producto;
SELECT * FROM Cliente;
SELECT * FROM Usuario;
SELECT * FROM Compra;
SELECT * FROM CompraDetalle;
SELECT * FROM Venta;
SELECT * FROM VentaDetalle;
-- Actualizar datos de auditoría
