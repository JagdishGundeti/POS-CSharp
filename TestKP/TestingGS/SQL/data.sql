-- MySQL dump 10.16  Distrib 10.1.21-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: localhost
-- ------------------------------------------------------
-- Server version	10.1.21-MariaDB

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
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(30) DEFAULT NULL,
  `description` varchar(30) DEFAULT NULL,
  `ModifiedOn` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Gold-24-Karat','Gold-24-Karat',NULL),(2,'Gold-22-Karat','Gold-22-Karat',NULL),(3,'Silver','Silver',NULL);
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(30) DEFAULT NULL,
  `middlename` varchar(30) DEFAULT NULL,
  `lastname` varchar(30) DEFAULT NULL,
  `address` varchar(150) DEFAULT NULL,
  `phone_no` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (4,'Ramesh','','Pulpati','Add 1','9876543210'),(5,'Suresh','','Prabhu','Add 2','9876543211'),(6,'Subramanyam','','Swamy','Add 3','9876543212'),(7,'Ganesh','','Vamsi','Address 1','888845611');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daily_rates`
--
/*

DROP TABLE IF EXISTS `daily_rates`;
CREATE TABLE `daily_rates` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gold24karat` int(11) NOT NULL,
  `gold22karat` int(11) NOT NULL,
  `silver` int(11) NOT NULL,
  `ModifiedOn` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `daily_rates`
--

LOCK TABLES `daily_rates` WRITE;
INSERT INTO `daily_rates` VALUES (2,2356,2659,35001,'2017-08-02');
UNLOCK TABLES;
*/
--
-- Table structure for table `daily_rates_ex`
--

DROP TABLE IF EXISTS `daily_rates_ex`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daily_rates_ex` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_id` int(11) NOT NULL,
  `value` int(11) NOT NULL,
  `ModifiedOn` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_daily_rates_category_id` (`category_id`),
  CONSTRAINT `fk_daily_rates_category_id` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily_rates_ex`
--

LOCK TABLES `daily_rates_ex` WRITE;
/*!40000 ALTER TABLE `daily_rates_ex` DISABLE KEYS */;
INSERT INTO `daily_rates_ex` VALUES (16,1,31000,'2017-08-26'),(17,2,29000,'2017-08-26'),(18,3,65000,'2017-08-26'),(19,1,30001,'2017-08-25'),(20,2,28001,'2017-08-25'),(21,3,61001,'2017-08-25'),(22,1,29500,'2017-08-27'),(23,2,8000,'2017-08-27'),(24,3,55000,'2017-08-27');
/*!40000 ALTER TABLE `daily_rates_ex` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_txn`
--

DROP TABLE IF EXISTS `order_txn`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_txn` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` float NOT NULL,
  `ModifiedOn` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `customer_id` (`customer_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `order_txn_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`),
  CONSTRAINT `order_txn_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_txn`
--

LOCK TABLES `order_txn` WRITE;
/*!40000 ALTER TABLE `order_txn` DISABLE KEYS */;
INSERT INTO `order_txn` VALUES (1,7,8,10,45000,'2017-08-02'),(2,7,8,10,545454,'2017-08-02'),(3,7,9,10,45001,'2017-08-27'),(4,4,10,1,55000,'2017-08-27'),(5,5,9,9,91000,'2017-08-27');
/*!40000 ALTER TABLE `order_txn` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  `details` varchar(150) DEFAULT NULL,
  `category` varchar(30) DEFAULT 'Gold',
  `category_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_category_id` (`category_id`),
  CONSTRAINT `fk_category_id` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (8,'Small Ring','Small Ring','Gold',1),(9,'Mangalsutram','Mangalsutram','Gold',1),(10,'Vigraha','Vigraha','Gold',3),(11,'Pedda Golsu','Pedda Golsu','Gold',1);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-27 21:07:53

