--
-- ER/Studio 8.0 SQL Code Generation
-- Project :      modelo.DM1
--
-- Date Created : Wednesday, May 17, 2017 21:12:17
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: bodega 
--

CREATE TABLE bodega(
    id_bodega           INT             AUTO_INCREMENT,
    nombre_bodega       VARCHAR(50),
    direccion_bodega    VARCHAR(150),
    PRIMARY KEY (id_bodega)
)ENGINE=MYISAM
;



-- 
-- TABLE: cliente 
--

CREATE TABLE cliente(
    codigo_cliente       INT             AUTO_INCREMENT,
    nit_cliente          VARCHAR(20),
    nombre_cliente       VARCHAR(50),
    apellido_cliente     VARCHAR(50),
    direccion_cliente    VARCHAR(100),
    telefono_cliente     VARCHAR(12),
    id_tprecio           INT,
    PRIMARY KEY (codigo_cliente)
)ENGINE=MYISAM
;



-- 
-- TABLE: detalle_factura 
--

CREATE TABLE detalle_factura(
    id_detalle         INT               AUTO_INCREMENT,
    nombre_producto    VARCHAR(50),
    precio             DECIMAL(10, 2),
    cantidad           INT,
    id_precio          INT,
    id_factura         INT,
    PRIMARY KEY (id_detalle)
)ENGINE=MYISAM
;



-- 
-- TABLE: existencia 
--

CREATE TABLE existencia(
    id_existencia    INT    AUTO_INCREMENT,
    cantidad         INT,
    id_producto      INT,
    id_bodega        INT,
    PRIMARY KEY (id_existencia)
)ENGINE=MYISAM
;



-- 
-- TABLE: factura 
--

CREATE TABLE factura(
    id_factura          INT               AUTO_INCREMENT,
    fecha_factura       VARCHAR(50),
    subtotal_factura    DECIMAL(10, 2),
    total_factura       DECIMAL(10, 2)    NOT NULL,
    codigo_cliente      INT,
    PRIMARY KEY (id_factura)
)ENGINE=MYISAM
;



-- 
-- TABLE: precio 
--

CREATE TABLE precio(
    id_precio      INT               AUTO_INCREMENT,
    precio         DECIMAL(10, 2)    NOT NULL,
    id_producto    INT,
    id_tprecio     INT,
    PRIMARY KEY (id_precio)
)ENGINE=MYISAM
;



-- 
-- TABLE: producto 
--

CREATE TABLE producto(
    id_producto        INT               AUTO_INCREMENT,
    nombre_producto    VARCHAR(50),
    marca_producto     VARCHAR(50),
    costo_producto     DECIMAL(10, 2),
    PRIMARY KEY (id_producto)
)ENGINE=MYISAM
;



-- 
-- TABLE: tipo_precio 
--

CREATE TABLE tipo_precio(
    id_tprecio    INT            AUTO_INCREMENT,
    tipo          VARCHAR(50),
    PRIMARY KEY (id_tprecio)
)ENGINE=MYISAM
;



-- 
-- TABLE: cliente 
--

ALTER TABLE cliente ADD CONSTRAINT Reftipo_precio11 
    FOREIGN KEY (id_tprecio)
    REFERENCES tipo_precio(id_tprecio)
;


-- 
-- TABLE: detalle_factura 
--

ALTER TABLE detalle_factura ADD CONSTRAINT Refprecio16 
    FOREIGN KEY (id_precio)
    REFERENCES precio(id_precio)
;

ALTER TABLE detalle_factura ADD CONSTRAINT Reffactura17 
    FOREIGN KEY (id_factura)
    REFERENCES factura(id_factura)
;


-- 
-- TABLE: existencia 
--

ALTER TABLE existencia ADD CONSTRAINT Refproducto19 
    FOREIGN KEY (id_producto)
    REFERENCES producto(id_producto)
;

ALTER TABLE existencia ADD CONSTRAINT Refbodega20 
    FOREIGN KEY (id_bodega)
    REFERENCES bodega(id_bodega)
;


-- 
-- TABLE: factura 
--

ALTER TABLE factura ADD CONSTRAINT Refcliente15 
    FOREIGN KEY (codigo_cliente)
    REFERENCES cliente(codigo_cliente)
;


-- 
-- TABLE: precio 
--

ALTER TABLE precio ADD CONSTRAINT Refproducto12 
    FOREIGN KEY (id_producto)
    REFERENCES producto(id_producto)
;

ALTER TABLE precio ADD CONSTRAINT Reftipo_precio14 
    FOREIGN KEY (id_tprecio)
    REFERENCES tipo_precio(id_tprecio)
;


