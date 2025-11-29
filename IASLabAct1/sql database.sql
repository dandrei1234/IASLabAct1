-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: localhost    Database: user_authentication_db
-- ------------------------------------------------------
-- Server version	8.0.44

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `user_authentication_db`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `user_authentication_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `user_authentication_db`;

--
-- Table structure for table `audit_trail_tbl`
--

DROP TABLE IF EXISTS `audit_trail_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `audit_trail_tbl` (
  `auditId` int NOT NULL AUTO_INCREMENT,
  `userID` int DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `role` enum('staff','admin') DEFAULT NULL,
  `actionType` varchar(255) NOT NULL,
  `details` longtext,
  `date` date NOT NULL,
  `time` time NOT NULL,
  `timeStamp` timestamp NOT NULL,
  PRIMARY KEY (`auditId`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_trail_tbl`
--

LOCK TABLES `audit_trail_tbl` WRITE;
/*!40000 ALTER TABLE `audit_trail_tbl` DISABLE KEYS */;
INSERT INTO `audit_trail_tbl` VALUES (1,1,'admin','admin','Database backed up','','2025-11-29','15:41:25','2025-11-29 07:41:25'),(2,1,'admin','admin','Database backed up','','2025-11-29','15:41:55','2025-11-29 07:41:55'),(3,1,'admin','admin','User logged in','Authorized Account','2025-11-29','15:48:55','2025-11-29 07:48:55'),(4,0,'','staff','Failed logged in attempt','Attempted username: blablabla','2025-11-29','15:49:23','2025-11-29 07:49:23'),(5,0,'','staff','Login with username/password mismatch','Username: blablabla','2025-11-29','15:49:23','2025-11-29 07:49:23'),(6,1,'admin','admin','User logged in','Authorized Account','2025-11-29','15:56:25','2025-11-29 07:56:25'),(7,1,'admin','admin','User logged in','Authorized Account','2025-11-29','15:59:14','2025-11-29 07:59:14'),(8,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:00:35','2025-11-29 08:00:35'),(9,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:05:29','2025-11-29 08:05:29'),(10,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:05:52','2025-11-29 08:05:52'),(11,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:06:21','2025-11-29 08:06:21'),(12,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:07:17','2025-11-29 08:07:17'),(13,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:07:28','2025-11-29 08:07:28'),(14,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:08:18','2025-11-29 08:08:18'),(15,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:09:01','2025-11-29 08:09:01'),(16,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:10:37','2025-11-29 08:10:37'),(17,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:11:01','2025-11-29 08:11:01'),(18,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:22:33','2025-11-29 08:22:33'),(19,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:23:09','2025-11-29 08:23:09'),(20,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:23:41','2025-11-29 08:23:41'),(21,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:25:27','2025-11-29 08:25:27'),(22,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:27:07','2025-11-29 08:27:07'),(23,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:27:31','2025-11-29 08:27:31'),(24,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:32:52','2025-11-29 08:32:52'),(25,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:33:26','2025-11-29 08:33:26'),(26,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:34:19','2025-11-29 08:34:19'),(27,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:36:41','2025-11-29 08:36:41'),(28,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:36:59','2025-11-29 08:36:59'),(29,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:37:37','2025-11-29 08:37:37'),(30,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:37:53','2025-11-29 08:37:53'),(31,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:38:15','2025-11-29 08:38:15'),(32,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:39:19','2025-11-29 08:39:19'),(33,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:40:20','2025-11-29 08:40:20'),(34,0,'george','staff','Successful registered user account','Username: george','2025-11-29','16:45:13','2025-11-29 08:45:13'),(35,15,'george','staff','User logged in','Pending Account','2025-11-29','16:45:32','2025-11-29 08:45:32'),(36,15,'george','staff','User logged in','Authorized Account','2025-11-29','16:45:48','2025-11-29 08:45:48'),(37,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:46:25','2025-11-29 08:46:25'),(38,15,'george','staff','User logged in','Authorized Account','2025-11-29','16:46:33','2025-11-29 08:46:33'),(39,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:47:22','2025-11-29 08:47:22'),(40,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:52:19','2025-11-29 08:52:19'),(41,1,'admin','admin','Stock added','Stock modified: Cheddar Slices \r\nAdded value 20 \r\nCurrent Total stocks 70','2025-11-29','16:52:40','2025-11-29 08:52:40'),(42,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:53:21','2025-11-29 08:53:21'),(43,15,'george','staff','User logged in','Authorized Account','2025-11-29','16:53:25','2025-11-29 08:53:25'),(44,15,'george','staff','Stock added','Stock modified: Tomato, \r\nAdded value: 22, \r\nCurrent Total stocks 44','2025-11-29','16:53:38','2025-11-29 08:53:38'),(45,15,'george','staff','Stock added','Stock modified: Cheddar Slices, \r\nAdded value: 1, \r\nCurrent Total stocks 71','2025-11-29','16:54:06','2025-11-29 08:54:06'),(46,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:56:59','2025-11-29 08:56:59'),(47,15,'george','staff','User logged in','Authorized Account','2025-11-29','16:57:13','2025-11-29 08:57:13'),(48,15,'george','staff','User logged in','Authorized Account','2025-11-29','16:57:29','2025-11-29 08:57:29'),(49,1,'admin','admin','User logged in','Authorized Account','2025-11-29','16:58:23','2025-11-29 08:58:23'),(50,15,'george','staff','User logged in','Authorized Account','2025-11-29','16:58:32','2025-11-29 08:58:32'),(51,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:10:21','2025-11-29 09:10:21'),(52,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:26:45','2025-11-29 09:26:45'),(53,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:27:24','2025-11-29 09:27:24'),(54,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:28:08','2025-11-29 09:28:08'),(55,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:32:50','2025-11-29 09:32:50'),(56,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:33:02','2025-11-29 09:33:02'),(57,1,'admin','admin','User logged in','Authorized Account','2025-11-29','17:42:28','2025-11-29 09:42:28');
/*!40000 ALTER TABLE `audit_trail_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products_tbl`
--

DROP TABLE IF EXISTS `products_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products_tbl` (
  `productid` int NOT NULL AUTO_INCREMENT,
  `productname` varchar(45) NOT NULL,
  `productprice` decimal(10,0) NOT NULL,
  `quantity` int NOT NULL,
  `is_deleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`productid`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products_tbl`
--

LOCK TABLES `products_tbl` WRITE;
/*!40000 ALTER TABLE `products_tbl` DISABLE KEYS */;
INSERT INTO `products_tbl` VALUES (10,'Ground Beef',30,20,NULL),(11,'Bread Buns',10,70,NULL),(12,'Cheddar Slices',10,71,NULL),(13,'Tomato',8,44,1);
/*!40000 ALTER TABLE `products_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_tbl`
--

DROP TABLE IF EXISTS `users_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_tbl` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` enum('staff','admin') NOT NULL DEFAULT 'staff',
  `status` enum('pending','authorized','unauthorized') NOT NULL DEFAULT 'pending',
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_tbl`
--

LOCK TABLES `users_tbl` WRITE;
/*!40000 ALTER TABLE `users_tbl` DISABLE KEYS */;
INSERT INTO `users_tbl` VALUES (1,'admin','6f6b4350de13e1d741be175f2bf01f796c41c0492ab911efa30630b13e24f59d','admin','authorized'),(6,'abc','45d515af03e67e4885866bb946ed457f30b68a227ccce202fd97608dc2682f13','admin','pending'),(8,'Andrei','948a3daa5d575dbf1f6661bf496f01d1cfc995e145bc524b411bc29e82ba4b5c','admin','authorized'),(10,'hello','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(11,'hi','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(12,'martha','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(13,'cecillia','d866f8905986f0ad87b0a7d9374b0388559dd4065ee7ffe2e75fe5cbe980b40d','staff','pending'),(15,'george','6f6b4350de13e1d741be175f2bf01f796c41c0492ab911efa30630b13e24f59d','staff','authorized');
/*!40000 ALTER TABLE `users_tbl` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-29 17:42:58
