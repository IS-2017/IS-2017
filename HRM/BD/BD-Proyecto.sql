-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-05-2017 a las 02:11:44
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
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `cantidad_dia` (`fecha_inicio` CHAR(25), `fecha_hoy` CHAR(20))  BEGIN
SELECT timestampdiff(DAY, fecha_inicio, fecha_hoy);

end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `comision` (`fecha_inicio` CHAR(30), `fecha_fin` CHAR(30), `id_empleado` CHAR(30))  BEGIN
  select sum(total_comision) as Total from com_venta where id_empleado_pk = id_empleado and fecha between fecha_inicio and fecha_fin;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPorcentajeSocial` (`sueldo_base` CHAR(20))  BEGIN
  DECLARE done INT DEFAULT 0;
  DECLARE a  int;
  DECLARE c int;
  DECLARE b int;
  DECLARE cur1 CURSOR  FOR SELECT minimo_sueldo, maximo_sueldo FROM tasa_impuesto;
  DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
  OPEN cur1;
c1_loop: LOOP
    FETCH cur1 INTO a, b;
   
    IF (sueldo_base between a and b) THEN
  
      select @F:= porcentaje from tasa_impuesto where minimo_sueldo = a and maximo_sueldo = b ;
      leave c1_loop;
      
    END IF;
  END LOOP ;
CLOSE cur1;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `validar_nomina` (`fecha_inicio` CHAR(40), `fecha_fin` CHAR(40), `empresa` CHAR(40))  BEGIN
select count(id_nomina_pk) from nomina where fecha_inicio_pago between  fecha_inicio and fecha_fin and id_empresa_pk = empresa;

end$$

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
-- Estructura de tabla para la tabla `activos_empresa`
--

CREATE TABLE `activos_empresa` (
  `id_activos_emp_pk` int(11) NOT NULL,
  `nombre_activo` varchar(50) DEFAULT NULL,
  `num_serie_activo` varchar(50) NOT NULL,
  `precio_activo` decimal(10,2) DEFAULT NULL,
  `descripcion_activo` varchar(150) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `activos_empresa`
--

INSERT INTO `activos_empresa` (`id_activos_emp_pk`, `nombre_activo`, `num_serie_activo`, `precio_activo`, `descripcion_activo`, `estado`) VALUES
(1, 'Laptop Acer Aspire v3', 'A928482992-1', '3467.39', 'Procesador I5, 8Gb de Ram', 'ACTIVO'),
(2, 'Celular Samsung', 'A293847567/4', '1000.00', 'Celuar', 'ACTIVO'),
(3, 'Monitor HP 26', 'T516', '1740.00', 'Monitor', 'INACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aignacion_activo_empleado`
--

