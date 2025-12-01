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
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_trail_tbl`
--

LOCK TABLES `audit_trail_tbl` WRITE;
/*!40000 ALTER TABLE `audit_trail_tbl` DISABLE KEYS */;
INSERT INTO `audit_trail_tbl` VALUES (1,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:05:50','2025-12-01 13:05:50'),(2,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:06:56','2025-12-01 13:06:56'),(3,7,'admin','admin','Logged out','','2025-12-01','21:07:05','2025-12-01 13:07:05'),(4,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:08:22','2025-12-01 13:08:22'),(5,7,'admin','admin','Logged out','','2025-12-01','21:08:39','2025-12-01 13:08:39'),(6,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:08:48','2025-12-01 13:08:48'),(7,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:11:42','2025-12-01 13:11:42'),(8,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:11:57','2025-12-01 13:11:57'),(9,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:12:46','2025-12-01 13:12:46'),(10,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:16:39','2025-12-01 13:16:39'),(11,7,'admin','admin','Logged out','','2025-12-01','21:16:43','2025-12-01 13:16:43'),(12,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:16:51','2025-12-01 13:16:51'),(13,6,'george','staff','Logged out','','2025-12-01','21:17:22','2025-12-01 13:17:22'),(14,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:18:51','2025-12-01 13:18:51'),(15,7,'admin','admin','Logged out','','2025-12-01','21:18:57','2025-12-01 13:18:57'),(16,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:19:06','2025-12-01 13:19:06'),(17,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:19:46','2025-12-01 13:19:46'),(18,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:21:29','2025-12-01 13:21:29'),(19,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:23:20','2025-12-01 13:23:20'),(20,7,'admin','admin','Logged out','','2025-12-01','21:23:22','2025-12-01 13:23:22'),(21,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:23:40','2025-12-01 13:23:40'),(22,7,'admin','admin','Logged out','','2025-12-01','21:24:41','2025-12-01 13:24:41'),(23,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:28:38','2025-12-01 13:28:38'),(24,7,'admin','admin','Logged out','','2025-12-01','21:29:38','2025-12-01 13:29:38'),(25,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:30:07','2025-12-01 13:30:07'),(26,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:31:10','2025-12-01 13:31:10'),(27,7,'admin','admin','Stock modified','Previous Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 45)\r\nCurrent Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)','2025-12-01','21:33:00','2025-12-01 13:33:00'),(28,7,'admin','admin','Session timeout due to inactivity','','2025-12-01','21:33:20','2025-12-01 13:33:20'),(29,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:20','2025-12-01 13:33:20'),(30,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:21','2025-12-01 13:33:21'),(31,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:22','2025-12-01 13:33:22'),(32,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:23','2025-12-01 13:33:23'),(33,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:23','2025-12-01 13:33:23'),(34,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:23','2025-12-01 13:33:23'),(35,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:23','2025-12-01 13:33:23'),(36,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:23','2025-12-01 13:33:23'),(37,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:24','2025-12-01 13:33:24'),(38,0,'','staff','Session timeout due to inactivity','','2025-12-01','21:33:24','2025-12-01 13:33:24'),(39,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:33:29','2025-12-01 13:33:29'),(40,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:35:50','2025-12-01 13:35:50'),(41,7,'admin','admin','Stock modified','Previous Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 20)','2025-12-01','21:36:10','2025-12-01 13:36:10'),(42,7,'admin','admin','Stock modified','Previous Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)','2025-12-01','21:36:21','2025-12-01 13:36:21'),(43,7,'admin','admin','Stock modified','Previous Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)','2025-12-01','21:36:25','2025-12-01 13:36:25'),(44,7,'admin','admin','Stock modified','Previous Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)','2025-12-01','21:36:35','2025-12-01 13:36:35'),(45,7,'admin','admin','Stock modified','Previous Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 10)','2025-12-01','21:36:49','2025-12-01 13:36:49'),(46,7,'admin','admin','Stock modified','Previous Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 10)','2025-12-01','21:36:56','2025-12-01 13:36:56'),(47,7,'admin','admin','Stock modified','Previous Stock Values (\r\nGround Beef, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 20)','2025-12-01','21:37:07','2025-12-01 13:37:07'),(48,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:37:31','2025-12-01 13:37:31'),(49,7,'admin','admin','Stock modified','Previous Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 20)\r\nCurrent Stock Values (\r\nFries, \r\nPrice: 30, \r\nQuantity: 10)','2025-12-01','21:37:44','2025-12-01 13:37:44'),(50,7,'admin','admin','Search','username=\'f\'','2025-12-01','21:38:17','2025-12-01 13:38:17'),(51,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:42:44','2025-12-01 13:42:44'),(52,7,'admin','admin','Stock added','User role: admin\r\nStock modified: Fries\r\nAdded value: 10\r\nCurrent Total stocks 10','2025-12-01','21:42:59','2025-12-01 13:42:59'),(53,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:44:11','2025-12-01 13:44:11'),(54,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:46:59','2025-12-01 13:46:59'),(55,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:48:43','2025-12-01 13:48:43'),(56,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:51:26','2025-12-01 13:51:26'),(57,6,'george','staff','Stock added','User role: staff\r\nStock modified: Ground Beef\r\nAdded value: 10\r\nCurrent Total stocks 10','2025-12-01','21:51:41','2025-12-01 13:51:41'),(58,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:52:39','2025-12-01 13:52:39'),(59,6,'george','staff','User logged in','Authorized Account','2025-12-01','21:54:08','2025-12-01 13:54:08'),(60,6,'george','staff','Logged out','','2025-12-01','21:54:17','2025-12-01 13:54:17'),(61,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:54:28','2025-12-01 13:54:28'),(62,7,'admin','admin','Stock modified','Previous Stock Values (\r\nGround Beef, \r\nPrice: 0.00, \r\nQuantity: 10)\r\nCurrent Stock Values (\r\nGround Beef, \r\nPrice: 20.00, \r\nQuantity: 20)','2025-12-01','21:54:46','2025-12-01 13:54:46'),(63,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:56:07','2025-12-01 13:56:07'),(64,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:56:23','2025-12-01 13:56:23'),(65,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:56:48','2025-12-01 13:56:48'),(66,7,'admin','admin','Logged out','','2025-12-01','21:57:21','2025-12-01 13:57:21'),(67,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:57:30','2025-12-01 13:57:30'),(68,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:58:06','2025-12-01 13:58:06'),(69,7,'admin','admin','User logged in','Authorized Account','2025-12-01','21:58:15','2025-12-01 13:58:15'),(70,7,'admin','admin','Database backed up','','2025-12-01','21:58:20','2025-12-01 13:58:20'),(71,7,'admin','admin','Logged out','','2025-12-01','21:58:22','2025-12-01 13:58:22'),(72,7,'admin','admin','User logged in','Authorized Account','2025-12-01','22:00:20','2025-12-01 14:00:20');
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
  `productprice` decimal(10,2) NOT NULL,
  `quantity` int NOT NULL,
  `is_deleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`productid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products_tbl`
