-- MySqlBackup.NET 2.0.12
-- Dump Time: 2018-05-09 19:23:10
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
(1,'Caffetteria'),
(2,'Cornetteria'),
(3,'Snack'),
(4,'Bibite'),
(5,'Birre'),
(6,'Champagne al calice'),
(7,'Aperitivo'),
(8,'Frozen Drink'),
(9,'Cocktail'),
(10,'Vini in bottiglia'),
(11,'Grappe'),
(12,'Brandy'),
(13,'Cognac'),
(14,'Rum'),
(15,'Whiskey'),
(16,'Champagne'),
(17,'Succhi di Frutta');
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
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table prodotti
-- 

/*!40000 ALTER TABLE `prodotti` DISABLE KEYS */;
INSERT INTO `prodotti`(`ID`,`Nome`,`Prezzo`,`Categoria`,`Disponibile`) VALUES
(1,'Caffè Espresso','1,00','Caffetteria','Si'),
(2,'Caffè Con Panna','2,00','Caffetteria','Si'),
(3,'Caffè Alla nocciola','2,00','Caffetteria','Si'),
(4,'Caffè Marocchino','1,50','Caffetteria','Si'),
(5,'Caffè Shekerato','2,00','Caffetteria','Si'),
(6,'Caffè Corretto','1,50','Caffetteria','Si'),
(7,'Caffè ginseng','1,50','Caffetteria','Si'),
(8,'Caffè Brasiliano','2,00','Caffetteria','Si'),
(9,'Cappuccino','1,50','Caffetteria','Si'),
(10,'Cappuccino Freddo','2,00','Caffetteria','Si'),
(11,'Crema Caffè','2,50','Caffetteria','Si'),
(12,'Orzo Caffè','1,50','Caffetteria','Si'),
(13,'Caffè Decaffeinato','1,50','Caffetteria','Si'),
(14,'Cioccolata calda','3,00','Caffetteria','Si'),
(15,'Cioccolata calda con panna','3,50','Caffetteria','Si'),
(16,'Acqua 50cl','1,00','Caffetteria','Si'),
(17,'Sciroppi','3,00','Caffetteria','Si'),
(18,'Gatorade','2,00','Caffetteria','Si'),
(19,'Cornetto','1,20','Cornetteria','Si'),
(20,'Cornetto nutella','1,20','Cornetteria','Si'),
(21,'Trancio Margherita','1,50','Snack','Si'),
(22,'Trancio Marinara','1,50','Snack','Si'),
(23,'Parigina','2,00','Snack','Si'),
(24,'Peroni','2,00','Birre','Si'),
(25,'Heineken','3,00','Birre','Si'),
(26,'Tennet''s','3,00','Birre','Si'),
(27,'Succo di fragola','5,00','Frozen Drink','Si'),
(28,'Espresso Irish Whiskey','5,00','Frozen Drink','Si'),
(29,'Tassoni','3,00','Aperitivo','Si'),
(30,'Frattina Barricata','4,50','Grappe','Si'),
(31,'Matusalem 15 Anni','6,00','Rum','Si'),
(32,'Ferrari','30,00','Champagne','Si'),
(33,'Vecchia Romagna','3,50','Brandy','Si'),
(34,'Cornetto cioccolato bianco','1,20','Cornetteria','Si'),
(35,'Cornetto Black e White','1,20','Cornetteria','Si'),
(36,'Brioche','1,20','Cornetteria','Si'),
(37,'Graffa Semplice/Ripiena','1,20','Cornetteria','Si'),
(38,'Conchiglia','1,20','Cornetteria','Si'),
(39,'Fazzoletto mela','1,20','Cornetteria','Si'),
(40,'Sfogliata riccia/frolla','1,20','Cornetteria','Si'),
(41,'Fagottino cioccolata','1,20','Cornetteria','Si'),
(42,'Treccina albicocca','1,20','Cornetteria','Si'),
(43,'Panino Napoletano','2,00','Snack','Si'),
(44,'Ripieno Fritto','1,50','Snack','Si'),
(45,'Montanara','1,50','Snack','Si'),
(46,'CocaCola 33cl','2,00','Bibite','Si'),
(47,'Lemon Soda','2,00','Bibite','Si'),
(48,'Fanta 33cl','2,00','Bibite','Si'),
(49,'Sprite 33cl','2,00','Bibite','Si'),
(50,'Chinotto 33cl','2,00','Bibite','Si'),
(51,'Tè Freddo','2,00','Bibite','Si'),
(52,'RedBull','3,00','Bibite','Si'),
(53,'Schweppes','3,50','Bibite','Si'),
(54,'Bacardi Vol.Alc 4%','3,50','Bibite','Si'),
(55,'Fi.Ga','3,50','Bibite','Si'),
(56,'Beck''s','3,00','Birre','Si'),
(57,'Bud','3,50','Birre','Si'),
(58,'Ceres','3,50','Birre','Si'),
(59,'Corona','3,50','Birre','Si'),
(60,'Adelscott','4,00','Birre','Si'),
(61,'Ferrari','6,00','Champagne al calice','Si'),
(62,'Franciacorta Ca del Bosco','7,00','Champagne al calice','Si'),
(63,'Moet e Chardon','10,00','Champagne al calice','Si'),
(64,'Veuve Clicquot','10,00','Champagne al calice','Si'),
(65,'Sanbittèr','3,00','Aperitivo','Si'),
(66,'Crodino','3,00','Aperitivo','Si'),
(67,'Cocktail San Pellegrino','3,00','Aperitivo','Si'),
(68,'Campari soda','3,00','Aperitivo','Si'),
(69,'Aperol','4,00','Aperitivo','Si'),
(70,'Aperol spriz','4,00','Aperitivo','Si'),
(71,'Bitter Campari','4,00','Aperitivo','Si'),
(72,'Crodino Twist frutti rossi','3,50','Aperitivo','Si'),
(73,'Crodino Twist agrumi','3,50','Aperitivo','Si'),
(74,'Sante Rive','20,00','Vini in bottiglia','Si'),
(75,'Irmàna Corvo','20,00','Vini in bottiglia','Si'),
(76,'Falanghina Vongnolè','20,00','Vini in bottiglia','Si'),
(77,'903 Barricata','4,50','Grappe','Si'),
(78,'Frattina Cuvee','4,50','Grappe','Si'),
(79,'Frattina Barbera','4,00','Grappe','Si'),
(80,'Giare Amarone','5,00','Grappe','Si'),
(81,'Diciotto Lune','5,00','Grappe','Si'),
(82,'Primo Assaggio','5,00','Grappe','Si'),
(83,'Berta','9,00','Grappe','Si'),
(84,'Stravecchio','3,50','Brandy','Si'),
(85,'Stock 84','3,50','Brandy','Si'),
(86,'Havana Club 3 anni','5,00','Rum','Si'),
(87,'Havana Club bianco','5,00','Rum','Si'),
(88,'Havana club especial','5,00','Rum','Si'),
(89,'Pampero Anniversario','5,00','Rum','Si'),
(90,'Bacardi Bianco','5,00','Rum','Si'),
(91,'Zacapa Centenario 23 anni','8,00','Rum','Si'),
(92,'Zacapa 15 anni','6,00','Rum','Si'),
(93,'Zacapa X05','12,00','Rum','Si'),
(94,'Ballantines','4,50','Whiskey','Si'),
(95,'J&B','4,50','Whiskey','Si'),
(96,'Johnnie Walker','4,50','Whiskey','Si'),
(97,'Jack Daniel''s','4,50','Whiskey','Si'),
(98,'Glen Grant','4,50','Whiskey','Si'),
(99,'Chivas Regal','4,50','Whiskey','Si'),
(100,'Single Malt','7,00','Whiskey','Si'),
(101,'Berlucchi Brut','30,00','Champagne','Si'),
(102,'Mumm','50,00','Champagne','Si'),
(103,'Veuve Clinquot','60,00','Champagne','Si'),
(104,'Franciacorta Ca'' del bosco','40,00','Champagne','Si');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

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
(1,'MTIzNA==',150,'False','2,00','True','False');
/*!40000 ALTER TABLE `sys` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-05-09 19:23:10
-- Total time: 0:0:0:0:100 (d:h:m:s:ms)
