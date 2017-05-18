-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: pre_parcial
-- ------------------------------------------------------
-- Server version	5.5.27

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
-- Table structure for table `bien`
--

DROP TABLE IF EXISTS `bien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bien` (
  `id_bien_pk` int(11) NOT NULL AUTO_INCREMENT,
  `precio_venta` decimal(18,0) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `descripcion` char(80) DEFAULT NULL,
  `apartados` int(11) DEFAULT NULL,
  `metodologia` char(40) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `marca` varchar(30) DEFAULT NULL,
  `id_proveedor` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bien_pk`),
  KEY `Ref76` (`id_proveedor`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bien`
--

LOCK TABLES `bien` WRITE;
/*!40000 ALTER TABLE `bien` DISABLE KEYS */;
INSERT INTO `bien` VALUES (1,15,5,'capucchino',0,NULL,'activo','Nestle',1),(2,10,4,'cafe con leche',0,NULL,'activo','La Lechera',1),(3,10,4,'chocolate caliente',0,NULL,'activo','Nido',2),(4,15,5,'Chocolate en barra',0,NULL,'activo','Hersheys',2),(5,10,4,'croassant',0,NULL,'activo','La vaquita',1),(6,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL),(7,10,NULL,'cafe con vainilla',NULL,NULL,NULL,'La Lechera',0),(8,8,NULL,'Pan con pollo',NULL,NULL,NULL,'La abuelita',0);
/*!40000 ALTER TABLE `bien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `id_bit` int(11) NOT NULL AUTO_INCREMENT,
  `hora` time DEFAULT NULL,
  `fecha` time DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `accion` varchar(500) DEFAULT NULL,
  `tabla` varchar(100) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_bit`)
) ENGINE=MyISAM AUTO_INCREMENT=161 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (1,'18:11:35','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(2,'18:22:09','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(3,'19:05:32','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(4,'19:10:40','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(5,'23:41:47','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(6,'23:44:11','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(7,'23:47:34','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(8,'23:48:19','00:00:00','usuariodbs','Operacion ','Asignacion del usuario: javifigue al empleado: 4','usuario','192.168.1.'),(9,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13101','usuario_privilegios','192.168.1.'),(10,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13102','usuario_privilegios','192.168.1.'),(11,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13103','usuario_privilegios','192.168.1.'),(12,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13104','usuario_privilegios','192.168.1.'),(13,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13105','usuario_privilegios','192.168.1.'),(14,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13106','usuario_privilegios','192.168.1.'),(15,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13107','usuario_privilegios','192.168.1.'),(16,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13108','usuario_privilegios','192.168.1.'),(17,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13109','usuario_privilegios','192.168.1.'),(18,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13110','usuario_privilegios','192.168.1.'),(19,'23:48:19','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13111','usuario_privilegios','192.168.1.'),(20,'23:48:33','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(21,'00:22:06','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(22,'00:31:34','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(23,'00:35:43','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(24,'00:36:31','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(25,'00:39:31','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(26,'00:41:58','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(27,'00:46:36','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(28,'00:48:35','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(29,'00:51:54','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(30,'00:53:18','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(31,'00:56:55','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(32,'00:58:05','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(33,'00:59:22','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(34,'01:00:48','00:00:00','javifigue','Fallo logg','Login','usuario','192.168.1.'),(35,'01:00:53','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(36,'01:01:43','00:00:00','javifigue','Loggeo exi','Login','usuario','192.168.1.'),(37,'01:03:47','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(38,'01:05:37','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(39,'01:09:26','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(40,'01:26:05','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(41,'01:26:50','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(42,'06:41:09','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(43,'06:43:03','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(44,'06:45:56','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(45,'06:47:58','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(46,'06:51:22','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(47,'07:05:57','00:00:00','usuariodbs','Loggeo exi','Login','usuario','127.0.0.1'),(48,'07:10:04','00:00:00','usuariodbs','Loggeo exi','Login','usuario','127.0.0.1'),(49,'07:16:07','00:00:00','usuariodbs','Loggeo exi','Login','usuario','127.0.0.1'),(50,'07:16:38','00:00:00','usuariodbs','Loggeo exi','Login','usuario','127.0.0.1'),(51,'07:17:53','00:00:00','javifigue','Loggeo exi','Login','usuario','127.0.0.1'),(52,'07:18:24','00:00:00','usuariodbs','Loggeo exi','Login','usuario','127.0.0.1'),(53,'07:25:16','00:00:00','javifigue','Loggeo exi','Login','usuario','127.0.0.1'),(54,'07:30:29','00:00:00','usuariodbs','Loggeo exi','Login','usuario','127.0.0.1'),(55,'07:55:05','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(56,'07:58:48','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(57,'07:59:24','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(58,'08:03:11','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(59,'08:03:34','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(60,'08:13:37','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(61,'08:14:49','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(62,'08:20:12','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(63,'08:22:00','00:00:00','javifigue','Loggeo exi','Login','usuario','10.1.66.22'),(64,'08:22:11','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(65,'08:24:16','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(66,'08:41:37','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(67,'10:36:28','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(68,'10:40:27','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(69,'10:41:43','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(70,'10:43:11','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(71,'10:45:00','00:00:00','usuariodbs','Loggeo exi','Login','usuario','169.254.36'),(72,'10:48:17','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(73,'10:49:51','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(74,'10:52:51','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(75,'10:59:05','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(76,'11:18:37','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(77,'11:20:49','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(78,'11:21:30','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(79,'11:31:02','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(80,'11:31:24','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(81,'11:37:55','00:00:00','javifigue','Loggeo exi','Login','usuario','10.1.66.22'),(82,'11:39:11','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(83,'11:40:01','00:00:00','usuariodbs','Asignacion','Eliminacion de privilegios para usuario: javifigue','usuario_privilegios','10.1.66.22'),(84,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13101','usuario_privilegios','10.1.66.22'),(85,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13102','usuario_privilegios','10.1.66.22'),(86,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13103','usuario_privilegios','10.1.66.22'),(87,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13104','usuario_privilegios','10.1.66.22'),(88,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13105','usuario_privilegios','10.1.66.22'),(89,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13106','usuario_privilegios','10.1.66.22'),(90,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13107','usuario_privilegios','10.1.66.22'),(91,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13108','usuario_privilegios','10.1.66.22'),(92,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13109','usuario_privilegios','10.1.66.22'),(93,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13110','usuario_privilegios','10.1.66.22'),(94,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13111','usuario_privilegios','10.1.66.22'),(95,'11:40:01','00:00:00','usuariodbs','Asignacion','Asignacion de permiso: ins: True sel: True upd: True del: True a usuario: javifigue Sobre aplicacion: 13207','usuario_privilegios','10.1.66.22'),(96,'11:40:16','00:00:00','javifigue','Loggeo exi','Login','usuario','10.1.66.22'),(97,'11:40:38','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(98,'11:41:49','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(99,'11:51:03','00:00:00','USUARIODBS','Fallo logg','Login','usuario','10.1.66.22'),(100,'11:51:12','00:00:00','usuariodbs','Loggeo exi','Login','usuario','10.1.66.22'),(101,'15:47:01','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(102,'15:55:33','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(103,'15:59:05','00:00:00','usuariodbs','Loggeo exi','Login','usuario','192.168.1.'),(104,'16:12:01','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(105,'16:12:47','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(106,'16:15:23','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(107,'16:16:46','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(108,'16:18:55','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(109,'17:49:06','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(110,'17:55:15','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(111,'17:55:44','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(112,'17:56:26','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(113,'18:14:58','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(114,'18:18:09','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(115,'18:35:55','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(116,'18:38:56','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(117,'18:41:51','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(118,'18:44:26','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(119,'18:47:39','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(120,'18:55:20','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(121,'19:25:37','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(122,'19:34:08','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(123,'19:35:10','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(124,'20:02:57','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(125,'20:05:17','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(126,'20:08:03','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(127,'20:09:32','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(128,'20:13:06','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(129,'20:26:28','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(130,'20:31:03','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(131,'20:32:28','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(132,'20:40:16','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(133,'20:45:38','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(134,'20:48:55','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(135,'20:53:31','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(136,'21:25:53','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(137,'21:27:08','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(138,'21:45:05','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(139,'21:51:51','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(140,'21:57:25','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(141,'22:01:11','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(142,'22:03:52','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(143,'22:12:38','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(144,'22:14:28','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(145,'22:15:20','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(146,'22:26:39','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(147,'22:29:40','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(148,'22:52:59','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(149,'22:56:27','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(150,'23:03:29','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(151,'23:06:53','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(152,'23:09:39','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(153,'23:16:59','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(154,'23:22:24','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(155,'23:23:39','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(156,'23:33:17','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(157,'23:36:14','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(158,'23:38:16','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(159,'23:39:37','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100'),(160,'23:43:49','00:00:00','usuariodbs','Loggeo exitoso','Login','usuario','192.168.1.100');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bodega` (
  `id_bodega` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` char(40) DEFAULT NULL,
  `direccion` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_bodega`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
INSERT INTO `bodega` VALUES (1,'La bodega grande','16 calle B 0-01 zona 1'),(2,'La bodega mediana','18 calle B 0-04 zona 2'),(3,'La bodega pequeña','19 calle B 0-01 zonA 10');
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `id_cliente_pk` int(11) NOT NULL AUTO_INCREMENT,
  `Nit` varchar(45) DEFAULT NULL,
  `nombre_cliente` char(40) DEFAULT NULL,
  `apellido_cliente` char(40) DEFAULT NULL,
  `direccion_cliente` char(40) DEFAULT NULL,
  `telefono_cliente` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_cliente_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'654785-5','Adriana Mishell','López Mendoza','16 calle A 0-01 zona 1','5412-8965'),(2,'648596-2','Lucrecia Maria','Pérez Dieguez','14 calle B 0-03 zona 1','5126-8956'),(3,'674859-5','Paola María','Monterroso Caseres','17 Avenida 0-01 zona 2','5145-9658'),(4,'Consumidor Final',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `id_factura_pk` int(11) NOT NULL AUTO_INCREMENT,
  `estado_factura` varchar(15) DEFAULT NULL,
  `fecha_emision` date NOT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `IVA` varchar(15) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  `id_cliente_pk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_factura_pk`),
  KEY `Ref53` (`id_cliente_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
INSERT INTO `factura` VALUES (1,NULL,'2017-05-17',NULL,NULL,NULL,1),(2,NULL,'2017-05-17',NULL,NULL,NULL,1),(3,NULL,'2017-05-17',NULL,NULL,NULL,1),(4,NULL,'2017-05-17',NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_detalle`
--

DROP TABLE IF EXISTS `factura_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura_detalle` (
  `id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_factura_pk` varchar(45) DEFAULT NULL,
  `Descripción` char(30) DEFAULT NULL,
  `Precio` int(11) DEFAULT NULL,
  `Cantidad` varchar(200) DEFAULT NULL,
  `Total` decimal(18,2) DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_factura`),
  KEY `Ref11` (`Descripción`),
  KEY `Ref64` (`id_bien_pk`),
  KEY `fk122` (`id_factura_pk`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_detalle`
--

LOCK TABLES `factura_detalle` WRITE;
/*!40000 ALTER TABLE `factura_detalle` DISABLE KEYS */;
INSERT INTO `factura_detalle` VALUES (1,3,'3','chocolate caliente',10,'10',NULL,'activo'),(2,3,'4','chocolate caliente',10,'10',NULL,'activo'),(3,3,'4','chocolate caliente',10,'10',NULL,'activo'),(4,3,'4','chocolate caliente',10,'10',NULL,'activo'),(5,3,'4','chocolate caliente',10,'10',NULL,'activo');
/*!40000 ALTER TABLE `factura_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_bodega`
--

DROP TABLE IF EXISTS `producto_bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto_bodega` (
  `id_bodega_producto` int(11) NOT NULL AUTO_INCREMENT,
  `id_bien_pk` int(11) DEFAULT NULL,
  `id_bodega` int(11) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `fecha_entrada` date DEFAULT NULL,
  `estado` char(15) DEFAULT NULL,
  PRIMARY KEY (`id_bodega_producto`),
  KEY `Ref67` (`id_bien_pk`),
  KEY `Ref98` (`id_bodega`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_bodega`
--

LOCK TABLES `producto_bodega` WRITE;
/*!40000 ALTER TABLE `producto_bodega` DISABLE KEYS */;
INSERT INTO `producto_bodega` VALUES (1,1,1,100,'2017-01-12','activo'),(2,2,1,200,'2017-03-12','activo'),(3,1,2,200,'2017-04-06','activo'),(4,2,2,100,'2017-01-07','activo');
/*!40000 ALTER TABLE `producto_bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` char(40) DEFAULT NULL,
  `direccion` char(40) DEFAULT NULL,
  `telefono` char(40) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'El bodegon','14 calle B 0-02 zona 1','5856-8956'),(2,'El mejor precio','15 calle B 0-04 zona 3','5489-5685');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
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
  `estado` char(10) DEFAULT NULL,
  `id_empleado_pk` varchar(18) NOT NULL,
  `id_empresa_pk` int(11) NOT NULL,
  `id_area_trabajo_pk` int(11) NOT NULL,
  `tipo` varchar(150) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('usuariodbs','aABvAGwAYQA=','2017-04-25','ACTIVO','1',1,1,''),('javifigue','MQAyADMANAA1AA==','2017-04-25',NULL,'4',0,0,'');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pre_parcial'
--

--
-- Dumping routines for database 'pre_parcial'
--
/*!50003 DROP FUNCTION IF EXISTS `registraroperacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `registraroperacion`(`iusuario` NVARCHAR(100), `iaccion` NVARCHAR(500), `idescrip` NVARCHAR(500), `itabla` NVARCHAR(50), `iip` NVARCHAR(20)) RETURNS int(2)
BEGIN
	insert into bitacora(hora,fecha,usuario,descripcion,accion,tabla,ip)values(current_time(),curdate(),iusuario,idescrip,iaccion,itabla,iip);
    return 1;
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
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena`(`iusuario` NVARCHAR(20), `icon` NVARCHAR(20), `iip` NVARCHAR(20)) RETURNS int(2)
IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
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
END IF ;;
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

-- Dump completed on 2017-05-17 23:57:15
