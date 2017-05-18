CREATE DATABASE  IF NOT EXISTS `sancarlos2` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sancarlos2`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: sancarlos2
-- ------------------------------------------------------
-- Server version	5.7.13-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_aplicacion` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=10115 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (10101,'Mantenimiento categorias'),(10102,'Mantenimiento de bodegas'),(10103,'Generar devolucion sobre compra'),(10104,'Reporte de existencias'),(10105,'Facturas pendientes'),(10106,'Listado de bienes'),(10107,'kardex'),(10108,'Mantenimiento de linea'),(10109,'Mantenimiento de medidas'),(10110,'Reporte de movimientos'),(10111,'Ingreso de nuevo producto'),(10112,'Recibir stock'),(10113,'Generar requisicion'),(10114,'Mantenimiento de marcas');
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `autos`
--

DROP TABLE IF EXISTS `autos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `autos` (
  `placa` char(50) NOT NULL,
  `marca` char(80) DEFAULT NULL,
  `modelo` int(11) DEFAULT NULL,
  PRIMARY KEY (`placa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autos`
--

LOCK TABLES `autos` WRITE;
/*!40000 ALTER TABLE `autos` DISABLE KEYS */;
INSERT INTO `autos` VALUES ('189vwh','mazda',2013),('452sdf','toyota',2006),('545bdr','ford',2008),('643fem','nissan',2011);
/*!40000 ALTER TABLE `autos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `autos_recientes`
--

