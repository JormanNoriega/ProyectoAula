//relaciono productos con su laboratorio, categoria y su proveedor
ALTER TABLE PRODUCTOS ADD CONSTRAINT fk_productos_id_categoria FOREIGN KEY (id_categoria) REFERENCES categorias(id_categoria);
ALTER TABLE PRODUCTOS ADD CONSTRAINT fk_productos_id_laboratorio FOREIGN KEY (id_laboratorio) REFERENCES laboratorios(id_laboratorio);
ALTER TABLE PRODUCTOS ADD CONSTRAINT fk_productos_nit_proveedor FOREIGN KEY (nit_proveedor) REFERENCES proveedores(nit_proveedor);

//relaciono los lotes de cada producto
ALTER TABLE LOTES ADD CONSTRAINT fk_lotes_cod_producto FOREIGN KEY (cod_producto) REFERENCES productos(cod_producto);
ALTER TABLE LOTES ADD CONSTRAINT pk_cod_lote PRIMARY KEY (cod_lote,cod_producto);

//relaciono detalles_ventas con productos y ventas
ALTER TABLE DETALLES_VENTAS ADD CONSTRAINT fk_detalles_ventas_cod_producto FOREIGN KEY (cod_producto) REFERENCES productos(cod_producto);
ALTER TABLE DETALLES_VENTAS ADD CONSTRAINT fk_detalles_ventas_id_venta FOREIGN KEY (id_venta) REFERENCES ventas(id_venta);


Delete from Laboratorios;
Delete from Categorias;
Delete from Productos;
DROP SEQUENCE incremento;

//Creo las secuencias
CREATE SEQUENCE incrementoLab START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE incrementoCat START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE incrementoDetalleVenta START WITH 1 INCREMENT BY 1;

//Creacion de Trigers
CREATE OR REPLACE TRIGGER trg_laboratorio
BEFORE INSERT ON LABORATORIOS
FOR EACH ROW
BEGIN
    SELECT incrementoLab.NEXTVAL INTO :NEW.id_laboratorio FROM dual;
END;

CREATE OR REPLACE TRIGGER trg_categoria
BEFORE INSERT ON CATEGORIAS
FOR EACH ROW
BEGIN
    SELECT incrementoCat.NEXTVAL INTO :NEW.id_categoria FROM dual;
END;

CREATE OR REPLACE TRIGGER trg_ingremento_detalle_venta
BEFORE INSERT ON detalles_ventas
FOR EACH ROW
BEGIN
    SELECT incrementoDetalleVenta.NEXTVAL INTO :NEW.id_detalle_venta FROM dual;
END;

SET SERVEROUTPUT ON;
//PROCEDIMIENTOS

