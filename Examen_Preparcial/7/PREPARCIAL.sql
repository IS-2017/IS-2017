-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-05-2017 a las 05:14:49
-- Versión del servidor: 5.7.14
-- Versión de PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hotelsancarlos`
--

DELIMITER $$
--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion` (`iusuario` NVARCHAR(100), `iaccion` NVARCHAR(500), `idescrip` NVARCHAR(500), `itabla` NVARCHAR(50), `iip` NVARCHAR(20)) RETURNS INT(2) BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena` (`iusuario` NVARCHAR(20), `icon` NVARCHAR(20), `iip` NVARCHAR(20)) RETURNS INT(2) IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
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

CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` char(40) DEFAULT NULL,
  `id_modulo` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`id_aplicacion`, `nombre_aplicacion`, `id_modulo`) VALUES
(13101, 'Empleado', '13100'),
(13102, 'Activos', '13100'),
(13103, 'Jornadas', '13100'),
(13104, 'Puesto Laboral', '13100'),
(13105, 'Perfil Reclutamiento', '13100'),
(13106, 'Candidato', '13100'),
(13107, 'Medio de Difusion', '13100'),
(13108, 'Funcion', '13100'),
(13109, 'Examenes', '13100'),
(13110, 'area de trabajo', '13100'),
(13111, 'nominas', '13100'),
(13201, 'Reclutamiento', '13200'),
(13202, 'Evaluacion', '13200'),
(13203, 'Comisiones', '13200'),
(13204, 'Capacitaciones', '13200'),
(13205, 'Indemnizaciones', '13200'),
(13206, 'Vacaciones', '13200'),
(13207, 'Nominas', '13200'),
(13301, 'Bitacora', '13300'),
(13401, 'Desempeño Laboral', '13400'),
(13402, 'Pagos', '13400'),
(13501, 'seguridad 1', '13500'),
(13502, 'seguridad 2', '13500'),
(13503, 'seguridad 3', '13500'),
(13504, 'seguridad 4', '13500'),
(13600, 'reporteador', '13600'),
(13208, 'Asistencia Capacitacion', '13200');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien`
--

CREATE TABLE `bien` (
  `id_inventario_pk` int(11) NOT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado` varchar(11) NOT NULL DEFAULT 'ACTIVO',
  `id_producto_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bien`
--