DROP TABLE IF EXISTS `autos_recientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `autos_recientes` (
  `placa` char(50) NOT NULL,
  `marca` char(80) DEFAULT NULL,
  `modelo` int(11) DEFAULT NULL,
  PRIMARY KEY (`placa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autos_recientes`
--

LOCK TABLES `autos_recientes` WRITE;
/*!40000 ALTER TABLE `autos_recientes` DISABLE KEYS */;
INSERT INTO `autos_recientes` VALUES ('189vwh','mazda',2013),('643fem','nissan',2011);
/*!40000 ALTER TABLE `autos_recientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bien`
--

DROP TABLE IF EXISTS `bien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bien` (
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `precio` decimal(18,0) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `descripcion` char(80) DEFAULT NULL,
  `id_linea_pk` int(11) DEFAULT NULL,
  `apartados` int(11) DEFAULT NULL,
  `tiempo_vida` char(30) DEFAULT NULL,
  `fecha_entrada` date DEFAULT NULL,
  `metodologia` char(40) DEFAULT NULL,
  `id_medida_pk` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_marca_pk` int(11) DEFAULT NULL,
  `porcentaje_comision` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_categoria_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bien`
--

LOCK TABLES `bien` WRITE;
/*!40000 ALTER TABLE `bien` DISABLE KEYS */;
INSERT INTO `bien` VALUES (1,'AF',0,865,'microondas oster',1,0,NULL,NULL,NULL,3,'activo',1,NULL),(1,'MP',25,15,'salsa de tomate naturas',4,0,NULL,NULL,NULL,3,'activo',3,NULL),(1,'PT',35,23,'Menú hanburgesa',6,0,NULL,NULL,NULL,3,'activo',11,NULL),(2,'AF',0,680,'Televisor',1,0,NULL,NULL,NULL,3,'activo',7,NULL),(2,'MP',0,5,'Consome de pollo',5,0,NULL,NULL,NULL,3,'activo',9,NULL),(3,'MP',15,15,'Pimienta',5,0,NULL,NULL,NULL,3,'activo',9,NULL),(4,'MP',0,35,'jamon t',5,0,NULL,NULL,NULL,1,'inactivo',10,80),(5,'MP',0,23,'Jalapneños',5,0,NULL,NULL,NULL,3,'activo',9,1);
/*!40000 ALTER TABLE `bien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bien_habitacion`
--

DROP TABLE IF EXISTS `bien_habitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bien_habitacion` (
  `id_bien_pk` int(11) NOT NULL,
  `id_habitacion_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_habitacion_pk`,`id_categoria_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bien_habitacion`
--

LOCK TABLES `bien_habitacion` WRITE;
/*!40000 ALTER TABLE `bien_habitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `bien_habitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `id_bit` int(10) NOT NULL AUTO_INCREMENT,
  `hora` time DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `accion` varchar(500) DEFAULT NULL,
  `tabla` varchar(50) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_bit`)
) ENGINE=InnoDB AUTO_INCREMENT=16811 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (16100,'19:30:47','2016-10-20','juan','Fallo loggeo','Login','usuario','192.168.1.11'),(16101,'19:33:36','2016-10-20','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16102,'19:55:50','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16103,'19:56:29','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16104,'19:58:01','2016-10-20','almasunshine','Insertar','Creacion usuario: esdu','usuario','192.168.1.11'),(16105,'19:58:14','2016-10-20','almasunshine','Operacion exitosa','Asignacion del usuario: esdu al colaborador: 1-1','usuario','192.168.1.11'),(16106,'19:58:15','2016-10-20','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: esdu Sobre aplicacion: 2','usuario_privilegios','192.168.1.11'),(16107,'20:03:21','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16108,'20:03:37','2016-10-20','almasunshine','Eliminar ','Se deshabilitò el usuario: esdu','usuario','192.168.1.11'),(16109,'20:05:01','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16110,'20:05:46','2016-10-20','almasunshine','Insertar','Creacion usuario: green','usuario','192.168.1.11'),(16111,'20:05:47','2016-10-20','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: green','bitacora','192.168.1.11'),(16112,'20:05:47','2016-10-20','almasunshine','Operacion exitosa','Asignacion del usuario: green al colaborador: 1-1','usuario','192.168.1.11'),(16113,'20:05:48','2016-10-20','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: green Sobre aplicacion: 2','usuario_privilegios','192.168.1.11'),(16114,'20:15:25','2016-10-20','hola','hola','hola','hola','hola'),(16115,'20:56:26','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16116,'20:57:27','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16117,'21:04:12','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16118,'21:10:38','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16119,'21:24:33','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16120,'21:24:52','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16121,'21:36:52','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16122,'21:39:48','2016-10-20','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16123,'21:39:53','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16124,'21:40:37','2016-10-20','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16125,'21:40:43','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16126,'21:41:44','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16127,'21:42:27','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16128,'21:46:36','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16129,'21:47:52','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16130,'22:06:53','2016-10-20','ooo','ooo','ooo','ooo','ooo'),(16131,'22:13:46','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16132,'22:18:23','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16133,'22:19:24','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16134,'22:35:19','2016-10-20','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16135,'22:35:25','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16136,'22:44:27','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16137,'22:46:47','2016-10-20','ooo','ooo','ooo','ooo','ooo'),(16138,'22:49:01','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16139,'22:49:59','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16140,'22:50:37','2016-10-20','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16141,'22:50:42','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16142,'23:03:38','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16143,'23:04:19','2016-10-20','almasunshine','Insertar','Creacion usuario: yun','usuario','192.168.1.11'),(16144,'23:04:19','2016-10-20','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: yun','bitacora','192.168.1.11'),(16145,'23:04:20','2016-10-20','almasunshine','Operacion exitosa','Asignacion del usuario: yun al colaborador: 1-1','usuario','192.168.1.11'),(16146,'23:04:20','2016-10-20','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: yun Sobre aplicacion: 2','usuario_privilegios','192.168.1.11'),(16147,'23:53:20','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16148,'23:53:41','2016-10-20','almasunshine','Modificar','Actualizacion de contraseña de usuario: almasunshine','usuario','192.168.1.11'),(16149,'23:57:30','2016-10-20','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16150,'23:57:47','2016-10-20','almasunshine','Modificar','Actualizacion de contraseña de usuario: almasunshine','usuario','192.168.1.11'),(16151,'14:30:20','2016-10-21','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16152,'14:30:30','2016-10-21','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16153,'14:30:36','2016-10-21','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16154,'14:38:55','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16155,'14:49:33','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16156,'14:55:10','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16157,'15:11:35','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16158,'15:18:36','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16159,'15:35:57','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16160,'15:37:36','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16161,'15:41:12','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16162,'15:42:23','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16163,'15:43:58','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16164,'15:53:59','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16165,'15:59:56','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16166,'16:21:27','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16167,'16:40:02','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16168,'16:46:12','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16169,'17:08:39','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16170,'17:12:00','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16171,'17:18:19','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16172,'17:20:03','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16173,'17:22:17','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16174,'17:28:32','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16175,'17:32:15','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16176,'17:33:24','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16177,'17:34:03','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16178,'17:36:47','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16179,'17:47:16','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16180,'17:47:39','2016-10-21','almasunshine','Operacion exitosa','Creacion de perfil:policia','perfil','192.168.1.11'),(16181,'17:47:39','2016-10-21','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: False a perfil: 12 Sobre aplicacion: 4','perfil_privilegios','192.168.1.11'),(16182,'17:47:40','2016-10-21','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: False a perfil: 12 Sobre aplicacion: 6','perfil_privilegios','192.168.1.11'),(16183,'18:43:28','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16184,'19:04:18','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16185,'19:30:14','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16186,'19:30:27','2016-10-21','almasunshine','Eliminar ','Se deshabilitó el usuario: policia','usuario','192.168.1.11'),(16187,'19:31:19','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16188,'19:32:15','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16189,'19:32:41','2016-10-21','almasunshine','Operacion exitosa','Creacion de perfil:yonito','perfil','192.168.1.11'),(16190,'19:32:41','2016-10-21','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: True a perfil: 13 Sobre aplicacion: 4','perfil_privilegios','192.168.1.11'),(16191,'19:32:41','2016-10-21','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: True a perfil: 13 Sobre aplicacion: 6','perfil_privilegios','192.168.1.11'),(16192,'19:34:13','2016-10-21','almasunshine','Eliminar ','Se deshabilitó el usuario: yonito','usuario','192.168.1.11'),(16193,'19:44:55','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16194,'19:45:40','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16195,'20:11:27','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16196,'20:12:52','2016-10-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16197,'20:13:30','2016-10-21','almasunshine','Insertar','Creacion usuario: yonito','usuario','192.168.1.11'),(16198,'20:13:31','2016-10-21','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: yonito','bitacora','192.168.1.11'),(16199,'20:13:31','2016-10-21','almasunshine','Operacion exitosa','Asignacion del usuario: yonito al colaborador: 1-1','usuario','192.168.1.11'),(16200,'20:13:31','2016-10-21','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: yonito Sobre aplicacion: 3','usuario_privilegios','192.168.1.11'),(16201,'20:15:14','2016-10-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16202,'20:18:27','2016-10-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16203,'20:22:37','2017-01-26','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16204,'20:24:15','2017-01-26','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16205,'20:25:55','2017-01-26','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16206,'20:27:32','2017-01-26','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16207,'20:28:07','2017-01-26','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16208,'20:30:08','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16209,'20:31:16','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16210,'20:31:46','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16211,'20:48:38','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16212,'20:49:17','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16213,'20:49:58','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16214,'20:51:15','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16215,'20:52:53','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16216,'20:53:36','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16217,'20:56:38','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16218,'20:56:50','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16219,'21:01:09','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16220,'21:01:47','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16221,'21:03:03','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16222,'21:06:52','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16223,'21:07:16','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16224,'21:07:49','2017-01-21','almasunshine','Insertar','Creacion usuario: asopotamadre','usuario','192.168.1.11'),(16225,'21:07:50','2017-01-21','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: asopotamadre','bitacora','192.168.1.11'),(16226,'21:07:50','2017-01-21','almasunshine','Operacion exitosa','Asignacion del usuario: asopotamadre al colaborador: 1-1','usuario','192.168.1.11'),(16227,'21:07:50','2017-01-21','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: False upd: True del: False a usuario: asopotamadre Sobre aplicacion: 7','usuario_privilegios','192.168.1.11'),(16228,'21:08:13','2017-01-21','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16229,'21:10:26','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16230,'21:10:36','2017-01-21','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16231,'21:22:58','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16232,'21:30:16','2017-01-21','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16233,'21:31:17','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16234,'21:34:09','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16235,'21:35:41','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16236,'21:39:56','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16237,'21:41:50','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16238,'21:43:23','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16239,'21:46:04','2017-01-21','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16240,'21:46:28','2017-01-21','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16241,'21:47:21','2017-01-21','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16242,'09:49:57','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16243,'09:50:19','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16244,'09:53:05','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16245,'09:55:39','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16246,'10:04:41','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16247,'10:05:59','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16248,'10:06:24','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16249,'10:09:41','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16250,'10:10:09','2016-10-22','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16251,'10:14:00','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16252,'10:17:48','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16253,'10:28:38','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16254,'10:30:39','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16255,'10:45:53','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16256,'10:47:43','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16257,'10:48:45','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16258,'10:50:34','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16259,'10:52:09','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16260,'10:52:36','2016-10-22','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16261,'10:54:19','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16262,'11:10:50','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16263,'11:13:14','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16264,'11:15:13','2016-10-22','asopotamadre','Loggeo exitoso','Login','usuario','192.168.1.11'),(16265,'11:18:43','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16266,'11:26:54','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16267,'11:27:12','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16268,'11:40:04','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16269,'11:40:34','2016-10-22','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16270,'16:44:28','2016-10-22','juan','Fallo loggeo','Login','usuario','192.168.1.11'),(16271,'16:44:34','2016-10-22','juan','Loggeo exitoso','Login','usuario','192.168.1.11'),(16272,'20:22:35','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16273,'20:28:27','2016-10-22','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16274,'10:32:31','2016-10-23','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16275,'10:56:30','2016-10-23','','Insertar','insercion de categoria: lacteos','categoria','192.168.1.11'),(16276,'19:28:55','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16277,'19:29:29','2016-10-24','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16278,'19:29:58','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16279,'19:32:20','2016-10-24','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16280,'19:33:12','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16281,'21:48:44','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16282,'22:01:46','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16283,'22:36:38','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16284,'22:37:23','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16285,'22:38:06','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16286,'22:39:09','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16287,'22:40:36','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16288,'22:44:40','2016-10-24','yonito','Loggeo exitoso','Login','usuario','127.0.0.1'),(16289,'22:45:37','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16290,'22:46:01','2016-10-24','yonito','Loggeo exitoso','Login','usuario','127.0.0.1'),(16291,'23:49:34','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16292,'23:51:03','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16293,'23:55:18','2016-10-24','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16294,'00:15:12','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16295,'07:52:19','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16296,'08:22:16','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16297,'09:16:53','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16298,'09:17:11','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16299,'09:19:33','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16300,'09:22:27','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16301,'09:23:17','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16302,'09:23:43','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16303,'09:25:33','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16304,'09:26:26','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16305,'09:26:46','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16306,'09:30:40','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16307,'09:34:00','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16308,'10:15:28','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16309,'10:26:10','2016-10-25','otto','Loggeo exitoso','Login','usuario','127.0.0.1'),(16310,'10:30:41','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16311,'10:31:18','2016-10-25','almasunshine','Insertar','insercion de categoria: vegetales','categoria','127.0.0.1'),(16312,'10:31:37','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16313,'10:39:17','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16314,'10:42:41','2016-10-25','yonito','Fallo loggeo','Login','usuario','127.0.0.1'),(16315,'10:42:48','2016-10-25','yonito','Loggeo exitoso','Login','usuario','127.0.0.1'),(16316,'10:47:07','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16317,'10:48:23','2016-10-25','almasunshine','Insertar','Creacion usuario: MiUsuario','usuario','127.0.0.1'),(16318,'10:48:23','2016-10-25','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: MiUsuario','bitacora','127.0.0.1'),(16319,'10:48:24','2016-10-25','almasunshine','Operacion exitosa','Asignacion del usuario: MiUsuario al colaborador: 1-1','usuario','127.0.0.1'),(16320,'10:48:24','2016-10-25','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: MiUsuario Sobre aplicacion: 1','usuario_privilegios','127.0.0.1'),(16321,'10:48:24','2016-10-25','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: False upd: False del: False a usuario: MiUsuario Sobre aplicacion: 2','usuario_privilegios','127.0.0.1'),(16322,'10:48:24','2016-10-25','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: MiUsuario Sobre aplicacion: 3','usuario_privilegios','127.0.0.1'),(16323,'10:48:24','2016-10-25','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: MiUsuario Sobre aplicacion: 4','usuario_privilegios','127.0.0.1'),(16324,'10:48:24','2016-10-25','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: True del: False a usuario: MiUsuario Sobre aplicacion: 10201','usuario_privilegios','127.0.0.1'),(16325,'17:41:26','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16326,'18:10:08','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16327,'18:12:20','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16328,'18:18:50','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16329,'18:19:31','2016-10-25','almasunshine','Insertar','insercion de categoria: Materia prima','categoria','192.168.1.11'),(16330,'18:19:52','2016-10-25','almasunshine','Insertar','insercion de categoria: Producto terminado','categoria','192.168.1.11'),(16331,'18:20:27','2016-10-25','almasunshine','Insertar','insercion de categoria: Activos fijos','categoria','192.168.1.11'),(16332,'18:22:00','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16333,'18:24:45','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16334,'19:03:07','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16335,'19:04:30','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16336,'19:04:53','2016-10-25','almasunshine','Insertar','insercion de categoria: AF','categoria','192.168.1.11'),(16337,'19:11:02','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16338,'19:11:54','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16339,'19:13:11','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16340,'19:34:50','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16341,'19:38:44','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16342,'19:41:00','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16343,'19:42:09','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16344,'19:46:02','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16345,'19:47:07','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16346,'19:47:40','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16347,'19:51:34','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16348,'19:56:08','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16349,'19:56:35','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16350,'20:02:01','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16351,'20:04:07','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16352,'20:06:45','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16353,'20:19:58','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16354,'20:23:12','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16355,'20:26:12','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16356,'20:55:31','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16357,'21:05:27','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16358,'21:23:25','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16359,'21:29:43','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16360,'21:31:16','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16361,'22:27:18','2016-10-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16362,'13:58:17','2016-10-26','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16363,'14:00:20','2016-10-26','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16364,'14:10:30','2016-10-26','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16365,'14:33:11','2016-10-26','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16366,'14:34:14','2016-10-26','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16367,'10:10:40','2016-10-27','','Insertar','insercion de categoria: Mobiliario','categoria','127.0.0.1'),(16368,'10:12:54','2016-10-27','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16369,'17:06:13','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16370,'17:55:58','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16371,'18:03:35','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16372,'18:49:10','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16373,'22:20:43','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16374,'22:36:47','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16375,'22:41:32','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16376,'22:44:13','2016-10-29','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16377,'10:31:57','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16378,'10:33:10','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16379,'10:34:38','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16380,'10:35:19','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16381,'10:36:27','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16382,'10:37:54','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16383,'10:38:35','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16384,'10:39:00','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16385,'10:39:27','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16386,'10:42:16','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16387,'13:14:55','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16388,'13:20:08','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16389,'14:15:07','2016-10-30','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16390,'14:16:22','2016-10-30','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16391,'21:03:16','2016-10-30','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16392,'21:39:13','2016-10-30','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16393,'21:39:14','2016-10-30','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 2','encabezado_documento','192.168.1.11'),(16394,'21:47:52','2016-10-30','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16395,'21:47:52','2016-10-30','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 3','encabezado_documento','192.168.1.11'),(16396,'23:37:07','2016-10-30','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16397,'23:37:09','2016-10-30','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 4','encabezado_documento','192.168.1.11'),(16398,'23:40:30','2016-10-30','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16399,'23:40:31','2016-10-30','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 5','encabezado_documento','192.168.1.11'),(16400,'23:53:56','2016-10-30','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16401,'23:53:57','2016-10-30','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 6','encabezado_documento','192.168.1.11'),(16402,'23:56:55','2016-10-30','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16403,'00:07:13','2016-10-31','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16404,'00:07:13','2016-10-31','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 7','encabezado_documento','192.168.1.11'),(16405,'14:57:01','2016-10-31','','Insertar','registro de  orden de compra como documento modificador de inventario: 1','encabezado_documento','192.168.1.11'),(16406,'15:58:45','2016-10-31','','Insertar','registro de  orden de compra como documento modificador de inventario: 3','encabezado_documento','192.168.1.11'),(16407,'16:02:31','2016-10-31','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16408,'16:02:31','2016-10-31','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 8','encabezado_documento','192.168.1.11'),(16409,'16:04:17','2016-10-31','','Insertar','registro de  orden de compra como documento modificador de inventario: 4','encabezado_documento','192.168.1.11'),(16410,'21:06:26','2016-10-31','','Insertar','registro de  orden de compra como documento modificador de inventario: 5','encabezado_documento','192.168.1.11'),(16411,'21:18:29','2016-10-31','','Insertar','registro de  orden de compra como documento modificador de inventario: 6','encabezado_documento','192.168.1.11'),(16412,'21:19:32','2016-10-31','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16413,'21:19:33','2016-10-31','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 9','encabezado_documento','192.168.1.11'),(16414,'14:43:15','2016-11-01','','Insertar','registro de  orden de compra como documento modificador de inventario: 7','encabezado_documento','192.168.1.11'),(16415,'16:19:28','2016-11-01','','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16416,'16:19:30','2016-11-01','','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 10','encabezado_documento','192.168.1.11'),(16417,'17:23:57','2016-11-02','','Insertar','insercion de categoria: CategoriaEliminada','categoria','192.168.1.11'),(16418,'19:34:13','2016-11-02','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16419,'19:34:17','2016-11-02','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16420,'19:34:23','2016-11-02','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16421,'07:46:30','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16422,'07:47:22','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16423,'07:48:14','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16424,'07:49:11','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16425,'07:50:10','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16426,'07:54:45','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16427,'07:58:35','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16428,'08:01:17','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16429,'08:10:09','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16430,'13:59:38','2016-11-03','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16431,'10:50:41','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16432,'10:53:37','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16433,'10:56:22','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16434,'12:05:27','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16435,'12:11:56','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16436,'12:22:47','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16437,'12:24:29','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16438,'12:32:28','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16439,'12:36:01','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16440,'13:17:34','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16441,'13:18:10','2016-11-06','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16442,'13:27:21','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16443,'13:27:42','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16444,'13:27:57','2016-11-06','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16445,'13:28:36','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16446,'13:28:49','2016-11-06','yonito','Loggeo exitoso','Login','usuario','192.168.1.11'),(16447,'13:32:08','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16448,'13:32:47','2016-11-06','almasunshine','Insertar','Registro de aplicacion: 10100--Inicio inventario','aplicacion','192.168.1.11'),(16449,'13:33:14','2016-11-06','almasunshine','Insertar','Registro de aplicacion: 10101--Gestión de categorias','aplicacion','192.168.1.11'),(16450,'13:37:59','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16451,'13:41:04','2016-11-06','almasunshine','Insertar','Creacion usuario: walter','usuario','192.168.1.11'),(16452,'13:41:05','2016-11-06','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: walter','bitacora','192.168.1.11'),(16453,'13:41:05','2016-11-06','almasunshine','Operacion exitosa','Asignacion del usuario: walter al colaborador: 1-1','usuario','192.168.1.11'),(16454,'13:41:05','2016-11-06','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10101','usuario_privilegios','192.168.1.11'),(16455,'13:54:00','2016-11-06','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16456,'15:24:31','2016-11-06','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16457,'15:25:54','2016-11-06','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16458,'16:30:13','2016-11-06','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16459,'16:31:06','2016-11-06','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16460,'16:32:15','2016-11-06','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16461,'16:35:04','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16462,'16:35:29','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16463,'16:36:51','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16464,'16:40:43','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16465,'21:32:36','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16466,'21:33:20','2016-11-06','almasunshine','Modificar','Actualizacion de contraseña de usuario: almasunshine','usuario','192.168.1.11'),(16467,'21:33:30','2016-11-06','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16468,'21:33:36','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16469,'21:42:31','2016-11-06','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16470,'21:42:34','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16471,'21:43:59','2016-11-06','almasunshine','Modificar','Modificacion de aplicacion: 9--Mi_aplicacion','aplicacion','192.168.1.11'),(16472,'21:55:42','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16473,'22:10:42','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16474,'22:14:25','2016-11-06','almasunshine','Operacion exitosa','Creacion de perfil:PerfilPrueba','perfil','192.168.1.11'),(16475,'22:14:25','2016-11-06','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: True upd: True del: False a perfil: 12 Sobre aplicacion: 9','perfil_privilegios','192.168.1.11'),(16476,'22:15:41','2016-11-06','almasunshine','Asignacion/cambio permisos','Eliminacion de privilegios a perfil: 12','perfil_privilegios','192.168.1.11'),(16477,'22:15:41','2016-11-06','almasunshine','Asignacion/cambio permisos','Actualizacion de permisos: ins: True sel: False upd: False del: False','privilegios_perfil','192.168.1.11'),(16478,'22:34:33','2016-11-06','almasunshine','Modificar','Actualizacion de contraseña de usuario: almasunshine','usuario','192.168.1.11'),(16479,'23:13:25','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16480,'23:36:29','2016-11-06','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16481,'10:08:24','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16482,'10:15:40','2016-11-07','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 8','encabezado_documento','127.0.0.1'),(16483,'10:17:49','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16484,'10:18:29','2016-11-07','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','127.0.0.1'),(16485,'10:18:29','2016-11-07','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 11','encabezado_documento','127.0.0.1'),(16486,'17:16:34','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16487,'17:17:34','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16488,'17:30:17','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16489,'17:56:47','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16490,'17:57:23','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16491,'18:01:06','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16492,'18:18:36','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16493,'18:27:16','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16494,'18:39:06','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16495,'18:41:13','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16496,'18:43:23','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16497,'18:43:52','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16498,'18:44:47','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16499,'19:12:09','2016-11-07','walter','Modificar','Actualizacion de contraseña de usuario: walter','usuario','192.168.1.11'),(16500,'19:12:18','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16501,'19:12:32','2016-11-07','walter','Modificar','Actualizacion de contraseña de usuario: walter','usuario','192.168.1.11'),(16502,'19:12:42','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16503,'19:15:51','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16504,'19:16:35','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16505,'19:17:03','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16506,'19:18:10','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16507,'19:31:15','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16508,'20:07:07','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16509,'20:21:19','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16510,'20:40:45','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16511,'20:42:45','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16512,'20:44:21','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16513,'20:45:21','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16514,'20:54:40','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16515,'20:56:18','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16516,'20:57:09','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16517,'21:03:26','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16518,'21:20:26','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16519,'21:21:49','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16520,'21:24:47','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16521,'21:39:22','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16522,'21:39:39','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16523,'21:50:51','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16524,'21:51:34','2016-11-07','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16525,'22:07:25','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16526,'22:11:55','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16527,'22:21:43','2016-11-07','almasunshine','Eliminar ','Eliminacion de aplicacion: 2','aplicacion','192.168.1.11'),(16528,'22:26:25','2016-11-07','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16529,'23:33:49','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10101--Mantenimiento categorias','aplicacion','192.168.1.11'),(16530,'23:34:12','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10102--Mantenimiento de bodegas','aplicacion','192.168.1.11'),(16531,'23:34:45','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10103--Generar devolucion sobre compra','aplicacion','192.168.1.11'),(16532,'23:35:07','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10104--Reporte de existencias','aplicacion','192.168.1.11'),(16533,'23:35:27','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10105--Facturas pendientes','aplicacion','192.168.1.11'),(16534,'23:38:51','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10106--Listado de bienes','aplicacion','192.168.1.11'),(16535,'23:50:18','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10107--kardex','aplicacion','192.168.1.11'),(16536,'23:50:35','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10108--Mantenimiento de linea','aplicacion','192.168.1.11'),(16537,'23:50:47','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10109--Mantenimiento de medidas','aplicacion','192.168.1.11'),(16538,'23:51:04','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10110--Reporte de movimientos','aplicacion','192.168.1.11'),(16539,'23:57:21','2016-11-07','almasunshine','Insertar','Registro de aplicacion: 10111--Ingreso de nuevo producto','aplicacion','192.168.1.11'),(16540,'00:00:46','2016-11-08','almasunshine','Insertar','Registro de aplicacion: 10112--Recibir stock','aplicacion','192.168.1.11'),(16541,'00:05:55','2016-11-08','almasunshine','Insertar','Registro de aplicacion: 10113--Generar requisicion','aplicacion','192.168.1.11'),(16542,'00:06:09','2016-11-08','almasunshine','Insertar','Registro de aplicacion: 10114--Mantenimiento de marcas','aplicacion','192.168.1.11'),(16543,'00:07:12','2016-11-08','almasunshine','Asignacion/cambio permisos','Eliminacion de privilegios para usuario: walter','usuario_privilegios','192.168.1.11'),(16544,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10101','usuario_privilegios','192.168.1.11'),(16545,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10102','usuario_privilegios','192.168.1.11'),(16546,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10103','usuario_privilegios','192.168.1.11'),(16547,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10104','usuario_privilegios','192.168.1.11'),(16548,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10105','usuario_privilegios','192.168.1.11'),(16549,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10106','usuario_privilegios','192.168.1.11'),(16550,'00:07:13','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10107','usuario_privilegios','192.168.1.11'),(16551,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10108','usuario_privilegios','192.168.1.11'),(16552,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10109','usuario_privilegios','192.168.1.11'),(16553,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10110','usuario_privilegios','192.168.1.11'),(16554,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10111','usuario_privilegios','192.168.1.11'),(16555,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10112','usuario_privilegios','192.168.1.11'),(16556,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10113','usuario_privilegios','192.168.1.11'),(16557,'00:07:14','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10114','usuario_privilegios','192.168.1.11'),(16558,'00:07:31','2016-11-08','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16559,'11:01:52','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16560,'11:26:38','2016-11-08','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 9','encabezado_documento','10.1.65.13'),(16561,'11:29:29','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16562,'11:33:06','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16563,'11:33:39','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16564,'11:34:48','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16565,'11:35:36','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16566,'11:38:17','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16567,'11:39:28','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','10.1.65.13'),(16568,'13:56:19','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16569,'13:57:09','2016-11-08','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16570,'13:57:58','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16571,'14:00:17','2016-11-08','almasunshine','Asignacion/cambio permisos','Eliminacion de privilegios para usuario: walter','usuario_privilegios','192.168.1.11'),(16572,'14:00:17','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10101','usuario_privilegios','192.168.1.11'),(16573,'14:00:18','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: True sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10102','usuario_privilegios','192.168.1.11'),(16574,'14:00:18','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10103','usuario_privilegios','192.168.1.11'),(16575,'14:00:18','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10104','usuario_privilegios','192.168.1.11'),(16576,'14:00:18','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10105','usuario_privilegios','192.168.1.11'),(16577,'14:00:18','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10106','usuario_privilegios','192.168.1.11'),(16578,'14:00:18','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10107','usuario_privilegios','192.168.1.11'),(16579,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10108','usuario_privilegios','192.168.1.11'),(16580,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10109','usuario_privilegios','192.168.1.11'),(16581,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10110','usuario_privilegios','192.168.1.11'),(16582,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10111','usuario_privilegios','192.168.1.11'),(16583,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10112','usuario_privilegios','192.168.1.11'),(16584,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10113','usuario_privilegios','192.168.1.11'),(16585,'14:00:19','2016-11-08','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: walter Sobre aplicacion: 10114','usuario_privilegios','192.168.1.11'),(16586,'14:00:30','2016-11-08','walter','Loggeo exitoso','Login','usuario','192.168.1.11'),(16587,'14:02:34','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16588,'14:17:43','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16589,'14:24:40','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16590,'14:25:53','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16591,'14:36:30','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16592,'14:45:13','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16593,'14:49:51','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16594,'14:52:03','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16595,'14:54:11','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16596,'15:28:04','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16597,'15:36:34','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16598,'15:39:52','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16599,'15:39:53','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 12','encabezado_documento','192.168.1.11'),(16600,'15:42:05','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16601,'15:42:05','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 13','encabezado_documento','192.168.1.11'),(16602,'15:42:38','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16603,'15:43:33','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16604,'15:44:39','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16605,'15:44:39','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 15','encabezado_documento','192.168.1.11'),(16606,'15:50:17','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16607,'15:50:17','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 16','encabezado_documento','192.168.1.11'),(16608,'15:56:19','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16609,'15:56:19','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 17','encabezado_documento','192.168.1.11'),(16610,'16:13:10','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16611,'16:20:04','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16612,'16:22:13','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16613,'16:35:23','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16614,'16:37:45','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16615,'16:38:43','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16616,'16:40:47','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16617,'16:42:25','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16618,'16:42:25','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 18','encabezado_documento','192.168.1.11'),(16619,'16:45:41','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16620,'16:46:25','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16621,'16:46:25','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 20','encabezado_documento','192.168.1.11'),(16622,'16:52:58','2016-11-08','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 10','encabezado_documento','192.168.1.11'),(16623,'16:54:44','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16624,'16:54:44','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 21','encabezado_documento','192.168.1.11'),(16625,'17:03:41','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16626,'17:04:15','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16627,'17:04:39','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 22','encabezado_documento','192.168.1.11'),(16628,'17:05:01','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16629,'17:05:02','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 23','encabezado_documento','192.168.1.11'),(16630,'17:05:17','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16631,'17:05:19','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 24','encabezado_documento','192.168.1.11'),(16632,'17:05:33','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16633,'17:05:34','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 25','encabezado_documento','192.168.1.11'),(16634,'17:08:32','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16635,'17:10:47','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16636,'17:10:49','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 26','encabezado_documento','192.168.1.11'),(16637,'17:13:29','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16638,'17:13:42','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 27','encabezado_documento','192.168.1.11'),(16639,'17:29:32','2016-11-08','almasunshine','Fallo loggeo','Login','usuario','192.168.1.11'),(16640,'17:29:37','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16641,'17:30:31','2016-11-08','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.11'),(16642,'17:30:31','2016-11-08','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 28','encabezado_documento','192.168.1.11'),(16643,'18:15:34','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16644,'18:19:32','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16645,'18:20:07','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16646,'18:42:13','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16647,'19:10:05','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16648,'19:13:47','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16649,'19:15:23','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16650,'19:17:38','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16651,'19:18:58','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16652,'19:37:53','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16653,'19:40:13','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16654,'20:10:40','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16655,'20:13:25','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16656,'20:14:48','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16657,'20:20:21','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16658,'21:00:38','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16659,'21:04:41','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16660,'21:15:32','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16661,'21:26:25','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16662,'21:32:41','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16663,'21:57:39','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16664,'22:05:25','2016-11-08','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.11'),(16665,'16:08:17','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16666,'16:18:44','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16667,'16:27:13','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16668,'17:06:16','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16669,'17:16:41','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16670,'17:17:54','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 11,dsjfhksajhkjshksjh,88,1,AF,100',' Detalle_ Muestreo ','192.168.1.6'),(16671,'17:18:46','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16672,'17:19:59','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 11,cualquiera,24,1,MP,20',' Detalle_ Muestreo ','192.168.1.6'),(16673,'17:21:59','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16674,'17:23:00','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 8,encontkjnrjkmkje,8,2,AF,11',' Detalle_ Muestreo ','192.168.1.6'),(16675,'17:25:51','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16676,'17:26:17','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 9,enonthghd,88,1,AF,99',' Detalle_ Muestreo ','192.168.1.6'),(16677,'17:30:41','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16678,'17:31:46','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 8,enocntre  18 pimientas,16,3,MP,18',' Detalle_ Muestreo ','192.168.1.6'),(16679,'17:32:02','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 8,enocntre  18 pimientas,16,1,MP,18',' Detalle_ Muestreo ','192.168.1.6'),(16680,'17:32:08','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 8,enocntre  18 pimientas,16,1,AF,18',' Detalle_ Muestreo ','192.168.1.6'),(16681,'17:38:24','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16682,'17:38:53','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 8,enocntre 36,24,1,MP,36',' Detalle_ Muestreo ','192.168.1.6'),(16683,'17:42:17','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16684,'17:42:56','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 4,rtyu,8,2,AF,44',' Detalle_ Muestreo ','192.168.1.6'),(16685,'17:45:33','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16686,'17:47:02','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16687,'17:47:31','2016-11-09','almasunshine','Insertar','Se ha hecho el registro de: 4,enoctgd,88,1,AF,100',' Detalle_ Muestreo ','192.168.1.6'),(16688,'17:57:17','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16689,'18:15:11','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16690,'18:25:55','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16691,'18:50:37','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16692,'19:02:40','2016-11-09','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 11','encabezado_documento','192.168.1.6'),(16693,'19:04:36','2016-11-09','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.6'),(16694,'19:04:36','2016-11-09','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 29','encabezado_documento','192.168.1.6'),(16695,'20:54:55','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16696,'21:06:16','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16697,'21:12:10','2016-11-09','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 12','encabezado_documento','192.168.1.6'),(16698,'21:15:45','2016-11-09','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.6'),(16699,'21:15:46','2016-11-09','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 30','encabezado_documento','192.168.1.6'),(16700,'21:22:14','2016-11-09','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.6'),(16701,'21:22:15','2016-11-09','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 31','encabezado_documento','192.168.1.6'),(16702,'21:53:01','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16703,'22:18:27','2016-11-09','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16704,'16:41:09','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16705,'16:43:25','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16706,'16:48:09','2016-11-10','almasunshine','Insertar','insercion de bien Jalapneños','bien','192.168.1.6'),(16707,'16:55:23','2016-11-10','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 13','encabezado_documento','192.168.1.6'),(16708,'16:57:06','2016-11-10','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','192.168.1.6'),(16709,'16:57:06','2016-11-10','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 32','encabezado_documento','192.168.1.6'),(16710,'17:09:35','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16711,'17:27:44','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16712,'17:32:07','2016-11-10','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 14','encabezado_documento','192.168.1.6'),(16713,'17:43:52','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16714,'17:49:34','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16715,'19:16:43','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16716,'22:31:43','2016-11-10','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16717,'13:41:56','2016-12-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16718,'10:05:07','2017-02-14','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16719,'11:24:49','2017-02-19','almasunshine','Loggeo exitoso','Login','usuario','miip'),(16720,'11:25:31','2017-02-19','almasunshine','Loggeo exitoso','Login','usuario','miip'),(16721,'11:25:59','2017-02-19','almasunshine','Fallo loggeo','Login','usuario','miip'),(16722,'11:26:47','2017-02-19','almasunshine','Loggeo exitoso','Login','usuario','miip'),(16723,'11:27:10','2017-02-19','almasunshine','Fallo loggeo','Login','usuario','miip'),(16724,'12:21:15','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16725,'12:41:16','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16726,'12:43:20','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16727,'12:44:05','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16728,'12:45:45','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16729,'12:46:24','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16730,'12:47:38','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16731,'12:48:40','2017-02-25','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16732,'18:44:37','2017-02-28','','Insertar','Registro de empresa: Lancasco','empresa','192.168.1.6'),(16733,'10:41:09','2017-03-05','almasunshine','Fallo loggeo','Login','usuario','192.168.1.6'),(16734,'10:41:20','2017-03-05','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.6'),(16735,'16:10:34','2017-03-05','MarioYuque','Insertar','Registro de empresa: Publimar','empresa','192.168.1.6'),(16736,'19:35:03','2017-03-05','MarioYuque','Insertar','Registro de categoria: Petroleros','categoria_neg','192.168.1.6'),(16737,'19:57:53','2017-03-05','MarioYuque','Insertar','Registro de categoria: Internacionales','categoria_neg','192.168.1.6'),(16738,'20:10:46','2017-03-05','MarioYuque','Insertar','Registro de categoria: Nacionales','categoria_neg','192.168.1.6'),(16739,'19:29:23','2017-03-06','MarioYuque','Insertar','Registro de negocio: Venta de mariguana','tbl_negocio','192.168.1.6'),(16740,'19:33:14','2017-03-06','MarioYuque','Insertar','Registro de negocio: Venta de autos','tbl_negocio','192.168.1.6'),(16741,'11:50:15','2017-03-22','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16742,'12:05:02','2017-03-22','almasunshine','Intento Operacion','Error al crear usuario a nivel DBSjavii3','dbo.users','127.0.0.1'),(16743,'12:25:27','2017-03-22','almasunshine','Insertar','Creacion usuario: almasinja','usuario','127.0.0.1'),(16744,'12:25:27','2017-03-22','almasunshine','Operacion exitosa','Se otorga permiso sobre bitacora al usuario: almasinja','bitacora','127.0.0.1'),(16745,'12:25:27','2017-03-22','almasunshine','Operacion exitosa','Asignacion del usuario: almasinja al colaborador: 1-1','usuario','127.0.0.1'),(16746,'12:25:27','2017-03-22','almasunshine','Asignacion/cambio permisos','Asignacion de permiso: ins: False sel: True upd: False del: False a usuario: almasinja Sobre aplicacion: 10111','usuario_privilegios','127.0.0.1'),(16747,'12:25:58','2017-03-22','almasinja','Loggeo exitoso','Login','usuario','127.0.0.1'),(16748,'17:44:38','2017-03-22','MarioYuque','Insertar','Registro de categoria: Industriales','categoria_neg','192.168.1.2'),(16749,'17:45:29','2017-03-22','MarioYuque','Insertar','Registro de empresa: CocaCola','empresa','192.168.1.2'),(16750,'11:07:06','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.43.153'),(16751,'11:10:41','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.43.153'),(16752,'11:15:23','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.43.153'),(16753,'11:20:15','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.43.153'),(16754,'11:23:13','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.43.153'),(16755,'11:34:50','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.43.153'),(16756,'11:36:35','2017-05-17','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 15','encabezado_documento','127.0.0.1'),(16757,'11:37:56','2017-05-17','almasunshine','Insertar','registro de  devolucion sobre compra: ','devolucion_compra','127.0.0.1'),(16758,'11:37:56','2017-05-17','almasunshine','Insertar','registro de Devolucion sobre compra como documento modificador de inventario: 33','encabezado_documento','127.0.0.1'),(16759,'11:42:29','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16760,'11:53:49','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16761,'11:57:39','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','127.0.0.1'),(16762,'13:47:52','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16763,'13:54:13','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16764,'14:12:56','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16765,'14:58:19','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16766,'15:09:15','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16767,'15:09:50','2017-05-17','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 16','encabezado_documento','192.168.1.5'),(16768,'15:16:05','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16769,'15:27:49','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16770,'16:30:45','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16771,'16:41:53','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16772,'16:43:29','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16773,'16:47:48','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16774,'16:48:46','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16775,'16:50:02','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16776,'16:54:28','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16777,'17:01:37','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16778,'17:42:38','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16779,'17:44:37','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16780,'17:44:38','2017-05-17','almasunshine','Insertar','registro de Factura como documento modificador de inventario: 4','encabezado_documento','192.168.1.5'),(16781,'17:48:56','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16782,'17:48:56','2017-05-17','almasunshine','Insertar','registro de Factura como documento modificador de inventario: 5','encabezado_documento','192.168.1.5'),(16783,'18:00:40','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16784,'18:04:47','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16785,'18:13:41','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16786,'18:31:31','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16787,'18:35:42','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16788,'18:37:01','2017-05-17','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 17','encabezado_documento','192.168.1.5'),(16789,'18:40:12','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16790,'18:40:12','2017-05-17','almasunshine','Insertar','registro de Factura como documento modificador de inventario: 6','encabezado_documento','192.168.1.5'),(16791,'19:18:04','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16792,'19:21:33','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16793,'19:30:49','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16794,'19:41:32','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16795,'19:50:27','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16796,'20:04:11','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16797,'20:09:02','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16798,'20:09:03','2017-05-17','almasunshine','Insertar','registro de Factura como documento modificador de inventario: 7','encabezado_documento','192.168.1.5'),(16799,'20:10:34','2017-05-17','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 18','encabezado_documento','192.168.1.5'),(16800,'20:29:29','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16801,'20:38:10','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16802,'20:38:30','2017-05-17','almasunshine','Insertar','registro de  orden de compra como documento modificador de inventario: 19','encabezado_documento','192.168.1.5'),(16803,'20:41:07','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16804,'20:41:07','2017-05-17','almasunshine','Insertar','registro de Factura como documento modificador de inventario: 8','encabezado_documento','192.168.1.5'),(16805,'20:48:50','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16806,'20:50:14','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16807,'20:52:01','2017-05-17','almasunshine','Insertar','registro de  factura: ','factura','192.168.1.5'),(16808,'20:52:01','2017-05-17','almasunshine','Insertar','registro de Factura como documento modificador de inventario: 9','encabezado_documento','192.168.1.5'),(16809,'22:19:21','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5'),(16810,'22:21:28','2017-05-17','almasunshine','Loggeo exitoso','Login','usuario','192.168.1.5');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora_log`
--

DROP TABLE IF EXISTS `bitacora_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora_log` (
  `id_bit` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `operacion` char(25) NOT NULL,
  `usuario` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_bit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora_log`
