 TecnoSucre – Sistema de Gestión para Tienda de Celulares
Bienvenido/a a TecnoCell, una tienda especializada en la venta de celulares nuevos, originales y con garantía. Este sistema está diseñado para gestionar eficientemente las operaciones comerciales de la tienda.

🧾 ¿Qué ofrece TecnoSucre?
Celulares nuevos y 100% originales

Precios competitivos

Garantía incluida en todos los equipos

Asesoría personalizada al cliente

🗂️ Modelo de Base de Datos
El sistema está compuesto por las siguientes tablas principales:
🗂️ Modelo de Base de Datos
📦 Entidades Iniciales
1. Categoria
id

descripcion

usuarioRegistro

fechaRegistro

estado

2. Producto
id

idCategoria

nombre

modelo

marca

color

descripcion

precioVenta

stock

usuarioRegistro

fechaRegistro

estado

3. Cliente
id

cedulaIdentidad

nombres

apellidos

direccion

celular

correoElectronico

usuarioRegistro

fechaRegistro

estado

4. Empleado
id

nombres

primerApellido

segundoApellido

direccion

celular

cargo

usuarioRegistro

fechaRegistro

estado

5. Usuario
id

idEmpleado

usuario

clave

usuarioRegistro

fechaRegistro

estado

6. Venta
id

idCliente

idUsuario

documentoCliente

montoPago

montoCambio

montoTotal

usuarioRegistro

fechaRegistro

estado

7. VentaDetalle
id

idVenta

idProducto

cantidad

precioUnitario

subtotal

usuarioRegistro

fechaRegistro

estado