//Buscar Prodcutos
CREATE OR REPLACE PROCEDURE BuscarProducto (CodProductoBuscado productos.cod_producto%TYPE, Resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN Resultados FOR SELECT * FROM PRODUCTOS WHERE Cod_Producto = CodProductoBuscado;
END BuscarProducto;


CREATE OR REPLACE PROCEDURE MostrarLotes (CodProductoBuscado productos.cod_producto%TYPE, resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN  resultados FOR SELECT * FROM Lotes WHERE Cod_Producto = CodProductoBuscado;
END MostrarLotes;

//Consultar Prodcutos con inner join
create or replace PROCEDURE ConsultarProductos (resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN  resultados FOR
    SELECT
      p.Cod_Producto "Codigo_Producto",
      p.Nomb_Producto "Nombre_Producto",
      f.nit_proveedor "Nit_Proveedor",
      f.Nomb_Proveedor "Nombre_Proveedor",
      c.id_categoria "Id_Categoria",
      c.Nomb_Categoria "Nombre_Categoria",
      l.id_laboratorio "Id_laboratorio",
      l.Nomb_Laboratorio "Nombre_Laboratorio",
      COALESCE(SUM(lt.cantidad), 0)"Cantidad_Total",
      p.descripcion "Descripcion"
    FROM Productos p
    INNER JOIN Proveedores f ON p.Nit_Proveedor = f.Nit_Proveedor
    INNER JOIN Categorias c ON p.Id_Categoria = c.Id_Categoria
    INNER JOIN Laboratorios l ON p.Id_Laboratorio = l.Id_Laboratorio
    LEFT JOIN Lotes lt ON p.Cod_Producto = lt.Cod_Producto OR lt.Cod_Producto IS NULL
    GROUP BY p.Cod_Producto, p.Nomb_Producto, f.nit_proveedor, f.Nomb_Proveedor, c.id_categoria, c.Nomb_Categoria, l.id_laboratorio, l.Nomb_Laboratorio,p.descripcion;
END ConsultarProductos;


//PROCEDIMIENTO DE INSERTAR PROVEEDOR
CREATE OR REPLACE PROCEDURE prc_InsertarProveedor (
    nit proveedores.nit_proveedor%type,
    nombre proveedores.nomb_proveedor%type
)
IS
BEGIN
    INSERT INTO Proveedores (nit_proveedor, nomb_proveedor)
    VALUES (nit,nombre);
    COMMIT;
END prc_InsertarProveedor;

//eliminar proveedores 
CREATE OR REPLACE PROCEDURE prc_eliminarproveedor (
    nit_proveedor Proveedores.NIT_PROVEEDOR%TYPE,
    eliminacion_exitosa OUT NUMBER
)
IS
    productos_asociados NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO productos_asociados
    FROM Productos
    WHERE NIT_PROVEEDOR = nit_proveedor;

    IF productos_asociados = 0 THEN
        DELETE FROM Proveedores
        WHERE NIT_PROVEEDOR = nit_proveedor;
        eliminacion_exitosa := 1;
        COMMIT;
    ELSE
        eliminacion_exitosa := 0;
    END IF;
END prc_eliminarproveedor;


//PROCEDIMIENTO PARA INSERTAR LABORATORIOS
CREATE OR REPLACE PROCEDURE prc_InsertarLaboratorio (
    nombre Laboratorios.nomb_laboratorio%type
)
IS
BEGIN
    INSERT INTO laboratorios (nomb_laboratorio)
    VALUES (nombre);
    COMMIT;
END prc_InsertarLaboratorio;

//eliminar labortorios
CREATE OR REPLACE PROCEDURE prc_eliminarlaboratorio (
    id_laboratorio Laboratorios.ID_LABORATORIO%TYPE,
    eliminacion_exitosa OUT NUMBER
)
IS
    productos_asociados NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO productos_asociados
    FROM Productos
    WHERE ID_LABORATORIO = id_laboratorio;

    IF productos_asociados = 0 THEN
        DELETE FROM Laboratorios
        WHERE ID_LABORATORIO = id_laboratorio;
        eliminacion_exitosa := 1;
        COMMIT;
    ELSE
        eliminacion_exitosa := 0;
    END IF;
END prc_eliminarlaboratorio;

//PROCEDIMIENTO PARA INSERTAR CATEGORIAS
CREATE OR REPLACE PROCEDURE prc_InsertarCategoria (
    nombre categorias.nomb_categoria%type
)
IS
BEGIN
    INSERT INTO categorias (nomb_categoria)
    VALUES (nombre);
    COMMIT;
END prc_InsertarCategoria;

// eliminar categorias
CREATE OR REPLACE PROCEDURE prc_eliminarcategoria (
    id_categoria Productos.ID_CATEGORIA%TYPE,
    eliminacion_exitosa OUT NUMBER
)
IS
    categoria_en_uso NUMBER;
BEGIN
    -- Verificar si la categoría está siendo utilizada en algún producto
    SELECT COUNT(*)
    INTO categoria_en_uso
    FROM Productos
    WHERE ID_CATEGORIA = id_categoria;

    IF categoria_en_uso = 0 THEN
        DELETE FROM Categorias
        WHERE ID_CATEGORIA = id_categoria;
        eliminacion_exitosa := 1; -- Indicador de eliminación exitosa
        COMMIT;
    ELSE
        eliminacion_exitosa := 0; -- Indicador de que la eliminación no fue exitosa
    END IF;
END prc_eliminarcategoria;



//insertar Productos
CREATE OR REPLACE PROCEDURE prc_InsertarProducto (
    p_cod_producto Productos.COD_PRODUCTO%TYPE,
    p_nomb_producto Productos.NOMB_PRODUCTO%TYPE,
    p_nit_proveedor Productos.NIT_PROVEEDOR%TYPE,
    p_id_categoria Productos.ID_CATEGORIA%TYPE,
    p_id_laboratorio Productos.ID_LABORATORIO%TYPE,
    p_descripcion Productos.DESCRIPCION%TYPE
)
IS
BEGIN
    INSERT INTO Productos (COD_PRODUCTO, NOMB_PRODUCTO, NIT_PROVEEDOR, ID_CATEGORIA, ID_LABORATORIO, DESCRIPCION)
    VALUES (p_cod_producto, p_nomb_producto, p_nit_proveedor, p_id_categoria, p_id_laboratorio, p_descripcion);
    COMMIT;
END prc_InsertarProducto;

//eliminar Productos
CREATE OR REPLACE PROCEDURE prc_eliminarproducto (
    codigo_producto Productos.COD_PRODUCTO%TYPE,
    eliminacion_exitosa OUT NUMBER
)
IS
    lote_count NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO lote_count
    FROM Lotes
    WHERE COD_PRODUCTO = codigo_producto;

    IF lote_count = 0 THEN
        DELETE FROM Productos
        WHERE COD_PRODUCTO = codigo_producto;
        eliminacion_exitosa := 1; -- Indicador de eliminación exitosa
        COMMIT;
    ELSE
        eliminacion_exitosa := 0; -- Indicador de que la eliminación no fue exitosa
    END IF;
END prc_eliminarproducto;

//actualizar Productos
CREATE OR REPLACE PROCEDURE prc_actualizarproducto (
    p_cod_producto Productos.COD_PRODUCTO%TYPE,
    p_nomb_producto Productos.NOMB_PRODUCTO%TYPE,
    p_nit_proveedor Productos.NIT_PROVEEDOR%TYPE,
    p_id_categoria Productos.ID_CATEGORIA%TYPE,
    p_id_laboratorio Productos.ID_LABORATORIO%TYPE,
    p_descripcion Productos.DESCRIPCION%TYPE
)
IS
BEGIN
    UPDATE Productos
    SET NOMB_PRODUCTO = p_nomb_producto,
        NIT_PROVEEDOR = p_nit_proveedor,
        ID_CATEGORIA = p_id_categoria,
        ID_LABORATORIO = p_id_laboratorio,
        DESCRIPCION = p_descripcion
    WHERE COD_PRODUCTO = p_cod_producto;
    COMMIT;
END prc_actualizarproducto;

//insertar Lotes
CREATE OR REPLACE PROCEDURE prc_InsertarLote (
    l_cod_lote Lotes.cod_lote%TYPE,
    l_cod_producto Lotes.cod_producto%TYPE,
    l_vencimiento Lotes.vencimiento%TYPE,
    l_cantidad Lotes.cantidad%TYPE,
    l_precio_compra Lotes.precio_compra%TYPE,
    l_precio_venta Lotes.precio_venta%TYPE
) 
IS
BEGIN
    INSERT INTO Lotes (cod_lote, cod_producto, vencimiento, cantidad, precio_compra, precio_venta)
    VALUES (l_cod_lote, l_cod_producto, l_vencimiento, l_cantidad, l_precio_compra, l_precio_venta);
    COMMIT;
END prc_InsertarLote;

//eliminar Lotes
CREATE OR REPLACE PROCEDURE prc_eliminarlote (
    codigo_lote Lotes.COD_LOTE%TYPE
)
IS
BEGIN
    DELETE FROM Lotes
    WHERE COD_LOTE = codigo_lote;
    COMMIT;
END prc_eliminarlote;

//actualizar Lote
CREATE OR REPLACE PROCEDURE prc_actualizarlote (
    codigo_lote Lotes.COD_LOTE%TYPE,
    vencimiento Lotes.VENCIMIENTO%TYPE,
    cantidad Lotes.CANTIDAD%TYPE,
    precio_compra Lotes.PRECIO_COMPRA%TYPE,
    precio_venta Lotes.PRECIO_VENTA%TYPE
)
IS
BEGIN
    UPDATE Lotes
    SET VENCIMIENTO = vencimiento,
        CANTIDAD = cantidad,
        PRECIO_COMPRA = precio_compra,
        PRECIO_VENTA = precio_venta
    WHERE COD_LOTE = codigo_lote;
    COMMIT;
END prc_actualizarlote;

UPDATE Lotes
    SET VENCIMIENTO = SYSDATE,
        CANTIDAD = 10,
        PRECIO_COMPRA = 1000,
        PRECIO_VENTA = 2000
    WHERE COD_LOTE = 'preuba 2'
    AND COD_PRODUCTO = 2;
    

//logica de venta
CREATE OR REPLACE TYPE producto_tipo AS OBJECT (
    cod_producto NUMBER,
    nomb_producto VARCHAR2(50),
    cantidad NUMBER,
    cod_lote VARCHAR2(50),
    total_venta NUMBER
);

CREATE OR REPLACE TYPE productos_tabla AS TABLE OF producto_tipo;

CREATE OR REPLACE PROCEDURE prc_InsertarVenta(
    p_fecha_venta DATE,
    p_total_venta NUMBER,
    p_productos_vendidos productos_tabla
) AS
    venta_id NUMBER;
BEGIN
    -- Lógica para insertar la venta
    INSERT INTO Ventas(fecha_venta, total_venta)
    VALUES (p_fecha_venta, p_total_venta)
    RETURNING id_venta INTO venta_id;
    
    -- Lógica para insertar detalles de la venta
    FOR i IN 1..p_productos_vendidos.COUNT
    LOOP
        INSERT INTO Detalles_Ventas(id_venta, cod_producto, cantidad, cod_lote, total_venta)
        VALUES (
            venta_id,
            p_productos_vendidos(i).cod_producto,
            p_productos_vendidos(i).cantidad,
            p_productos_vendidos(i).cod_lote,
            p_productos_vendidos(i).total_venta
        );
    END LOOP;
    COMMIT; -- Confirmar la transacción
END prc_InsertarVenta;

SELECT * FROM Ventas;


























