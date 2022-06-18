

-- lab.Cliente definition

CREATE TABLE `Cliente` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- lab.TransporteBase definition

CREATE TABLE `TransporteBase` (
  `idTransporteBase` int NOT NULL AUTO_INCREMENT,
  `Ano` int NOT NULL,
  `DataCadastro` datetime DEFAULT NULL,
  PRIMARY KEY (`idTransporteBase`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- lab.TransportePessoal definition

CREATE TABLE `TransportePessoal` (
  `idTransportePessoal` int NOT NULL AUTO_INCREMENT,
  `IdTransporteBase` int DEFAULT NULL,
  `Tipo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idTransportePessoal`),
  KEY `IdTransporteBase` (`IdTransporteBase`),
  CONSTRAINT `transportepessoal_ibfk_1` FOREIGN KEY (`IdTransporteBase`) REFERENCES `TransporteBase` (`idTransporteBase`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
