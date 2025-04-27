# sis457_TecnoCell
# [TecnoCell]

¡Bienvenido/a a [TecnoCell]!

Somos una tienda especializada en la venta de **celulares nuevos, originales y con garantía**. Contamos con una amplia variedad de modelos de las mejores marcas del mercado, adaptados a todos los gustos y presupuestos.


## ¿Qué ofrecemos?

-  Celulares nuevos y 100% originales
-  Precios competitivos
-  Garantía en todos los equipos
-  Asesoría personalizada 

## Entidades Iniciales

# Modelo
- id_Modelo
- nombreModelo 
- modeloProducto
- marca
- descripcio
- color

# Producto
- id 
- idModelo 
- descripcion 
- precioVenta 
- stock 

# Cliente
- id_Cliente 
- nombres 
- apellidos 
- direccion 
- celular 

# Compra
- id 
- idCliente 
- fechaCompra 
- totalCompra 

# DetalleCompra
- id 
- idCompra 
- idProducto 
- cantidad
- precioUnitario 
- total 