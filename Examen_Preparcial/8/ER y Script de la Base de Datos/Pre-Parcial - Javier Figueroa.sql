-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-05-2017 a las 07:28:41
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hotelsancarlos`
--
CREATE DATABASE IF NOT EXISTS `hotelsancarlos` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `hotelsancarlos`;

DELIMITER $$
--
-- Funciones
--
DROP FUNCTION IF EXISTS `registraroperacion`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion` (`iusuario` VARCHAR(100), `iaccion` VARCHAR(500), `idescrip` VARCHAR(500), `itabla` VARCHAR(50), `iip` VARCHAR(20)) RETURNS INT(2) BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
END$$

DROP FUNCTION IF EXISTS `ValidarContrasena`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena` (`iusuario` VARCHAR(20), `icon` VARCHAR(20), `iip` VARCHAR(20)) RETURNS INT(2) IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
BEGIN
DECLARE psw char(20);
SELECT contrasenia into psw FROM usuario WHERE usuario=iusuario;
	IF icon != psw THEN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Fallo loggeo','Login','usuario',iip);
	return 0;
	else
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Loggeo exitoso','Login','usuario',iip);
	return 1;
	END IF;
END;
ELSE 
return 0;
insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Fallo loggeo','Login','usuario',iip);
END IF$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` char(40) DEFAULT NULL,
  `id_modulo` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`id_aplicacion`, `nombre_aplicacion`, `id_modulo`) VALUES
(1101, 'Clientes', '1100'),
(1102, 'Proveedor', '1100'),
(1103, 'Producto', '1100'),
(1104, 'Inventario', '1100'),
(1201, 'Compras', '1200'),
(1202, 'Pedidos', '1200'),
(1203, 'Facturacion', '1200'),
(1301, 'Gestion de Perfil', '1300'),
(1302, 'Gestion de Usuarios', '1300'),
(1303, 'Aplicacion', '1300'),
(1304, 'Bitacora', '1300');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
CREATE TABLE `bitacora` (
  `id_bit` int(11) NOT NULL,
  `hora` time DEFAULT NULL,
  `fecha` time DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(10) DEFAULT NULL,
  `accion` varchar(500) DEFAULT NULL,
  `tabla` varchar(100) DEFAULT NULL,
  `ip` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`id_bit`, `hora`, `fecha`, `usuario`, `descripcion`, `accion`, `tabla`, `ip`) VALUES
