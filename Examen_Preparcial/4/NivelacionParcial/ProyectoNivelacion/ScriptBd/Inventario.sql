CREATE DATABASE  IF NOT EXISTS `crmbd` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `crmbd`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: crmbd
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
  `id_modulo` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`)
) ENGINE=MyISAM AUTO_INCREMENT=116 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (101,'Categorias Negocios','1'),(102,'Casos','1'),(103,'Contactos','1'),(104,'Negociaciones','1'),(106,'Categorias de caso','1'),(107,'Gestión de clientes','7'),(108,'Gestión de empresas','7'),(109,'Gestión de moneda','7'),(111,'Gestión de empleados','7'),(112,'Estadisticas clientes','4'),(113,'Estadisticas personal','4'),(114,'Proyecciones','4');
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=909 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (1,'19:23:22','2017-02-20','MarioYuque','Fallo loggeo','Login','usuario','192.168.1.6'),(2,'19:23:29','2017-02-20','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(3,'19:28:30','2017-02-20','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(4,'19:29:40','2017-02-20','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(5,'19:37:12','2017-02-21','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(6,'19:39:09','2017-02-21','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(7,'19:45:32','2017-02-21','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(8,'20:01:08','2017-02-21','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(9,'20:14:32','2017-02-21','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(10,'20:44:57','2017-02-21','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(11,'20:32:35','2017-02-23','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(12,'20:38:44','2017-02-23','MarioYuque','Loggeo exitoso','Login','usuario','192.168.1.6'),(13,'12:22:33','2017-03-02','marioyuque','Loggeo exitoso','Login','usuario','192.168.174.1'),(14,'12:59:07','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(15,'14:50:15','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(16,'15:07:36','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(17,'15:25:32','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(18,'15:41:36','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(19,'16:08:10','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(20,'16:12:15','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(21,'16:13:12','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(22,'16:13:56','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(23,'16:17:07','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(24,'16:22:47','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(25,'16:23:36','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(26,'17:45:40','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(27,'18:25:30','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(28,'19:13:41','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(29,'19:19:50','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(30,'19:33:20','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(31,'19:37:27','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(32,'20:04:36','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(33,'20:37:17','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(34,'20:40:21','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(35,'20:43:20','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(36,'20:45:07','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(37,'20:46:09','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(38,'20:52:12','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(39,'20:53:42','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(40,'21:07:17','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(41,'21:08:13','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(42,'21:09:04','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(43,'21:09:42','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(44,'21:10:36','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(45,'21:11:20','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(46,'21:12:04','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(47,'21:12:59','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(48,'21:13:45','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(49,'21:23:30','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(50,'21:28:01','2017-03-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(51,'18:49:32','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(52,'18:51:45','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(53,'19:24:25','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(54,'19:28:00','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(55,'20:12:37','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(56,'20:53:39','2017-03-03','MArvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(57,'20:56:09','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(58,'20:59:01','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(59,'21:42:48','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(60,'22:09:32','2017-03-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(61,'15:34:45','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(62,'17:00:11','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(63,'17:29:26','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(64,'17:35:41','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(65,'17:36:50','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(66,'17:55:14','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(67,'17:56:02','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(68,'18:02:22','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(69,'18:04:13','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(70,'18:09:26','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(71,'18:21:37','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(72,'18:22:42','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(73,'18:27:38','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(74,'19:38:16','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(75,'19:40:36','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(76,'19:46:49','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(77,'19:49:20','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(78,'19:52:17','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(79,'19:57:35','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(80,'19:58:38','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(81,'20:00:15','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(82,'20:01:39','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(83,'20:46:55','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(84,'20:49:16','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(85,'20:53:41','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(86,'21:10:13','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(87,'21:11:46','2017-03-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(88,'14:36:22','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(89,'15:24:05','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(90,'15:47:12','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(91,'16:00:23','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(92,'16:01:26','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(93,'16:02:23','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(94,'16:03:22','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(95,'16:04:10','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(96,'16:27:27','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(97,'16:30:53','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(98,'16:42:13','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(99,'17:30:33','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(100,'17:38:44','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(101,'17:39:37','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(102,'17:40:50','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(103,'17:42:24','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(104,'17:45:08','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(105,'17:50:28','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(106,'17:51:49','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(107,'17:53:02','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(108,'18:02:26','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(109,'18:04:18','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(110,'18:07:06','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(111,'18:08:51','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(112,'18:13:44','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(113,'18:15:52','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(114,'18:20:23','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(115,'18:27:43','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(116,'18:29:17','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(117,'18:32:18','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(118,'18:34:35','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(119,'18:36:33','2017-03-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(120,'13:17:41','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(121,'13:21:42','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(122,'13:25:37','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(123,'13:29:33','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(124,'13:50:36','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(125,'14:52:04','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(126,'15:00:12','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(127,'15:01:09','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(128,'15:05:19','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(129,'15:16:21','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(130,'15:18:04','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(131,'15:19:42','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(132,'15:21:40','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(133,'16:00:26','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(134,'16:02:23','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(135,'17:54:41','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(136,'18:10:31','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(137,'18:17:23','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(138,'18:19:05','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(139,'18:35:08','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(140,'18:36:31','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(141,'18:47:58','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(142,'18:51:31','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(143,'19:18:37','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(144,'19:20:28','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(145,'19:26:58','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(146,'19:28:30','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(147,'19:29:35','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(148,'19:37:36','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(149,'19:39:20','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(150,'19:45:30','2017-03-21','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(151,'17:08:33','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(152,'17:10:38','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(153,'17:20:34','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(154,'17:26:55','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(155,'17:31:57','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(156,'17:54:10','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(157,'18:18:37','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(158,'18:21:00','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(159,'18:49:37','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(160,'19:01:15','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(161,'19:02:50','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(162,'19:03:40','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(163,'19:07:59','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(164,'19:56:41','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(165,'20:07:28','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(166,'20:25:50','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(167,'20:35:59','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(168,'20:38:29','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(169,'21:15:52','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(170,'21:16:36','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(171,'21:23:26','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(172,'21:27:26','2017-03-22','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(173,'12:53:10','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(174,'12:57:14','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(175,'13:03:26','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(176,'13:07:44','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(177,'13:08:33','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(178,'13:10:05','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(179,'13:11:23','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(180,'13:13:50','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(181,'13:17:40','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(182,'13:24:38','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(183,'14:30:44','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(184,'14:41:02','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(185,'18:06:31','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(186,'18:24:08','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(187,'18:26:43','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(188,'19:14:34','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(189,'19:28:15','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(190,'19:35:39','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(191,'20:21:00','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(192,'20:22:31','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(193,'20:25:24','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(194,'20:34:40','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(195,'20:44:36','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(196,'20:49:42','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(197,'20:55:03','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(198,'21:10:05','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(199,'21:22:21','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(200,'21:25:55','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(201,'21:48:24','2017-03-23','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(202,'12:30:15','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(203,'12:36:49','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(204,'12:50:17','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(205,'14:29:54','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(206,'14:37:10','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(207,'14:48:29','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(208,'15:00:26','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(209,'15:05:58','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(210,'15:30:19','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(211,'15:36:58','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(212,'15:47:33','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(213,'15:50:53','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(214,'17:44:35','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(215,'17:48:22','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(216,'17:52:22','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(217,'17:57:02','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(218,'18:02:33','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(219,'18:14:32','2017-03-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(220,'10:41:54','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(221,'10:49:15','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(222,'10:55:27','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(223,'11:25:38','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(224,'11:26:55','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(225,'11:50:24','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(226,'12:03:24','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(227,'12:06:25','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(228,'12:08:32','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(229,'12:09:59','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(230,'12:11:22','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(231,'12:13:52','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(232,'12:15:55','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(233,'12:17:58','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(234,'12:19:22','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(235,'12:20:52','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(236,'12:29:48','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(237,'12:31:02','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(238,'12:31:59','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(239,'12:49:27','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(240,'13:28:19','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(241,'14:44:58','2017-03-25','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(242,'10:05:38','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(243,'11:11:43','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(244,'11:23:46','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(245,'11:30:05','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(246,'11:32:21','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(247,'11:37:37','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(248,'11:53:35','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(249,'11:55:31','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(250,'12:14:05','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(251,'12:16:03','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(252,'12:16:51','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(253,'12:18:41','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(254,'12:19:45','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(255,'12:21:50','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(256,'12:35:13','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(257,'12:38:35','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(258,'12:43:56','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(259,'12:45:17','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(260,'12:47:34','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(261,'16:38:13','2017-03-26','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(262,'10:59:01','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(263,'11:47:19','2017-03-27','selvinn','Loggeo exitoso','Login','usuario','192.168.174.1'),(264,'14:07:25','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(265,'14:09:51','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(266,'14:13:57','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(267,'14:15:00','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(268,'14:17:59','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(269,'14:25:32','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(270,'14:26:51','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(271,'14:32:41','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(272,'14:39:00','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(273,'14:47:46','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(274,'14:55:17','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(275,'15:33:22','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(276,'15:35:38','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(277,'15:37:21','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(278,'15:39:15','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(279,'15:40:40','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(280,'15:46:10','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(281,'15:51:18','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(282,'16:00:26','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(283,'16:01:50','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(284,'16:04:55','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(285,'16:10:19','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(286,'16:16:52','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(287,'16:26:15','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(288,'16:29:09','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(289,'16:32:50','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(290,'16:34:53','2017-03-27','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(291,'16:08:36','2017-03-28','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(292,'20:41:49','2017-03-28','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(293,'21:11:46','2017-03-28','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(294,'21:24:46','2017-03-28','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(295,'15:21:55','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(296,'15:26:54','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(297,'15:28:53','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(298,'15:51:33','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(299,'15:54:17','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(300,'15:57:13','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(301,'18:24:38','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(302,'19:11:45','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(303,'19:14:32','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(304,'19:16:58','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(305,'19:18:19','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(306,'19:22:34','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(307,'19:23:48','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(308,'19:25:31','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(309,'19:30:13','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(310,'19:31:23','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(311,'19:35:44','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(312,'19:37:17','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(313,'19:39:36','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(314,'19:42:50','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(315,'20:08:37','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(316,'20:10:12','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(317,'20:13:20','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(318,'20:22:23','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(319,'20:26:22','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(320,'20:38:32','2017-03-29','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(321,'13:53:53','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(322,'14:01:18','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(323,'14:07:54','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(324,'15:23:58','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(325,'15:40:19','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(326,'15:53:18','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(327,'18:28:06','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(328,'18:59:20','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(329,'20:27:24','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(330,'20:50:12','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(331,'21:02:42','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(332,'21:12:54','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(333,'21:22:48','2017-03-30','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(334,'11:25:14','2017-03-31','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(335,'09:35:49','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(336,'09:38:51','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(337,'09:40:16','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(338,'09:42:36','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(339,'09:43:27','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(340,'09:56:58','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(341,'09:59:01','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(342,'10:01:00','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(343,'10:02:14','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(344,'10:27:56','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(345,'10:37:18','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(346,'10:39:08','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(347,'10:41:19','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(348,'10:45:54','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(349,'11:14:08','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(350,'11:31:51','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(351,'11:36:53','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(352,'11:38:28','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(353,'11:39:48','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(354,'11:44:15','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(355,'11:45:14','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(356,'11:47:20','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(357,'11:49:20','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(358,'11:52:00','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(359,'11:52:51','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(360,'11:55:19','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(361,'11:58:32','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(362,'12:01:58','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(363,'12:04:48','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(364,'12:11:03','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(365,'12:12:25','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(366,'12:13:06','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(367,'12:14:43','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(368,'12:16:30','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(369,'12:22:55','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(370,'12:36:51','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(371,'12:44:27','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(372,'13:02:11','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(373,'13:16:39','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(374,'13:27:13','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(375,'13:33:06','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(376,'17:19:15','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(377,'17:44:19','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(378,'17:47:02','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(379,'17:48:13','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(380,'17:49:58','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(381,'17:50:44','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(382,'17:52:37','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(383,'17:55:09','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(384,'17:59:05','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(385,'18:00:39','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(386,'18:07:37','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(387,'18:08:40','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(388,'18:09:56','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(389,'18:10:41','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(390,'18:11:29','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(391,'18:21:09','2017-04-01','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(392,'12:21:23','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(393,'12:24:30','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(394,'12:25:37','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(395,'12:46:12','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(396,'13:26:15','2017-04-02','ycalito','Loggeo exitoso','Login','usuario','192.168.174.1'),(397,'13:27:27','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(398,'13:29:13','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(399,'13:31:36','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(400,'13:34:02','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(401,'13:35:09','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(402,'13:37:55','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(403,'13:38:55','2017-04-02','ycalito','Loggeo exitoso','Login','usuario','192.168.174.1'),(404,'13:42:40','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(405,'13:48:19','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(406,'13:53:02','2017-04-02','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(407,'10:51:21','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(408,'10:59:12','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(409,'18:56:03','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(410,'19:39:56','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(411,'19:42:44','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(412,'19:44:10','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(413,'19:55:43','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(414,'19:58:07','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(415,'20:01:18','2017-04-03','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(416,'18:17:37','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(417,'18:53:07','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(418,'19:37:22','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(419,'19:38:37','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(420,'19:40:17','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(421,'19:41:44','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(422,'20:19:28','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(423,'20:21:22','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(424,'20:22:47','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(425,'20:24:57','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(426,'20:30:51','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(427,'20:33:34','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(428,'20:36:35','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(429,'20:38:07','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(430,'20:45:46','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(431,'21:05:18','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(432,'21:07:34','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(433,'21:09:29','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(434,'21:15:24','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(435,'21:21:40','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(436,'21:23:53','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(437,'21:28:30','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(438,'21:30:08','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(439,'21:50:41','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(440,'21:53:46','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(441,'21:56:58','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(442,'22:13:17','2017-04-04','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(443,'08:43:25','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(444,'09:04:33','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(445,'09:20:45','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(446,'09:32:12','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(447,'09:35:53','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(448,'09:37:18','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(449,'09:38:32','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(450,'09:58:43','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(451,'10:02:47','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(452,'10:08:17','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(453,'10:09:28','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(454,'10:16:29','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(455,'12:26:55','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(456,'12:55:35','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(457,'13:01:45','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(458,'13:04:18','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(459,'13:15:18','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(460,'13:21:08','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(461,'13:23:49','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(462,'13:40:42','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(463,'13:45:03','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(464,'14:04:37','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(465,'14:10:18','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(466,'14:13:01','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(467,'14:14:54','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(468,'14:16:21','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(469,'14:22:30','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(470,'14:27:39','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(471,'14:30:27','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(472,'14:51:52','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(473,'15:09:58','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(474,'16:01:40','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(475,'16:09:03','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(476,'16:19:07','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(477,'16:27:28','2017-04-08','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(478,'12:36:53','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(479,'12:43:06','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(480,'13:00:32','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(481,'13:04:08','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(482,'13:16:14','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(483,'13:19:16','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(484,'13:24:40','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(485,'13:27:30','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(486,'13:53:26','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(487,'13:57:19','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(488,'16:44:14','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(489,'16:47:01','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(490,'16:48:55','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(491,'16:50:03','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(492,'16:53:02','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(493,'16:57:00','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(494,'16:59:03','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(495,'17:07:32','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(496,'17:15:18','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(497,'17:20:49','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(498,'17:27:30','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(499,'17:40:47','2017-04-09','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(500,'10:58:47','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(501,'12:01:57','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(502,'12:26:04','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(503,'12:42:20','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(504,'12:45:12','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(505,'12:49:56','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(506,'13:06:18','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(507,'13:45:45','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(508,'13:51:13','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(509,'13:55:54','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(510,'14:03:06','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(511,'14:18:05','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(512,'16:05:01','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(513,'16:08:18','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(514,'16:16:55','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(515,'16:42:42','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(516,'16:44:34','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(517,'16:47:21','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(518,'16:49:38','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(519,'16:51:10','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(520,'17:22:19','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(521,'17:24:14','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(522,'17:36:25','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(523,'17:39:58','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(524,'17:47:42','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(525,'18:05:41','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(526,'18:11:47','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(527,'18:13:08','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(528,'18:16:17','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(529,'18:22:50','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(530,'18:25:13','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(531,'18:27:35','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(532,'18:50:15','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(533,'18:51:25','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(534,'19:05:45','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(535,'19:11:08','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(536,'19:12:09','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(537,'19:15:55','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(538,'19:17:19','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(539,'19:21:00','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(540,'19:22:13','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(541,'19:25:09','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(542,'20:14:59','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(543,'20:21:59','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(544,'20:30:10','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(545,'20:39:11','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(546,'20:50:33','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(547,'20:55:14','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(548,'20:57:20','2017-04-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(549,'09:30:07','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(550,'09:56:28','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(551,'09:58:10','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(552,'10:05:13','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(553,'10:08:18','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(554,'10:25:31','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(555,'10:59:31','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(556,'11:06:33','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(557,'11:10:38','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(558,'11:28:19','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(559,'11:31:48','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(560,'11:43:38','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(561,'11:46:08','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(562,'11:48:22','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(563,'14:06:50','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(564,'14:12:53','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(565,'14:23:08','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(566,'14:26:58','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(567,'14:35:30','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(568,'14:39:30','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(569,'14:49:43','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(570,'14:52:02','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(571,'14:54:05','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(572,'15:06:48','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(573,'15:07:42','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(574,'15:40:15','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(575,'15:41:09','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(576,'15:43:41','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(577,'15:55:56','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(578,'15:58:32','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(579,'16:01:30','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(580,'16:02:15','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(581,'16:05:12','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(582,'16:12:32','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(583,'16:15:06','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(584,'16:17:22','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(585,'16:22:24','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(586,'16:23:32','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(587,'16:26:12','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(588,'20:59:44','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(589,'21:08:18','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(590,'21:09:06','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(591,'21:10:05','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(592,'21:51:51','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(593,'21:54:29','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(594,'21:58:32','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(595,'22:01:40','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(596,'22:02:59','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(597,'22:04:00','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(598,'22:04:53','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(599,'22:05:45','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(600,'22:08:18','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(601,'22:11:53','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(602,'22:13:19','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(603,'22:15:17','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(604,'22:18:07','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(605,'22:22:53','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(606,'22:24:00','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(607,'22:25:14','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(608,'22:29:34','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(609,'22:30:19','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(610,'22:32:25','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(611,'22:32:49','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(612,'22:34:17','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(613,'22:35:17','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(614,'22:36:16','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(615,'22:36:55','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(616,'22:38:08','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(617,'22:39:33','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(618,'22:56:27','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(619,'23:05:43','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(620,'23:07:43','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(621,'23:24:19','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(622,'23:31:02','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(623,'23:33:07','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(624,'23:34:11','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(625,'23:43:28','2017-04-11','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(626,'00:03:57','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(627,'00:06:29','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(628,'00:07:30','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(629,'08:06:59','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(630,'08:22:03','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(631,'08:28:48','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(632,'09:03:58','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(633,'09:12:41','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(634,'09:27:35','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(635,'10:14:38','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(636,'10:17:27','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(637,'10:19:49','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(638,'10:40:38','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(639,'10:43:57','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(640,'10:47:46','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(641,'10:59:21','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(642,'11:06:23','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(643,'11:31:40','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(644,'11:56:35','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(645,'12:00:07','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(646,'12:19:52','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(647,'12:42:59','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(648,'12:51:08','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(649,'13:09:02','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(650,'13:41:41','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(651,'13:49:24','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(652,'13:57:59','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(653,'14:09:47','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(654,'14:13:15','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(655,'14:16:29','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(656,'14:24:15','2017-04-12','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(657,'15:34:37','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(658,'15:42:14','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(659,'15:47:34','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(660,'16:00:57','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(661,'16:03:13','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(662,'16:06:31','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(663,'16:07:41','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(664,'16:08:28','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(665,'16:13:44','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(666,'18:39:27','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(667,'19:07:58','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(668,'19:18:20','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(669,'19:19:36','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(670,'19:20:34','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(671,'19:25:46','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(672,'19:53:06','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(673,'20:02:18','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(674,'20:03:20','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(675,'20:21:21','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(676,'20:31:14','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(677,'20:52:54','2017-04-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(678,'12:47:52','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(679,'12:59:59','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(680,'13:23:06','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(681,'14:00:19','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(682,'15:21:43','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(683,'19:04:00','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(684,'19:32:04','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(685,'20:09:46','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(686,'20:12:00','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(687,'20:28:38','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(688,'20:31:43','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(689,'20:33:50','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(690,'20:42:05','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(691,'20:51:38','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(692,'20:54:14','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(693,'20:58:51','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(694,'21:12:42','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(695,'21:14:08','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(696,'21:16:22','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(697,'21:17:32','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(698,'21:19:11','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(699,'21:21:19','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(700,'21:22:56','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(701,'21:23:58','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(702,'21:24:48','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(703,'21:25:42','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(704,'21:30:47','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(705,'21:31:47','2017-04-18','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(706,'10:53:35','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(707,'11:06:16','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(708,'11:07:34','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(709,'14:29:18','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(710,'14:36:20','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(711,'14:50:21','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(712,'14:58:23','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(713,'15:16:51','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(714,'15:25:02','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(715,'15:35:03','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(716,'15:43:30','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(717,'15:48:04','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(718,'15:51:07','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(719,'15:52:44','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(720,'18:30:34','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(721,'18:38:10','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(722,'18:40:49','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(723,'19:09:19','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(724,'19:20:29','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(725,'19:47:48','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(726,'19:51:25','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(727,'21:09:42','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(728,'21:18:05','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(729,'21:22:11','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(730,'21:23:37','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(731,'21:38:47','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(732,'21:43:53','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(733,'21:53:13','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(734,'21:57:41','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(735,'22:03:43','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(736,'22:07:09','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(737,'22:08:55','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(738,'22:11:16','2017-04-19','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(739,'12:28:18','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(740,'12:37:48','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(741,'12:42:32','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(742,'12:46:58','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(743,'12:52:20','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(744,'13:08:10','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(745,'13:11:22','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(746,'13:23:11','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(747,'13:32:08','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(748,'14:43:53','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(749,'14:50:14','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(750,'18:23:52','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(751,'18:26:20','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(752,'19:47:49','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(753,'19:52:04','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(754,'19:56:20','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(755,'19:57:59','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(756,'19:59:30','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(757,'20:01:02','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(758,'20:06:47','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(759,'20:12:10','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(760,'20:14:13','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(761,'20:25:24','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(762,'20:26:40','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(763,'20:29:43','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(764,'20:56:07','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(765,'21:02:55','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(766,'21:29:40','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(767,'21:35:58','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(768,'21:44:07','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(769,'21:47:50','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(770,'21:49:58','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(771,'21:59:04','2017-04-20','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(772,'13:16:03','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(773,'13:35:34','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(774,'13:37:18','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(775,'13:38:35','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(776,'13:40:23','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(777,'14:00:47','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(778,'14:01:32','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(779,'14:30:50','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(780,'18:14:12','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(781,'18:17:08','2017-04-24','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(782,'13:48:42','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(783,'14:11:20','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(784,'14:17:50','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(785,'14:29:49','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(786,'14:54:55','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(787,'14:58:45','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(788,'15:02:06','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(789,'15:05:07','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(790,'15:09:27','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(791,'15:17:48','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(792,'15:20:09','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(793,'15:23:24','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(794,'15:28:46','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(795,'15:31:52','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(796,'15:36:07','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(797,'15:38:00','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(798,'15:39:03','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(799,'16:37:44','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(800,'17:12:36','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(801,'17:13:17','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(802,'17:16:34','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(803,'17:36:20','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(804,'17:38:27','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(805,'17:40:49','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(806,'17:43:11','2017-05-07','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(807,'15:03:15','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(808,'15:18:05','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(809,'15:41:55','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(810,'16:22:32','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(811,'16:31:41','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(812,'16:37:48','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(813,'18:25:50','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(814,'18:41:05','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(815,'18:42:40','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(816,'18:50:31','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(817,'18:54:40','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(818,'18:55:51','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(819,'18:57:45','2017-05-10','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(820,'09:33:55','2017-05-13','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(821,'10:20:39','2017-05-13','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(822,'10:25:33','2017-05-13','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(823,'09:35:23','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(824,'09:42:36','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(825,'13:21:49','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(826,'13:34:35','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(827,'13:37:45','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(828,'13:39:39','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(829,'13:43:27','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(830,'13:45:13','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(831,'13:48:23','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(832,'13:51:15','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(833,'13:52:37','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(834,'13:56:54','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(835,'14:00:20','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(836,'14:04:15','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(837,'14:06:55','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(838,'14:10:33','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(839,'14:12:38','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(840,'14:17:01','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(841,'14:22:31','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(842,'14:25:33','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(843,'14:28:13','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(844,'14:30:23','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(845,'14:33:01','2017-05-14','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(846,'11:17:05','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(847,'11:25:55','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(848,'11:27:27','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(849,'11:29:41','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(850,'11:30:48','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(851,'11:34:32','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(852,'11:41:14','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(853,'11:42:27','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(854,'11:45:48','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(855,'11:47:31','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(856,'11:59:28','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(857,'12:02:18','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(858,'12:04:20','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(859,'12:07:39','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(860,'12:08:26','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(861,'12:09:12','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(862,'12:11:41','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(863,'13:28:31','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(864,'13:55:13','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(865,'14:00:10','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(866,'14:04:50','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(867,'14:07:48','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(868,'14:37:35','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(869,'14:53:39','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(870,'14:55:42','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(871,'15:03:55','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(872,'15:13:53','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(873,'15:15:17','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(874,'15:17:34','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(875,'15:19:11','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(876,'15:22:44','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(877,'15:34:46','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(878,'15:35:47','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(879,'15:36:58','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(880,'15:46:31','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(881,'15:47:52','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(882,'16:02:18','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(883,'16:30:00','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(884,'16:35:15','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(885,'16:38:02','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(886,'16:40:54','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(887,'16:44:58','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(888,'16:49:58','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(889,'16:52:43','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(890,'16:55:33','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(891,'16:59:52','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(892,'18:18:23','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(893,'18:23:36','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(894,'18:28:50','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(895,'18:31:43','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(896,'18:34:17','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(897,'18:39:27','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(898,'18:39:53','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(899,'18:47:19','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(900,'18:55:05','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(901,'18:56:06','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(902,'18:59:45','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(903,'19:27:25','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(904,'19:29:26','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(905,'19:30:32','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(906,'19:34:30','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(907,'19:37:14','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1'),(908,'20:09:59','2017-05-17','Marvin','Loggeo exitoso','Login','usuario','192.168.174.1');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caso`
--

