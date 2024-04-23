use EMPRESA
CREATE TABLE Productos (
    ID_Producto INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL
);

   (ID_Producto, Nombre, Precio, Stock)
VALUES
    (1, 'Hamburguesa Simple', 5, 50),
    (2, 'Hamburguesa Doble',  8, 100),
    (3, 'alitas_pollo',  10, 75);

	select * from productos
	DELETE FROM productos;

