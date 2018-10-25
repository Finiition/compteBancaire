SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE DATABASE IF NOT EXISTS `comptebancaire` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `comptebancaire`;

DROP TABLE IF EXISTS `compte`;
CREATE TABLE IF NOT EXISTS `compte` (
  `numero` int(11) NOT NULL,
  `solde` decimal(12,2) NOT NULL,
  `devise` int(11) NOT NULL,
  PRIMARY KEY (`numero`),
  KEY `devise` (`devise`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `compte` (`numero`, `solde`, `devise`) VALUES
(1, '200', 1),
(2, '150', 1),
(3, '150', 2),
(4, '250', 1),
(5, '300', 1);

DROP TABLE IF EXISTS `monnaie`;
CREATE TABLE IF NOT EXISTS `monnaie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

INSERT INTO `monnaie` (`id`, `nom`) VALUES
(1, 'EUR'),
(2, 'USD'),
(3, 'GBP');


ALTER TABLE `compte`
  ADD CONSTRAINT `FK_monnaie` FOREIGN KEY (`devise`) REFERENCES `monnaie` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;