DROP TABLE IF EXISTS `caso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caso` (
  `id_caso` int(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` varchar(10) DEFAULT NULL,
  `id_cliente` varchar(10) DEFAULT NULL,
  `id_empresa` varchar(10) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `estado_caso` varchar(30) DEFAULT NULL,
  `fecha_finalizacion` date DEFAULT NULL,
  `fecha_asignacion` date DEFAULT NULL,
  `fecha_limite` date DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` varchar(30) DEFAULT NULL,
  `id_cat_caso` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_caso`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caso`
--

LOCK TABLES `caso` WRITE;
/*!40000 ALTER TABLE `caso` DISABLE KEYS */;
INSERT INTO `caso` VALUES (19,'1','14','1','Revision de maquina','Abierto',NULL,'2017-04-01','2017-04-05','Calentamiento excesivo de maquina en parte del ventilador','activo','1'),(20,'1','23','0','Errores en portal de correos','Abierto',NULL,'2017-04-01','2017-04-06','Algunos de los correos no entran a la bandeja de entrada','activo','5'),(21,'1','21','2','Activacion de office 2016','cerrado',NULL,'2017-04-01','2017-04-04','Error al abrir office 2016, necesidad de activar','inactivo','5'),(22,'3','21','2','Revision de impresora','Abierto',NULL,'2017-04-09','2017-04-10','La impresora esta sacando las hojas con tinta','activo','1'),(23,'3','23','0','Bandeja de entrada','cerrado',NULL,'2017-04-09','2017-04-12','La bandeja de entrada de correos no esta recibiendo correos de la noche','inactivo','5'),(24,'1','22','0','Revision de servidor','cerrado','2017-04-18','2017-04-17',NULL,'revision','activo','2'),(25,'2','0','2','Inventario','Abierto','2017-04-24','2017-04-24',NULL,'revision de inventario','activo','1'),(26,'2','15','0','Revision de inventario','Abierto','2017-04-24','2017-04-24',NULL,'revision','activo','1'),(27,'3','0','2','revision de servidor central','Abierto','2017-04-24','2017-04-24','2017-04-24','revision','activo','4'),(28,'3','0','7','llamada a DH','Abierto','2017-04-24','2017-04-24',NULL,'llamar por molestias en las pcs','inactivo','1');
/*!40000 ALTER TABLE `caso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_caso`
--

DROP TABLE IF EXISTS `categoria_caso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria_caso` (
  `id_cat_caso` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_caso` varchar(50) DEFAULT NULL,
  `estado` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_cat_caso`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_caso`
--

LOCK TABLES `categoria_caso` WRITE;
/*!40000 ALTER TABLE `categoria_caso` DISABLE KEYS */;
INSERT INTO `categoria_caso` VALUES (1,'Hardware','activo'),(2,'Redes','activo'),(3,'Software','inactivo'),(4,'Infraestructura','activo'),(5,'Software','activo');
/*!40000 ALTER TABLE `categoria_caso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_neg`
--

DROP TABLE IF EXISTS `categoria_neg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria_neg` (
  `id_cat` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cat` varchar(50) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_cat`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_neg`
--

LOCK TABLES `categoria_neg` WRITE;
/*!40000 ALTER TABLE `categoria_neg` DISABLE KEYS */;
INSERT INTO `categoria_neg` VALUES (2,'Servicios IT','activo'),(3,'Consultorias','activo');
/*!40000 ALTER TABLE `categoria_neg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contacto`
--

DROP TABLE IF EXISTS `contacto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contacto` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `tipo` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contacto`
--

LOCK TABLES `contacto` WRITE;
/*!40000 ALTER TABLE `contacto` DISABLE KEYS */;
INSERT INTO `contacto` VALUES (1,'Carlos','ciudad','22568974','persona'),(2,'Marvin','ciudad','58975421','persona'),(3,'Lancasco','ciudad','22541202','organizacion');
/*!40000 ALTER TABLE `contacto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `id_empresa` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(60) DEFAULT NULL,
  `direccion` varchar(30) DEFAULT NULL,
  `correo` varchar(25) DEFAULT NULL,
  `telefono1` varchar(15) DEFAULT NULL,
  `telefono2` varchar(15) DEFAULT NULL,
  `id_pais` int(11) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_empresa`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` VALUES (0,'','','','','',1,'activo'),(1,'CPX','ciudad','cpx@piobox.com','1111-2222','3333-4444',1,'activo'),(2,'software S,A','ciudad','software@gmail.com','2343-2121','7888-0909',1,'activo'),(7,'Distribuidora Hardware','ciudad','hardware@hardware.es','7900-1212','0900-6657',1,'activo');
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_encabezado`
--

DROP TABLE IF EXISTS `factura_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura_encabezado` (
  `id_factura` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `forma_pago` varchar(30) DEFAULT NULL,
  `total` varchar(30) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `id_cliente` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_factura`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_encabezado`
--

LOCK TABLES `factura_encabezado` WRITE;
/*!40000 ALTER TABLE `factura_encabezado` DISABLE KEYS */;
INSERT INTO `factura_encabezado` VALUES (1,'2017-04-17','efectivo','1850','activo','2'),(2,'2017-05-14','efectivo','3400','activo','2');
/*!40000 ALTER TABLE `factura_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulo`
--

DROP TABLE IF EXISTS `modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modulo` (
  `id_modulo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_modulo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulo`
--

LOCK TABLES `modulo` WRITE;
/*!40000 ALTER TABLE `modulo` DISABLE KEYS */;
INSERT INTO `modulo` VALUES (1,'CRM'),(2,'Ventas'),(3,'Cobros'),(4,'Estadisticas'),(5,'Productos'),(6,'Seguridad'),(7,'Mantenimientos');
/*!40000 ALTER TABLE `modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moneda`
--

DROP TABLE IF EXISTS `moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `moneda` (
  `id_moneda` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(40) DEFAULT NULL,
  `simbolo` varchar(10) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_moneda`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moneda`
--

LOCK TABLES `moneda` WRITE;
/*!40000 ALTER TABLE `moneda` DISABLE KEYS */;
INSERT INTO `moneda` VALUES (1,'Quetzal','Q.','activo'),(2,'Dolar','$.','activo'),(3,'Dolar Salvadoreño','$.','inactivo'),(4,'Yen','Y.','activo');
/*!40000 ALTER TABLE `moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas_caso`
--

DROP TABLE IF EXISTS `notas_caso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notas_caso` (
  `id_nota` int(11) NOT NULL AUTO_INCREMENT,
  `nota` varchar(200) DEFAULT NULL,
  `id_caso` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_nota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notas_caso`
--

LOCK TABLES `notas_caso` WRITE;
/*!40000 ALTER TABLE `notas_caso` DISABLE KEYS */;
/*!40000 ALTER TABLE `notas_caso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pais`
--

DROP TABLE IF EXISTS `pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pais` (
  `id_pais` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_pais`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pais`
--

LOCK TABLES `pais` WRITE;
/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
INSERT INTO `pais` VALUES (1,'Guatemala');
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
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
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`,`id_perfil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_privilegios`
--

LOCK TABLES `perfil_privilegios` WRITE;
/*!40000 ALTER TABLE `perfil_privilegios` DISABLE KEYS */;
/*!40000 ALTER TABLE `perfil_privilegios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `veces_contado` varchar(10) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `nombres` varchar(10) DEFAULT NULL,
  `apellidos` varchar(10) DEFAULT NULL,
  `puesto` varchar(50) DEFAULT NULL,
  `incidencia` varchar(50) DEFAULT NULL,
  `id_estado_cuenta` varchar(10) DEFAULT NULL,
  `tipo` varchar(25) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `movil` varchar(15) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `id_empresa` varchar(10) DEFAULT NULL,
  `nit` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,NULL,NULL,'chis','chiso','vendedor',NULL,NULL,NULL,'1213-1231','132131-1231','elchiso@gmail.com','3',NULL),(2,NULL,NULL,'carlos','aguirro','gerente',NULL,NULL,NULL,'3123-3212','1233-1232','acarlos@gmail.com','2',NULL),(3,NULL,'inactivo','Guille','Lamp','vendedor',NULL,NULL,NULL,'1233-1231','1231-4322','glamp@gmail.com','2',NULL),(4,NULL,NULL,'Luis','Gonzales','jefe',NULL,NULL,NULL,'1234-4132','7890-9877','lgonzales@hotmail.com','3',NULL),(5,NULL,NULL,'Andres','Ruiz','Secretario',NULL,NULL,NULL,'7890-8765','1233-1231','ruiz@yahoo.es','0',NULL),(6,NULL,NULL,'Qijote','Panza','bodega',NULL,NULL,NULL,'11111','22222','qijote@hotmail.com','6',NULL),(7,NULL,NULL,'Jesus','Martinez','Bodega',NULL,NULL,NULL,'1233-1232','4321-2122','jmartin@hotmail.com','3',NULL),(8,NULL,NULL,'Jorge','Luna','Contador',NULL,NULL,NULL,'1212312','312313','luna@cpx.com','1',NULL),(9,NULL,'inactivo','Julio','Sosa','Programador',NULL,NULL,NULL,'1234-4321','123','sosa@cpx.com','1',NULL),(10,NULL,'inactivo','Armando','Solorzano','Contador',NULL,NULL,NULL,'8900-4321','1255-1234','asolorzano@cpx.es','1',NULL),(11,NULL,'inactivo','Juan','lopez','Gerente',NULL,NULL,NULL,'5648-1212','0909-1212','jarrivillaga@cpx.es','1',NULL),(12,NULL,'activo','Leo','Martinez','Analista',NULL,NULL,NULL,'123131','qeqeq','12312','1',NULL),(13,NULL,'inactivo','Juan','Luis','secretario',NULL,NULL,NULL,'567890','890','jluis@gmail.com','1',NULL),(14,NULL,'activo','Yulian','Marley','vendedor',NULL,NULL,NULL,'7890-2334','12313-123','ymarley@gmail.com','1',NULL),(15,NULL,'activo','Juan','PAblo','bodega',NULL,NULL,NULL,'1234-1234','4321-4321','jpablo@hotmail.com','1',NULL),(16,NULL,'activo','Alejandra','Moran','Secretaria',NULL,NULL,NULL,'1234-4554','6789-2345','amoran@gmail.com','1',NULL),(17,NULL,'activo','afas','ad','sd',NULL,NULL,NULL,'asd','asd','ad','',NULL),(18,NULL,'activo','Madelin','Fernandez','Administracion',NULL,NULL,NULL,'6789-5432','7890-1213','mfernandez@gmail.com','',NULL),(19,NULL,'activo','Alfre','Leon','adf',NULL,NULL,NULL,'adf','adf','asdf','0',NULL),(20,NULL,'activo','Enrique','Zafar','Call center',NULL,NULL,NULL,'567890','789096','ezafar@gmail.com','0',NULL),(21,NULL,'activo','Vinicio','Engel','Analista',NULL,NULL,NULL,'4780-1234','1234-5432','vengel@software.com','2',NULL),(22,NULL,'activo','Carlos','Davila','Contador',NULL,NULL,NULL,'7890-8764','7890-123','cdavila@gmail.com','1',NULL),(23,NULL,'activo','Martin','Juarez','IT',NULL,NULL,NULL,'4567-1231','0900-1211','mjuarez@gmail.com','0',NULL),(24,NULL,'inactivo','ad','asd','asd',NULL,NULL,NULL,'asda','asd','as','0',NULL),(25,NULL,'activo','Edgar','Luna','Tecnico',NULL,NULL,NULL,'0989-1221','7890-2211','eluna@gmail.com','0',NULL),(26,NULL,'activo','Andres','Pinto','Tecnico',NULL,NULL,NULL,'7875-1221','0909-1221','apinto@hotmail.com','0',NULL),(27,NULL,'activo','Juan','Ramos','Analista',NULL,NULL,NULL,'1234-8765','1234-4321','jramos@cpx.com','1',NULL),(28,NULL,NULL,'chris','wat',NULL,NULL,NULL,NULL,'123','321','cwat@gmail.com',NULL,'222'),(29,NULL,NULL,'jkj','kjk',NULL,NULL,NULL,NULL,'jkj','jk','jkj',NULL,'jkj'),(30,NULL,NULL,'Juan','Plata',NULL,NULL,NULL,NULL,'1234','1234','elpin@gmail.com',NULL,'1234');
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_factura`
--

DROP TABLE IF EXISTS `tbl_detalle_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_detalle_factura` (
  `id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` varchar(10) DEFAULT NULL,
  `producto` varchar(50) DEFAULT NULL,
  `precio` varchar(20) DEFAULT NULL,
  `id_enca_factura` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_factura`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_factura`
--

LOCK TABLES `tbl_detalle_factura` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_factura` DISABLE KEYS */;
INSERT INTO `tbl_detalle_factura` VALUES (1,'12','Pepinillos','12','3'),(2,'1','Leche','10','4'),(3,'2','Pepinillos','12','5'),(4,'5','Wicoy','12','5'),(5,'5','albaca','15','5'),(6,'11','Wicoy','12','6'),(7,'2','Leche','10','6'),(8,'2','Pepinillos','12','6');
/*!40000 ALTER TABLE `tbl_detalle_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_pedido`
--

DROP TABLE IF EXISTS `tbl_detalle_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_detalle_pedido` (
  `id_detalle_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` varchar(10) DEFAULT NULL,
  `producto` varchar(50) DEFAULT NULL,
  `precio` varchar(20) DEFAULT NULL,
  `proveedor` varchar(50) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `id_enca_pedido` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_pedido`
--

LOCK TABLES `tbl_detalle_pedido` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_pedido` DISABLE KEYS */;
INSERT INTO `tbl_detalle_pedido` VALUES (1,'90','Pepinos','25','Empresa Prueba','1111','3'),(2,'10','Pepinos','25','Verduras SA','2332-8912','3'),(3,'12','Pepinos','25','Empresa Prueba','1111','4'),(4,'12','Wicoy','','Verduras SA','2332-8912','5'),(5,'12','Leche','','Empresa Prueba','1111','6'),(6,'12','Leche','','Empresa Prueba','1111','7'),(7,'12','Leche','','Empresa Prueba','1111','8'),(8,'10','Wicoy','','Empresa Prueba','1111','9'),(9,'12','Pepinillos','12','Empresa Prueba','1111','10'),(10,'5','Pepinillos','12','Empresa Prueba','1111','11'),(11,'12','Queso','10','Frescos','67890','12'),(12,'11','Pepinillos','12','Frescos','67890','12'),(13,'10','Wicoy','12','Frescos','67890','12');
/*!40000 ALTER TABLE `tbl_detalle_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_empleado`
--

DROP TABLE IF EXISTS `tbl_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_empleado` (
  `id_empleado` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(50) DEFAULT NULL,
  `apellidos` varchar(50) DEFAULT NULL,
  `puesto` varchar(50) DEFAULT NULL,
  `telefono1` varchar(15) DEFAULT NULL,
  `movil` varchar(15) DEFAULT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `correo` varchar(40) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `estado` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_empleado`
--

LOCK TABLES `tbl_empleado` WRITE;
/*!40000 ALTER TABLE `tbl_empleado` DISABLE KEYS */;
INSERT INTO `tbl_empleado` VALUES (0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1,'Yoni','Calito','Programador','1234-432','66666666','Ciudad','ycalito@gmail.com','C:\\ProyectoCRM\\Usuarios\\yons.jpg','activo'),(2,'Leandro','Tutini','Analista','123113','123132','ciudad','ltutini@gmail.com','C:\\ProyectoCRM\\Usuarios\\leandro.jpg','activo'),(3,'Christian','Lopez','DBA','1234567','1234567','ciudad','clopez@hotmail.com','C:\\ProyectoCRM\\Usuarios\\chis.jpg','activo'),(4,'Angel','López','Analista','7890-0988','45678-987','ciudad','alopez@yahoo.com','C:\\ProyectoCRM\\Usuarios\\john.jpg','activo'),(5,'Rick','Harrison','Compras','8908-7875','1234-5678','Las vegas','riki@miempresa.com','C:\\ProyectoCRM\\Usuarios\\john.jpg','activo');
/*!40000 ALTER TABLE `tbl_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_enca_factura`
--

DROP TABLE IF EXISTS `tbl_enca_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_enca_factura` (
  `id_enca_factura` int(11) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(50) DEFAULT NULL,
  `apellidos` varchar(50) DEFAULT NULL,
  `total` varchar(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_enca_factura`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_enca_factura`
--

LOCK TABLES `tbl_enca_factura` WRITE;
/*!40000 ALTER TABLE `tbl_enca_factura` DISABLE KEYS */;
INSERT INTO `tbl_enca_factura` VALUES (1,'chris','wat','22','2017-05-17'),(2,'chris','wat','22','2017-05-17'),(3,'chris','wat','12','2017-05-17'),(4,'chris','wat','10','2017-05-17'),(5,'chris','wat','39','2017-05-17'),(6,'Juan','Plata','34','2017-05-17');
/*!40000 ALTER TABLE `tbl_enca_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_enca_pedido`
--

DROP TABLE IF EXISTS `tbl_enca_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_enca_pedido` (
  `id_enca_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `encargado` varchar(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_enca_pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_enca_pedido`
--

LOCK TABLES `tbl_enca_pedido` WRITE;
/*!40000 ALTER TABLE `tbl_enca_pedido` DISABLE KEYS */;
INSERT INTO `tbl_enca_pedido` VALUES (1,'Coca','2017-05-17'),(2,'christina','2017-05-17'),(3,'Larson','2017-05-17'),(4,'de','2017-05-17'),(5,'Selvin','2017-05-17'),(6,'pepo','2017-05-17'),(7,'','2017-05-17'),(8,'','2017-05-17'),(9,'','2017-05-17'),(10,'Pepo','2017-05-17'),(11,'Pepo','2017-05-17'),(12,'Jesus Navas','2017-05-17');
/*!40000 ALTER TABLE `tbl_enca_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estadistica`
--

DROP TABLE IF EXISTS `tbl_estadistica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_estadistica` (
  `id_estadistica` int(11) NOT NULL AUTO_INCREMENT,
  `meta` varchar(50) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_estadistica`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_estadistica`
--

LOCK TABLES `tbl_estadistica` WRITE;
/*!40000 ALTER TABLE `tbl_estadistica` DISABLE KEYS */;
INSERT INTO `tbl_estadistica` VALUES (2,'50000','2017-04-01','2017-04-30',NULL),(3,'25000','2017-05-01','2017-05-31',NULL);
/*!40000 ALTER TABLE `tbl_estadistica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_inventario`
--

DROP TABLE IF EXISTS `tbl_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_inventario` (
  `id_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `producto` varchar(50) DEFAULT NULL,
  `cantidad` varchar(50) DEFAULT NULL,
  `categoria` varchar(20) DEFAULT NULL,
  `medida` varchar(20) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_inventario`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_inventario`
--

LOCK TABLES `tbl_inventario` WRITE;
/*!40000 ALTER TABLE `tbl_inventario` DISABLE KEYS */;
INSERT INTO `tbl_inventario` VALUES (1,'Wicoy','5','Vegetales','Lbs','wicoy'),(2,'Leche','10','Lacteos','Kg','leche'),(3,'Pepinillos','12','Vegetales','Lbs','pepis'),(4,'Queso','12','Lacteos','Lbs','kesooo');
/*!40000 ALTER TABLE `tbl_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_negocio`
--

DROP TABLE IF EXISTS `tbl_negocio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_negocio` (
  `id_negocio` int(11) NOT NULL AUTO_INCREMENT,
  `status` varchar(20) DEFAULT NULL,
  `notas` varchar(500) DEFAULT NULL,
  `etapa_negocio` varchar(20) DEFAULT NULL,
  `id_cliente` varchar(30) DEFAULT NULL,
  `id_empleado` varchar(30) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `detalles` varchar(300) DEFAULT NULL,
  `id_moneda` varchar(30) DEFAULT NULL,
  `valor` varchar(15) DEFAULT NULL,
  `tarifa` varchar(20) DEFAULT NULL,
  `fecha_est_cierre` date DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `id_cat` varchar(30) DEFAULT NULL,
  `id_empresa` varchar(30) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_negocio`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_negocio`
--

LOCK TABLES `tbl_negocio` WRITE;
/*!40000 ALTER TABLE `tbl_negocio` DISABLE KEYS */;
INSERT INTO `tbl_negocio` VALUES (1,'proceso',NULL,'0','14','1','Negociacion de software',NULL,'1','6000.00',NULL,'2017-04-06','2017-03-27','2','1','activo'),(2,'proceso',NULL,'0','15','2','Negociacion de Venta de Pcs',NULL,'1','10000.00',NULL,'2017-04-10','2017-03-28','3','1','activo'),(4,'perdido',NULL,'3','16','1','Negociacion de software',NULL,'1','6000.00',NULL,'2017-04-06','2017-03-27','3','1','activo'),(5,'perdido',NULL,'3','16','1','Negociacion de consultorias',NULL,'1','6000.00',NULL,'2017-02-05','2017-02-03','2','1','activo'),(8,'perdido',NULL,'0','22','1','Pagina web','','1','4000.59',NULL,'2017-04-01','2017-03-29','2','1','activo'),(9,'proceso',NULL,'0','14','1','Aplicacion portatil','','1','3500.89',NULL,'2017-05-04','2017-03-29','2','1','activo'),(10,'ganado',NULL,'0','23','5','Ventas de equipo','Establecer el mejor precio en equipos de computo','1','10000.45',NULL,'2017-04-06','2017-04-01','2','0','activo'),(11,'ganado',NULL,'0','26','4','Servicios IT','Negociacion de servicios IT','1','2787.12',NULL,'2017-04-04','2017-04-01','2','0','activo'),(12,'proceso',NULL,'0','26','2','Servicios de BackUp','negociar servicios de backup','1','4500',NULL,'2017-04-19','2017-04-10','2','2','activo'),(13,'proceso',NULL,'0','15','2','Consultorias','','1','3500.00',NULL,'2017-04-19','2017-04-10','3','0','activo'),(14,'proceso',NULL,'0','25','5','Auditoria empresarial','','1','5000',NULL,'2017-04-11','2017-04-11','3','0','activo'),(15,'proceso',NULL,'0','21','3','Servicio Reparaciones','','1','1000',NULL,'2017-04-13','2017-04-12','2','0','activo'),(16,'Ganado',NULL,'0','15','2','Venta de servicios','ventas','1','12500',NULL,'2017-04-18','2017-04-17','2','0','activo'),(17,'Ganado',NULL,'0','0','1','Compra de pcs','garantias','1','30000',NULL,'2017-04-20','2017-04-17','3','7','activo'),(18,'Ganado',NULL,'0','0','1','Negocio de infraestructura','creacion de nueva infraestructura','1','12000',NULL,'2017-04-18','2017-04-17','2','1','activo'),(19,'ganado',NULL,'0','16','3','Negociacion de tutorias','tutorias','1','3500',NULL,'2017-04-19','2017-04-18','3','0','activo'),(20,'Proceso',NULL,'0','21','1','Una noche sin anestesia','me va a dar amnesia','1','12000',NULL,'2017-04-24','2017-04-24','3','0','activo'),(21,'Proceso',NULL,'0','0','4','qwe','qweqwe','1','12333',NULL,'2017-04-24','2017-04-24','2','1','activo'),(22,'Ganado',NULL,'0','12','1','Negocio de Servicios TI','negocio de it','1','3000',NULL,'2017-05-07','2017-05-07','2','0','activo');
/*!40000 ALTER TABLE `tbl_negocio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_producto`
--

DROP TABLE IF EXISTS `tbl_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_producto` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `producto` varchar(50) DEFAULT NULL,
  `categoria` varchar(20) DEFAULT NULL,
  `medida` varchar(20) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `valor` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_producto`
--

LOCK TABLES `tbl_producto` WRITE;
/*!40000 ALTER TABLE `tbl_producto` DISABLE KEYS */;
INSERT INTO `tbl_producto` VALUES (4,'Wicoy','Vegetales','Lbs','wicoy','12'),(5,'Leche','Lacteos','Kg','leche','10'),(6,'Pepinillos','Vegetales','Lbs','pepis','12'),(7,'Queso','Lacteos','Lbs','kesooo','10');
/*!40000 ALTER TABLE `tbl_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proveedor`
--

DROP TABLE IF EXISTS `tbl_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_proveedor` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `empresa` varchar(50) DEFAULT NULL,
  `movil` varchar(20) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `nit` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedor`
--

LOCK TABLES `tbl_proveedor` WRITE;
/*!40000 ALTER TABLE `tbl_proveedor` DISABLE KEYS */;
INSERT INTO `tbl_proveedor` VALUES (1,'Empresa Prueba','8888','1111','prueba@gmail.com','123321'),(2,'Verduras SA','9009-1212','2332-8912','verduras@hotmail.com','123123'),(3,'Frescos','4567890','67890','frescos@gmail.com','78956-1');
/*!40000 ALTER TABLE `tbl_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_puesto`
--

DROP TABLE IF EXISTS `tbl_puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_puesto` (
  `id_puesto` int(11) NOT NULL AUTO_INCREMENT,
  `puesto` varchar(50) DEFAULT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_puesto`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_puesto`
--

LOCK TABLES `tbl_puesto` WRITE;
/*!40000 ALTER TABLE `tbl_puesto` DISABLE KEYS */;
INSERT INTO `tbl_puesto` VALUES (1,'Gerente','Gerente','activo'),(2,'Analista','Analista de datos','activo');
/*!40000 ALTER TABLE `tbl_puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tarea`
--

DROP TABLE IF EXISTS `tbl_tarea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_tarea` (
  `id_tarea` int(11) NOT NULL AUTO_INCREMENT,
  `hora_fin` datetime DEFAULT NULL,
  `estado_tarea` varchar(20) DEFAULT NULL,
  `id_empleado` varchar(12) DEFAULT NULL,
  `fecha_asignacion` date DEFAULT NULL,
  `fecha_establecida` datetime DEFAULT NULL,
  `descripcion_tarea` varchar(200) DEFAULT NULL,
  `id_negocio` varchar(20) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `id_tipo` char(30) DEFAULT NULL,
  `id_caso` varchar(20) DEFAULT NULL,
  `origen` varchar(10) DEFAULT NULL,
  `criticidad` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tarea`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tarea`
--

LOCK TABLES `tbl_tarea` WRITE;
/*!40000 ALTER TABLE `tbl_tarea` DISABLE KEYS */;
INSERT INTO `tbl_tarea` VALUES (1,'2017-04-01 05:00:00','realizado','1','2017-02-01','2017-02-10 00:00:00',NULL,'5','activo','1','',NULL,'Alta'),(2,'2017-04-01 10:00:00','pendiente','1','2017-03-27','2017-03-30 00:00:00',NULL,'1','activo','2','',NULL,'Alta'),(3,'2017-04-01 12:00:00','realizado','1','2017-03-27','2017-03-30 00:00:00',NULL,'3','activo','5','',NULL,'Alta'),(4,'2017-04-01 02:00:00','realizado','1','2017-03-27','2017-03-30 00:00:00',NULL,'4','activo','4','',NULL,'Alta'),(5,'2017-04-01 06:00:00','realizado','1','2017-03-28','2017-03-30 00:00:00',NULL,'7','activo','1','',NULL,'Alta'),(6,'2017-04-01 14:00:00','pendiente','6','2017-03-28','2017-04-05 00:00:00',NULL,'8','activo','3','',NULL,'Alta'),(8,'2017-04-01 16:00:00','pendiente','1','2017-03-29','2017-04-05 00:00:00',NULL,'10','activo','5','',NULL,'Alta'),(9,'2017-04-01 17:00:00','pendiente','4','2017-04-01','2017-05-04 00:00:00',NULL,'11','activo','2','',NULL,NULL),(11,'2017-04-01 00:12:00','pendiente','1','2017-04-01','2017-04-05 00:00:00',NULL,'','activo','2','19',NULL,NULL),(12,'2017-04-01 13:00:00','pendiente','3','2017-04-09','2017-04-12 00:00:00',NULL,'','activo','2','22',NULL,NULL),(13,'2017-04-01 11:00:00','pendiente','3','2017-04-09','2017-04-12 00:00:00',NULL,'','activo','2','23',NULL,NULL),(15,'2017-04-01 16:00:00','pendiente','2','2017-04-10','2017-04-12 00:00:00',NULL,'12','activo','2','',NULL,'Alta'),(16,'2017-04-01 17:00:00','pendiente','2','2017-04-10','2017-04-01 00:00:00','LLegar a un acuerdo','13','activo','2','0','negocio','Alta'),(17,'2017-04-01 18:00:00','pendiente','5','2017-04-11','2017-04-11 00:00:00','auditoria para su empresa','14','activo','3','0','negocio','Media'),(18,'2017-04-01 19:00:00','pendiente','3','2017-04-12','2017-04-12 00:00:00','reparaciones de pcs','15','activo','3','0','negocio','Baja'),(19,'2017-04-01 08:00:00','pendiente','2','2017-04-17','2017-04-01 00:00:00','Ventas de servicios','16','activo','2','0','negocio','Alta'),(20,'2017-04-01 09:00:00','Pendiente','1','2017-04-17','2017-04-01 00:00:00','servidores','0','activo','4','24','caso','Media'),(21,'2017-04-20 10:00:00','pendiente','1','2017-04-17','2017-04-20 00:00:00','garantias','17','activo','1','0','negocio','Baja'),(22,'2017-04-01 11:00:00','Pendiente','1','2017-04-17','2017-04-01 00:00:00','nueva infraestructura','18','activo','1','0','negocio','Media'),(23,'2017-04-19 15:00:00','Pendiente','3','2017-04-18','2017-04-19 00:00:00','tutorias','19','activo','2','0','negocio','Alta'),(24,'2017-04-01 03:58:00','Pendiente','1','2017-04-24','2017-04-01 03:00:00','mi menta da mil vueltas','20','activo','1','0','negocio','Alta'),(25,'2017-04-01 04:00:00','Pendiente','2','2017-04-24','2017-04-01 15:00:00','inventario','0','activo','4','25','caso','Alta'),(26,'2017-04-01 17:00:00','Pendiente','2','2017-04-24','2017-04-01 16:00:00','inventario','0','activo','4','26','caso','Alta'),(27,'2017-04-24 06:00:00','Pendiente','4','2017-04-24','2017-04-24 17:00:00','erer','21','activo','2','0','negocio','Media'),(28,'2017-04-01 15:00:00','Pendiente','3','2017-04-24','2017-04-01 13:00:00','revisar','0','activo','4','27','caso','Media'),(29,'2017-04-01 14:00:00','Pendiente','3','2017-04-24','2017-04-01 13:00:00','DH','0','activo','4','28','caso','Media'),(30,'2017-04-01 14:00:00','Pendiente','1','2017-05-07','2017-04-01 13:00:00','nueva negociacion','22','activo','3','0','negocio','Alta');
/*!40000 ALTER TABLE `tbl_tarea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_tarea`
--

DROP TABLE IF EXISTS `tipo_tarea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_tarea` (
  `id_tipo` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_tarea`
--

LOCK TABLES `tipo_tarea` WRITE;
/*!40000 ALTER TABLE `tipo_tarea` DISABLE KEYS */;
INSERT INTO `tipo_tarea` VALUES (1,'Reunion'),(2,'Almuerzo'),(3,'Llamada'),(4,'Tarea'),(5,'Plazo');
/*!40000 ALTER TABLE `tipo_tarea` ENABLE KEYS */;
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
  `id_empleado` char(10) DEFAULT NULL,
  `tipo` char(20) DEFAULT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('MarioYuque','aABvAGwAYQA=','2017-02-20',NULL,NULL,NULL),('Marvin','aABvAGwAYQA=',NULL,NULL,NULL,'administrador'),('selvinn','aABvAGwAYQA=','2017-03-27',NULL,'1',NULL),('ycalito','aABvAGwAYQA=','2017-04-02',NULL,'1',NULL);
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
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario`,`id_aplicacion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_privilegios`
--

LOCK TABLES `usuario_privilegios` WRITE;
/*!40000 ALTER TABLE `usuario_privilegios` DISABLE KEYS */;
INSERT INTO `usuario_privilegios` VALUES ('Marvin',114,1,1,1,1,0),('Marvin',113,1,1,1,1,0),('Marvin',112,1,1,1,1,0),('Marvin',111,1,1,1,1,0),('Marvin',109,1,1,1,1,0),('Marvin',108,1,1,1,1,0),('Marvin',107,1,1,1,1,0),('Marvin',106,1,1,1,1,0),('Marvin',104,1,1,1,1,0),('selvinn',103,1,0,0,0,0),('selvinn',104,1,0,0,0,0),('selvinn',111,1,0,0,0,0),('ycalito',112,1,1,1,1,0),('ycalito',113,1,1,1,1,0),('ycalito',114,1,1,1,1,0),('Marvin',103,1,1,1,1,0),('Marvin',102,1,1,1,1,0),('Marvin',101,1,1,1,1,0);
/*!40000 ALTER TABLE `usuario_privilegios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `valor_moneda`
--

DROP TABLE IF EXISTS `valor_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `valor_moneda` (
  `id_valor_moneda` int(11) NOT NULL AUTO_INCREMENT,
  `valor` varchar(20) DEFAULT NULL,
  `id_moneda` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_valor_moneda`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `valor_moneda`
--

LOCK TABLES `valor_moneda` WRITE;
/*!40000 ALTER TABLE `valor_moneda` DISABLE KEYS */;
INSERT INTO `valor_moneda` VALUES (1,'7.49','2'),(2,'8.00','$.'),(3,'1','1'),(4,'7.44','2'),(5,'14.06','4');
/*!40000 ALTER TABLE `valor_moneda` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-17 22:43:38
