-- MySQL dump 10.16  Distrib 10.1.25-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: kpsonar
-- ------------------------------------------------------
-- Server version	10.1.25-MariaDB

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
INSERT INTO `category` VALUES (1,'Gold-Bar','Gold-24-Karat',NULL),(2,'Gold-Ornament','Gold-22-Karat',NULL),(3,'Silver','Silver',NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (4,'RAMESH','','PULPATI','ADD 1','9876543210'),(5,'SURESH','','PRABHU','ADD 2','9876543211'),(6,'SUBRAMANYAM','','SWAMY','ADD 3','9876543212'),(7,'GANESH','','VAMSI','ADDRESS 1','888845611'),(8,'LAXMAN','','','WORLI','1234567890');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily_rates_ex`
--

LOCK TABLES `daily_rates_ex` WRITE;
/*!40000 ALTER TABLE `daily_rates_ex` DISABLE KEYS */;
INSERT INTO `daily_rates_ex` VALUES (37,1,2800,'2017-09-03'),(38,2,2400,'2017-09-03'),(39,3,1200,'2017-09-03'),(40,1,2900,'2017-09-04'),(41,2,2700,'2017-09-04'),(42,3,1500,'2017-09-04'),(43,1,2900,'2017-09-05'),(44,2,2700,'2017-09-05'),(45,3,1050,'2017-09-05'),(46,1,3100,'2017-09-11'),(47,2,3000,'2017-09-11'),(48,3,1000,'2017-09-11'),(49,1,32000,'2018-03-15'),(50,2,31000,'2018-03-15'),(51,3,10000,'2018-03-15'),(52,1,3100,'2018-03-16'),(53,2,3000,'2018-03-16'),(54,3,1000,'2018-03-16'),(55,1,3200,'2018-03-18'),(56,2,3100,'2018-03-18'),(57,3,1000,'2018-03-18'),(58,1,3100,'2018-03-19'),(59,2,2900,'2018-03-19'),(60,3,100,'2018-03-19');
/*!40000 ALTER TABLE `daily_rates_ex` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(30) NOT NULL,
  `firstname` varchar(30) DEFAULT NULL,
  `middlename` varchar(30) DEFAULT NULL,
  `lastname` varchar(30) DEFAULT NULL,
  `address` varchar(150) DEFAULT NULL,
  `phone_no` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (9,'E1','EMP1','','','',''),(10,'E2','EMP2','','','','');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoices` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `invoice_date_created` date NOT NULL,
  `invoice_time_created` time NOT NULL DEFAULT '00:00:00',
  `invoice_date_modified` datetime NOT NULL,
  `invoice_date_due` date NOT NULL,
  `invoice_number` varchar(100) DEFAULT NULL,
  `payment_method` int(11) NOT NULL DEFAULT '0',
  `paid_price_1` float(11,2) NOT NULL DEFAULT '0.00',
  `paid_price_2` float(11,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
INSERT INTO `invoices` VALUES (1,8,'2018-03-18','00:00:00','2018-03-18 00:00:00','0000-00-00',NULL,0,0.00,0.00);
/*!40000 ALTER TABLE `invoices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_txn`
--

DROP TABLE IF EXISTS `order_txn`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_txn` (
  `id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `invoice_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `work_start_date` date DEFAULT NULL,
  `work_end_date` date DEFAULT NULL,
  `quantity` int(11) NOT NULL,
  `price` float NOT NULL,
  `CGST` float(8,2) DEFAULT NULL,
  `SGST` float(8,2) DEFAULT NULL,
  `total_price` float(10,2) DEFAULT NULL,
  `ModifiedOn` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `customer_id` (`customer_id`),
  KEY `product_id` (`product_id`),
  KEY `invoice_id` (`invoice_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `order_txn_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`),
  CONSTRAINT `order_txn_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  CONSTRAINT `order_txn_ibfk_3` FOREIGN KEY (`invoice_id`) REFERENCES `invoices` (`id`),
  CONSTRAINT `order_txn_ibfk_4` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_txn`
--

LOCK TABLES `order_txn` WRITE;
/*!40000 ALTER TABLE `order_txn` DISABLE KEYS */;
INSERT INTO `order_txn` VALUES (0,8,15,1,10,NULL,NULL,1,3200,48.00,48.00,3296.00,'2018-03-18');
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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (15,'Small Ring','Small Ring','Gold',1),(16,'Wide Ring','Wide Ring','Gold',1);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tableinfo`
--

DROP TABLE IF EXISTS `tableinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tableinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tableinfo`
--

LOCK TABLES `tableinfo` WRITE;
/*!40000 ALTER TABLE `tableinfo` DISABLE KEYS */;
INSERT INTO `tableinfo` VALUES (8,'John Smith',33);
/*!40000 ALTER TABLE `tableinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-19 19:55:47