CREATE TABLE `aignacion_activo_empleado` (
  `id_asignacion_act_emp_pk` int(11) NOT NULL,
  `disponibilidad` varchar(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `id_activos_emp_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
-- Estructura de tabla para la tabla `area_trabajo`
--

CREATE TABLE `area_trabajo` (
  `id_area_trabajo_pk` int(11) NOT NULL,
  `puesto` char(25) DEFAULT NULL,
  `descripcion_puesto` char(200) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `area_trabajo`
--

INSERT INTO `area_trabajo` (`id_area_trabajo_pk`, `puesto`, `descripcion_puesto`, `fecha`, `estado`) VALUES
(1, 'IT', 'fasdfasfa', '2017-04-12', 'ACTIVO'),
(2, 'Produccion', 'afsdfas', '2017-04-07', 'ACTIVO'),
(3, 'Desarrollo', 'desarrollo', '2017-04-18', 'INACTIVO'),
(4, 'Ext', 'fasd', '2017-04-23', 'INACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencia_cap`
--

CREATE TABLE `asistencia_cap` (
  `id_asis_cap_pk` int(10) NOT NULL,
  `fecha_asis` date NOT NULL,
  `asistencia` varchar(50) NOT NULL,
  `evaluacion` int(11) NOT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  `id_capacitacion_pk` varchar(100) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bien`
--

CREATE TABLE `bien` (
  `id_bien_pk` int(11) NOT NULL,
  `precio` decimal(18,0) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `descripcion` char(80) DEFAULT NULL,
  `id_linea_pk` int(11) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bien`
--

INSERT INTO `bien` (`id_bien_pk`, `precio`, `costo`, `descripcion`, `id_linea_pk`, `porcentaje_comision`, `estado`, `id_marca_pk`) VALUES
(1, '1000', '500', 'PRODUCTO 1', 1, '5', 'ACTIVO', 1),
(2, '1500', '750', 'PRODUCTO 2', 2, '7', 'ACTIVO', 1),
(3, '2000', '1000', 'PRODUCTO 3', 1, '8', 'ACTIVO', 2),
(4, '3500', '2000', 'PRODUCTO 4', 2, '10', 'ACTIVO', 2);

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
(102, '15:55:33', '00:00:00', 'usuariodbs', 'Loggeo exi', 'Login', 'usuario', '192.168.1.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bonificacion`
--

CREATE TABLE `bonificacion` (
  `id_bono_pk` int(11) NOT NULL,
  `pais` varchar(40) DEFAULT NULL,
  `valor` int(20) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bonificacion`
--

INSERT INTO `bonificacion` (`id_bono_pk`, `pais`, `valor`, `estado`) VALUES
(1, 'Guatemala', 250, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `candidato`
--

CREATE TABLE `candidato` (
  `id_candidato_pk` int(10) NOT NULL,
  `nombre_candidato` varchar(50) DEFAULT NULL,
  `apellido_candidato` varchar(50) DEFAULT NULL,
  `cv_candidato` varchar(500) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_reclutamiento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `candidato`
--

INSERT INTO `candidato` (`id_candidato_pk`, `nombre_candidato`, `apellido_candidato`, `cv_candidato`, `estado`, `id_reclutamiento_pk`) VALUES
(1, 'daniel', 'estrada', 'C:UsersottogDownloads54-231-1-PB.pdf', 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `capacitacion`
--

CREATE TABLE `capacitacion` (
  `id_capacitacion_pk` int(10) NOT NULL,
  `objetivo` varchar(100) DEFAULT NULL,
  `actividad` varchar(50) DEFAULT NULL,
  `recursos` varchar(150) DEFAULT NULL,
  `estado` varchar(10) DEFAULT 'ACTIVO',
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `horario_inicio` varchar(15) DEFAULT NULL,
  `horario_fin` varchar(15) DEFAULT NULL,
  `marca` varchar(50) NOT NULL DEFAULT 'X',
  `marca_asistencia` varchar(10) DEFAULT 'X',
  `id_empleado_pk` varchar(18) NOT NULL,
  `id_ubicacion_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `capacitacion`
--

INSERT INTO `capacitacion` (`id_capacitacion_pk`, `objetivo`, `actividad`, `recursos`, `estado`, `fecha_inicio`, `fecha_fin`, `horario_inicio`, `horario_fin`, `marca`, `marca_asistencia`, `id_empleado_pk`, `id_ubicacion_pk`, `id_empresa_pk`) VALUES
(1, 'fasdfasd', 'hola', 'fasdfas', 'INACTIVO', '2017-04-16', '2017-04-16', '8:00', '8:00', 'X', 'X', '1', 1, 1),
(2, 'fasdfasd', 'hola', 'fasdfas', 'INACTIVO', '2017-04-16', '2017-04-16', '8:00', '8:00', 'X', 'X', '3', 1, 1),
(3, 'fasdfasdfasd', 'fasdf', 'fasdfdas', 'INACTIVO', '2017-04-16', '2017-04-16', '12:00', '13:00', 'X', 'X', '1', 2, 1),
(4, 'fasdfasdfasd', 'fasdf', 'fasdfdas', 'INACTIVO', '2017-04-16', '2017-04-16', '12:00', '13:00', 'X', 'S', '3', 2, 1),
(5, 'fasdfasdfasd', 'fasdf', 'fasdfdas', 'INACTIVO', '2017-04-16', '2017-04-16', '12:00', '13:00', 'X', 'X', '2', 2, 1),
(6, 'fasdfasdfasd', 'fasdf', 'fasdfdas', 'INACTIVO', '2017-04-16', '2017-04-16', '12:00', '13:00', 'X', 'X', '4', 2, 1),
(12, 'fasdfasd', 'hola', 'fasdfas', 'INACTIVO', '2017-04-16', '2017-04-16', '8:00', '8:00', 'X', 'X', '4', 1, 1),
(11, 'fasdfasd', 'hola', 'fasdfas', 'INACTIVO', '2017-04-16', '2017-04-16', '8:00', '8:00', 'X', 'X', '2', 1, 1),
(13, 'ninguno', 'Nuevo', 'desarrollo', 'ACTIVO', '2017-04-18', '2017-04-14', '8:00', '16:00', 'X', 'X', '1', 1, 1),
(14, 'ninguno', 'Nuevo', 'desarrollo', 'ACTIVO', '2017-04-18', '2017-04-14', '8:00', '16:00', 'X', 'S', '2', 1, 1),
(15, 'ninguno', 'Nuevo', 'desarrollo', 'ACTIVO', '2017-04-18', '2017-04-14', '8:00', '16:00', 'X', 'X', '3', 1, 1),
(21, 'produccion', 'nuevo2', 'Datos', 'ACTIVO', '2017-04-19', '2017-04-29', '8:00', '12:00', 'X', 'X', '1', 2, 1),
(20, 'ninguno', 'Nuevo', 'desarrollo', 'ACTIVO', '2017-04-18', '2017-04-14', '8:00', '16:00', 'X', 'S', '2', 1, 1),
(22, 'produccion', 'nuevo2', 'Datos', 'ACTIVO', '2017-04-19', '2017-04-29', '8:00', '12:00', 'X', 'X', '3', 2, 1),
(23, 'Reuniones', 'Reunion', 'Nuevo', 'ACTIVO', '2017-04-19', '2017-04-22', '8:00', '16:00', 'X', 'S', '1', 1, 1),
(24, 'Reuniones', 'Reunion', 'Nuevo', 'ACTIVO', '2017-04-19', '2017-04-22', '8:00', '16:00', 'X', 'S', '2', 1, 1),
(25, 'Reuniones', 'Reunion', 'Nuevo', 'ACTIVO', '2017-04-19', '2017-04-22', '8:00', '16:00', 'X', 'X', '3', 1, 1),
(26, 'fasdfasdfa', 'Prueba 2', 'datos', 'ACTIVO', '2017-04-20', '2017-04-20', '8:00', '11:00', 'X', 'X', '1', 2, 1),
(27, 'fasdfasdfa', 'Prueba 2', 'datos', 'ACTIVO', '2017-04-20', '2017-04-20', '8:00', '11:00', 'X', 'X', '3', 2, 1),
(28, 'fasdfas', 'fasdf', 'fasf', 'INACTIVO', '2017-04-21', '2017-04-21', '8:00', '15:00', 'X', 'S', '1', 1, 1),
(29, 'fasdfas', 'fasdf', 'fasf', 'INACTIVO', '2017-04-21', '2017-04-21', '8:00', '15:00', 'X', 'S', '2', 1, 1),
(30, 'fasfdas', 'IT', 'gad', 'ACTIVO', '2017-04-21', '2017-04-21', '8:00', '8:00', 'X', 'X', '2', 3, 2),
(31, 'fasfdas', 'IT', 'gad', 'ACTIVO', '2017-04-21', '2017-04-21', '8:00', '8:00', 'X', 'X', '3', 3, 2),
(32, 'fasfdas', 'IT', 'gad', 'ACTIVO', '2017-04-21', '2017-04-21', '8:00', '8:00', 'X', 'X', '1', 3, 2),
(33, 'fasdfasd', 'wiii', 'wiii', 'ACTIVO', '2017-04-21', '2017-04-21', '8:00', '11:00', 'X', 'X', '1', 1, 1),
(34, 'fasdfasd', 'wiii', 'wiii', 'ACTIVO', '2017-04-21', '2017-04-21', '8:00', '11:00', 'X', 'X', '3', 1, 1),
(35, 'xvc', 'fasd', 'xv', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '8:00', 'X', 'X', '1', 1, 1),
(36, 'xvc', 'fasd', 'xv', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '8:00', 'X', 'X', '2', 1, 1),
(37, 'xvcx', 'gasd', 'xgd', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '8:00', 'X', 'X', '1', 1, 1),
(38, 'xvcx', 'gasd', 'xgd', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '8:00', 'X', 'S', '2', 1, 1),
(39, 'vxdg', 'casd', 'drc', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '11:00', 'X', 'X', '4', 1, 2),
(40, 'vzxcv', 'prueba12', '---', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '8:00', 'X', 'X', '1', 1, 1),
(41, 'xvcx', 'gasd', 'xgd', 'ACTIVO', '2017-04-23', '2017-04-23', '8:00', '8:00', 'X', 'X', '3', 1, 1),
(42, 'hola', 'entrenamiento', 'holis', 'ACTIVO', '2017-04-14', '2017-04-28', '10:00', '10:00', 'X', 'X', '1', 2, 1),
(43, 'hola', 'entrenamiento', 'holis', 'ACTIVO', '2017-04-14', '2017-04-28', '10:00', '10:00', 'X', 'X', '2', 2, 1),
(44, 'hola', 'entrenamiento', 'holis', 'ACTIVO', '2017-04-14', '2017-04-28', '10:00', '10:00', 'X', 'X', '3', 2, 1),
(45, 'fasdasd', 'afsdfas', 'fsdas', 'ACTIVO', '2017-04-24', '2017-04-24', '8:00', '10:00', 'X', 'X', '1', 1, 1),
(46, 'fasdasd', 'afsdfas', 'fsdas', 'ACTIVO', '2017-04-24', '2017-04-24', '8:00', '10:00', 'X', 'X', '2', 1, 1),
(47, 'Nuevo ', 'Prueba', 'Prueba', 'ACTIVO', '2017-04-24', '2017-04-24', '8:00', '10:00', 'X', 'X', '2', 1, 1),
(48, 'Nuevo ', 'Prueba', 'Prueba', 'ACTIVO', '2017-04-24', '2017-04-24', '8:00', '10:00', 'X', 'X', '1', 1, 1),
(49, 'Nuevo ', 'Prueba', 'Prueba', 'ACTIVO', '2017-04-24', '2017-04-24', '8:00', '10:00', 'X', 'X', '4', 1, 1),
(50, 'sdfasd', 'fda', 'dfasd', 'ACTIVO', '2017-04-25', '2017-04-25', '8:00', '10:00', 'X', 'X', '1', 1, 1),
(51, 'sdfasd', 'fda', 'dfasd', 'ACTIVO', '2017-04-25', '2017-04-25', '8:00', '10:00', 'X', 'X', '2', 1, 1),
(52, 'sdfasd', 'fda', 'dfasd', 'ACTIVO', '2017-04-25', '2017-04-25', '8:00', '10:00', 'X', 'X', '3', 1, 1),
(53, 'gasfas', 'hoy', 'mañana', 'INACTIVO', '2017-04-26', '2017-04-26', '8:00', '15:00', 'X', 'X', '1-002', 4, 1),
(54, 'gasfas', 'hoy', 'mañana', 'INACTIVO', '2017-04-26', '2017-04-26', '8:00', '15:00', 'X', 'X', '1-001', 4, 1),
(55, 'gasfas', 'hoy', 'mañana', 'INACTIVO', '2017-04-26', '2017-04-26', '8:00', '15:00', 'X', 'X', '22', 4, 1),
(56, 'gasfas', 'hoy', 'mañana', 'INACTIVO', '2017-04-26', '2017-04-26', '8:00', '15:00', 'X', 'X', '15', 4, 1),
(57, 'gaddsfasdgasd', 'hoy', 'mañana', 'ACTIVO', '2017-04-26', '2017-04-26', '8:00', '11:00', 'X', 'X', '1-002', 1, 1),
(58, 'gaddsfasdgasd', 'hoy', 'mañana', 'ACTIVO', '2017-04-26', '2017-04-26', '8:00', '11:00', 'X', 'X', '1-001', 1, 1),
(59, 'gaddsfasdgasd', 'hoy', 'mañana', 'ACTIVO', '2017-04-26', '2017-04-26', '8:00', '11:00', 'X', 'X', '22', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `com_venta`
--

CREATE TABLE `com_venta` (
  `id_com_venta_pk` int(10) NOT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `total_venta` decimal(10,2) DEFAULT NULL,
  `porsentaje_comision` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `total_comision` decimal(10,2) DEFAULT NULL,
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `com_venta`
--

INSERT INTO `com_venta` (`id_com_venta_pk`, `id_empleado_pk`, `estado`, `total_venta`, `porsentaje_comision`, `fecha`, `total_comision`, `id_fac_empresa_pk`, `id_empresa_pk`) VALUES
(4, '1', 'ACTIVO', '3000.00', '6.00', '2017-04-18', '180.00', 1, 1),
(5, '2', 'ACTIVO', '7500.00', '3.00', '2017-04-18', '225.00', 2, 1),
(6, '3', 'ACTIVO', '3000.00', '4.00', '2017-04-18', '120.00', 3, 1),
(7, '4', 'ACTIVO', '17500.00', '10.00', '2017-04-18', '1750.00', 4, 2),
(8, '1', 'ACTIVO', '1400.00', '3.00', '2017-04-23', '42.00', 1, 1),
(9, '1', 'ACTIVO', '1400.00', '3.00', '2017-04-23', '42.00', 1, 1),
(10, '1', 'ACTIVO', '1400.00', '3.00', '2017-04-23', '42.00', 1, 1),
(11, '2', 'ACTIVO', '4000.00', '8.00', '2017-04-23', '320.00', 2, 1),
(12, '2', 'ACTIVO', '4000.00', '8.00', '2017-04-23', '320.00', 2, 1),
(13, '3', 'ACTIVO', '3000.00', '4.00', '2017-04-23', '120.00', 3, 1),
(14, '4', 'ACTIVO', '17500.00', '10.00', '2017-04-23', '1750.00', 4, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contrato`
--

CREATE TABLE `contrato` (
  `id_contrato_pk` int(11) NOT NULL,
  `fecha_inicio_servicio_empleado` char(15) DEFAULT NULL,
  `fecha_fin_servicio_empleado` char(15) DEFAULT NULL,
  `puesto_ocupa_empleado` char(15) DEFAULT NULL,
  `salario_base_empleado` char(10) DEFAULT NULL,
  `bonificacion_empleado` char(15) DEFAULT NULL,
  `periodo_pago` char(15) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `id_jornadatrabajo_pk` int(11) NOT NULL,
  `Id_datopersonal` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deducciones`
--

CREATE TABLE `deducciones` (
  `id_deduccion_pk` int(10) NOT NULL,
  `fecha` char(10) DEFAULT NULL,
  `nombre_deduccion` char(50) DEFAULT NULL,
  `cantidad_deduccion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) DEFAULT NULL,
  `id_detalle_igss_pk` int(11) DEFAULT NULL,
  `id_isr_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `deducciones`
--

INSERT INTO `deducciones` (`id_deduccion_pk`, `fecha`, `nombre_deduccion`, `cantidad_deduccion`, `estado`, `id_empleado_pk`, `id_detalle_igss_pk`, `id_isr_pk`) VALUES
(1, '2017-04-26', 'IGSS laboral', '149.73', 'ACTIVO', '3', 4, NULL),
(2, '2017-04-26', 'deduccion extra', '', 'ACTIVO', '3', NULL, NULL),
(3, '2017-04-26', 'IGSS laboral', '249.554991', 'ACTIVO', '2', 5, NULL),
(4, '2017-04-26', 'deduccion extra', '', 'ACTIVO', '2', NULL, NULL),
(5, '2017-04-26', 'IGSS laboral', '149.73', 'ACTIVO', '1', 6, NULL),
(6, '2017-04-26', 'deduccion extra', '', 'ACTIVO', '1', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `desempe`
--

CREATE TABLE `desempe` (
  `id_desempe` char(10) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_final` datetime DEFAULT NULL,
  `progreso` int(11) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_com_ventas`
--

CREATE TABLE `detalle_com_ventas` (
  `id_detalle_com_ventas` int(10) NOT NULL,
  `estado` char(25) DEFAULT 'ACTIVO',
  `total_venta` decimal(10,2) DEFAULT NULL,
  `comision` decimal(10,2) DEFAULT NULL,
  `id_com_venta_pk` varchar(10) NOT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_com_ventas`
--

INSERT INTO `detalle_com_ventas` (`id_detalle_com_ventas`, `estado`, `total_venta`, `comision`, `id_com_venta_pk`, `id_empleado_pk`, `fecha`) VALUES
(1, 'ACTIVO', '3000.00', '180.00', '1', '1', '2017-04-18'),
(2, 'ACTIVO', '7500.00', '225.00', '1', '2', '2017-04-18'),
(3, 'ACTIVO', '3000.00', '120.00', '1', '3', '2017-04-18'),
(4, 'ACTIVO', '17500.00', '1750.00', '2', '4', '2017-04-18'),
(5, 'ACTIVO', '4000.00', '320.00', '1', '2', '2017-04-23'),
(6, 'ACTIVO', '4000.00', '320.00', '1', '2', '2017-04-23'),
(7, 'ACTIVO', '3000.00', '120.00', '1', '3', '2017-04-23'),
(8, 'ACTIVO', '17500.00', '1750.00', '2', '4', '2017-04-23');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_igss`
--

CREATE TABLE `detalle_igss` (
  `id_detalle_igss_pk` int(11) NOT NULL,
  `id_empleado_pk` varchar(18) DEFAULT NULL,
  `id_planilla_igss_pk` int(11) DEFAULT NULL,
  `sueldo_base` char(12) DEFAULT NULL,
  `iggs_a_pagar_laboral` char(10) DEFAULT NULL,
  `iggs_a_pagar_patronal` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `fecha` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_igss`
--

INSERT INTO `detalle_igss` (`id_detalle_igss_pk`, `id_empleado_pk`, `id_planilla_igss_pk`, `sueldo_base`, `iggs_a_pagar_laboral`, `iggs_a_pagar_patronal`, `estado`, `fecha`) VALUES
(1, '3', NULL, '3100', '149.73', '330.77', 'ACTIVO', '2017-04-26'),
(2, '2', NULL, '5166.77', '249.554991', '551.294359', 'ACTIVO', '2017-04-26'),
(3, '1', NULL, '3100', '149.73', '330.77', 'ACTIVO', '2017-04-26'),
(4, '3', NULL, '3100', '149.73', '330.77', 'ACTIVO', '2017-04-26'),
(5, '2', NULL, '5166.77', '249.554991', '551.294359', 'ACTIVO', '2017-04-26'),
(6, '1', NULL, '3100', '149.73', '330.77', 'ACTIVO', '2017-04-26');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_nomina`
--

CREATE TABLE `detalle_nomina` (
  `id_detalle_nomina_pk` int(11) NOT NULL,
  `total_a_pagar` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_nomina_pk` int(11) DEFAULT NULL,
  `id_devengo_pk` int(11) DEFAULT NULL,
  `id_deduccion_pk` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_nomina`
--

INSERT INTO `detalle_nomina` (`id_detalle_nomina_pk`, `total_a_pagar`, `estado`, `id_nomina_pk`, `id_devengo_pk`, `id_deduccion_pk`) VALUES
(26, '250', 'ACTIVO', 6, 16, NULL),
(25, '', 'ACTIVO', 5, NULL, '4'),
(24, '', 'ACTIVO', 5, 15, NULL),
(23, '', 'ACTIVO', 5, 14, NULL),
(22, '249.554991', 'ACTIVO', 5, NULL, '3'),
(21, '250', 'ACTIVO', 5, 13, NULL),
(20, '', 'ACTIVO', 4, NULL, '2'),
(19, '', 'ACTIVO', 4, 12, NULL),
(18, '', 'ACTIVO', 4, 11, NULL),
(17, '149.73', 'ACTIVO', 4, NULL, '1'),
(16, '250', 'ACTIVO', 4, 10, NULL),
(27, '149.73', 'ACTIVO', 6, NULL, '5'),
(28, '', 'ACTIVO', 6, 17, NULL),
(29, '', 'ACTIVO', 6, 18, NULL),
(30, '', 'ACTIVO', 6, NULL, '6');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devengos`
--

CREATE TABLE `devengos` (
  `id_devengo_pk` int(11) NOT NULL,
  `fecha` char(14) DEFAULT NULL,
  `nombre_devengo` char(50) DEFAULT NULL,
  `cantidad_devengado` char(10) DEFAULT NULL,
  `cantidad_horas_extra` char(12) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_com_venta_pk` int(10) DEFAULT NULL,
  `id_empleado_pk` varchar(140) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `devengos`
--

INSERT INTO `devengos` (`id_devengo_pk`, `fecha`, `nombre_devengo`, `cantidad_devengado`, `cantidad_horas_extra`, `estado`, `id_com_venta_pk`, `id_empleado_pk`) VALUES
(18, '2017-04-26', 'devengo extra', '', NULL, 'ACTIVO', NULL, NULL),
(17, '2017-04-26', 'horas extra', '', '', 'ACTIVO', NULL, NULL),
(16, '2017-04-26', 'bonificacion', '250', NULL, 'ACTIVO', NULL, NULL),
(15, '2017-04-26', 'devengo extra', '', NULL, 'ACTIVO', NULL, NULL),
(14, '2017-04-26', 'horas extra', '', '', 'ACTIVO', NULL, NULL),
(13, '2017-04-26', 'bonificacion', '250', NULL, 'ACTIVO', NULL, NULL),
(12, '2017-04-26', 'devengo extra', '', NULL, 'ACTIVO', NULL, NULL),
(11, '2017-04-26', 'horas extra', '', '', 'ACTIVO', NULL, NULL),
(10, '2017-04-26', 'bonificacion', '250', NULL, 'ACTIVO', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `id_empleado_pk` varchar(18) NOT NULL,
  `dpi_emp` varchar(13) DEFAULT NULL,
  `no_afiliacionIGSS_emp` varchar(50) DEFAULT NULL,
  `estadolaboral` varchar(25) DEFAULT NULL,
  `fecha_de_alta_emp` varchar(50) DEFAULT NULL,
  `fecha_de_baja_emp` date DEFAULT NULL,
  `nombre_emp` varchar(55) DEFAULT NULL,
  `apellido_emp` varchar(55) DEFAULT NULL,
  `telefono_hogar_emp` varchar(12) DEFAULT NULL,
  `telefono_movil_emp` varchar(12) DEFAULT NULL,
  `fotografia_emp` varchar(300) DEFAULT NULL,
  `direccion_emp` varchar(150) DEFAULT NULL,
  `nacionalidad_emp` varchar(50) DEFAULT NULL,
  `periodo_pago` char(25) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `id_jornadatrabajo_pk` int(11) NOT NULL,
  `id_puesto_laboral_pk` int(11) DEFAULT NULL,
  `id_area_trabajo_pk` int(11) DEFAULT NULL,
  `porcentaje` decimal(10,0) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id_empleado_pk`, `dpi_emp`, `no_afiliacionIGSS_emp`, `estadolaboral`, `fecha_de_alta_emp`, `fecha_de_baja_emp`, `nombre_emp`, `apellido_emp`, `telefono_hogar_emp`, `telefono_movil_emp`, `fotografia_emp`, `direccion_emp`, `nacionalidad_emp`, `periodo_pago`, `estado`, `id_empresa_pk`, `id_jornadatrabajo_pk`, `id_puesto_laboral_pk`, `id_area_trabajo_pk`, `porcentaje`) VALUES
('3', '3483450101', '0003945', 'Alta', '2017-02-15', '2017-04-26', 'Cristian', 'Estrada', NULL, NULL, '10441140_10202168077834619_5772315235045178214_n.jpg', 'Prueba', 'Guatemala', 'Mensual', 'ACTIVO', 1, 3, 1, 1, '0'),
('', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, '0'),
('2', '384734730101', '939493000', 'Alta', '2017-02-01', '2017-04-26', 'Javier', 'Figueroa', NULL, NULL, 'enhanced-3189-1437757123-1.jpg', 'Prueba', 'Guatemala', 'Mensual', 'ACTIVO', 1, 0, 2, 2, '0'),
('1', '38373480101', '0003945', 'Alta', '2016-10-11', '2017-04-26', 'Otto ', 'Hernandez ', NULL, NULL, '14610915_10211669450990920_656789259473347350_n.jpg', 'Nueva22 Zona 1', 'Guatemala', 'Mensual', 'ACTIVO', 1, 3, 1, 2, '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL,
  `nombre_empresa` varchar(100) DEFAULT NULL,
  `direccion_empresa` varchar(150) DEFAULT NULL,
  `NIT_empresa` varchar(15) DEFAULT NULL,
  `telefono_empresa` varchar(15) DEFAULT NULL,
  `correo_empresa` varchar(50) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id_empresa_pk`, `id_area_trabajo_pk`, `nombre_empresa`, `direccion_empresa`, `NIT_empresa`, `telefono_empresa`, `correo_empresa`, `estado`) VALUES
(1, 1, 'EMPRESA 1', 'FASDFSDA', '123123', '21321312', 'FASDFASD', 'ACTIVO'),
(2, 1, 'EMPRESA 2', 'FASDFAS', '21321', '12312412', 'FASFADSF', 'ACTIVO'),
(3, 0, '0', 'Nueva23', 'Nueva22', '938439-1', '443394845', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_correo_electronico`
--

CREATE TABLE `emp_correo_electronico` (
  `id_correo_electronico_emp` int(11) NOT NULL,
  `correo_electronico1_emp` varchar(50) DEFAULT NULL,
  `correo_electronico2_emp` varchar(50) DEFAULT NULL,
  `correo_electronico3_emp` varchar(50) DEFAULT NULL,
  `descripcion_correo` varchar(100) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_datopersonal`
--

CREATE TABLE `emp_datopersonal` (
  `Id_datopersonal` int(11) NOT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `nombre_del_padre` varchar(65) DEFAULT NULL,
  `nombre_de_madre` varchar(65) DEFAULT NULL,
  `genero_empleado` varchar(25) DEFAULT NULL,
  `estado_civil` varchar(25) DEFAULT NULL,
  `documentacion_del_trabajador` text,
  `observaciones_emp` varchar(200) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_formapago`
--

CREATE TABLE `emp_formapago` (
  `formapago_pk` int(11) NOT NULL,
  `forma_pago` varchar(35) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `nombre_banco` varchar(55) DEFAULT NULL,
  `nombre_entidad_bancaria` varchar(55) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_jornadatrabajo`
--

CREATE TABLE `emp_jornadatrabajo` (
  `id_jornadatrabajo_pk` int(11) NOT NULL,
  `forma_cobro` varchar(35) DEFAULT NULL,
  `nombre_jornada` varchar(25) DEFAULT NULL,
  `horas_trabajo` decimal(10,0) DEFAULT NULL,
  `jdiaria_dias` varchar(100) DEFAULT NULL,
  `jhora_diario` varchar(100) DEFAULT NULL,
  `disponibilidad` binary(5) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `emp_jornadatrabajo`
--

INSERT INTO `emp_jornadatrabajo` (`id_jornadatrabajo_pk`, `forma_cobro`, `nombre_jornada`, `horas_trabajo`, `jdiaria_dias`, `jhora_diario`, `disponibilidad`, `estado`) VALUES
(1, 'MENSUAL', 'matutina', '8', '0', '0', NULL, 'INACTIVO'),
(2, 'QUINCENAL', 'vespertina', '3', '0', '0', NULL, 'INACTIVO'),
(3, 'MENSUAL', 'vespertina', '8', '0', '0', NULL, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_municipio`
--

CREATE TABLE `emp_municipio` (
  `id_municipio_pk` int(11) NOT NULL,
  `nombre_municipio` varchar(50) DEFAULT NULL,
  `descripcion_muni` varchar(150) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_salario_minimo`
--

CREATE TABLE `emp_salario_minimo` (
  `id_salario_emp_pk` int(11) NOT NULL,
  `nombre_monto` varchar(50) DEFAULT NULL,
  `monto_salario` decimal(10,2) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_telefono`
--

CREATE TABLE `emp_telefono` (
  `id_telefono_emp_pk` int(11) NOT NULL,
  `numero_telefono1_emp` varchar(15) DEFAULT NULL,
  `numero_telefono2_emp` varchar(15) DEFAULT NULL,
  `numero_telefono3_emp` varchar(15) DEFAULT NULL,
  `descripcion_tel` varchar(100) DEFAULT NULL,
  `estado` varchar(15) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `emp_zona`
--

CREATE TABLE `emp_zona` (
  `id_zona_emp_pk` int(11) NOT NULL,
  `nombre_zona_emp` varchar(50) DEFAULT NULL,
  `descripcion_zona_emp` varbinary(200) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evaluacion`
--

CREATE TABLE `evaluacion` (
  `id_evaluacion_pk` int(10) NOT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `puntuacion` varchar(25) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_candidato_pk` int(10) NOT NULL,
  `id_examen_evaluacion_fk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `examen_evaluacion`
--

CREATE TABLE `examen_evaluacion` (
  `id_examen_evaluacion_pk` int(11) NOT NULL,
  `nombre_examen_evaluacion` varchar(150) NOT NULL,
  `nota_maxima_examen_evaluacion` int(11) NOT NULL,
  `estado` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `marca_comision` char(10) DEFAULT 'X',
  `fecha_vencimiento` date DEFAULT NULL,
  `estado_factura` varchar(15) DEFAULT NULL,
  `fecha_emision` date NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`id_fac_empresa_pk`, `id_empresa_pk`, `id_empleado_pk`, `marca_comision`, `fecha_vencimiento`, `estado_factura`, `fecha_emision`, `subtotal`, `total`, `estado`) VALUES
(1, 1, '1', 'S', '2017-04-19', 'ACTIVO', '2017-04-19', '3000.00', '3000.00', 'ACTIVO'),
(2, 1, '2', 'S', '2017-04-11', 'ACTIVO', '2017-04-10', '4000.00', '4000.00', 'ACTIVO'),
(3, 1, '3', 'S', '2017-04-20', 'ACTIVO', '2017-04-05', '3700.00', '3800.00', 'ACTIVO'),
(4, 2, '4', 'S', '2017-04-19', 'ACTIVO', '2017-04-13', '5000.00', '5100.00', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_detalle`
--

CREATE TABLE `factura_detalle` (
  `id_fac_empresa_pk` int(11) NOT NULL,
  `id_precio` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `nombre_desc` varchar(200) DEFAULT NULL,
  `precio` decimal(18,2) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura_detalle`
--

INSERT INTO `factura_detalle` (`id_fac_empresa_pk`, `id_precio`, `cantidad`, `nombre_desc`, `precio`, `estado`, `id_empresa_pk`) VALUES
(1, 1, 2, 'COSAS', '2500.00', 'ACTIVO', 1),
(2, 2, 5, 'COSAS 2', '600.00', 'ACTIVO', 1),
(3, 3, 6, 'COSAS 3', '1000.00', 'ACTIVO', 1),
(4, 4, 7, 'COSAS 4', '2000.00', 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcion`
--

CREATE TABLE `funcion` (
  `id_funcion` int(11) NOT NULL,
  `sueldo_funcion` varchar(150) DEFAULT NULL,
  `descripcion_funcion` varchar(250) DEFAULT NULL,
  `nombre_funcion` varchar(150) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_perfil_reclutamiento_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `funcion`
--

INSERT INTO `funcion` (`id_funcion`, `sueldo_funcion`, `descripcion_funcion`, `nombre_funcion`, `estado`, `id_perfil_reclutamiento_pk`) VALUES
(1, '654.12', 'asdas', 'dfsaas', 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `indenmizacion`
--

CREATE TABLE `indenmizacion` (
  `id_indemnizacion` int(11) NOT NULL,
  `id_empleado_fk` varchar(18) DEFAULT NULL,
  `fecha_retiro` datetime DEFAULT NULL,
  `salario_mensual` int(11) NOT NULL,
  `indemnizar` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `isr`
--

CREATE TABLE `isr` (
  `id_isr_pk` int(11) NOT NULL,
  `salario_anual` char(10) DEFAULT NULL,
  `aguinaldo` char(10) DEFAULT NULL,
  `bono_14` char(10) DEFAULT NULL,
  `total_devengo` char(10) DEFAULT NULL,
  `deduccion_legal` char(10) DEFAULT NULL,
  `igss_anual` char(10) DEFAULT NULL,
  `deduccion_total` char(10) DEFAULT NULL,
  `renta_imponible` char(10) DEFAULT NULL,
  `iva` char(10) DEFAULT NULL,
  `impuesto_sobre_renta_anual` char(10) DEFAULT NULL,
  `impuesto_mensual` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_tasa_pk` int(11) DEFAULT NULL,
  `id_empleado_pk` varchar(18) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `linea`
--

CREATE TABLE `linea` (
  `id_linea_pk` int(11) NOT NULL,
  `nombre_categoria` char(40) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `linea`
--

INSERT INTO `linea` (`id_linea_pk`, `nombre_categoria`, `porcentaje_comision`, `estado`) VALUES
(1, 'ELECTRODOMESTICOS', '4', 'ACTIVO'),
(2, 'VIDEOJUEGOS', '9', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id_marca_pk` int(11) NOT NULL,
  `nombre_marca` char(50) DEFAULT NULL,
  `procentaje_comision` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca_pk`, `nombre_marca`, `procentaje_comision`, `estado`) VALUES
(1, 'NIKE', '3', 'ACTIVO'),
(2, 'ADIDAS', '6', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medio_distribucion`
--

CREATE TABLE `medio_distribucion` (
  `id_medio_distribucion` int(11) NOT NULL,
  `nombre_medio` varchar(150) DEFAULT NULL,
  `correo_medio` varchar(150) DEFAULT NULL,
  `telefono_medio` varchar(20) DEFAULT NULL,
  `url_medio` varchar(250) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `medio_distribucion`
--

INSERT INTO `medio_distribucion` (`id_medio_distribucion`, `nombre_medio`, `correo_medio`, `telefono_medio`, `url_medio`, `estado`) VALUES
(1, 'prensa', 'asdasdas@gmail.com', '2516516', 'oiasdoias.com', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE `modulo` (
  `id_modulo` char(10) NOT NULL,
  `nombre` char(80) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`id_modulo`, `nombre`) VALUES
('13100', 'catalogo'),
('13200', 'procesos'),
('13300', 'reportes'),
('13400', 'estadistica'),
('13500', 'seguridad'),
('13600', 'reporteador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nomina`
--

CREATE TABLE `nomina` (
  `id_nomina_pk` int(11) NOT NULL,
  `descripcion` char(50) DEFAULT NULL,
  `fecha_inicio_pago` char(10) DEFAULT NULL,
  `fecha_fin_pago` char(10) DEFAULT NULL,
  `dias_trabajados_mes` char(10) DEFAULT NULL,
  `sueldo_base` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `id_area_trabajo_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `nomina`
--

INSERT INTO `nomina` (`id_nomina_pk`, `descripcion`, `fecha_inicio_pago`, `fecha_fin_pago`, `dias_trabajados_mes`, `sueldo_base`, `estado`, `id_empleado_pk`, `id_empresa_pk`, `id_area_trabajo_pk`) VALUES
(6, 'generación de nóminas', '2017-03-01', '2017-04-01', '31', '3100', 'procesada', '1', 1, 2),
(5, 'generación de nóminas', '2017-03-01', '2017-04-01', '31', '5166.77', 'procesada', '2', 1, 2),
(4, 'generación de nóminas', '2017-03-01', '2017-04-01', '31', '3100', 'procesada', '3', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pago_empleado`
--

CREATE TABLE `pago_empleado` (
  `pago_emp_pk` int(11) NOT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `formapago_pk` int(11) NOT NULL,
  `cuenta_bancaria` char(10) DEFAULT NULL,
  `tipo_cuenta` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL,
  `nombre_perfil` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_privilegios`
--

CREATE TABLE `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_reclutamiento`
--

CREATE TABLE `perfil_reclutamiento` (
  `id_perfil_reclutamiento_pk` int(11) NOT NULL,
  `titulo_puesto` varchar(50) DEFAULT NULL,
  `descripcion_puesto` varchar(150) DEFAULT NULL,
  `detalle` varchar(150) DEFAULT NULL,
  `departamento` varchar(50) DEFAULT NULL,
  `localizacion` varchar(25) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil_reclutamiento`
--

INSERT INTO `perfil_reclutamiento` (`id_perfil_reclutamiento_pk`, `titulo_puesto`, `descripcion_puesto`, `detalle`, `departamento`, `localizacion`, `estado`, `id_empresa_pk`, `id_area_trabajo_pk`) VALUES
(1, 'hola', 'hola', 'hola', 'hola', 'hola', 'ACTIVO', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planilla_igss`
--

CREATE TABLE `planilla_igss` (
  `id_planilla_igss_pk` int(11) NOT NULL,
  `porcentaje_igss_laboral` varchar(10) DEFAULT NULL,
  `porcentaje_igss_patronal` varchar(10) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `id_area_trabajo_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `planilla_igss`
--

INSERT INTO `planilla_igss` (`id_planilla_igss_pk`, `porcentaje_igss_laboral`, `porcentaje_igss_patronal`, `fecha`, `estado`, `id_empresa_pk`, `id_area_trabajo_pk`) VALUES
(1, '4.83', '10.67', '2017-04-01', 'ACTIVO', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio`
--

CREATE TABLE `precio` (
  `id_precio` int(11) NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `precio`
--

INSERT INTO `precio` (`id_precio`, `precio`, `id_bien_pk`, `estado`) VALUES
(1, '700.00', 1, 'ACTIVO'),
(2, '1500.00', 2, 'ACTIVO'),
(3, '500.00', 3, 'ACTIVO'),
(4, '2500.00', 4, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto_laboral`
--

CREATE TABLE `puesto_laboral` (
  `id_puesto_laboral_pk` int(11) NOT NULL,
  `nombre_puesto` char(40) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `salario_base` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `puesto_laboral`
--

INSERT INTO `puesto_laboral` (`id_puesto_laboral_pk`, `nombre_puesto`, `descripcion`, `salario_base`, `estado`) VALUES
(1, 'VENDEDOR', 'VENDE', '3000', 'ACTIVO'),
(2, 'PROGRAMADOR', 'PROGRAMADOR', '5000', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reclutamiento`
--

CREATE TABLE `reclutamiento` (
  `id_reclutamiento_pk` int(11) NOT NULL,
  `nombre_reclutamiento` varchar(150) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_perfil_reclutamiento_pk` int(11) NOT NULL,
  `id_medio_distribucion` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reclutamiento`
--

INSERT INTO `reclutamiento` (`id_reclutamiento_pk`, `nombre_reclutamiento`, `estado`, `id_perfil_reclutamiento_pk`, `id_medio_distribucion`) VALUES
(1, 'sasa', 'ACTIVO', 1, 1),
(2, 'sadasd', 'ACTIVO', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporteador`
--

CREATE TABLE `reporteador` (
  `id_reporteador` int(11) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `ubicacion` varchar(250) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tasa_hora_extra`
--

CREATE TABLE `tasa_hora_extra` (
  `id_hora_pk` int(11) NOT NULL,
  `descripcion` char(20) DEFAULT NULL,
  `porcentaje` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tasa_impuesto`
--

CREATE TABLE `tasa_impuesto` (
  `id_tasa_pk` int(11) NOT NULL,
  `porcentaje` char(10) DEFAULT NULL,
  `maximo_sueldo` char(10) DEFAULT NULL,
  `minimo_sueldo` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ubicacion`
--

CREATE TABLE `ubicacion` (
  `id_ubicacion_pk` int(11) NOT NULL,
  `ciudad` varchar(50) DEFAULT NULL,
  `pais` varchar(50) DEFAULT NULL,
  `ubicacion` char(50) DEFAULT NULL,
  `estado` char(10) DEFAULT 'ACTIVO',
  `nombre_ubi` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ubicacion`
--

INSERT INTO `ubicacion` (`id_ubicacion_pk`, `ciudad`, `pais`, `ubicacion`, `estado`, `nombre_ubi`) VALUES
(1, 'GT', 'Guate', 'zona 10', 'ACTIVO', 'Parque central'),
(2, 'GT', 'GT', 'zona 10', 'ACTIVO', 'Oakland mall'),
(3, 'Gt', 'Gt', 'zona 8', 'ACTIVO', 'Miraflores'),
(4, 'guatemala', 'guatemala', 'zona 2', NULL, 'umg'),
(5, 'GT', 'GT', 'Nuevo', 'INACTIVO', 'Nuevo');

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
('javifigue', 13207, 1, 1, 1, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vacaciones`
--

CREATE TABLE `vacaciones` (
  `id_vacaciones` int(11) NOT NULL,
  `fecha_de_inicio` datetime NOT NULL,
  `fecha_salida` datetime DEFAULT NULL,
  `salario_mensual` int(11) NOT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `dev_vacaciones` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `activos_empresa`
--
ALTER TABLE `activos_empresa`
  ADD PRIMARY KEY (`id_activos_emp_pk`);

--
-- Indices de la tabla `aignacion_activo_empleado`
--
ALTER TABLE `aignacion_activo_empleado`
  ADD PRIMARY KEY (`id_asignacion_act_emp_pk`),
  ADD KEY `Refempleado97` (`id_empleado_pk`),
  ADD KEY `Refactivos_empresa98` (`id_activos_emp_pk`),
  ADD KEY `Refempresa116` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`id_aplicacion`),
  ADD KEY `Refmodulo104` (`id_modulo`);

--
-- Indices de la tabla `area_trabajo`
--
ALTER TABLE `area_trabajo`
  ADD PRIMARY KEY (`id_area_trabajo_pk`);

--
-- Indices de la tabla `asistencia_cap`
--
ALTER TABLE `asistencia_cap`
  ADD PRIMARY KEY (`id_asis_cap_pk`),
  ADD KEY `Refcapacitacion50` (`id_capacitacion_pk`);

--
-- Indices de la tabla `bien`
--
ALTER TABLE `bien`
  ADD PRIMARY KEY (`id_bien_pk`),
  ADD KEY `Refmarca120` (`id_marca_pk`),
  ADD KEY `Reflinea121` (`id_linea_pk`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`id_bit`);

--
-- Indices de la tabla `bonificacion`
--
ALTER TABLE `bonificacion`
  ADD PRIMARY KEY (`id_bono_pk`);

--
-- Indices de la tabla `candidato`
--
ALTER TABLE `candidato`
  ADD PRIMARY KEY (`id_candidato_pk`),
  ADD KEY `Refreclutamiento83` (`id_reclutamiento_pk`);

--
-- Indices de la tabla `capacitacion`
--
ALTER TABLE `capacitacion`
  ADD PRIMARY KEY (`id_capacitacion_pk`),
  ADD KEY `Refempleado41` (`id_empleado_pk`),
  ADD KEY `Refubicacion75` (`id_ubicacion_pk`);

--
-- Indices de la tabla `com_venta`
--
ALTER TABLE `com_venta`
  ADD PRIMARY KEY (`id_com_venta_pk`,`id_empleado_pk`),
  ADD KEY `Reffactura125` (`id_fac_empresa_pk`,`id_empresa_pk`),
  ADD KEY `Refempleado128` (`id_empleado_pk`);

--
-- Indices de la tabla `contrato`
--
ALTER TABLE `contrato`
  ADD PRIMARY KEY (`id_contrato_pk`),
  ADD KEY `Refempleado52` (`id_empleado_pk`),
  ADD KEY `Refemp_jornadatrabajo53` (`id_jornadatrabajo_pk`),
  ADD KEY `Refemp_DatoPersonal54` (`Id_datopersonal`),
  ADD KEY `Refempresa55` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `deducciones`
--
ALTER TABLE `deducciones`
  ADD PRIMARY KEY (`id_deduccion_pk`),
  ADD KEY `Refempleado23` (`id_empleado_pk`),
  ADD KEY `Refdetalle_igss28` (`id_detalle_igss_pk`),
  ADD KEY `Refisr57` (`id_isr_pk`);

--
-- Indices de la tabla `desempe`
--
ALTER TABLE `desempe`
  ADD PRIMARY KEY (`id_desempe`),
  ADD KEY `Refempleado113` (`id_empleado_pk`);

--
-- Indices de la tabla `detalle_com_ventas`
--
ALTER TABLE `detalle_com_ventas`
  ADD PRIMARY KEY (`id_detalle_com_ventas`),
  ADD KEY `Refcom_venta51` (`id_com_venta_pk`,`id_empleado_pk`);

--
-- Indices de la tabla `detalle_igss`
--
ALTER TABLE `detalle_igss`
  ADD PRIMARY KEY (`id_detalle_igss_pk`),
  ADD KEY `Refplanilla_igss24` (`id_planilla_igss_pk`),
  ADD KEY `Refempleado26` (`id_empleado_pk`);

--
-- Indices de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  ADD PRIMARY KEY (`id_detalle_nomina_pk`),
  ADD KEY `Refnomina29` (`id_nomina_pk`),
  ADD KEY `Refdevengos30` (`id_devengo_pk`),
  ADD KEY `Refdeducciones32` (`id_deduccion_pk`);

--
-- Indices de la tabla `devengos`
--
ALTER TABLE `devengos`
  ADD PRIMARY KEY (`id_devengo_pk`),
  ADD KEY `id_empleado_pk` (`id_empleado_pk`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`id_empleado_pk`),
  ADD KEY `Refpuesto_laboral92` (`id_puesto_laboral_pk`),
  ADD KEY `Refemp_jornadatrabajo14` (`id_jornadatrabajo_pk`),
  ADD KEY `Refempresa34` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`id_empresa_pk`,`id_area_trabajo_pk`),
  ADD KEY `Refarea_trabajo96` (`id_area_trabajo_pk`);

--
-- Indices de la tabla `emp_correo_electronico`
--
ALTER TABLE `emp_correo_electronico`
  ADD PRIMARY KEY (`id_correo_electronico_emp`),
  ADD KEY `Refempleado80` (`id_empleado_pk`);

--
-- Indices de la tabla `emp_datopersonal`
--
ALTER TABLE `emp_datopersonal`
  ADD PRIMARY KEY (`Id_datopersonal`),
  ADD KEY `Refempleado117` (`id_empleado_pk`);

--
-- Indices de la tabla `emp_formapago`
--
ALTER TABLE `emp_formapago`
  ADD PRIMARY KEY (`formapago_pk`);

--
-- Indices de la tabla `emp_jornadatrabajo`
--
ALTER TABLE `emp_jornadatrabajo`
  ADD PRIMARY KEY (`id_jornadatrabajo_pk`);

--
-- Indices de la tabla `emp_municipio`
--
ALTER TABLE `emp_municipio`
  ADD PRIMARY KEY (`id_municipio_pk`),
  ADD KEY `Refempleado94` (`id_empleado_pk`);

--
-- Indices de la tabla `emp_salario_minimo`
--
ALTER TABLE `emp_salario_minimo`
  ADD PRIMARY KEY (`id_salario_emp_pk`);

--
-- Indices de la tabla `emp_telefono`
--
ALTER TABLE `emp_telefono`
  ADD PRIMARY KEY (`id_telefono_emp_pk`),
  ADD KEY `Refempleado79` (`id_empleado_pk`);

--
-- Indices de la tabla `emp_zona`
--
ALTER TABLE `emp_zona`
  ADD PRIMARY KEY (`id_zona_emp_pk`),
  ADD KEY `Refempleado95` (`id_empleado_pk`);

--
-- Indices de la tabla `evaluacion`
--
ALTER TABLE `evaluacion`
  ADD PRIMARY KEY (`id_evaluacion_pk`),
  ADD KEY `Refcandidato82` (`id_candidato_pk`),
  ADD KEY `Refcapacitacion89` (`id_examen_evaluacion_fk`);

--
-- Indices de la tabla `examen_evaluacion`
--
ALTER TABLE `examen_evaluacion`
  ADD PRIMARY KEY (`id_examen_evaluacion_pk`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_empresa_pk`),
  ADD KEY `Refempleado124` (`id_empleado_pk`);

--
-- Indices de la tabla `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD PRIMARY KEY (`id_fac_empresa_pk`,`id_precio`),
  ADD KEY `Reffactura118` (`id_fac_empresa_pk`,`id_empresa_pk`),
  ADD KEY `Refprecio119` (`id_precio`);

--
-- Indices de la tabla `funcion`
--
ALTER TABLE `funcion`
  ADD PRIMARY KEY (`id_funcion`),
  ADD KEY `Refperfil_reclutamiento87` (`id_perfil_reclutamiento_pk`);

--
-- Indices de la tabla `indenmizacion`
--
ALTER TABLE `indenmizacion`
  ADD PRIMARY KEY (`id_indemnizacion`),
  ADD KEY `Refempleado111` (`id_empleado_fk`);

--
-- Indices de la tabla `isr`
--
ALTER TABLE `isr`
  ADD PRIMARY KEY (`id_isr_pk`),
  ADD KEY `Reftasa_impuesto56` (`id_tasa_pk`),
  ADD KEY `Refempleado60` (`id_empleado_pk`);

--
-- Indices de la tabla `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`id_linea_pk`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca_pk`);

--
-- Indices de la tabla `medio_distribucion`
--
ALTER TABLE `medio_distribucion`
  ADD PRIMARY KEY (`id_medio_distribucion`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`id_modulo`);

--
-- Indices de la tabla `nomina`
--
ALTER TABLE `nomina`
  ADD PRIMARY KEY (`id_nomina_pk`),
  ADD KEY `Refempleado33` (`id_empleado_pk`),
  ADD KEY `Refempresa35` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `pago_empleado`
--
ALTER TABLE `pago_empleado`
  ADD PRIMARY KEY (`pago_emp_pk`),
  ADD KEY `Refempleado18` (`id_empleado_pk`),
  ADD KEY `Refemp_FormaPago19` (`formapago_pk`);

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
  ADD KEY `Refperfil101` (`id_perfil`);

--
-- Indices de la tabla `perfil_reclutamiento`
--
ALTER TABLE `perfil_reclutamiento`
  ADD PRIMARY KEY (`id_perfil_reclutamiento_pk`),
  ADD KEY `Refempresa86` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `planilla_igss`
--
ALTER TABLE `planilla_igss`
  ADD PRIMARY KEY (`id_planilla_igss_pk`),
  ADD KEY `Refempresa36` (`id_empresa_pk`,`id_area_trabajo_pk`);

--
-- Indices de la tabla `precio`
--
ALTER TABLE `precio`
  ADD PRIMARY KEY (`id_precio`),
  ADD KEY `Refbien122` (`id_bien_pk`);

--
-- Indices de la tabla `puesto_laboral`
--
ALTER TABLE `puesto_laboral`
  ADD PRIMARY KEY (`id_puesto_laboral_pk`);

--
-- Indices de la tabla `reclutamiento`
--
ALTER TABLE `reclutamiento`
  ADD PRIMARY KEY (`id_reclutamiento_pk`),
  ADD KEY `Refmedio_distribucion84` (`id_medio_distribucion`),
  ADD KEY `Refperfil_reclutamiento85` (`id_perfil_reclutamiento_pk`);

--
-- Indices de la tabla `reporteador`
--
ALTER TABLE `reporteador`
  ADD PRIMARY KEY (`id_reporteador`);

--
-- Indices de la tabla `tasa_hora_extra`
--
ALTER TABLE `tasa_hora_extra`
  ADD PRIMARY KEY (`id_hora_pk`);

--
-- Indices de la tabla `tasa_impuesto`
--
ALTER TABLE `tasa_impuesto`
  ADD PRIMARY KEY (`id_tasa_pk`);

--
-- Indices de la tabla `ubicacion`
--
ALTER TABLE `ubicacion`
  ADD PRIMARY KEY (`id_ubicacion_pk`);

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
-- Indices de la tabla `vacaciones`
--
ALTER TABLE `vacaciones`
  ADD PRIMARY KEY (`id_vacaciones`),
  ADD KEY `Refempleado114` (`id_empleado_pk`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `activos_empresa`
--
ALTER TABLE `activos_empresa`
  MODIFY `id_activos_emp_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `aignacion_activo_empleado`
--
ALTER TABLE `aignacion_activo_empleado`
  MODIFY `id_asignacion_act_emp_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13601;
--
-- AUTO_INCREMENT de la tabla `area_trabajo`
--
ALTER TABLE `area_trabajo`
  MODIFY `id_area_trabajo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `asistencia_cap`
--
ALTER TABLE `asistencia_cap`
  MODIFY `id_asis_cap_pk` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;
--
-- AUTO_INCREMENT de la tabla `bonificacion`
--
ALTER TABLE `bonificacion`
  MODIFY `id_bono_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `candidato`
--
ALTER TABLE `candidato`
  MODIFY `id_candidato_pk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `capacitacion`
--
ALTER TABLE `capacitacion`
  MODIFY `id_capacitacion_pk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
--
-- AUTO_INCREMENT de la tabla `com_venta`
--
ALTER TABLE `com_venta`
  MODIFY `id_com_venta_pk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT de la tabla `contrato`
--
ALTER TABLE `contrato`
  MODIFY `id_contrato_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `deducciones`
--
ALTER TABLE `deducciones`
  MODIFY `id_deduccion_pk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `detalle_com_ventas`
--
ALTER TABLE `detalle_com_ventas`
  MODIFY `id_detalle_com_ventas` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `detalle_igss`
--
ALTER TABLE `detalle_igss`
  MODIFY `id_detalle_igss_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  MODIFY `id_detalle_nomina_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT de la tabla `devengos`
--
ALTER TABLE `devengos`
  MODIFY `id_devengo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `emp_correo_electronico`
--
ALTER TABLE `emp_correo_electronico`
  MODIFY `id_correo_electronico_emp` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `emp_datopersonal`
--
ALTER TABLE `emp_datopersonal`
  MODIFY `Id_datopersonal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `emp_formapago`
--
ALTER TABLE `emp_formapago`
  MODIFY `formapago_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `emp_jornadatrabajo`
--
ALTER TABLE `emp_jornadatrabajo`
  MODIFY `id_jornadatrabajo_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `emp_municipio`
--
ALTER TABLE `emp_municipio`
  MODIFY `id_municipio_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `emp_telefono`
--
ALTER TABLE `emp_telefono`
  MODIFY `id_telefono_emp_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `emp_zona`
--
ALTER TABLE `emp_zona`
  MODIFY `id_zona_emp_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `evaluacion`
--
ALTER TABLE `evaluacion`
  MODIFY `id_evaluacion_pk` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `examen_evaluacion`
--
ALTER TABLE `examen_evaluacion`
  MODIFY `id_examen_evaluacion_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `funcion`
--
ALTER TABLE `funcion`
  MODIFY `id_funcion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `indenmizacion`
--
ALTER TABLE `indenmizacion`
  MODIFY `id_indemnizacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `isr`
--
ALTER TABLE `isr`
  MODIFY `id_isr_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `linea`
--
ALTER TABLE `linea`
  MODIFY `id_linea_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `medio_distribucion`
--
ALTER TABLE `medio_distribucion`
  MODIFY `id_medio_distribucion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `nomina`
--
ALTER TABLE `nomina`
  MODIFY `id_nomina_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `pago_empleado`
--
ALTER TABLE `pago_empleado`
  MODIFY `pago_emp_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil_reclutamiento`
--
ALTER TABLE `perfil_reclutamiento`
  MODIFY `id_perfil_reclutamiento_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `planilla_igss`
--
ALTER TABLE `planilla_igss`
  MODIFY `id_planilla_igss_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `precio`
--
ALTER TABLE `precio`
  MODIFY `id_precio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `puesto_laboral`
--
ALTER TABLE `puesto_laboral`
  MODIFY `id_puesto_laboral_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `reclutamiento`
--
ALTER TABLE `reclutamiento`
  MODIFY `id_reclutamiento_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `reporteador`
--
ALTER TABLE `reporteador`
  MODIFY `id_reporteador` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tasa_hora_extra`
--
ALTER TABLE `tasa_hora_extra`
  MODIFY `id_hora_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tasa_impuesto`
--
ALTER TABLE `tasa_impuesto`
  MODIFY `id_tasa_pk` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `ubicacion`
--
ALTER TABLE `ubicacion`
  MODIFY `id_ubicacion_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `vacaciones`
--
ALTER TABLE `vacaciones`
  MODIFY `id_vacaciones` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