--

LOCK TABLES `products_tbl` WRITE;
/*!40000 ALTER TABLE `products_tbl` DISABLE KEYS */;
INSERT INTO `products_tbl` VALUES (1,'Ground Beef',20.00,20,0),(2,'Bread Buns',10.00,70,0),(3,'Cheddar Slices',10.00,50,0),(4,'Tomato',8.00,24,0),(6,'Fries',30.00,10,0),(7,'Fries',10.00,10,0),(8,'Ground Beef',20.00,20,0);
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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_tbl`
--

LOCK TABLES `users_tbl` WRITE;
/*!40000 ALTER TABLE `users_tbl` DISABLE KEYS */;
INSERT INTO `users_tbl` VALUES (1,'232','45d515af03e67e4885866bb946ed457f30b68a227ccce202fd97608dc2682f13','admin','pending'),(2,'Andrei','948a3daa5d575dbf1f6661bf496f01d1cfc995e145bc524b411bc29e82ba4b5c','admin','authorized'),(3,'hello','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(4,'basta','1f60f019c4afa565621927d118448ac9f2bc585ffda9ebc38cd04d9c6baa74e0','admin','authorized'),(5,'martha','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(6,'george','6f6b4350de13e1d741be175f2bf01f796c41c0492ab911efa30630b13e24f59d','staff','authorized'),(7,'admin','6f6b4350de13e1d741be175f2bf01f796c41c0492ab911efa30630b13e24f59d','admin','authorized');
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

-- Dump completed on 2025-12-01 22:00:46