--

LOCK TABLES `bitacora_log` WRITE;
/*!40000 ALTER TABLE `bitacora_log` DISABLE KEYS */;
INSERT INTO `bitacora_log` VALUES (20160001,'2016-09-29','09:24:00','Fail Log','jojo'),(20160002,'2016-09-29','09:24:07','Sucessful Log','jojo'),(20160003,'2016-09-29','09:35:01','Fail Log','jojo'),(20160004,'2016-09-29','09:35:08','Sucessful Log','jojo'),(20160005,'2016-09-29','10:22:05','Fail Log','jojo');
/*!40000 ALTER TABLE `bitacora_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bodega` (
  `id_bodega_pk` int(11) NOT NULL AUTO_INCREMENT,
  `ubicacion` char(40) DEFAULT NULL,
  `nombre_bodega` char(40) DEFAULT NULL,
  `tamaño` char(50) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bodega_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
INSERT INTO `bodega` VALUES (2,'central','bodega principal',NULL,'activo',1),(3,'central','bodega 2',NULL,'activo',1),(4,'central','bodega 3',NULL,'activo',1),(5,'sotano','bodeguita',NULL,'inactivo',1);
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `id_categoria_pk` char(18) NOT NULL,
  `tipo_categoria` char(25) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_categoria_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES ('AF','Activos fijos','activo'),('MP','Materia prima','activo'),('otros','Otros','inactivo'),('PT','Producto terminado','activo');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cita`
--

DROP TABLE IF EXISTS `cita`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cita` (
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  PRIMARY KEY (`fecha`,`hora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cita`
--

LOCK TABLES `cita` WRITE;
/*!40000 ALTER TABLE `cita` DISABLE KEYS */;
/*!40000 ALTER TABLE `cita` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compra` (
  `id_factura_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_factura` int(11) DEFAULT NULL,
  `id_pedido_compra_pk` int(11) NOT NULL,
  `serie_factura` char(15) DEFAULT NULL,
  `fecha_recibida` date DEFAULT NULL,
  `encargado` char(20) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_cuenta_pk` int(11) DEFAULT NULL,
  `id_proveedor_pk` int(11) DEFAULT NULL,
  `id_forma_pk` int(11) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  `estado_compra` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_factura_compra_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES (1,NULL,1,'A','2016-03-15',NULL,NULL,'activo',NULL,1,NULL,1,'procesada'),(3,NULL,1,NULL,'2016-10-31',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(4,NULL,1,NULL,'2016-10-31',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(5,NULL,1,NULL,'2016-10-31',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(6,NULL,1,NULL,'2016-10-31',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(7,NULL,1,NULL,'2016-11-01',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(8,NULL,1,NULL,'2016-11-07',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(9,NULL,1,NULL,'2016-11-08',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(10,NULL,1,NULL,'2016-11-08',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(11,NULL,1,NULL,'2016-11-09',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(12,NULL,1,NULL,'2016-11-09',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(13,NULL,1,NULL,'2016-11-10',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(14,NULL,1,NULL,'2016-11-10',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(15,NULL,1,NULL,'2017-05-17',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(16,NULL,1,NULL,'2017-05-17',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(17,NULL,1,NULL,'2017-05-17',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(18,NULL,1,NULL,'2017-05-17',NULL,NULL,'activo',NULL,2,NULL,1,'procesada'),(19,NULL,1,NULL,'2017-05-17',NULL,NULL,'activo',NULL,2,NULL,1,'procesada');
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultaalmacenada`
--

DROP TABLE IF EXISTS `consultaalmacenada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultaalmacenada` (
  `id_consulta_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`id_consulta_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultaalmacenada`
--

LOCK TABLES `consultaalmacenada` WRITE;
/*!40000 ALTER TABLE `consultaalmacenada` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultaalmacenada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_compra`
--

DROP TABLE IF EXISTS `detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_compra` (
  `id_detalle_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `precio_compra` decimal(15,0) DEFAULT NULL,
  `subtotal_compra` decimal(15,0) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_compra_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_compra`
--

LOCK TABLES `detalle_compra` WRITE;
/*!40000 ALTER TABLE `detalle_compra` DISABLE KEYS */;
INSERT INTO `detalle_compra` VALUES (1,8,NULL,NULL,'activo',1,2,'MP'),(2,10,NULL,NULL,'activo',1,1,'AF'),(3,5,NULL,NULL,'activo',1,1,'MP'),(6,5,NULL,NULL,'activo',3,1,'AF'),(7,5,NULL,NULL,'activo',3,2,'AF'),(8,2,NULL,NULL,'activo',4,2,'AF'),(9,10,NULL,NULL,'activo',5,1,'MP'),(10,10,NULL,NULL,'activo',5,2,'MP'),(11,1,NULL,NULL,'activo',5,1,'AF'),(12,2,NULL,NULL,'activo',6,1,'MP'),(13,15,NULL,NULL,'activo',7,3,'MP'),(14,10,NULL,NULL,'activo',8,1,'MP'),(15,10,NULL,NULL,'activo',9,2,'MP'),(16,10,NULL,NULL,'activo',9,1,'MP'),(17,7,NULL,NULL,'activo',10,1,'MP'),(18,7,NULL,NULL,'activo',10,3,'MP'),(19,1,NULL,NULL,'activo',11,3,'MP'),(20,1,NULL,NULL,'activo',11,2,'MP'),(21,1,NULL,NULL,'activo',12,1,'MP'),(22,1,NULL,NULL,'activo',12,3,'MP'),(23,88,NULL,NULL,'activo',13,5,'MP'),(24,8,NULL,NULL,'activo',14,2,'MP'),(25,1,NULL,NULL,'activo',15,5,'MP'),(26,20,NULL,NULL,'activo',16,1,'MP'),(27,5,NULL,NULL,'activo',16,2,'AF'),(28,8,NULL,NULL,'activo',17,2,'AF'),(29,1,NULL,NULL,'activo',18,2,'AF'),(30,50,NULL,NULL,'activo',19,1,'PT');
/*!40000 ALTER TABLE `detalle_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_devolucion_compra`
--

DROP TABLE IF EXISTS `detalle_devolucion_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_devolucion_compra` (
  `id_detalle_devolucion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `observaciones` char(100) DEFAULT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `id_devolucion_compra_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_devolucion_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_devolucion_compra`
--

LOCK TABLES `detalle_devolucion_compra` WRITE;
/*!40000 ALTER TABLE `detalle_devolucion_compra` DISABLE KEYS */;
INSERT INTO `detalle_devolucion_compra` VALUES (14,9,'ggh','activo',1,'AF',8),(15,1,'gfhf','activo',2,'AF',8),(16,2,'gff','activo',2,'MP',9),(17,1,'rtr','activo',3,'MP',10),(18,10,'uh','activo',1,'MP',11),(19,10,'dfg','activo',2,'MP',12),(20,1,'df','activo',1,'MP',13),(21,1,'cv','activo',1,'MP',17),(22,10,'kk','activo',2,'MP',18),(23,5,'dsfsd','activo',2,'MP',20),(24,5,'sdf','activo',1,'MP',21),(25,5,'dsf','activo',3,'MP',21),(26,1,'ert','activo',2,'MP',23),(27,1,'gf','activo',2,'MP',25),(28,1,'dfg','activo',1,'AF',28),(29,1,'fgh','activo',3,'MP',29),(30,1,'fd','activo',2,'MP',30),(31,1,'f','activo',2,'AF',30),(32,1,'fg','activo',3,'MP',31),(33,78,'malos','activo',5,'MP',32),(34,1,'hhgjhghj','activo',5,'MP',33);
/*!40000 ALTER TABLE `detalle_devolucion_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_documento`
--

DROP TABLE IF EXISTS `detalle_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_documento` (
  `id_detalle_pk` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `no_doc` char(20) DEFAULT NULL,
  `serie_doc` char(20) DEFAULT NULL,
  `tipo_doc` char(40) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `empresa` char(20) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_documento`
--

LOCK TABLES `detalle_documento` WRITE;
/*!40000 ALTER TABLE `detalle_documento` DISABLE KEYS */;
INSERT INTO `detalle_documento` VALUES (33,2,8,'MP','1','-','Orden de compra','activo','1'),(34,1,10,'AF','1','-','Orden de compra','activo','1'),(35,1,5,'MP','1','-','Orden de compra','activo','1'),(36,1,5,'AF','3','-','Orden de compra','activo','1'),(37,2,5,'AF','3','-','Orden de compra','activo','1'),(38,1,9,'AF','8','-','Devolucion sobre compra','activo','-'),(39,2,1,'AF','8','-','Devolucion sobre compra','activo','-'),(40,2,2,'AF','4','-','Orden de compra','activo','1'),(41,1,10,'MP','5','-','Orden de compra','activo','1'),(42,2,10,'MP','5','-','Orden de compra','activo','1'),(43,1,1,'AF','5','-','Orden de compra','activo','1'),(44,1,2,'MP','6','-','Orden de compra','activo','1'),(45,2,2,'MP','9','-','Devolucion sobre compra','activo','-'),(46,3,15,'MP','7','-','Orden de compra','activo','1'),(47,3,1,'MP','10','-','Devolucion sobre compra','activo','-'),(48,1,2,'AF','1','A','Factura','activo','1'),(49,2,2,'AF','1','A','Factura','activo','1'),(50,1,5,'AF','2','A','Factura','activo','1'),(51,2,8,'AF','3','A','Factura','activo','1'),(52,1,10,'MP','8','-','Orden de compra','activo','1'),(53,1,10,'MP','11','-','Devolucion sobre compra','activo','-'),(54,2,10,'MP','9','-','Orden de compra','activo','1'),(55,1,10,'MP','9','-','Orden de compra','activo','1'),(56,2,10,'MP','12','-','Devolucion sobre compra','activo','-'),(57,1,1,'MP','13','-','Devolucion sobre compra','activo','-'),(58,1,1,'MP','17','-','Devolucion sobre compra','activo','-'),(59,1,5,'MP','4','A','Factura','activo','1'),(60,2,5,'MP','4','A','Factura','activo','1'),(61,1,3,'MP','5','A','Factura','activo','1'),(62,2,10,'MP','18','-','Devolucion sobre compra','activo','-'),(63,2,5,'MP','20','-','Devolucion sobre compra','activo','-'),(64,1,7,'MP','10','-','Orden de compra','activo','1'),(65,3,7,'MP','10','-','Orden de compra','activo','1'),(66,1,5,'MP','21','-','Devolucion sobre compra','activo','-'),(67,3,5,'MP','21','-','Devolucion sobre compra','activo','-'),(68,2,1,'MP','22','-','Devolucion sobre compra','activo','-'),(69,2,1,'MP','23','-','Devolucion sobre compra','activo','-'),(70,2,1,'MP','24','-','Devolucion sobre compra','activo','-'),(71,2,1,'MP','25','-','Devolucion sobre compra','activo','-'),(72,1,1,'AF','26','-','Devolucion sobre compra','activo','-'),(73,1,1,'MP','27','-','Devolucion sobre compra','activo','-'),(74,1,1,'AF','28','-','Devolucion sobre compra','activo','-'),(75,3,1,'MP','11','-','Orden de compra','activo','1'),(76,2,1,'MP','11','-','Orden de compra','activo','1'),(77,3,1,'MP','29','-','Devolucion sobre compra','activo','-'),(78,1,1,'MP','12','-','Orden de compra','activo','1'),(79,3,1,'MP','12','-','Orden de compra','activo','1'),(80,2,1,'MP','30','-','Devolucion sobre compra','activo','-'),(81,2,1,'AF','30','-','Devolucion sobre compra','activo','-'),(82,3,1,'MP','31','-','Devolucion sobre compra','activo','-'),(83,5,88,'MP','13','-','Orden de compra','activo','1'),(84,5,78,'MP','32','-','Devolucion sobre compra','activo','-'),(85,2,8,'MP','14','-','Orden de compra','activo','1'),(86,5,1,'MP','15','-','Orden de compra','activo','1'),(87,5,1,'MP','33','-','Devolucion sobre compra','activo','-'),(88,1,20,'MP','16','-','Orden de compra','activo','1'),(89,2,5,'AF','16','-','Orden de compra','activo','1'),(90,2,1,'AF','4','-','Factura','activo','-'),(91,1,1,'AF','4','-','Factura','activo','-'),(92,2,1,'AF','5','-','Factura','activo','-'),(93,1,1,'AF','5','-','Factura','activo','-'),(94,2,8,'AF','17','-','Orden de compra','activo','1'),(95,2,2,'AF','6','-','Factura','activo','-'),(96,2,1,'AF','7','-','Factura','activo','-'),(97,2,1,'AF','18','-','Orden de compra','activo','1'),(98,1,50,'PT','19','-','Orden de compra','activo','1'),(99,1,2,'PT','8','-','Factura','activo','-'),(100,2,1,'MP','8','-','Factura','activo','-'),(101,1,20,'MP','9','-','Factura','activo','-'),(102,3,2,'MP','9','-','Factura','activo','-');
/*!40000 ALTER TABLE `detalle_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_fact`
--

DROP TABLE IF EXISTS `detalle_fact`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_fact` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `correlativo_fac` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `precio` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_detalle`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_fact`
--

LOCK TABLES `detalle_fact` WRITE;
/*!40000 ALTER TABLE `detalle_fact` DISABLE KEYS */;
INSERT INTO `detalle_fact` VALUES (1,5,'activo',2,2,'AF',0),(2,5,'activo',2,1,'AF',0),(3,1,'activo',3,2,'AF',0),(4,1,'activo',3,1,'AF',0),(5,1,'activo',4,2,'AF',0),(6,1,'activo',4,1,'AF',0),(7,1,'activo',5,2,'AF',0),(8,1,'activo',5,1,'AF',0),(9,2,'activo',6,2,'AF',0),(10,1,'activo',7,2,'AF',0),(11,2,'activo',8,1,'PT',35),(12,1,'activo',8,2,'MP',0),(13,20,'activo',9,1,'MP',25),(14,2,'activo',9,3,'MP',15);
/*!40000 ALTER TABLE `detalle_fact` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_muestreo`
--

DROP TABLE IF EXISTS `detalle_muestreo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_muestreo` (
  `id_muestreo_pk` int(11) NOT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `existencia_auditada` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_muestreo`
--

LOCK TABLES `detalle_muestreo` WRITE;
/*!40000 ALTER TABLE `detalle_muestreo` DISABLE KEYS */;
INSERT INTO `detalle_muestreo` VALUES (8,'encontkjnrjkmkje',8,2,2,'AF',NULL,'11'),(9,'enonthghd',88,1,2,'AF',NULL,'99'),(11,'dsjfhksajhkjshksjh',88,1,2,'AF',NULL,'100'),(4,'rtyu',8,2,2,'AF',NULL,'44'),(4,'enoctgd',88,1,2,'AF',NULL,'100');
/*!40000 ALTER TABLE `detalle_muestreo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_requisicion`
--

DROP TABLE IF EXISTS `detalle_requisicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_requisicion` (
  `id_detalle_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `id_requisicion_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_requisicion_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_requisicion`
--

LOCK TABLES `detalle_requisicion` WRITE;
/*!40000 ALTER TABLE `detalle_requisicion` DISABLE KEYS */;
INSERT INTO `detalle_requisicion` VALUES (17,7,'activo',1,'MP',18),(18,5,'activo',2,'MP',18),(19,1,'activo',1,'AF',18),(20,1,'activo',2,'AF',19),(21,1,'activo',1,'AF',19),(22,2,'activo',2,'AF',20),(23,2,'activo',1,'AF',20),(24,1,'activo',1,'MP',21),(25,3,'activo',2,'AF',22),(26,3,'activo',1,'AF',22),(27,4,'activo',1,'AF',23),(28,4,'activo',2,'AF',23),(29,5,'activo',1,'AF',24),(30,5,'activo',2,'AF',24),(31,2,'activo',2,'AF',25),(32,10,'activo',1,'MP',26),(33,10,'activo',2,'MP',26),(34,1,'activo',1,'AF',26),(35,2,'activo',1,'MP',27),(36,15,'activo',3,'MP',28),(37,10,'activo',1,'MP',29),(38,10,'activo',2,'MP',30),(39,10,'activo',1,'MP',30),(40,7,'activo',1,'MP',31),(41,7,'activo',3,'MP',31),(42,1,'activo',3,'MP',32),(43,1,'activo',2,'MP',32),(44,1,'activo',1,'MP',33),(45,1,'activo',3,'MP',33),(46,88,'activo',5,'MP',34),(47,8,'activo',2,'MP',35),(48,1,'activo',5,'MP',36),(49,20,'activo',1,'MP',37),(50,5,'activo',2,'AF',37),(51,8,'activo',2,'AF',38),(52,1,'activo',2,'AF',39),(53,50,'activo',1,'PT',40);
/*!40000 ALTER TABLE `detalle_requisicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucion_compra`
--

DROP TABLE IF EXISTS `devolucion_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devolucion_compra` (
  `id_devolucion_compra_pk` int(11) NOT NULL AUTO_INCREMENT,
  `encargado` char(25) DEFAULT NULL,
  `fecha_devolucion` char(25) DEFAULT NULL,
  `estado` char(25) DEFAULT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_factura_compra_pk` int(11) NOT NULL,
  `id_proveedor_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_devolucion_compra_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion_compra`
--

LOCK TABLES `devolucion_compra` WRITE;
/*!40000 ALTER TABLE `devolucion_compra` DISABLE KEYS */;
INSERT INTO `devolucion_compra` VALUES (8,'george','2016-10-31','activo',2,1,1),(9,'jose luis','2016-10-31','activo',4,6,2),(10,'jose luis','2016-11-01','activo',4,1,1),(11,'Luis','2016-11-07','activo',2,8,1),(12,'Jose','2016-11-08','activo',2,4,2),(13,'Jorge','2016-11-08','activo',2,1,1),(17,'','2016-11-08','activo',2,1,1),(18,'julio','2016-11-08','activo',2,9,1),(19,'','2016-11-08','activo',2,5,1),(20,'jose','2016-11-08','activo',2,5,1),(21,'Tulio','2016-11-08','activo',4,10,1),(22,'Jose Luis','2016-11-08','activo',2,9,1),(23,'Jose Luis','2016-11-08','activo',2,9,1),(24,'Jose Luis','2016-11-08','activo',2,9,1),(25,'Jose Luis','2016-11-08','activo',2,9,1),(26,'Marvin','2016-11-08','activo',2,3,1),(27,'julio','2016-11-08','activo',2,5,1),(28,'JulioCesar','2016-11-08','activo',2,5,1),(29,'yoni','2016-11-09','activo',4,1,1),(30,'jhk','2016-11-09','activo',3,1,1),(31,'dfgd','2016-11-09','activo',3,1,1),(32,'Javier','2016-11-10','activo',2,1,2),(33,'jose','2017-05-17','activo',2,1,1);
/*!40000 ALTER TABLE `devolucion_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `id_empleados_pk` char(10) NOT NULL,
  `nombre` char(10) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  `direccion` char(10) DEFAULT NULL,
  `genero` char(10) DEFAULT NULL,
  `fecha_nacimiento` char(10) DEFAULT NULL,
  `fecha_ingreso` char(10) DEFAULT NULL,
  `fecha_egreso` char(10) DEFAULT NULL,
  `dpi` char(10) DEFAULT NULL,
  `no_afiliacion_igss` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  PRIMARY KEY (`id_empleados_pk`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('1','juan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `id_empresa_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `direccion` varchar(30) NOT NULL,
  `region` char(20) NOT NULL,
  `estrellas_hotel` varchar(15) NOT NULL,
  `nit` char(10) DEFAULT NULL,
  `correo` char(35) DEFAULT NULL,
  `telefono` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_empresa_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` VALUES (1,'Miempresa','45calle','capital','3',NULL,NULL,NULL,'activo'),(2,'Miempresa2','15calle','capital','3',NULL,NULL,NULL,'activo');
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_documento`
--

DROP TABLE IF EXISTS `encabezado_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_documento` (
  `no_doc` char(18) NOT NULL,
  `serie_doc` char(18) NOT NULL,
  `tipo_doc` char(25) NOT NULL,
  `fecha` char(20) DEFAULT NULL,
  `empresa` char(20) NOT NULL,
  `estado_doc` char(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `clie_prov` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_doc`,`serie_doc`,`tipo_doc`,`empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_documento`
--

LOCK TABLES `encabezado_documento` WRITE;
/*!40000 ALTER TABLE `encabezado_documento` DISABLE KEYS */;
INSERT INTO `encabezado_documento` VALUES ('1','-','Orden de compra','2016-03-15','1','procesado','activo',1),('1','A','Factura','2016-11-01','1','procesado','activo',NULL),('10','-','Devolucion sobre compra','2016-11-01','-','procesado','activo',1),('10','-','Orden de compra','2016-11-08','1','procesado','activo',2),('11','-','Devolucion sobre compra','2016-11-07','-','procesado','activo',1),('11','-','Orden de compra','2016-11-09','1','procesado','activo',2),('12','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',2),('12','-','Orden de compra','2016-11-09','1','procesado','activo',2),('13','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('13','-','Orden de compra','2016-11-10','1','procesado','activo',2),('14','-','Orden de compra','2016-11-10','1','procesado','activo',2),('15','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('15','-','Orden de compra','2017-05-17','1','procesado','activo',2),('16','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('16','-','Orden de compra','2017-05-17','1','procesado','activo',2),('17','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('17','-','Orden de compra','2017-05-17','1','procesado','activo',2),('18','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('18','-','Orden de compra','2017-05-17','1','procesado','activo',2),('19','-','Orden de compra','2017-05-17','1','procesado','activo',2),('2','A','Factura','2016-11-01','1','procesado','activo',NULL),('20','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('21','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('22','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('23','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('24','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('25','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('26','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('27','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('28','-','Devolucion sobre compra','2016-11-08','-','procesado','activo',1),('29','-','Devolucion sobre compra','2016-11-09','-','procesado','activo',1),('3','-','Orden de compra','2016-10-31','1','procesado','activo',2),('3','A','Factura','2016-11-01','1','procesado','activo',NULL),('30','-','Devolucion sobre compra','2016-11-09','-','procesado','activo',1),('31','-','Devolucion sobre compra','2016-11-09','-','procesado','activo',1),('32','-','Devolucion sobre compra','2016-11-10','-','procesado','activo',2),('33','-','Devolucion sobre compra','2017-05-17','-','procesado','activo',1),('4','-','Factura','2017-05-17','-','procesado','activo',0),('4','-','Orden de compra','2016-10-31','1','procesado','activo',2),('4','A','Factura','2016-11-08','1','procesado','activo',NULL),('5','-','Factura','2017-05-17','-','procesado','activo',0),('5','-','Orden de compra','2016-10-31','1','procesado','activo',2),('5','A','Factura','2016-11-08','1','procesado','activo',NULL),('6','-','Factura','2017-05-17','-','procesado','activo',0),('6','-','Orden de compra','2016-10-31','1','procesado','activo',2),('7','-','Factura','2017-05-17','-','procesado','activo',0),('7','-','Orden de compra','2016-11-01','1','procesado','activo',2),('8','-','Devolucion sobre compra','2016-10-31','-','procesado','activo',1),('8','-','Factura','2017-05-17','-','procesado','activo',0),('8','-','Orden de compra','2016-11-07','1','procesado','activo',2),('9','-','Devolucion sobre compra','2016-10-31','-','procesado','activo',2),('9','-','Factura','2017-05-17','-','procesado','activo',0),('9','-','Orden de compra','2016-11-08','1','procesado','activo',2);
/*!40000 ALTER TABLE `encabezado_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_factura`
--

DROP TABLE IF EXISTS `encabezado_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_factura` (
  `correlativo_fac` int(11) NOT NULL AUTO_INCREMENT,
  `nit` char(50) DEFAULT NULL,
  `nombres` char(50) DEFAULT NULL,
  `apellidos` char(50) DEFAULT NULL,
  `direccion` char(50) DEFAULT NULL,
  PRIMARY KEY (`correlativo_fac`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_factura`
--

LOCK TABLES `encabezado_factura` WRITE;
/*!40000 ALTER TABLE `encabezado_factura` DISABLE KEYS */;
INSERT INTO `encabezado_factura` VALUES (1,'93890-4','carlos','lopez','ciudad'),(2,'8888888888','josuesito','josuesito','ciudad'),(3,'7787878788','josesito','josesito','ciudad'),(4,'8976545645656','josesote','josesote','ciudad'),(5,'54665465','sdfsa','sfsdf','dfasd'),(6,'65465313156','carlitos','carlitos','ciudad'),(7,'7897545','dsfas','sdfas','dfsaf'),(8,'203131656','potto','potto','ciudad'),(9,'125865','julio','julio','ciudad');
/*!40000 ALTER TABLE `encabezado_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_muestreo`
--

DROP TABLE IF EXISTS `encabezado_muestreo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `encabezado_muestreo` (
  `id_muestreo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `responsable` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_muestreo_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_muestreo`
--

LOCK TABLES `encabezado_muestreo` WRITE;
/*!40000 ALTER TABLE `encabezado_muestreo` DISABLE KEYS */;
INSERT INTO `encabezado_muestreo` VALUES (3,'2016-10-27','jose luis','activo'),(4,'2016-10-21','eduardo del aguila','activo'),(5,'2016-10-28','carlos','activo'),(6,'2016-10-28','jorge','activo'),(7,'2016-10-28','yoni','activo'),(8,'2016-10-28','fernando','activo'),(9,'2016-10-28','luis','activo'),(10,'2016-10-28','geg','activo'),(11,'2016-11-09','cualquiera','activo');
/*!40000 ALTER TABLE `encabezado_muestreo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `linea`
--

DROP TABLE IF EXISTS `linea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `linea` (
  `id_linea_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_linea` char(35) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_linea_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `linea`
--

LOCK TABLES `linea` WRITE;
/*!40000 ALTER TABLE `linea` DISABLE KEYS */;
INSERT INTO `linea` VALUES (1,'electronicos','AF','activo'),(2,'vehiculos','AF','activo'),(3,'lacteos','MP','activo'),(4,'Salsas','MP','activo'),(5,'condimentos','MP','activo'),(6,'Platillo principal','PT','activo'),(7,'Otro','AF','inactivo');
/*!40000 ALTER TABLE `linea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca` (
  `id_marca_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` char(50) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'Pepsi','activo'),(2,'Coca-cola','activo'),(3,'Naturas','activo'),(4,'Ketchup','activo'),(5,'Colgate','activo'),(6,'Oster','activo'),(7,'Samsung','activo'),(8,'Toyota','activo'),(9,'Maller','activo'),(10,'toshiba','activo'),(11,'HSCD','activo'),(12,'AOC','inactivo');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca_producto`
--

DROP TABLE IF EXISTS `marca_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca_producto` (
  `id_marca_pk` int(11) NOT NULL,
  `id_bien_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `fecha` date DEFAULT NULL,
  `precio` decimal(10,0) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_marca_pk`,`id_bien_pk`,`id_categoria_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca_producto`
--

LOCK TABLES `marca_producto` WRITE;
/*!40000 ALTER TABLE `marca_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medida`
--

DROP TABLE IF EXISTS `medida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medida` (
  `id_medida_pk` int(11) NOT NULL AUTO_INCREMENT,
  `valor` char(10) DEFAULT NULL,
  `nombre_medida` char(30) DEFAULT NULL,
  `abreviatura` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_medida_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medida`
--

LOCK TABLES `medida` WRITE;
/*!40000 ALTER TABLE `medida` DISABLE KEYS */;
INSERT INTO `medida` VALUES (1,NULL,'kilogramos','Kg','activo'),(2,NULL,'Libras','Lb','activo'),(3,NULL,'unidades','Unidad','activo'),(4,NULL,'litros','Lts','activo');
/*!40000 ALTER TABLE `medida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_inventario`
--

DROP TABLE IF EXISTS `movimiento_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento_inventario` (
  `id_movimiento_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_mov` date DEFAULT NULL,
  `transaccion` char(40) DEFAULT NULL,
  `id_bodega_pk` int(11) DEFAULT NULL,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_categoria_pk` char(18) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `no_doc` char(20) DEFAULT NULL,
  `serie_doc` char(20) DEFAULT NULL,
  `tipo_doc` char(40) DEFAULT NULL,
  `empresa` char(20) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_movimiento_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_inventario`
--

LOCK TABLES `movimiento_inventario` WRITE;
/*!40000 ALTER TABLE `movimiento_inventario` DISABLE KEYS */;
INSERT INTO `movimiento_inventario` VALUES (12,'2016-10-31','Compra',2,2,'MP',8,'1','-','Orden de compra','1','activo'),(13,'2016-10-31','Compra',2,1,'AF',10,'1','-','Orden de compra','1','activo'),(14,'2016-10-31','Compra',2,1,'MP',5,'1','-','Orden de compra','1','activo'),(15,'2016-10-31','Compra',2,1,'AF',5,'3','-','Orden de compra','1','activo'),(16,'2016-10-31','Compra',2,2,'AF',5,'3','-','Orden de compra','1','activo'),(17,'2016-10-31','Devolucion sobre compra',2,1,'AF',9,'8','-','Devolucion sobre compra','-','activo'),(18,'2016-10-31','Devolucion sobre compra',2,2,'AF',1,'8','-','Devolucion sobre compra','-','activo'),(19,'2016-10-31','Compra',3,2,'AF',2,'4','-','Orden de compra','1','activo'),(20,'2016-10-31','Compra',4,1,'MP',10,'5','-','Orden de compra','1','activo'),(21,'2016-10-31','Compra',4,2,'MP',10,'5','-','Orden de compra','1','activo'),(22,'2016-10-31','Compra',3,1,'AF',1,'5','-','Orden de compra','1','activo'),(23,'2016-10-31','Compra',4,1,'MP',2,'6','-','Orden de compra','1','activo'),(24,'2016-10-31','Devolucion sobre compra',4,2,'MP',2,'9','-','Devolucion sobre compra','-','activo'),(25,'2016-11-01','Compra',4,3,'MP',15,'7','-','Orden de compra','1','activo'),(26,'2016-11-01','Devolucion sobre compra',4,3,'MP',1,'10','-','Devolucion sobre compra','-','activo'),(27,'2016-11-01','Venta',2,1,'AF',2,'1','A','Factura','1','activo'),(28,'2016-11-01','Venta',2,2,'AF',2,'1','A','Factura','1','activo'),(29,'2016-11-01','Venta',2,1,'AF',5,'2','A','Factura','1','activo'),(30,'2016-11-07','Compra',2,1,'MP',10,'8','-','Orden de compra','1','activo'),(31,'2016-11-07','Devolucion sobre compra',2,1,'MP',10,'11','-','Devolucion sobre compra','-','activo'),(32,'2016-11-08','Compra',2,2,'MP',10,'9','-','Orden de compra','1','activo'),(33,'2016-11-08','Compra',2,1,'MP',10,'9','-','Orden de compra','1','activo'),(34,'2016-11-08','Venta',2,2,'AF',8,'3','A','Factura','1','activo'),(35,'2016-11-08','Devolucion sobre compra',2,2,'MP',10,'12','-','Devolucion sobre compra','-','activo'),(36,'2016-11-08','Devolucion sobre compra',2,1,'MP',1,'13','-','Devolucion sobre compra','-','activo'),(37,'2016-11-08','Devolucion sobre compra',2,1,'MP',1,'17','-','Devolucion sobre compra','-','activo'),(38,'2016-11-08','Venta',2,1,'MP',5,'4','A','Factura','1','activo'),(39,'2016-11-08','Venta',2,2,'MP',5,'4','A','Factura','1','activo'),(40,'2016-11-08','Devolucion sobre compra',2,2,'MP',10,'18','-','Devolucion sobre compra','-','activo'),(41,'2016-11-08','Devolucion sobre compra',2,2,'MP',5,'20','-','Devolucion sobre compra','-','activo'),(42,'2016-11-08','Compra',4,1,'MP',7,'10','-','Orden de compra','1','activo'),(43,'2016-11-08','Compra',4,3,'MP',7,'10','-','Orden de compra','1','activo'),(44,'2016-11-08','Devolucion sobre compra',4,1,'MP',5,'21','-','Devolucion sobre compra','-','activo'),(45,'2016-11-08','Devolucion sobre compra',4,3,'MP',5,'21','-','Devolucion sobre compra','-','activo'),(46,'2016-11-08','Devolucion sobre compra',2,2,'MP',1,'22','-','Devolucion sobre compra','-','activo'),(47,'2016-11-08','Devolucion sobre compra',2,2,'MP',1,'23','-','Devolucion sobre compra','-','activo'),(48,'2016-11-08','Devolucion sobre compra',2,2,'MP',1,'24','-','Devolucion sobre compra','-','activo'),(49,'2016-11-08','Devolucion sobre compra',2,2,'MP',1,'25','-','Devolucion sobre compra','-','activo'),(50,'2016-11-08','Devolucion sobre compra',2,1,'AF',1,'26','-','Devolucion sobre compra','-','activo'),(51,'2016-11-08','Devolucion sobre compra',2,1,'MP',1,'27','-','Devolucion sobre compra','-','activo'),(52,'2016-11-08','Devolucion sobre compra',2,1,'AF',1,'28','-','Devolucion sobre compra','-','activo'),(53,'2016-11-09','Compra',4,3,'MP',1,'11','-','Orden de compra','1','activo'),(54,'2016-11-09','Compra',4,2,'MP',1,'11','-','Orden de compra','1','activo'),(55,'2016-11-09','Devolucion sobre compra',4,3,'MP',1,'29','-','Devolucion sobre compra','-','activo'),(56,'2016-11-09','Compra',2,1,'MP',1,'12','-','Orden de compra','1','activo'),(57,'2016-11-09','Compra',3,3,'MP',1,'12','-','Orden de compra','1','activo'),(58,'2016-11-09','Devolucion sobre compra',3,2,'MP',1,'30','-','Devolucion sobre compra','-','activo'),(59,'2016-11-09','Devolucion sobre compra',3,2,'AF',1,'30','-','Devolucion sobre compra','-','activo'),(60,'2016-11-09','Devolucion sobre compra',3,3,'MP',1,'31','-','Devolucion sobre compra','-','activo'),(61,'2016-11-10','Compra',2,5,'MP',88,'13','-','Orden de compra','1','activo'),(62,'2016-11-10','Devolucion sobre compra',2,5,'MP',78,'32','-','Devolucion sobre compra','-','activo'),(63,'2016-11-10','Venta',2,1,'MP',3,'5','A','Factura','1','activo'),(64,'2016-11-10','Compra',2,2,'MP',8,'14','-','Orden de compra','1','activo'),(65,'2017-05-17','Compra',2,5,'MP',1,'15','-','Orden de compra','1','activo'),(66,'2017-05-17','Devolucion sobre compra',2,5,'MP',1,'33','-','Devolucion sobre compra','-','activo'),(67,'2017-05-17','Compra',2,1,'MP',20,'16','-','Orden de compra','1','activo'),(68,'2017-05-17','Compra',3,2,'AF',5,'16','-','Orden de compra','1','activo'),(69,'2017-05-17','Venta',2,2,'AF',1,'4','-','Factura','-','activo'),(70,'2017-05-17','Venta',2,1,'AF',1,'4','-','Factura','-','activo'),(71,'2017-05-17','Venta',2,2,'AF',1,'5','-','Factura','-','activo'),(72,'2017-05-17','Venta',2,1,'AF',1,'5','-','Factura','-','activo'),(73,'2017-05-17','Compra',2,2,'AF',8,'17','-','Orden de compra','1','activo'),(74,'2017-05-17','Venta',2,2,'AF',2,'6','-','Factura','-','activo'),(75,'2017-05-17','Venta',3,2,'AF',1,'7','-','Factura','-','activo'),(76,'2017-05-17','Compra',3,2,'AF',1,'18','-','Orden de compra','1','activo'),(77,'2017-05-17','Compra',2,1,'PT',50,'19','-','Orden de compra','1','activo'),(78,'2017-05-17','Venta',2,1,'PT',2,'8','-','Factura','-','activo'),(79,'2017-05-17','Venta',2,2,'MP',1,'8','-','Factura','-','activo'),(80,'2017-05-17','Venta',2,1,'MP',20,'9','-','Factura','-','activo'),(81,'2017-05-17','Venta',2,3,'MP',2,'9','-','Factura','-','activo');
/*!40000 ALTER TABLE `movimiento_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil`
--

DROP TABLE IF EXISTS `perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_perfil` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil` VALUES (1,'perfil1'),(2,'perfil2'),(3,'perfil3'),(6,'miperfil'),(7,'hgjg'),(8,'miperfil2'),(9,'cajero'),(10,'mesero'),(11,'bodegero'),(12,'PerfilPrueba');
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_privilegios`
--

DROP TABLE IF EXISTS `perfil_privilegios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` tinyint(1) DEFAULT NULL,
  `sel` tinyint(1) DEFAULT NULL,
  `upd` tinyint(1) DEFAULT NULL,
  `del` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`,`id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_privilegios`
--

LOCK TABLES `perfil_privilegios` WRITE;
/*!40000 ALTER TABLE `perfil_privilegios` DISABLE KEYS */;
INSERT INTO `perfil_privilegios` VALUES (1,4,0,0,1,0),(1,6,1,0,0,0),(1,7,1,0,0,0),(1,8,1,0,0,0),(2,4,0,0,1,0),(2,6,1,0,0,0),(2,7,1,0,0,0),(2,8,1,0,0,0),(3,6,0,1,0,0),(3,7,1,0,0,0),(3,9,1,1,1,1),(4,6,0,1,0,0),(4,7,1,0,0,0),(5,6,0,0,1,0),(6,6,0,0,1,0),(6,11,1,1,1,1),(7,6,0,0,0,1),(7,10,1,0,1,0),(8,6,0,0,0,1),(9,12,1,0,0,0);
/*!40000 ALTER TABLE `perfil_privilegios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_bodega`
--

DROP TABLE IF EXISTS `producto_bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto_bodega` (
  `id_bien_pk` int(11) NOT NULL,
  `id_bodega_pk` int(11) NOT NULL,
  `id_categoria_pk` char(18) NOT NULL,
  `existencia` int(11) DEFAULT NULL,
  `existencia_congelada` int(11) DEFAULT NULL,
  `existencia_auditada` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`,`id_bodega_pk`,`id_categoria_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_bodega`
--

LOCK TABLES `producto_bodega` WRITE;
/*!40000 ALTER TABLE `producto_bodega` DISABLE KEYS */;
INSERT INTO `producto_bodega` VALUES (1,0,'AF',0,NULL,NULL,NULL),(1,0,'MP',0,NULL,NULL,NULL),(1,0,'PT',0,NULL,NULL,'activo'),(1,2,'AF',75,88,100,'activo'),(1,2,'MP',26,NULL,NULL,'activo'),(1,2,'PT',48,NULL,NULL,'activo'),(1,3,'AF',1,NULL,NULL,'activo'),(1,4,'AF',1,NULL,NULL,'activo'),(1,4,'MP',14,NULL,NULL,'activo'),(2,0,'AF',0,NULL,NULL,NULL),(2,0,'MP',0,NULL,NULL,NULL),(2,2,'AF',12,8,44,'activo'),(2,2,'MP',68,NULL,NULL,'activo'),(2,3,'AF',6,NULL,NULL,'activo'),(2,3,'MP',2,NULL,NULL,'activo'),(2,4,'MP',9,NULL,NULL,'activo'),(3,0,'MP',0,NULL,NULL,'activo'),(3,2,'MP',2,NULL,NULL,'activo'),(3,3,'MP',0,NULL,NULL,'activo'),(3,4,'MP',16,NULL,NULL,'activo'),(4,0,'MP',0,NULL,NULL,'activo'),(5,0,'MP',0,NULL,NULL,'activo'),(5,2,'MP',20,NULL,NULL,'activo');
/*!40000 ALTER TABLE `producto_bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `id_proveedor_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` char(25) DEFAULT NULL,
  `direccion` date DEFAULT NULL,
  `telefono` char(15) DEFAULT NULL,
  `correo_electronico` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'El guayo',NULL,NULL,NULL,'activo'),(2,'El sol S.A.',NULL,NULL,NULL,'activo');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporteador`
--

DROP TABLE IF EXISTS `reporteador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reporteador` (
  `id_reporteador` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  `ubicacion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_reporteador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporteador`
--

LOCK TABLES `reporteador` WRITE;
/*!40000 ALTER TABLE `reporteador` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporteador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requisicion`
--

DROP TABLE IF EXISTS `requisicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requisicion` (
  `id_requisicion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `encargado` char(50) DEFAULT NULL,
  `estado` char(15) DEFAULT 'ACTIVO',
  `id_bodega_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_requisicion_pk`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisicion`
--

LOCK TABLES `requisicion` WRITE;
/*!40000 ALTER TABLE `requisicion` DISABLE KEYS */;
INSERT INTO `requisicion` VALUES (18,'2016-10-27','Jose Luis','activo',2),(19,'2016-10-27','Jorge','activo',2),(20,'2016-10-31','Julio','activo',2),(21,'2016-10-31','jose','activo',2),(22,'2016-10-31','jorge','activo',2),(23,'2016-10-31','pol','activo',2),(24,'2016-10-31','federico','activo',2),(25,'2016-10-31','jorge jose','activo',2),(26,'2016-10-31','Carlitos','activo',2),(27,'2016-10-31','paul','activo',2),(28,'2016-11-01','Saul','activo',4),(29,'2016-11-07','Carlos','activo',2),(30,'2016-11-08','Luis','activo',2),(31,'2016-11-08','Paul','activo',2),(32,'2016-11-09','Julito','activo',4),(33,'2016-11-09','jorge','activo',2),(34,'2016-11-10','Javier','activo',2),(35,'2016-11-10','Javier','activo',2),(36,'2017-05-17','jose','activo',2),(37,'2017-05-17','jose','activo',2),(38,'2017-05-17','josuesito','activo',2),(39,'2017-05-17','jose luis','activo',3),(40,'2017-05-17','potto','activo',2);
/*!40000 ALTER TABLE `requisicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_doc_inv`
--

DROP TABLE IF EXISTS `tipo_doc_inv`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_doc_inv` (
  `id_tipo_pk` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tipo` char(55) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_doc_inv`
--

LOCK TABLES `tipo_doc_inv` WRITE;
/*!40000 ALTER TABLE `tipo_doc_inv` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_doc_inv` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaccion`
--

DROP TABLE IF EXISTS `transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaccion` (
  `id_transaccion_pk` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_transaccion` char(40) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_transaccion_pk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaccion`
--

LOCK TABLES `transaccion` WRITE;
/*!40000 ALTER TABLE `transaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `transaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('Aguila Poderosa','123','2016-10-17',NULL,NULL),('AguilaPoderosa','123','2016-10-17',NULL,NULL),('almasinja','aABvAGwAYQA=','2017-03-22','1',1),('almasunshine','aABvAGwAYQA=',NULL,'1',1),('bodegero1','123','2016-10-17',NULL,NULL),('galvez','galvez','2016-10-16',NULL,NULL),('green','ZwByAGUAZQBuAA==','2016-10-20','1',1),('juan','juan','2016-10-17','1',1),('MiUsuario','MQAyADMA','2016-10-25','1',1),('otto','MQAyADMA',NULL,NULL,NULL),('perez','perez','2016-10-16',NULL,NULL),('raul','raul','2016-10-16',NULL,NULL),('usuariodbs','aABvAGwAYQA=',NULL,NULL,NULL),('walter','dwBhAGwAdABlAHIA','2016-11-06','1',1),('yonito','eQBvAG4AaQB0AG8A','2016-10-21','1',1),('yun','eQB1AG4A','2016-10-20','1',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_privilegios`
--

DROP TABLE IF EXISTS `usuario_privilegios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_privilegios` (
  `usuario` char(50) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ins` tinyint(1) DEFAULT NULL,
  `sel` tinyint(1) DEFAULT NULL,
  `upd` tinyint(1) DEFAULT NULL,
  `del` tinyint(1) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`,`id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_privilegios`
--

LOCK TABLES `usuario_privilegios` WRITE;
/*!40000 ALTER TABLE `usuario_privilegios` DISABLE KEYS */;
INSERT INTO `usuario_privilegios` VALUES ('Aguila Poderosa',3,1,1,1,1,9),('AguilaPoderosa',3,1,1,1,1,9),('almasinja',10111,0,1,0,0,0),('asopotamadre',7,0,0,1,0,0),('bodegero1',6,1,1,1,1,11),('galvez',1,1,0,0,0,6),('galvez',2,1,0,0,0,6),('galvez',3,1,1,1,1,9),('galvez',7,0,0,0,1,6),('galvez',8,0,0,0,1,6),('green',2,1,0,0,0,0),('juan',1,1,0,0,0,8),('juan',2,1,0,0,0,8),('MiUsuario',1,1,0,0,0,8),('MiUsuario',2,1,0,0,0,8),('MiUsuario',3,0,1,1,0,0),('MiUsuario',4,0,1,1,0,0),('MiUsuario',10201,0,1,1,0,0),('perez',1,1,0,0,0,8),('perez',6,0,1,0,0,0),('raul',5,0,1,1,0,0),('raul',7,0,1,1,0,0),('walter',10101,0,1,0,0,0),('walter',10102,1,1,0,0,0),('walter',10103,0,1,0,0,0),('walter',10104,0,1,0,0,0),('walter',10105,0,1,0,0,0),('walter',10106,0,1,0,0,0),('walter',10107,0,1,0,0,0),('walter',10108,0,1,0,0,0),('walter',10109,0,1,0,0,0),('walter',10110,0,1,0,0,0),('walter',10111,0,1,0,0,0),('walter',10112,0,1,0,0,0),('walter',10113,0,1,0,0,0),('walter',10114,0,1,0,0,0),('yonito',3,0,1,0,0,0),('yun',2,1,0,0,0,0);
/*!40000 ALTER TABLE `usuario_privilegios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sancarlos2'
--

--
-- Dumping routines for database 'sancarlos2'
--
/*!50003 DROP FUNCTION IF EXISTS `generador_correlativo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `generador_correlativo`() RETURNS varchar(10) CHARSET utf8
BEGIN
    DECLARE ultimo_correlativo nvarchar(10) default (SELECT YEAR(curdate()));
    DECLARE vacio int default 0;
    DEClARE correlativo_cursor CURSOR FOR
    SELECT id_bit FROM bitacora ORDER BY id_bit DESC LIMIT 1;
    DECLARE CONTINUE HANDLER
    FOR NOT FOUND SET vacio = 1;
    OPEN correlativo_cursor;
    FETCH correlativo_cursor INTO ultimo_correlativo;
    CLOSE correlativo_cursor;

    IF vacio = 0 THEN
        SET ultimo_correlativo = ultimo_correlativo + 1;
    ELSEIF vacio = 1 THEN
        SET ultimo_correlativo = concat((SELECT YEAR(curdate())),'0001');
    END IF;
    RETURN(ultimo_correlativo);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `miloop` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `miloop`(NUM INT) RETURNS int(11)
BEGIN
DECLARE CONT INT default 0;
lop: LOOP
set NUM = NUM +1;
set CONT = CONT +1;
IF NUM = 10 THEN
LEAVE lop;
END IF;

END LOOP lop;
return CONT;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `mostrarloop` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `mostrarloop`(cad varchar(10), num int) RETURNS varchar(15) CHARSET utf8
BEGIN
DECLARE resultado varchar(15);  
DECLARE cont int DEFAULT 0;
miloop: LOOP
set cont = cont+1;
if cont =num then
leave miloop;
end if;

set resultado = concat(resultado,resultado); 
END LOOP miloop;
return resultado;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `ObtenerCorrelativoBien` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `ObtenerCorrelativoBien`(categoria nvarchar(18)) RETURNS int(11)
IF (select count(*) from bien where id_categoria_pk = categoria) > 0 THEN
BEGIN
DECLARE ult_corr int; 
DECLARE nuevo_corr int; 
select max(id_bien_pk) into ult_corr from bien where id_categoria_pk = categoria;
set nuevo_corr = ult_corr + 1; 
return nuevo_corr;
END;
ELSE 
return 1;
END IF ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `registraroperacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion`(iusuario nvarchar(100), iaccion nvarchar(500), idescrip nvarchar(500),itabla nvarchar(50), iip nvarchar(20)) RETURNS int(2)
BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `salidafunc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `salidafunc`(id INT) RETURNS varchar(20) CHARSET utf8
BEGIN
DECLARE des varchar(20);
select descripcion into des from bien where id_bien_pk = id;
return des;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `ValidarContrasena` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena`(iusuario nvarchar(20), icon nvarchar(20), iip nvarchar(20)) RETURNS int(2)
IF EXISTS (select usuario from usuario where usuario = iusuario) THEN
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
return 3;
insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,'Fallo loggeo','Login','usuario',iip);
END IF ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `kardex` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `kardex`( fecha_inicio char(20), fecha_fin char(20) , T_inicial char(20))
begin 
DECLARE T int;
SET @T:= T_inicial;
SELECT id_movimiento_pk, fecha_mov, id_bien_pk , id_categoria_pk , transaccion ,cantidad  ,IF( transaccion  ='Compra' or transaccion = 'Devolucion sobre venta' ,(@T:=@T+cantidad),(@T:=@T-cantidad )) AS Saldo FROM movimiento_inventario where fecha_mov between fecha_inicio and fecha_fin ;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MostrarCursor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarCursor`(model int)
BEGIN
DECLARE fin INT DEFAULT FALSE;
DECLARE pl char(20);
DECLARE ma char(20);
DECLARE mo int;
DECLARE micursor CURSOR FOR select placa, marca, modelo from autos;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET fin = TRUE;

open micursor;
loopcursor: LOOP
fetch micursor into pl, ma, mo;
if fin then
leave loopcursor;
end if;

if mo >= model then
insert into autos_recientes (placa, marca, modelo) values (pl,ma,mo);
end if;

END LOOP loopcursor;
close micursor;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `salida` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `salida`(id INT,OUT ndesc VARCHAR(20))
BEGIN
 SELECT descripcion FROM bien WHERE id_bien_pk = id INTO ndesc ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Ultimo_saldo_anterior` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Ultimo_saldo_anterior`( fecha_inicio char(20))
begin 
DECLARE T int;
SET @T:= 0;
SELECT IF( transaccion  ='Compra' or transaccion = 'Devolucion sobre venta' ,(@T:=@T+cantidad),(@T:=@T-cantidad )) AS Saldo FROM movimiento_inventario where fecha_mov <fecha_inicio;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-17 22:25:59
