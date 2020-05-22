-- MySqlBackup.NET 2.0.12
-- Dump Time: 2018-05-07 19:12:26
-- --------------------------------------
-- Server version 5.7.20-log MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table categoria
-- 

/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria`(`ID`,`Nome`) VALUES
(1,'Panini'),
(2,'Hamburger'),
(3,'Sandwich'),
(4,'Bruschette'),
(5,'Patatine Fritte'),
(6,'Insalate'),
(7,'Pizza'),
(8,'Bevande'),
(9,'Birre'),
(10,'Vini'),
(11,'Pizze Bianche'),
(12,'Pizze in teglia'),
(13,'Calzoni'),
(14,'Focacce'),
(15,'Le Piadine'),
(16,'Pizze Bianche'),
(17,'Frittura');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table ordinazioni
-- 

/*!40000 ALTER TABLE `ordinazioni` DISABLE KEYS */;

/*!40000 ALTER TABLE `ordinazioni` ENABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table prodotti
-- 

/*!40000 ALTER TABLE `prodotti` DISABLE KEYS */;
INSERT INTO `prodotti`(`ID`,`Nome`,`Prezzo`,`Categoria`,`Disponibile`) VALUES
(1,'Panino notting hill','6,00','Panini','Si'),
(2,'Panino Piccadilly','6,00','Panini','Si'),
(3,'Panino portobello','6,00','Panini','Si'),
(4,'Panino Wimbledon','6,00','Panini','Si'),
(6,'Panino Brixton','6,00','Panini','Si'),
(7,'Panino Victoria','6,00','Panini','Si'),
(8,'Hamburger Coventry','6,00','Hamburger','Si'),
(9,'Hamburger East Park','7,00','Hamburger','Si'),
(10,'Hamburger Stratford','7,00','Hamburger','Si'),
(11,'Hamburger West Ham','7,00','Hamburger','Si'),
(12,'Hamburger Wemblay','7,00','Hamburger','Si'),
(13,'Toast','4,50','Sandwich','Si'),
(14,'Sandwich al Pollo','6,00','Sandwich','Si'),
(15,'Sandwich al Tonno','6,00','Sandwich','Si'),
(16,'Sandwich al Bacon','6,00','Sandwich','Si'),
(17,'Piadina Spring','5,50','Le Piadine','Si'),
(18,'Piadina Autumn','5,50','Le Piadine','Si'),
(19,'Acqua Naturale 50cl','1,50','Bevande','Si'),
(20,'Acqua Frizzante 50cl','1,50','Bevande','Si'),
(21,'Coca Cola 33cl','2,50','Bevande','Si'),
(22,'Coca Cola Zero 33cl','2,50','Bevande','Si'),
(23,'Fanta 33cl','2,50','Bevande','Si'),
(24,'Sprite','2,50','Bevande','Si'),
(25,'Leffe Vieille Cuveè','3,50','Birre','Si'),
(26,'Corona Extra','3,50','Birre','Si'),
(27,'Warsteiner','3,50','Birre','Si'),
(28,'Tennents Gluten Free','5,00','Birre','Si'),
(29,'Tennents','5,00','Birre','Si'),
(30,'Pizza Diavola','5,50','Pizza','Si'),
(31,'Pizza Funghi','5,50','Pizza','Si'),
(32,'Pizza Margherita','3,00','Pizza','Si'),
(33,'Pizza Napoli','5,50','Pizza','Si'),
(34,'Pizza Wurstel','5,50','Pizza','Si'),
(35,'Pizza Marinara','3,50','Pizza','Si'),
(36,'Pizza Parmigiana','6,00','Pizza','Si'),
(37,'Pizza Patatissima','6,00','Pizza','Si'),
(38,'Pizza 4 Formaggi','6,50','Pizza','Si'),
(39,'Pizza 4 Stagioni','6,50','Pizza','Si'),
(40,'Pizza 4 Salumi','6,50','Pizza','Si'),
(41,'Pizza Bufala','6,50','Pizza','Si'),
(42,'Pizza Capricciosa','6,50','Pizza','Si'),
(43,'Patatine Doc','3,50','Patatine Fritte','Si'),
(44,'Patatine con Formaggio','4,00','Patatine Fritte','Si'),
(45,'Patatine con provola','4,00','Patatine Fritte','Si'),
(46,'Patatine con salsiccia','4,50','Patatine Fritte','Si'),
(47,'Patatine Bacone Cheddar','5,00','Patatine Fritte','Si'),
(48,'Ins. Mista con Tonno e olive','6,00','Insalate','Si'),
(49,'Crocchè','1,50','Frittura','Si'),
(50,'Arancini Bolognese','1,50','Frittura','Si'),
(51,'Patatine Salsiccia e Provola','5,50','Patatine Fritte','Si'),
(52,'Chele di granchio','4,00','Frittura','Si'),
(53,'Mozzarelline','4,00','Frittura','Si'),
(54,'Coscette di pollo','4,00','Frittura','Si'),
(55,'Ins. Mais e scaglie di grana','6,00','Insalate','Si'),
(56,'Focaccia','4,50','Focacce','Si'),
(57,'Focaccia con crudo','7,00','Focacce','Si'),
(58,'Focaccia Nostrana','6,50','Focacce','Si'),
(59,'Calice di vino','5,00','Vini','Si');
/*!40000 ALTER TABLE `prodotti` ENABLE KEYS */;

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
(1,'< Nome Attività >','< Indirizzo >','< Piva >','< Telefono >','Grazie Per Averci Scelto');
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table storico
-- 

/*!40000 ALTER TABLE `storico` DISABLE KEYS */;

/*!40000 ALTER TABLE `storico` ENABLE KEYS */;

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
(1,'MTIzNA==',150,'True','2,00','True','False');
/*!40000 ALTER TABLE `sys` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-05-07 19:12:26
-- Total time: 0:0:0:0:32 (d:h:m:s:ms)
