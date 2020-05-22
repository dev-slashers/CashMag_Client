-- MySqlBackup.NET 2.0.12
-- Dump Time: 2018-05-23 09:13:50
-- --------------------------------------
-- Server version 8.0.11 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of categoria
-- 

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table categoria
-- 



-- 
-- Definition of ordinazioni
-- 

DROP TABLE IF EXISTS `ordinazioni`;
CREATE TABLE IF NOT EXISTS `ordinazioni` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ID_Ordinazione` text NOT NULL,
  `Tavolo` text NOT NULL,
  `Coperto` text NOT NULL,
  `Totale` text NOT NULL,
  `Stato` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table ordinazioni
-- 


-- 
-- Definition of prodotti
-- 

DROP TABLE IF EXISTS `prodotti`;
CREATE TABLE IF NOT EXISTS `prodotti` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` text NOT NULL,
  `Prezzo` text NOT NULL,
  `Categoria` text NOT NULL,
  `Disponibile` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table prodotti
-- 


-- 
-- Definition of scontrino
-- 

DROP TABLE IF EXISTS `scontrino`;
CREATE TABLE IF NOT EXISTS `scontrino` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Attivita` text NOT NULL,
  `Indirizzo` text NOT NULL,
  `Piva` text NOT NULL,
  `Tel` text NOT NULL,
  `Footer` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table scontrino
-- 

/*!40000 ALTER TABLE `scontrino` DISABLE KEYS */;
INSERT INTO `scontrino`(`ID`,`Attivita`,`Indirizzo`,`Piva`,`Tel`,`Footer`) VALUES
(1,'< Nome Attività >','< Indirizzo >','< P.Iva >','< Recapito >','Scontrino non fiscale');
/*!40000 ALTER TABLE `scontrino` ENABLE KEYS */;

-- 
-- Definition of storico
-- 

DROP TABLE IF EXISTS `storico`;
CREATE TABLE IF NOT EXISTS `storico` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TimeData` text NOT NULL,
  `Ordinazione` text NOT NULL,
  `Totale` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table storico
-- 


-- 
-- Definition of sys
-- 

DROP TABLE IF EXISTS `sys`;
CREATE TABLE IF NOT EXISTS `sys` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `UserPass` text NOT NULL,
  `Numero_Tavoli` int(11) NOT NULL,
  `Campanello` text NOT NULL,
  `Costo_Coperto` text NOT NULL,
  `Insert_Items` text NOT NULL,
  `FormSize` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table sys
-- 

/*!40000 ALTER TABLE `sys` DISABLE KEYS */;
INSERT INTO `sys`(`ID`,`UserPass`,`Numero_Tavoli`,`Campanello`,`Costo_Coperto`,`Insert_Items`,`FormSize`) VALUES
(1,'MTIzNA==',150,'False','2,00','False','False');
/*!40000 ALTER TABLE `sys` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-05-23 09:13:50
-- Total time: 0:0:0:0:186 (d:h:m:s:ms)
