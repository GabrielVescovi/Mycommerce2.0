-- --------------------------------------------------------
-- Servidor:                     localhost
-- Versão do servidor:           10.2.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para my2
CREATE DATABASE IF NOT EXISTS `my2` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `my2`;

-- Copiando estrutura para tabela my2.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `ID` smallint(15) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Telefone` varchar(200) DEFAULT NULL,
  `Endereco` varchar(200) DEFAULT NULL,
  `Bairro` varchar(200) DEFAULT NULL,
  `Cidade` varchar(200) DEFAULT NULL,
  `UF` varchar(200) DEFAULT NULL,
  `Email` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela my2.clientes: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`ID`, `Nome`, `Telefone`, `Endereco`, `Bairro`, `Cidade`, `UF`, `Email`) VALUES
	(2, 'Angela', '9999999', 'BelaVista', 'teste', 'Quedas do Iguaçu', 'PR', 'Teste@gmail.com'),
	(8, 'Angela', '9999999', 'BelaVista', 'teste', 'Quedas do Iguaçu', 'PR', 'Teste@gmail.com'),
	(13, 'asdsadsa', 'System.Windows.Forms.MaskedTextBox, Text: (__) ____-____', 'System.Windows.Forms.TextBox, Text: asdsadas', 'System.Windows.Forms.TextBox, Text: sadsadsa', 'System.Windows.Forms.TextBox, Text: asdasdasdsa', 'System.Windows.Forms.TextBox, Text: PR', 'System.Windows.Forms.TextBox, Text: sdasdsa'),
	(14, 'dsadasdas', 'System.Windows.Forms.MaskedTextBox, Text: (__) ____-____', 'System.Windows.Forms.TextBox, Text: asdsadsa', 'System.Windows.Forms.TextBox, Text: asdsadasd', 'System.Windows.Forms.TextBox, Text: dasdasdsa', 'System.Windows.Forms.TextBox, Text: PR', 'System.Windows.Forms.TextBox, Text: dasdsadsa');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Copiando estrutura para tabela my2.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `ID` int(11) NOT NULL,
  `Usuario` varchar(50) DEFAULT NULL,
  `Senha` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela my2.usuarios: 2 rows
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`ID`, `Usuario`, `Senha`) VALUES
	(1, 'gabriel', '123'),
	(2, 'teste', 'teste');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
