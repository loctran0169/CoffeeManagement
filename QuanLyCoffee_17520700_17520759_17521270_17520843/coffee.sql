CREATE DATABASE  IF NOT EXISTS `coffee` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;
USE `coffee`;
-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: coffee
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `baocao`
--

DROP TABLE IF EXISTS `baocao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `baocao` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaBC` char(10) COLLATE utf8_bin NOT NULL,
  `MaNV` char(10) COLLATE utf8_bin DEFAULT NULL,
  `Loai` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `ThoiGian` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaBC`),
  KEY `FK_BC_NV` (`MaNV`),
  CONSTRAINT `FK_BC_NV` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `baocao`
--

LOCK TABLES `baocao` WRITE;
/*!40000 ALTER TABLE `baocao` DISABLE KEYS */;
INSERT INTO `baocao` VALUES (2,'BC0002','NV0001','Doanh thu','2019-12-16 16:20:22'),(3,'BC0003','NV0001','Doanh thu','2019-12-16 16:27:15'),(4,'BC0004','NV0001','Kho','2019-12-16 17:35:14'),(5,'BC0005','NV0001','Kho','2019-12-16 17:36:02'),(6,'BC0006','NV0001','Kho','2019-12-16 17:42:22');
/*!40000 ALTER TABLE `baocao` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_baocao_insert` BEFORE INSERT ON `baocao` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM baocao ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.mabc = CONCAT('BC', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.mabc = CONCAT('BC', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `cthoadon`
--

DROP TABLE IF EXISTS `cthoadon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cthoadon` (
  `MaHD` char(10) COLLATE utf8_bin NOT NULL,
  `MaSP` char(10) COLLATE utf8_bin NOT NULL,
  `SoLuong` float DEFAULT NULL,
  `DonGia` float DEFAULT NULL,
  PRIMARY KEY (`MaHD`,`MaSP`),
  KEY `FK_ct_SP` (`MaSP`),
  CONSTRAINT `FK_ct_SP` FOREIGN KEY (`MaSP`) REFERENCES `sanpham` (`MaSP`),
  CONSTRAINT `cthoadon_ibfk_1` FOREIGN KEY (`MaHD`) REFERENCES `hoadon` (`MaHD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cthoadon`
--

LOCK TABLES `cthoadon` WRITE;
/*!40000 ALTER TABLE `cthoadon` DISABLE KEYS */;
/*!40000 ALTER TABLE `cthoadon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ctphieunhap`
--

DROP TABLE IF EXISTS `ctphieunhap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ctphieunhap` (
  `MaPN` char(10) COLLATE utf8_bin NOT NULL,
  `MaNL` char(10) COLLATE utf8_bin NOT NULL,
  `SoLuong` float DEFAULT NULL,
  `DonGia` float DEFAULT NULL,
  PRIMARY KEY (`MaPN`,`MaNL`),
  CONSTRAINT `ctphieunhap_ibfk_1` FOREIGN KEY (`MaPN`) REFERENCES `phieunhap` (`MaPN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ctphieunhap`
--

LOCK TABLES `ctphieunhap` WRITE;
/*!40000 ALTER TABLE `ctphieunhap` DISABLE KEYS */;
INSERT INTO `ctphieunhap` VALUES ('PN0001','NL0001',12,24000),('PN0001','NL0002',12,16000),('PN0001','NL0003',12,15000),('PN0002','NL0002',11,16000),('PN0003','NL0002',123,16000),('PN0003','NL0003',123,15000),('PN0004','NL0001',12,24000),('PN0004','NL0002',12,16000),('PN0005','NL0001',123,24000),('PN0005','NL0002',123,16000),('PN0005','NL0003',123,15000),('PN0006','NL0001',12,24000),('PN0006','NL0002',123123,16000),('PN0007','NL0002',132,16000),('PN0007','NL0004',12,17000);
/*!40000 ALTER TABLE `ctphieunhap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ctphieuxuat`
--

DROP TABLE IF EXISTS `ctphieuxuat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ctphieuxuat` (
  `MaPX` char(10) COLLATE utf8_bin NOT NULL,
  `MaNL` char(10) COLLATE utf8_bin NOT NULL,
  `SoLuong` float DEFAULT NULL,
  `DonGia` float DEFAULT NULL,
  PRIMARY KEY (`MaPX`,`MaNL`),
  KEY `FK_NL` (`MaNL`),
  CONSTRAINT `FK_PX` FOREIGN KEY (`MaPX`) REFERENCES `phieuxuat` (`MaPX`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ctphieuxuat`
--

LOCK TABLES `ctphieuxuat` WRITE;
/*!40000 ALTER TABLE `ctphieuxuat` DISABLE KEYS */;
INSERT INTO `ctphieuxuat` VALUES ('PX0001','NL0001',123,24000),('PX0002','NL0001',24234,24000),('PX0002','NL0002',23424,16000),('PX0002','NL0003',24234,15000),('PX0003','NL0001',9.9,24000),('PX0003','NL0002',8.8,16000),('PX0003','NL0003',1.112,15000),('PX0004','NL0001',1.111,24000),('PX0004','NL0002',10,16000),('PX0005','NL0001',12,24000),('PX0005','NL0002',112,16000),('PX0006','NL0002',242,16000),('PX0007','NL0002',123,16000),('PX0007','NL0003',13,15000);
/*!40000 ALTER TABLE `ctphieuxuat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donvi`
--

DROP TABLE IF EXISTS `donvi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `donvi` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaDV` char(10) COLLATE utf8_bin NOT NULL,
  `TenDV` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `GhiChu` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaDV`),
  KEY `sanpham_ibfk_1` (`MaDV`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donvi`
--

LOCK TABLES `donvi` WRITE;
/*!40000 ALTER TABLE `donvi` DISABLE KEYS */;
INSERT INTO `donvi` VALUES (1,'DV0001','Size S','loại nhỏ'),(2,'DV0002','Size L','loại lớn'),(3,'DV0003','ly',''),(4,'DV0004','kg',NULL);
/*!40000 ALTER TABLE `donvi` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_donvi_insert` BEFORE INSERT ON `donvi` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM donvi ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.madv = CONCAT('DV', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.madv = CONCAT('DV', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `hoadon`
--

DROP TABLE IF EXISTS `hoadon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hoadon` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaHD` char(10) COLLATE utf8_bin NOT NULL,
  `MaNV` char(10) COLLATE utf8_bin DEFAULT NULL,
  `NgayLap` datetime DEFAULT NULL,
  `TongTien` float DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaHD`),
  KEY `cthoadon_ibfk_1` (`MaHD`),
  KEY `hoadon_ibfk_1` (`MaNV`),
  CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hoadon`
--

LOCK TABLES `hoadon` WRITE;
/*!40000 ALTER TABLE `hoadon` DISABLE KEYS */;

/*!40000 ALTER TABLE `hoadon` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_hoadon_insert` BEFORE INSERT ON `hoadon` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM hoadon ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.mahd = CONCAT('HD', LPAD(@idm+1, 5, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.mahd = CONCAT('HD', LPAD(1, 5, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `nguyenlieu`
--

DROP TABLE IF EXISTS `nguyenlieu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nguyenlieu` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaNL` char(10) COLLATE utf8_bin NOT NULL,
  `TenNL` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `MaDV` char(10) COLLATE utf8_bin NOT NULL,
  `SoLuongTon` float DEFAULT NULL,
  `GiaNhap` float DEFAULT NULL,
  `GiaBan` float DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaNL`),
  KEY `ctphieunhap_ibfk_2` (`MaNL`),
  KEY `MaDV` (`MaDV`),
  CONSTRAINT `nguyenlieu_ibfk_1` FOREIGN KEY (`MaDV`) REFERENCES `donvi` (`MaDV`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nguyenlieu`
--

LOCK TABLES `nguyenlieu` WRITE;
/*!40000 ALTER TABLE `nguyenlieu` DISABLE KEYS */;
INSERT INTO `nguyenlieu` VALUES (1,'NL0001','Bột mì','DV0004',14.5,23000,24000),(2,'NL0002','Bột gạo','DV0004',123.5,15000,16000),(3,'NL0003','Bột củ năng','DV0004',98,14000,15000),(4,'NL0004','Bột nghệ','DV0004',55,16000,19500);
/*!40000 ALTER TABLE `nguyenlieu` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_nguyenlieu_insert` BEFORE INSERT ON `nguyenlieu` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM nguyenlieu ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.manl = CONCAT('NL', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.manl = CONCAT('NL', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nhanvien` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaNV` char(10) COLLATE utf8_bin NOT NULL,
  `TenNV` varchar(200) COLLATE utf8_bin DEFAULT NULL,
  `NgaySinh` datetime DEFAULT NULL,
  `GioiTinh` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `DiaChi` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `SDT` char(15) COLLATE utf8_bin DEFAULT NULL,
  `Email` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `MaTK` char(10) COLLATE utf8_bin DEFAULT NULL,
  `GhiChu` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaNV`),
  KEY `hoadon_ibfk_1` (`MaNV`),
  KEY `MaTK` (`MaTK`),
  CONSTRAINT `nhanvien_ibfk_1` FOREIGN KEY (`MaTK`) REFERENCES `taikhoan` (`MaTK`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES (1,'NV0001','Trần Hữu Lộc','1999-05-21 00:00:00','Nam','Cần Đước, Long An','0971244421','loctran0169@gmail.com','TK0001','không');
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_nhanvien_insert` BEFORE INSERT ON `nhanvien` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM nhanvien ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.manv = CONCAT('NV', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.manv = CONCAT('NV', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `phanquyen`
--

DROP TABLE IF EXISTS `phanquyen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phanquyen` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaPQ` char(10) COLLATE utf8_bin NOT NULL,
  `TenPhanQuyen` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaPQ`),
  KEY `taikhoan_ibfk_1` (`MaPQ`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phanquyen`
--

LOCK TABLES `phanquyen` WRITE;
/*!40000 ALTER TABLE `phanquyen` DISABLE KEYS */;
INSERT INTO `phanquyen` VALUES (1,'PQ0001','admin');
/*!40000 ALTER TABLE `phanquyen` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_phanquyen_insert` BEFORE INSERT ON `phanquyen` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM phanquyen ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.mapq = CONCAT('PQ', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.mapq = CONCAT('PQ', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `phieunhap`
--

DROP TABLE IF EXISTS `phieunhap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phieunhap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaPN` char(10) COLLATE utf8_bin NOT NULL,
  `MaNV` char(10) COLLATE utf8_bin DEFAULT NULL,
  `NgayLap` datetime DEFAULT NULL,
  `NgayNhap` datetime DEFAULT NULL,
  `DiaChi` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `TinhTrang` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `TongTien` float DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaPN`),
  KEY `ctphieunhap_ibfk_1` (`MaPN`),
  KEY `FK_PN_NV` (`MaNV`),
  CONSTRAINT `FK_PN_NV` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieunhap`
--

LOCK TABLES `phieunhap` WRITE;
/*!40000 ALTER TABLE `phieunhap` DISABLE KEYS */;
INSERT INTO `phieunhap` VALUES (1,'PN0001','NV0001','2019-12-12 17:56:17','2019-12-11 00:00:00','12','False',660000),(2,'PN0002','NV0001','2019-12-12 17:56:43','2019-12-12 00:00:00','11','False',176000),(3,'PN0003','NV0001','2019-12-16 11:52:26','2019-12-11 00:00:00','123','False',3813000),(4,'PN0004','NV0001','2019-12-16 12:09:50','2019-12-11 00:00:00','12','False',480000),(5,'PN0005','NV0001','2019-12-16 12:11:06','2019-12-11 00:00:00','123','False',6765000),(6,'PN0006','NV0001','2019-12-16 13:25:49','2019-12-11 00:00:00','123123','False',1970260000),(7,'PN0007','NV0001','2019-12-16 13:29:28','2019-12-11 00:00:00','12312','False',2112000);
/*!40000 ALTER TABLE `phieunhap` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_phieunhap_insert` BEFORE INSERT ON `phieunhap` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM phieunhap ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.mapn = CONCAT('PN', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.mapn = CONCAT('PN', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `phieuxuat`
--

DROP TABLE IF EXISTS `phieuxuat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phieuxuat` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaPX` char(10) COLLATE utf8_bin NOT NULL,
  `MaNV` char(10) COLLATE utf8_bin DEFAULT NULL,
  `NgayLap` datetime DEFAULT NULL,
  `NgayXuat` datetime DEFAULT NULL,
  `DiaChi` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `TinhTrang` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `TongTien` float DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaPX`),
  KEY `fk_mapx` (`MaPX`),
  KEY `FK_PX_NV` (`MaNV`),
  CONSTRAINT `FK_PX_NV` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieuxuat`
--

LOCK TABLES `phieuxuat` WRITE;
/*!40000 ALTER TABLE `phieuxuat` DISABLE KEYS */;
INSERT INTO `phieuxuat` VALUES (1,'PX0001','NV0001','2019-12-12 16:17:20','2019-12-11 00:00:00','123','False',2952000),(2,'PX0002','NV0001','2019-12-12 16:19:09','2019-12-11 00:00:00','sfsdf','False',1319910000),(3,'PX0003','NV0001','2019-12-12 16:24:20','2019-12-11 00:00:00','Số 208, Ấp 2, xã Long Định','False',395080),(4,'PX0004','NV0001','2019-12-12 16:26:16','2019-12-11 00:00:00','Nhà tao','False',186664),(5,'PX0005','NV0001','2019-12-15 17:14:57','2019-12-11 00:00:00','12','False',2080000),(6,'PX0006','NV0001','2019-12-16 11:47:26','2019-12-11 00:00:00','234','False',3872000),(7,'PX0007','NV0001','2019-12-16 13:31:18','2019-12-11 00:00:00','123','False',2163000);
/*!40000 ALTER TABLE `phieuxuat` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_phieuxuat_insert` BEFORE INSERT ON `phieuxuat` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM phieuxuat ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.mapx = CONCAT('PX', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.mapx = CONCAT('PX', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `sanpham`
--

DROP TABLE IF EXISTS `sanpham`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `sanpham` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaSP` char(10) COLLATE utf8_bin NOT NULL,
  `TenSP` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `HinhAnh` mediumblob,
  `MaDV` char(10) COLLATE utf8_bin NOT NULL,
  `DonGia` float DEFAULT NULL,
  `GhiChu` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaSP`),
  KEY `MaDV` (`MaDV`),
  KEY `cthoadon_ibfk_2` (`MaSP`),
  CONSTRAINT `sanpham_ibfk_1` FOREIGN KEY (`MaDV`) REFERENCES `donvi` (`MaDV`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sanpham`
--

LOCK TABLES `sanpham` WRITE;
/*!40000 ALTER TABLE `sanpham` DISABLE KEYS */;

/*!40000 ALTER TABLE `sanpham` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_sanpham_insert` BEFORE INSERT ON `sanpham` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM sanpham ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.masp = CONCAT('SP', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.masp = CONCAT('SP', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `taikhoan`
--

DROP TABLE IF EXISTS `taikhoan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `taikhoan` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MaTK` char(10) COLLATE utf8_bin NOT NULL,
  `TaiKhoan` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `MatKhau` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `MaPQ` char(10) COLLATE utf8_bin DEFAULT NULL,
  `GhiChu` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`,`MaTK`),
  KEY `nhavien_ibfk_1` (`MaTK`),
  KEY `taikhoan_ibfk_1` (`MaPQ`),
  CONSTRAINT `taikhoan_ibfk_1` FOREIGN KEY (`MaPQ`) REFERENCES `phanquyen` (`MaPQ`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taikhoan`
--

LOCK TABLES `taikhoan` WRITE;
/*!40000 ALTER TABLE `taikhoan` DISABLE KEYS */;
INSERT INTO `taikhoan` VALUES (1,'TK0001','admin','admin','PQ0001',NULL),(2,'TK0002','loctran0169','1111111','PQ0001',NULL);
/*!40000 ALTER TABLE `taikhoan` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tg_taikhoan_insert` BEFORE INSERT ON `taikhoan` FOR EACH ROW BEGIN
	set @idm=(SELECT id FROM taikhoan ORDER BY id DESC LIMIT 1);
    if(@idm is not NULL) then		
		SET NEW.matk = CONCAT('TK', LPAD(@idm+1, 4, '0'));
        set NEW.ID=@idm+1;
	else
		SET NEW.matk = CONCAT('TK', LPAD(1, 4, '0'));
        set NEW.ID=1;
    end if;
END */;;
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

-- Dump completed on 2019-12-16 18:54:00
