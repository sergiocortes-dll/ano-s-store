# CLIENT MEETING REQUIREMENTS
## Proyecto tienda

Ana es una estudiante que vende dulces en el salón. Ella quiere tener un programa en C# que le ayude a manejar las ventas de su tienda.
Tu equipo será el encargado de desarrollar este programa.

### Objetivo
Crear un sistema en C# (consola) que simule el funcionamiento de la tienda de Ana, aplicando todos los temas vistos en clase:
- Condicionales (if, else if, else, anidados, ternarios).
- Ciclos (for, while, do while).
- Arrays.
- Listas.
- Métodos.
#### Requerimientos del programa
1. Productos iniciales
La tienda debe manejar 4 productos, cada uno con:
- Nombre.
- Precio.
- Stock (cantidad disponible).
2. Mostrar productos
Al iniciar, el programa debe mostrar todos los productos con su precio y stock disponible.
3. Comprar productos:
- El usuario debe poder escribir qué producto desea comprar.
- El programa debe validar si existe ese producto.
- Luego debe preguntar cuántas unidades quiere.
- Si la cantidad solicitada está disponible en el stock:
- Se descuenta del inventario.
- Se suma al total de la compra.
- Se guarda un registro de lo comprado en un historial.
- Si no hay suficiente stock, mostrar un mensaje de error.
4. Seguir comprando
Después de cada compra, el programa debe preguntar si desea seguir comprando.
- Si la respuesta es "sí", volver a mostrar el menú de productos.
- Si la respuesta es "no", terminar la compra.
5. Descuentos
- Si la compra total supera $10.000, aplicar un 10% de descuento.
- Si la compra total supera $20.000, aplicar un 20% de descuento.
6. Ticket de compra
Al final, el programa debe mostrar:
- Todos los productos comprados con su cantidad y subtotal.
- El total de la compra (con el descuento aplicado si corresponde).
- Un mensaje de agradecimiento: "¡Gracias por comprar en la tienda de Ana!".

#### Recomendación: Trabajen en equipo(célula) Cada integrante puede encargarse de una parte:
1. Mostrar productos.
2. Manejo del stock.
3. Validaciones de compra.
4. Aplicar descuentos.
5. Generar el ticket final.