(1, '17:25:31', '00:00:00', 'javier', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(2, '17:25:52', '00:00:00', 'javier', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(3, '17:27:38', '00:00:00', 'javier', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(4, '17:29:44', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(5, '17:34:10', '00:00:00', 'javierf', 'Fallo logg', 'Login', 'usuario', '192.168.1.'),
(6, '17:34:14', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(7, '17:35:09', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(8, '17:36:50', '00:00:00', 'javierf', 'Fallo logg', 'Login', 'usuario', '192.168.1.'),
(9, '17:36:52', '00:00:00', 'javierf', 'Fallo logg', 'Login', 'usuario', '192.168.1.'),
(10, '17:37:00', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(11, '17:37:09', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(12, '17:44:19', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(13, '17:54:08', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(14, '17:55:06', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(15, '18:35:44', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(16, '18:39:08', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(17, '19:03:57', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(18, '19:07:52', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(19, '19:09:47', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(20, '19:10:45', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(21, '19:11:23', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(22, '19:12:06', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(23, '19:37:11', '00:00:00', 'javierf', 'Fallo logg', 'Login', 'usuario', '192.168.1.'),
(24, '19:37:12', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(25, '19:39:08', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(26, '19:42:31', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(27, '19:56:45', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(28, '19:58:45', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(29, '20:00:36', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(30, '20:04:06', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(31, '20:10:39', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(32, '20:17:07', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(33, '20:21:19', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(34, '20:23:19', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(35, '20:30:19', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(36, '20:35:39', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(37, '20:38:06', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(38, '20:40:17', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(39, '20:43:50', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(40, '20:47:16', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(41, '20:50:32', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(42, '20:51:35', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(43, '20:53:36', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(44, '20:54:26', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(45, '20:55:08', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(46, '20:55:47', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(47, '21:02:04', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(48, '21:03:15', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(49, '21:05:38', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(50, '21:06:29', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(51, '21:34:01', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(52, '21:49:53', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(53, '21:50:53', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(54, '21:52:18', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(55, '21:54:24', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(56, '21:56:43', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(57, '21:57:34', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(58, '21:58:35', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(59, '21:59:18', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(60, '22:00:19', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(61, '22:01:14', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(62, '22:02:38', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(63, '22:03:26', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(64, '22:05:26', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(65, '22:08:01', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(66, '22:10:59', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(67, '22:12:36', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(68, '22:13:00', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(69, '22:14:25', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(70, '22:15:45', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(71, '22:16:29', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(72, '22:17:21', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(73, '22:18:13', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(74, '22:20:51', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(75, '22:21:31', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(76, '22:22:37', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(77, '22:26:58', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(78, '22:38:52', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(79, '22:39:42', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(80, '22:47:38', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(81, '22:53:15', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(82, '22:54:15', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(83, '23:03:34', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(84, '23:04:04', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(85, '23:17:49', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(86, '23:18:52', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(87, '23:19:41', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(88, '23:21:23', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(89, '23:22:47', '00:00:00', 'javierf', 'Loggeo exi', 'Login', 'usuario', '192.168.1.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `id_cliente_pk` int(11) NOT NULL,
  `nombre_cliente` varchar(75) DEFAULT NULL,
  `identificacion_cliente` varchar(50) DEFAULT NULL,
  `direccion_cliente` varchar(250) DEFAULT NULL,
  `telefono_cliente` varchar(25) DEFAULT NULL,
  `dpi_cliente` varchar(15) DEFAULT NULL,
  `nit_cliente` varchar(15) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente_pk`, `nombre_cliente`, `identificacion_cliente`, `direccion_cliente`, `telefono_cliente`, `dpi_cliente`, `nit_cliente`, `estado`) VALUES
(1, 'Javier Figueroa', NULL, '34 Ave A 7-43 Zona 7', '55544950', '290 5493 0101', '12393-1', 'INACTIVO'),
(2, 'pruebaprueba', NULL, 'pruebapruebapruebapruebapruebapruebaprueba', 'pruebaprueba', 'pruebaprueba', 'pruebaprueba', 'ACTIVO'),
(3, 'a', NULL, 'aa', 'a', 'a', 'a', 'INACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

DROP TABLE IF EXISTS `compra`;
CREATE TABLE `compra` (
  `id_compra_pk` int(11) NOT NULL,
  `cantidad_compra` int(11) DEFAULT NULL,
  `valor_unitario_compra` decimal(10,2) DEFAULT NULL,
  `valor_total_compra` decimal(10,2) DEFAULT NULL,
  `descuento_compra` decimal(10,2) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL,
  `id_producto_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_factura`
--

DROP TABLE IF EXISTS `detalle_factura`;
CREATE TABLE `detalle_factura` (
  `id_num_factura_pk` int(11) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  `id_compra_pk` int(11) NOT NULL,
  `id_producto_pk` int(11) NOT NULL,
  `cantidad_prods` int(11) DEFAULT NULL,
  `id_cliente_pk` int(11) NOT NULL,
  `id_factura_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

DROP TABLE IF EXISTS `detalle_pedido`;
CREATE TABLE `detalle_pedido` (
  `id_detalle_pedido_pk` int(11) NOT NULL,
  `cantidad_detalle_pedido` int(11) DEFAULT NULL,
  `subtotal_detalle_pedido` char(10) DEFAULT NULL,
  `estado_detalle_pedido` varchar(25) DEFAULT NULL,
  `descripcion_detalle_pedido` char(10) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `id_producto_pk` int(11) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  `id_compra_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

DROP TABLE IF EXISTS `factura`;
CREATE TABLE `factura` (
  `id_factura_pk` int(11) NOT NULL,
  `fecha_emision_factura` date DEFAULT NULL,
  `fecha_recepcion_factura` char(10) DEFAULT NULL,
  `subtotal_factura` decimal(10,2) DEFAULT NULL,
  `total_factura` decimal(10,2) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

DROP TABLE IF EXISTS `inventario`;
CREATE TABLE `inventario` (
  `id_inventario_pk` int(11) NOT NULL,
  `detalle_inventario` varchar(500) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

DROP TABLE IF EXISTS `modulo`;
CREATE TABLE `modulo` (
  `id_modulo` char(10) NOT NULL,
  `nombre` char(80) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`id_modulo`, `nombre`) VALUES
('1100', 'Catalogo'),
('1200', 'Procesos'),
('1300', 'Seguridad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE `pedido` (
  `id_pedido_pk` int(11) NOT NULL,
  `id_compra_pk` int(11) NOT NULL,
  `fecha_pedido` date DEFAULT NULL,
  `fecha_entreda_pedido` date DEFAULT NULL,
  `estado_pedido` varchar(25) DEFAULT NULL,
  `descuento_pedido` decimal(10,2) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL,
  `id_cliente_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

DROP TABLE IF EXISTS `perfil`;
CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL,
  `nombre_perfil` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `nombre_perfil`) VALUES
(1, 'Seguridad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_privilegios`
--

DROP TABLE IF EXISTS `perfil_privilegios`;
CREATE TABLE `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil_privilegios`
--

INSERT INTO `perfil_privilegios` (`id_aplicacion`, `id_perfil`, `ins`, `sel`, `upd`, `del`) VALUES
(1301, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `id_producto_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  `nombre_producto` varchar(65) DEFAULT NULL,
  `precio_producto` char(10) DEFAULT NULL,
  `descripcion_producto` varchar(250) DEFAULT NULL,
  `fecha_registro_producto` varchar(50) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto_pk`, `id_proveedor_pk`, `nombre_producto`, `precio_producto`, `descripcion_producto`, `fecha_registro_producto`, `estado`) VALUES
(5, 1, 'Parcialito', '58', 'hola', '1/05/2017', 'ACTIVO'),
(4, 1, '1', '1', '1', '16/05/2017', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_almacenado`
--

DROP TABLE IF EXISTS `producto_almacenado`;
CREATE TABLE `producto_almacenado` (
  `id_produc_almac` int(11) NOT NULL,
  `cantidad_existente` int(11) DEFAULT NULL,
  `id_inventario_pk` int(11) NOT NULL,
  `id_producto_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL,
  `nombre_proveedor` varchar(65) DEFAULT NULL,
  `direccion_proveedor` varchar(150) DEFAULT NULL,
  `telefono_proveedor` varchar(25) DEFAULT NULL,
  `correo_proveedor` varchar(65) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id_proveedor_pk`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `correo_proveedor`, `estado`) VALUES
(1, 'Comida Parcialito', '3a. Avenida 9-00 zona 2, 01002 Interior Finca El Zapote', '2411 1800', 'universidadmarianogalvez@miumg.edu.gt', 'ACTIVO'),
(2, 'prueba1111111', 'prueba', 'prueba', 'prueba', 'INACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empleado_pk`, `id_empresa_pk`, `id_area_trabajo_pk`) VALUES
('javierf', 'aABvAGwAYQA=', '2017-05-17', 'ACTIVO', '1', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_modulo`
--

DROP TABLE IF EXISTS `usuario_modulo`;
CREATE TABLE `usuario_modulo` (
  `usuario` char(50) NOT NULL,
  `id_modulo` char(10) NOT NULL,
  `permiso` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario_modulo`
--

INSERT INTO `usuario_modulo` (`usuario`, `id_modulo`, `permiso`) VALUES
('javierf', '1300', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_privilegios`
--

DROP TABLE IF EXISTS `usuario_privilegios`;
CREATE TABLE `usuario_privilegios` (
  `usuario` char(50) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario_privilegios`
--

INSERT INTO `usuario_privilegios` (`usuario`, `id_aplicacion`, `ins`, `sel`, `upd`, `del`, `id_perfil`) VALUES
('javierf', 1101, 1, 1, 1, 1, 1),
('javierf', 1102, 1, 1, 1, 1, 1),
('javierf', 1103, 1, 1, 1, 1, 1),
('javierf', 1104, 1, 1, 1, 1, 1),
('javierf', 1201, 1, 1, 1, 1, 1),
('javierf', 1202, 1, 1, 1, 1, 1),
('javierf', 1203, 1, 1, 1, 1, 1),
('javierf', 1301, 1, 1, 1, 1, 1),
('javierf', 1302, 1, 1, 1, 1, 1),
('javierf', 1303, 1, 1, 1, 1, 1),
('javierf', 1304, 1, 1, 1, 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`id_aplicacion`),
  ADD KEY `Refmodulo32` (`id_modulo`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`id_bit`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente_pk`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`id_compra_pk`),
  ADD KEY `RefProducto26` (`id_producto_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD PRIMARY KEY (`id_num_factura_pk`,`id_pedido_pk`,`id_compra_pk`),
  ADD KEY `RefCliente14` (`id_cliente_pk`),
  ADD KEY `RefFactura15` (`id_factura_pk`),
  ADD KEY `RefProducto16` (`id_producto_pk`,`id_proveedor_pk`),
  ADD KEY `RefPedido20` (`id_pedido_pk`,`id_compra_pk`);

--
-- Indices de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD PRIMARY KEY (`id_detalle_pedido_pk`),
  ADD KEY `RefProducto11` (`id_producto_pk`,`id_proveedor_pk`),
  ADD KEY `RefPedido12` (`id_pedido_pk`,`id_compra_pk`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`id_factura_pk`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`id_inventario_pk`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`id_modulo`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido_pk`,`id_compra_pk`),
  ADD KEY `RefCliente13` (`id_cliente_pk`),
  ADD KEY `RefCompra19` (`id_compra_pk`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`id_perfil`);

--
-- Indices de la tabla `perfil_privilegios`
--
ALTER TABLE `perfil_privilegios`
  ADD PRIMARY KEY (`id_aplicacion`,`id_perfil`),
  ADD KEY `Refperfil29` (`id_perfil`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_producto_pk`,`id_proveedor_pk`),
  ADD KEY `RefProveedor25` (`id_proveedor_pk`);

--
-- Indices de la tabla `producto_almacenado`
--
ALTER TABLE `producto_almacenado`
  ADD PRIMARY KEY (`id_produc_almac`),
  ADD KEY `RefInventario21` (`id_inventario_pk`),
  ADD KEY `RefProducto22` (`id_producto_pk`,`id_proveedor_pk`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id_proveedor_pk`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usuario`);

--
-- Indices de la tabla `usuario_modulo`
--
ALTER TABLE `usuario_modulo`
  ADD PRIMARY KEY (`usuario`,`id_modulo`),
  ADD KEY `Refmodulo34` (`id_modulo`);

--
-- Indices de la tabla `usuario_privilegios`
--
ALTER TABLE `usuario_privilegios`
  ADD PRIMARY KEY (`usuario`,`id_aplicacion`),
  ADD KEY `Refperfil27` (`id_perfil`),
  ADD KEY `Refaplicacion31` (`id_aplicacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1305;
--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `id_compra_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  MODIFY `id_num_factura_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  MODIFY `id_detalle_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `id_factura_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `id_inventario_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `id_producto_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `producto_almacenado`
--
ALTER TABLE `producto_almacenado`
  MODIFY `id_produc_almac` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
