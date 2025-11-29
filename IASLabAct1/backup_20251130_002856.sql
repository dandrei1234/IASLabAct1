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
) ENGINE=InnoDB AUTO_INCREMENT=324 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_trail_tbl`
--

LOCK TABLES `audit_trail_tbl` WRITE;
/*!40000 ALTER TABLE `audit_trail_tbl` DISABLE KEYS */;
INSERT INTO `audit_trail_tbl` VALUES (156,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:07:20','2025-11-29 13:07:20'),(157,1,'admin','admin','Logged out','','2025-11-29','21:07:22','2025-11-29 13:07:22'),(158,15,'george','staff','User logged in','Authorized Account','2025-11-29','21:08:13','2025-11-29 13:08:13'),(159,15,'george','staff','Logged out','','2025-11-29','21:08:17','2025-11-29 13:08:17'),(160,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:08:47','2025-11-29 13:08:47'),(161,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:09:30','2025-11-29 13:09:30'),(162,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:35:57','2025-11-29 13:35:57'),(163,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:37:52','2025-11-29 13:37:52'),(164,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:40:53','2025-11-29 13:40:53'),(165,1,'admin','admin','User logged in','Authorized Account','2025-11-29','21:56:16','2025-11-29 13:56:16'),(166,1,'admin','admin','User created successful','username=\'mamatayTayo, status=\'pending, role=\'staff','2025-11-29','21:57:19','2025-11-29 13:57:19'),(167,1,'admin','admin','User logged in','Authorized Account','2025-11-29','22:03:34','2025-11-29 14:03:34'),(168,1,'admin','admin','User created successful','username=\'tatttaaa, status=\'pending, role=\'staff','2025-11-29','22:03:51','2025-11-29 14:03:51'),(169,1,'admin','admin','User updated successfully','Password changed=False, Previous credentials: (username=\'tae\', status=\'authorized, role=\'staff\') Current credentials: username=\'77, status=\'pending, role=\'admin\')','2025-11-29','22:04:09','2025-11-29 14:04:09'),(170,1,'admin','admin','User updated successfully','Password changed=True, Previous credentials: (username=\'77\', status=\'pending, role=\'admin\') Current credentials: username=\'sss, status=\'unauthorized, role=\'staff\')','2025-11-29','22:05:10','2025-11-29 14:05:10'),(171,1,'admin','admin','User logged in','Authorized Account','2025-11-29','22:11:01','2025-11-29 14:11:01'),(172,1,'admin','admin','Deleted User','username=\'mamatayTayo, status=\'pending, role=\'staff','2025-11-29','22:11:05','2025-11-29 14:11:05'),(173,1,'admin','admin','User logged in','Authorized Account','2025-11-29','22:11:42','2025-11-29 14:11:42'),(174,1,'admin','admin','Error in attempting to delete user','id=','2025-11-29','22:11:50','2025-11-29 14:11:50'),(175,1,'admin','admin','Attempted to delete a non-existent user','id=22','2025-11-29','22:12:06','2025-11-29 14:12:06'),(176,1,'admin','admin','User logged in','Authorized Account','2025-11-29','22:16:33','2025-11-29 14:16:33'),(177,1,'admin','admin','Search','username=\', ','2025-11-29','22:16:35','2025-11-29 14:16:35'),(178,1,'admin','admin','User logged in','Authorized Account','2025-11-29','22:18:42','2025-11-29 14:18:42'),(179,1,'admin','admin','Search','username=\'admin\'','2025-11-29','22:18:52','2025-11-29 14:18:52'),(180,1,'admin','admin','User logged in','Authorized Account','2025-11-29','22:19:33','2025-11-29 14:19:33'),(181,1,'admin','admin','Search','username=\'gro\'','2025-11-29','22:19:41','2025-11-29 14:19:41'),(182,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:15:59','2025-11-29 15:15:59'),(183,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:17:24','2025-11-29 15:17:24'),(184,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:18:10','2025-11-29 15:18:10'),(185,1,'admin','admin','Logged out','','2025-11-29','23:18:50','2025-11-29 15:18:50'),(186,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:19:05','2025-11-29 15:19:05'),(187,1,'admin','admin','Logged out','','2025-11-29','23:19:07','2025-11-29 15:19:07'),(188,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:19:51','2025-11-29 15:19:51'),(189,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:23:00','2025-11-29 15:23:00'),(190,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:24:09','2025-11-29 15:24:09'),(191,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:26:23','2025-11-29 15:26:23'),(192,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:27:39','2025-11-29 15:27:39'),(193,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:28:21','2025-11-29 15:28:21'),(194,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:28:28','2025-11-29 15:28:28'),(195,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:28:33','2025-11-29 15:28:33'),(196,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:28:40','2025-11-29 15:28:40'),(197,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:28:42','2025-11-29 15:28:42'),(198,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:28:44','2025-11-29 15:28:44'),(199,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:28:49','2025-11-29 15:28:49'),(200,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:28:51','2025-11-29 15:28:51'),(201,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:29:08','2025-11-29 15:29:08'),(202,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:29:12','2025-11-29 15:29:12'),(203,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:29:17','2025-11-29 15:29:17'),(204,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:29:19','2025-11-29 15:29:19'),(205,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:29:54','2025-11-29 15:29:54'),(206,1,'admin','admin','Logged out','','2025-11-29','23:29:56','2025-11-29 15:29:56'),(207,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:30:20','2025-11-29 15:30:20'),(208,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:30:33','2025-11-29 15:30:33'),(209,1,'admin','admin','Logged out','','2025-11-29','23:30:37','2025-11-29 15:30:37'),(210,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:32:57','2025-11-29 15:32:57'),(211,1,'admin','admin','Logged out','','2025-11-29','23:32:59','2025-11-29 15:32:59'),(212,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:33:57','2025-11-29 15:33:57'),(213,1,'admin','admin','Logged out','','2025-11-29','23:34:00','2025-11-29 15:34:00'),(214,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:34:34','2025-11-29 15:34:34'),(215,1,'admin','admin','Logged out','','2025-11-29','23:34:35','2025-11-29 15:34:35'),(216,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:34:47','2025-11-29 15:34:47'),(217,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:34:51','2025-11-29 15:34:51'),(218,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:35:02','2025-11-29 15:35:02'),(219,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:35:04','2025-11-29 15:35:04'),(220,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:35:06','2025-11-29 15:35:06'),(221,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:35:08','2025-11-29 15:35:08'),(222,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:35:11','2025-11-29 15:35:11'),(223,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:35:13','2025-11-29 15:35:13'),(224,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:36:35','2025-11-29 15:36:35'),(225,1,'admin','admin','Logged out','','2025-11-29','23:36:37','2025-11-29 15:36:37'),(226,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:36:44','2025-11-29 15:36:44'),(227,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:36:47','2025-11-29 15:36:47'),(228,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:36:49','2025-11-29 15:36:49'),(229,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:40:25','2025-11-29 15:40:25'),(230,1,'admin','admin','Logged out','','2025-11-29','23:40:27','2025-11-29 15:40:27'),(231,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:40:38','2025-11-29 15:40:38'),(232,1,'admin','admin','Logged out','','2025-11-29','23:40:40','2025-11-29 15:40:40'),(233,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:40:49','2025-11-29 15:40:49'),(234,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:40:50','2025-11-29 15:40:50'),(235,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:40:54','2025-11-29 15:40:54'),(236,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:40:56','2025-11-29 15:40:56'),(237,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:40:58','2025-11-29 15:40:58'),(238,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:41:11','2025-11-29 15:41:11'),(239,1,'admin','admin','Logged out','','2025-11-29','23:41:24','2025-11-29 15:41:24'),(240,15,'george','staff','User logged in','Authorized Account','2025-11-29','23:41:30','2025-11-29 15:41:30'),(241,15,'george','staff','Session timeout due to inactivity','','2025-11-29','23:41:39','2025-11-29 15:41:39'),(242,15,'george','staff','User logged in','Authorized Account','2025-11-29','23:41:43','2025-11-29 15:41:43'),(243,15,'george','staff','Session timeout due to inactivity','','2025-11-29','23:41:45','2025-11-29 15:41:45'),(244,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:41:46','2025-11-29 15:41:46'),(245,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:41:59','2025-11-29 15:41:59'),(246,1,'admin','admin','Logged out','','2025-11-29','23:42:01','2025-11-29 15:42:01'),(247,15,'george','staff','User logged in','Authorized Account','2025-11-29','23:42:08','2025-11-29 15:42:08'),(248,15,'george','staff','Session timeout due to inactivity','','2025-11-29','23:42:21','2025-11-29 15:42:21'),(249,15,'george','staff','User logged in','Authorized Account','2025-11-29','23:43:16','2025-11-29 15:43:16'),(250,15,'george','staff','Session timeout due to inactivity','','2025-11-29','23:43:25','2025-11-29 15:43:25'),(251,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:43:27','2025-11-29 15:43:27'),(252,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:43:29','2025-11-29 15:43:29'),(253,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:46:02','2025-11-29 15:46:02'),(254,1,'admin','admin','Logged out','','2025-11-29','23:46:04','2025-11-29 15:46:04'),(255,15,'george','staff','User logged in','Authorized Account','2025-11-29','23:46:10','2025-11-29 15:46:10'),(256,15,'george','staff','Logged out','','2025-11-29','23:46:17','2025-11-29 15:46:17'),(257,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:48:17','2025-11-29 15:48:17'),(258,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:52:22','2025-11-29 15:52:22'),(259,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:52:29','2025-11-29 15:52:29'),(260,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:52:41','2025-11-29 15:52:41'),(261,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:53:17','2025-11-29 15:53:17'),(262,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:53:32','2025-11-29 15:53:32'),(263,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:53:36','2025-11-29 15:53:36'),(264,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:53:37','2025-11-29 15:53:37'),(265,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:53:44','2025-11-29 15:53:44'),(266,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:54:00','2025-11-29 15:54:00'),(267,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:55:24','2025-11-29 15:55:24'),(268,1,'admin','admin','Session timeout due to inactivity','','2025-11-29','23:55:59','2025-11-29 15:55:59'),(269,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:56:04','2025-11-29 15:56:04'),(270,0,'','staff','Session timeout due to inactivity','','2025-11-29','23:56:06','2025-11-29 15:56:06'),(271,1,'admin','admin','User logged in','Authorized Account','2025-11-29','23:59:40','2025-11-29 15:59:40'),(272,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:00:19','2025-11-29 16:00:19'),(273,1,'admin','admin','Logged out','','2025-11-30','00:00:33','2025-11-29 16:00:33'),(274,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:00:47','2025-11-29 16:00:47'),(275,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:01:07','2025-11-29 16:01:07'),(276,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:01:14','2025-11-29 16:01:14'),(277,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:04:45','2025-11-29 16:04:45'),(278,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:04:56','2025-11-29 16:04:56'),(279,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:05:37','2025-11-29 16:05:37'),(280,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:05:50','2025-11-29 16:05:50'),(281,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:05:54','2025-11-29 16:05:54'),(282,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:05:55','2025-11-29 16:05:55'),(283,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:06:02','2025-11-29 16:06:02'),(284,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:06:08','2025-11-29 16:06:08'),(285,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:06:14','2025-11-29 16:06:14'),(286,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:10:54','2025-11-29 16:10:54'),(287,1,'admin','admin','User updated successfully','Password changed=False, Previous credentials: (username=\'admin\', status=\'authorized, role=\'admin\') Current credentials: (username=\'admin, status=\'authorized, role=\'admin\')','2025-11-30','00:11:02','2025-11-29 16:11:02'),(288,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:11:05','2025-11-29 16:11:05'),(289,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:11:06','2025-11-29 16:11:06'),(290,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:11:07','2025-11-29 16:11:07'),(291,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:11:18','2025-11-29 16:11:18'),(292,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:12:17','2025-11-29 16:12:17'),(293,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:12:46','2025-11-29 16:12:46'),(294,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:12:47','2025-11-29 16:12:47'),(295,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:12:54','2025-11-29 16:12:54'),(296,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:13:03','2025-11-29 16:13:03'),(297,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:13:27','2025-11-29 16:13:27'),(298,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:13:50','2025-11-29 16:13:50'),(299,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:13:56','2025-11-29 16:13:56'),(300,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:14:10','2025-11-29 16:14:10'),(301,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:20:59','2025-11-29 16:20:59'),(302,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:23:13','2025-11-29 16:23:13'),(303,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:23:43','2025-11-29 16:23:43'),(304,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:23:45','2025-11-29 16:23:45'),(305,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:23:46','2025-11-29 16:23:46'),(306,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:23:47','2025-11-29 16:23:47'),(307,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:23:51','2025-11-29 16:23:51'),(308,1,'admin','admin','Logged out','','2025-11-30','00:24:10','2025-11-29 16:24:10'),(309,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:24:19','2025-11-29 16:24:19'),(310,1,'admin','admin','Logged out','','2025-11-30','00:24:40','2025-11-29 16:24:40'),(311,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:24:45','2025-11-29 16:24:45'),(312,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:24:58','2025-11-29 16:24:58'),(313,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:25:00','2025-11-29 16:25:00'),(314,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:25:06','2025-11-29 16:25:06'),(315,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:25:19','2025-11-29 16:25:19'),(316,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:25:20','2025-11-29 16:25:20'),(317,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:25:25','2025-11-29 16:25:25'),(318,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:27:35','2025-11-29 16:27:35'),(319,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:28:18','2025-11-29 16:28:18'),(320,0,'','staff','Session timeout due to inactivity','','2025-11-30','00:28:19','2025-11-29 16:28:19'),(321,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:28:26','2025-11-29 16:28:26'),(322,1,'admin','admin','Session timeout due to inactivity','','2025-11-30','00:28:34','2025-11-29 16:28:34'),(323,1,'admin','admin','User logged in','Authorized Account','2025-11-30','00:28:53','2025-11-29 16:28:53');
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
INSERT INTO `products_tbl` VALUES (10,'Ground Beef',1,1,0),(11,'Bread Buns',10,72,0),(12,'Cheddar Slices',10000,74,0),(13,'Tomato',8,56,0);
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_tbl`
--

LOCK TABLES `users_tbl` WRITE;
/*!40000 ALTER TABLE `users_tbl` DISABLE KEYS */;
INSERT INTO `users_tbl` VALUES (1,'admin','6f6b4350de13e1d741be175f2bf01f796c41c0492ab911efa30630b13e24f59d','admin','authorized'),(6,'abc','45d515af03e67e4885866bb946ed457f30b68a227ccce202fd97608dc2682f13','admin','pending'),(8,'Andrei','948a3daa5d575dbf1f6661bf496f01d1cfc995e145bc524b411bc29e82ba4b5c','admin','authorized'),(10,'hello','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(11,'basta','1f60f019c4afa565621927d118448ac9f2bc585ffda9ebc38cd04d9c6baa74e0','admin','authorized'),(12,'martha','d5d0f40d94b53b27acfea8ea8f4f8aa3f2e7a3a8517b4bb1a47ff7ba4f413687','staff','pending'),(15,'george','6f6b4350de13e1d741be175f2bf01f796c41c0492ab911efa30630b13e24f59d','staff','authorized');
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

-- Dump completed on 2025-11-30  0:28:59