INSERT INTO `bien` (`id_inventario_pk`, `descripcion`, `cantidad`, `estado`, `id_producto_pk`) VALUES
(1, 'fasdf', 2384, 'ACTIVO', 1),
(2, 'gdfbbfd', 54, 'ACTIVO', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

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
(1, '18:11:35', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(2, '18:22:09', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(3, '19:05:32', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(4, '19:10:40', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(5, '23:41:47', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(6, '23:44:11', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(7, '23:47:34', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(8, '23:48:19', '00:00:00', 'usuariodbs', 'Operacion ', 'Asignacion del usuario: javifigue al empleado: 4', 'usuario', '192.168.1.'),
(9, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13101', 'usuario_privilegios', '192.168.1.'),
(10, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13102', 'usuario_privilegios', '192.168.1.'),
(11, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13103', 'usuario_privilegios', '192.168.1.'),
(12, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13104', 'usuario_privilegios', '192.168.1.'),
(13, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13105', 'usuario_privilegios', '192.168.1.'),
(14, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13106', 'usuario_privilegios', '192.168.1.'),
(15, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13107', 'usuario_privilegios', '192.168.1.'),
(16, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13108', 'usuario_privilegios', '192.168.1.'),
(17, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13109', 'usuario_privilegios', '192.168.1.'),
(18, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13110', 'usuario_privilegios', '192.168.1.'),
(19, '23:48:19', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13111', 'usuario_privilegios', '192.168.1.'),
(20, '23:48:33', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(21, '00:22:06', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(22, '00:31:34', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(23, '00:35:43', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(24, '00:36:31', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(25, '00:39:31', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(26, '00:41:58', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(27, '00:46:36', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(28, '00:48:35', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(29, '00:51:54', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(30, '00:53:18', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(31, '00:56:55', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(32, '00:58:05', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(33, '00:59:22', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(34, '01:00:48', '00:00:00', 'javifigue', 'Fallo logg', 'Login', 'usuario', '192.168.1.'),
(35, '01:00:53', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(36, '01:01:43', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(37, '01:03:47', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(38, '01:05:37', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(39, '01:09:26', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(40, '01:26:05', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(41, '01:26:50', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(42, '06:41:09', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(43, '06:43:03', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(44, '06:45:56', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(45, '06:47:58', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(46, '06:51:22', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(47, '07:05:57', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(48, '07:10:04', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(49, '07:16:07', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(50, '07:16:38', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(51, '07:17:53', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(52, '07:18:24', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(53, '07:25:16', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(54, '07:30:29', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '127.0.0.1'),
(55, '07:55:05', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(56, '07:58:48', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(57, '07:59:24', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(58, '08:03:11', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(59, '08:03:34', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(60, '08:13:37', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(61, '08:14:49', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(62, '08:20:12', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(63, '08:22:00', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(64, '08:22:11', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(65, '08:24:16', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(66, '08:41:37', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(67, '10:36:28', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(68, '10:40:27', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(69, '10:41:43', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(70, '10:43:11', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(71, '10:45:00', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '169.254.36'),
(72, '10:48:17', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(73, '10:49:51', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(74, '10:52:51', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(75, '10:59:05', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(76, '11:18:37', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(77, '11:20:49', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(78, '11:21:30', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(79, '11:31:02', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(80, '11:31:24', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(81, '11:37:55', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(82, '11:39:11', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(83, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Eliminacion de privilegios para usuario: javifigue', 'usuario_privilegios', '10.1.66.22'),
(84, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13101', 'usuario_privilegios', '10.1.66.22'),
(85, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13102', 'usuario_privilegios', '10.1.66.22'),
(86, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13103', 'usuario_privilegios', '10.1.66.22'),
(87, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13104', 'usuario_privilegios', '10.1.66.22'),
(88, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13105', 'usuario_privilegios', '10.1.66.22'),
(89, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13106', 'usuario_privilegios', '10.1.66.22'),
(90, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13107', 'usuario_privilegios', '10.1.66.22'),
(91, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13108', 'usuario_privilegios', '10.1.66.22'),
(92, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13109', 'usuario_privilegios', '10.1.66.22'),
(93, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13110', 'usuario_privilegios', '10.1.66.22'),
(94, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13111', 'usuario_privilegios', '10.1.66.22'),
(95, '11:40:01', '00:00:00', 'usuariodbs', 'Asignacion', 'Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13207', 'usuario_privilegios', '10.1.66.22'),
(96, '11:40:16', '00:00:00', 'javifigue', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(97, '11:40:38', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(98, '11:41:49', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(99, '11:51:03', '00:00:00', 'USUARIODBS', 'Fallo logg', 'Login', 'usuario', '10.1.66.22'),
(100, '11:51:12', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.66.22'),
(101, '15:47:01', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(102, '15:55:33', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(103, '01:59:51', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(104, '02:01:52', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(105, '02:02:56', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(106, '02:05:19', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.'),
(107, '11:05:26', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(108, '11:08:47', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(109, '11:13:16', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(110, '11:21:22', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(111, '11:22:10', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(112, '11:24:19', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(113, '11:27:21', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(114, '11:30:22', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(115, '11:31:04', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(116, '11:34:09', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(117, '11:35:44', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(118, '11:40:44', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '10.1.80.66'),
(119, '13:23:31', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.56'),
(120, '21:43:13', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.56'),
(121, '21:45:40', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.56'),
(122, '21:54:12', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.56'),
(123, '22:14:11', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.56'),
(124, '22:14:54', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.56');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente_pk` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `correo_electronico` varchar(75) DEFAULT NULL,
  `estado` varchar(15) NOT NULL DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente_pk`, `nombre`, `apellido`, `telefono`, `correo_electronico`, `estado`) VALUES
(1, 'Daniel', 'Estrada', 123123, '214214213fasd', 'INACTIVO'),
(2, 'fxafa', 'fasdfas', 132312, 'dfas', 'ACTIVO'),
(3, 'cri', 'est', 52432, 'gdfb', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_factura`
--

CREATE TABLE `detalle_factura` (
  `id_detalle_fac_pk` int(11) NOT NULL,
  `id_pedido_pk` int(11) NOT NULL,
  `id_factura_pk` varchar(18) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_factura`
--

INSERT INTO `detalle_factura` (`id_detalle_fac_pk`, `id_pedido_pk`, `id_factura_pk`, `id_empresa_pk`) VALUES
(1, 1, '1', 1),
(2, 1, '2', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `id_empresa_pk` int(11) NOT NULL,
  `nombre_empresa` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `estado` varchar(12) NOT NULL DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id_empresa_pk`, `nombre_empresa`, `direccion`, `telefono`, `estado`) VALUES
(1, 'fasdf', 'xvcgds', 323, 'ACTIVO'),
(2, 'empresa2', 'gdsga1', 4213, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `id_factura_pk` int(18) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `fecha_vencimiento` date NOT NULL,
  `fecha_emision` date DEFAULT NULL,
  `hora_emision` varchar(10) NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `estado` varchar(15) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`id_factura_pk`, `id_empresa_pk`, `fecha_vencimiento`, `fecha_emision`, `hora_emision`, `subtotal`, `total`, `estado`) VALUES
(1, 1, '2017-05-17', '2017-05-17', '7:18 PM', '200.00', '200.00', 'ACTIVO'),
(2, 1, '2017-05-17', '2017-05-17', '7:19 PM', '200.00', '200.00', 'ACTIVO'),
(3, 1, '2017-05-17', '2017-05-17', '9:07 PM', '200.00', '200.00', 'ACTIVO'),
(4, 1, '2017-05-17', '2017-05-17', '9:11 PM', '200.00', '200.00', 'ACTIVO'),
(5, 1, '2017-05-17', '2017-05-17', '9:22 PM', '200.00', '200.00', 'ACTIVO'),
(6, 1, '2017-05-17', '2017-05-17', '10:32 PM', '964.80', '964.80', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nota_recibo`
--

CREATE TABLE `nota_recibo` (
  `id_nota_pk` int(11) NOT NULL,
  `id_inventario_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `id_pedido_pk` int(11) NOT NULL,
  `nombre` varchar(93) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `marca` varchar(12) NOT NULL DEFAULT 'S',
  `id_cliente_pk` int(11) NOT NULL,
  `id_producto_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`id_pedido_pk`, `nombre`, `descripcion`, `cantidad`, `marca`, `id_cliente_pk`, `id_producto_pk`) VALUES
(1, 'PEDIDO1', 'fasd', 3, 'X', 2, 1),
(2, 'PEDIDO1', 'FASDF', 2, 'X', 2, 1),
(3, 'PEDIDO2', 'dcbdfg', 23, 'X', 3, 1),
(4, 'PEDIDO2', 'ggfdsg', 5, 'X', 3, 2),
(5, 'pedido3', 'ghadga', 4, 'S', 2, 2),
(6, 'Pedido4', 'asdfasd', 5, 'S', 2, 2),
(7, 'Pedido4', 'gax', 53, 'S', 2, 2),
(8, 'Pedido4', 'gadgasd', 4, 'S', 2, 1),
(9, 'Pedido4', 'dgasdg', 5, 'S', 2, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio`
--

CREATE TABLE `precio` (
  `id_precio_pk` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `estado` varchar(15) DEFAULT 'ACTIVO',
  `id_inventario_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio_pk`, `precio`, `estado`, `id_inventario_pk`) VALUES
(1, '40.00', 'ACTIVO', 1),
(2, '8.96', 'ACTIVO', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `id_producto_pk` int(11) NOT NULL,
  `nombre_producto` varchar(50) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `estado` varchar(50) DEFAULT 'ACTIVO',
  `precio` decimal(10,2) DEFAULT NULL,
  `id_proveedor_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto_pk`, `nombre_producto`, `descripcion`, `estado`, `precio`, `id_proveedor_pk`) VALUES
(1, 'gsdgad', 'son 213mffasd', 'ACTIVO', '214.00', 1),
(2, 'manzanas', '35bb', 'ACTIVO', '5.66', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `estado` varchar(14) NOT NULL DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id_proveedor_pk`, `nombre`, `direccion`, `telefono`, `estado`) VALUES
(1, 'gaasgxgd', 'gasg', 123142, 'ACTIVO'),
(2, 'nuevo 1', 'fad', 15685, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL,
  `tipo` varchar(150) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empleado_pk`, `id_empresa_pk`, `id_area_trabajo_pk`, `tipo`) VALUES
('usuariodbs', 'aABvAGwAYQA=', '2017-04-25', 'ACTIVO', '1', 1, 1, ''),
('javifigue', 'MQAyADMANAA1AA==', '2017-04-25', NULL, '4', 0, 0, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_modulo`
--

CREATE TABLE `usuario_modulo` (
  `usuario` char(50) NOT NULL,
  `id_modulo` char(10) NOT NULL,
  `permiso` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_privilegios`
--

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
('usuariodbs', 13103, 1, 1, 1, 1, 1),
('usuariodbs', 13102, 1, 1, 1, 1, 1),
('usuariodbs', 13101, 1, 1, 1, 1, 1),
('usuariodbs', 13100, 1, 1, 1, 1, 1),
('usuariodbs', 13104, 1, 1, 1, 1, 1),
('usuariodbs', 13105, 1, 1, 1, 1, 1),
('usuariodbs', 13106, 1, 1, 1, 1, 1),
('usuariodbs', 13107, 1, 1, 1, 1, 1),
('usuariodbs', 13108, 1, 1, 1, 1, 1),
('usuariodbs', 13109, 1, 1, 1, 1, 1),
('usuariodbs', 13110, 1, 1, 1, 1, 1),
('usuariodbs', 13111, 1, 1, 1, 1, 1),
('usuariodbs', 13200, 1, 1, 1, 1, 1),
('usuariodbs', 13201, 1, 1, 1, 1, 1),
('usuariodbs', 13202, 1, 1, 1, 1, 1),
('usuariodbs', 13203, 1, 1, 1, 1, 1),
('usuariodbs', 13204, 1, 1, 1, 1, 1),
('usuariodbs', 13205, 1, 1, 1, 1, 1),
('usuariodbs', 13206, 1, 1, 1, 1, 1),
('usuariodbs', 13207, 1, 1, 1, 1, 1),
('usuariodbs', 13300, 1, 1, 1, 1, 1),
('usuariodbs', 13301, 1, 1, 1, 1, 1),
('usuariodbs', 13400, 1, 1, 1, 1, 1),
('usuariodbs', 13401, 1, 1, 1, 1, 1),
('usuariodbs', 13402, 1, 1, 1, 1, 1),
('usuariodbs', 13500, 1, 1, 1, 1, 1),
('usuariodbs', 13600, 1, 1, 1, 1, 1),
('usuariodbs', 13208, 1, 1, 1, 1, 1),
('usuariodbs', 13501, 1, 1, 1, 1, 1),
('usuariodbs', 13502, 1, 1, 1, 1, 1),
('usuariodbs', 13503, 1, 1, 1, 1, 1),
('usuariodbs', 13504, 1, 1, 1, 1, 1),
('javifigue', 13111, 1, 1, 1, 1, 0),
('javifigue', 13110, 1, 1, 1, 1, 0),
('javifigue', 13109, 1, 1, 1, 1, 0),
('javifigue', 13108, 1, 1, 1, 1, 0),
('javifigue', 13107, 1, 1, 1, 1, 0),
('javifigue', 13106, 1, 1, 1, 1, 0),
('javifigue', 13105, 1, 1, 1, 1, 0),
('javifigue', 13104, 1, 1, 1, 1, 0),
('javifigue', 13103, 1, 1, 1, 1, 0),
('javifigue', 13102, 1, 1, 1, 1, 0),
('javifigue', 13101, 1, 1, 1, 1, 0),
('javifigue', 13207, 1, 1, 1, 1, 0),
('usuariodbs', 13209, 1, 1, 1, 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bien`
--
ALTER TABLE `bien`
  ADD PRIMARY KEY (`id_inventario_pk`),
  ADD KEY `Refproducto1` (`id_producto_pk`);

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
-- Indices de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD PRIMARY KEY (`id_detalle_fac_pk`),
  ADD KEY `Refpedido7` (`id_pedido_pk`),
  ADD KEY `Reffactura8` (`id_factura_pk`,`id_empresa_pk`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`id_empresa_pk`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`id_factura_pk`,`id_empresa_pk`),
  ADD KEY `Refempresa3` (`id_empresa_pk`);

--
-- Indices de la tabla `nota_recibo`
--
ALTER TABLE `nota_recibo`
  ADD PRIMARY KEY (`id_nota_pk`),
  ADD KEY `Refbien10` (`id_inventario_pk`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido_pk`),
  ADD KEY `Refcliente6` (`id_cliente_pk`),
  ADD KEY `Refproducto9` (`id_producto_pk`);

--
-- Indices de la tabla `precio`
--
ALTER TABLE `precio`
  ADD PRIMARY KEY (`id_precio_pk`),
  ADD KEY `Refbien2` (`id_inventario_pk`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_producto_pk`),
  ADD KEY `Refproveedor4` (`id_proveedor_pk`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id_proveedor_pk`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usuario`),
  ADD KEY `Refempleado109` (`id_empleado_pk`),
  ADD KEY `Refempresa110` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `usuario_modulo`
--
ALTER TABLE `usuario_modulo`
  ADD PRIMARY KEY (`usuario`,`id_modulo`),
  ADD KEY `Refmodulo106` (`id_modulo`);

--
-- Indices de la tabla `usuario_privilegios`
--
ALTER TABLE `usuario_privilegios`
  ADD PRIMARY KEY (`usuario`,`id_aplicacion`),
  ADD KEY `Refperfil99` (`id_perfil`),
  ADD KEY `Refaplicacion103` (`id_aplicacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bien`
--
ALTER TABLE `bien`
  MODIFY `id_inventario_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  MODIFY `id_detalle_fac_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `id_factura_pk` int(18) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `nota_recibo`
--
ALTER TABLE `nota_recibo`
  MODIFY `id_nota_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de la tabla `precio`
--
ALTER TABLE `precio`
  MODIFY `id_precio_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `id_producto_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
