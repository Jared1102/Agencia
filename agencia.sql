-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.0.29 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para agencia
CREATE DATABASE IF NOT EXISTS `agencia` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `agencia`;

-- Volcando estructura para tabla agencia.herramienta
CREATE TABLE IF NOT EXISTS `herramienta` (
  `CodigoHerramienta` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Medida` decimal(65,2) DEFAULT NULL,
  `Marca` varchar(100) DEFAULT NULL,
  `Descripcion` text,
  PRIMARY KEY (`CodigoHerramienta`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla agencia.herramienta: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `herramienta` DISABLE KEYS */;
INSERT INTO `herramienta` (`CodigoHerramienta`, `Nombre`, `Medida`, `Marca`, `Descripcion`) VALUES
	(1, 'Kit De Emergencia Para Auto', 0.09, '‎FRANCISCO', 'Kit De Emergencia Para Auto 11pcs');
/*!40000 ALTER TABLE `herramienta` ENABLE KEYS */;

-- Volcando estructura para tabla agencia.permiso
CREATE TABLE IF NOT EXISTS `permiso` (
  `IdPermiso` int NOT NULL AUTO_INCREMENT,
  `Crear` tinyint(1) DEFAULT NULL,
  `Leer` tinyint(1) DEFAULT NULL,
  `Actualizar` tinyint(1) DEFAULT NULL,
  `Borrar` tinyint(1) DEFAULT NULL,
  `fkIdUsuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdPermiso`),
  KEY `fkIdUsuario` (`fkIdUsuario`),
  CONSTRAINT `permiso_ibfk_1` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla agencia.permiso: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `permiso` DISABLE KEYS */;
INSERT INTO `permiso` (`IdPermiso`, `Crear`, `Leer`, `Actualizar`, `Borrar`, `fkIdUsuario`) VALUES
	(1, 1, 1, 1, 1, 'Jared11'),
	(2, 1, 1, 1, 1, 'Jared11'),
	(10, 1, 1, 1, 1, 'Hatumer'),
	(11, 0, 1, 1, 0, 'Hatumer');
/*!40000 ALTER TABLE `permiso` ENABLE KEYS */;

-- Volcando estructura para tabla agencia.permisoherramienta
CREATE TABLE IF NOT EXISTS `permisoherramienta` (
  `IdPermisoHerramienta` int NOT NULL AUTO_INCREMENT,
  `fkIdPermiso` int DEFAULT NULL,
  PRIMARY KEY (`IdPermisoHerramienta`),
  KEY `fkIdPermiso` (`fkIdPermiso`),
  CONSTRAINT `permisoherramienta_ibfk_1` FOREIGN KEY (`fkIdPermiso`) REFERENCES `permiso` (`IdPermiso`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla agencia.permisoherramienta: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `permisoherramienta` DISABLE KEYS */;
INSERT INTO `permisoherramienta` (`IdPermisoHerramienta`, `fkIdPermiso`) VALUES
	(1, 2),
	(3, 11);
/*!40000 ALTER TABLE `permisoherramienta` ENABLE KEYS */;

-- Volcando estructura para tabla agencia.permisoproducto
CREATE TABLE IF NOT EXISTS `permisoproducto` (
  `IdPermisoProducto` int NOT NULL AUTO_INCREMENT,
  `fkIdPermiso` int DEFAULT NULL,
  PRIMARY KEY (`IdPermisoProducto`),
  KEY `fkIdPermiso` (`fkIdPermiso`),
  CONSTRAINT `permisoproducto_ibfk_1` FOREIGN KEY (`fkIdPermiso`) REFERENCES `permiso` (`IdPermiso`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla agencia.permisoproducto: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `permisoproducto` DISABLE KEYS */;
INSERT INTO `permisoproducto` (`IdPermisoProducto`, `fkIdPermiso`) VALUES
	(1, 1),
	(3, 10);
/*!40000 ALTER TABLE `permisoproducto` ENABLE KEYS */;

-- Volcando estructura para tabla agencia.producto
CREATE TABLE IF NOT EXISTS `producto` (
  `CodigoBarras` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Descripcion` text,
  `Marca` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`CodigoBarras`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla agencia.producto: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` (`CodigoBarras`, `Nombre`, `Descripcion`, `Marca`) VALUES
	(3, 'Llanta', 'Llanta Bridgestone Pilot Street 110/80-17', 'Bridgestone');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;

-- Volcando estructura para procedimiento agencia.p_herramienta
DELIMITER //
CREATE PROCEDURE `p_herramienta`(
IN p_CodigoHerramienta INT,
IN p_Nombre VARCHAR(100),
IN p_Medida DECIMAL(65,2),
IN p_Marca VARCHAR(100),
IN p_Descripcion TEXT,
IN p_opcion INT
)
BEGIN
	if(p_opcion=1)then
		INSERT INTO herramienta(Nombre,Medida,Marca,Descripcion)
		VALUES(p_Nombre,p_Medida,p_Marca,p_Descripcion);
	END if;
	if(p_opcion=2)then
		UPDATE herramienta
		SET Nombre=p_Nombre, Medida=p_Medida, Marca=p_Marca,
		Descripcion=p_Descripcion
		WHERE CodigoHerramienta=p_CodigoHerramienta;
	END if;
	if(p_opcion=3)then
		DELETE FROM herramienta
		WHERE CodigoHerramienta=p_CodigoHerramienta;
	END if;
END//
DELIMITER ;

-- Volcando estructura para procedimiento agencia.p_Permiso
DELIMITER //
CREATE PROCEDURE `p_Permiso`(
IN p_IdPermiso INT,
IN p_Crear BOOL,
IN p_Leer BOOL,
IN p_Actualizar BOOL,
IN p_Borrar BOOL,
IN p_fkIdUsuario VARCHAR(100),
IN p_opcion INT 
)
BEGIN
	if(p_opcion=1)then
		INSERT INTO permiso(Crear,Leer,Actualizar,Borrar,fkIdUsuario)
		VALUES(p_Crear,p_Leer,p_Actualizar,p_Borrar,p_fkIdUsuario);
	END if;
	if(p_opcion=2)then
		UPDATE permiso
		SET Crear=p_Crear, Leer=p_Leer, Actualizar=p_Actualizar,
		Borrar=p_Borrar, fkIdUsuario=p_fkIdUsuario
		WHERE IdPermiso=p_IdPermiso;
	END if;
	if(p_opcion=3)then
		DELETE FROM permiso
		WHERE IdPermiso=p_IdPermiso;
	END if;
END//
DELIMITER ;

-- Volcando estructura para procedimiento agencia.p_permisoHerramienta
DELIMITER //
CREATE PROCEDURE `p_permisoHerramienta`(
	IN `p_IdPermisoHerramienta` INT,
	IN `p_fkIdPermiso` INT,
	IN `p_opcion` INT
)
BEGIN
	if(p_opcion=1)then
		INSERT INTO permisoherramienta(fkIdPermiso)
		VALUES(p_fkIdPermiso);
	END if;
	if(p_opcion=2)then
		UPDATE permisoherramienta
		SET fkIdPermiso=p_fkIdPermiso
		WHERE IdPermisoHerramienta = p_IdPermisoHerramienta;
	END if;
	if(p_opcion=3)then
		DELETE FROM permisoHerramienta
		WHERE IdPermisoHerramienta=p_IdPermisoHerramienta;
	END if;
END//
DELIMITER ;

-- Volcando estructura para procedimiento agencia.p_permisoProducto
DELIMITER //
CREATE PROCEDURE `p_permisoProducto`(
IN p_IdPermisoProducto INT,
IN p_fkIdPermiso INT, 
IN p_opcion INT 
)
BEGIN
	if(p_opcion=1)then
		INSERT INTO permisoproducto(fkIdPermiso)
		VALUES(p_fkIdPermiso);
	END if;
	if(p_opcion=2)then
		UPDATE permisoproducto
		SET fkIdPermiso=p_fkIdPermiso
		WHERE IdPermisoProducto = p_IdPermisoProducto;
	END if;
	if(p_opcion=3)then
		DELETE FROM permisoproducto
		WHERE IdPermisoProducto=p_IdPermisoProducto;
	END if;
END//
DELIMITER ;

-- Volcando estructura para procedimiento agencia.p_producto
DELIMITER //
CREATE PROCEDURE `p_producto`(
IN p_CodigoBarras INT,
IN p_Nombre VARCHAR(100),
IN p_descripcion TEXT,
IN p_Marca VARCHAR(100),
IN p_opcion INT
)
BEGIN
	if(p_opcion=1)then
		INSERT INTO producto(Nombre,Descripcion,Marca)
		VALUES(p_Nombre,p_descripcion,p_marca);
	END if;
	if(p_opcion=2)then
		UPDATE producto
		SET Nombre=p_Nombre,Descripcion=p_Descripcion,
		Marca=p_Marca
		WHERE CodigoBarras=p_CodigoBarras;
	END if;
	if(p_opcion=3)then
		DELETE FROM producto
		WHERE CodigoBarras=p_CodigoBarras;
	END if;
END//
DELIMITER ;

-- Volcando estructura para procedimiento agencia.p_Usuario
DELIMITER //
CREATE PROCEDURE `p_Usuario`(
IN p_IdUsuario VARCHAR(100),
IN p_Nombre VARCHAR(100),
IN p_ApellidoP VARCHAR(100),
IN p_ApellidoM VARCHAR(100),
IN p_FechaNacimiento DATE,
IN p_RFC VARCHAR(13),
IN p_opcion INT
)
BEGIN
	if(p_opcion=1) then
		INSERT INTO usuario VALUES(p_IdUsuario, p_Nombre, p_ApellidoP,
		p_ApellidoM,p_FechaNacimiento,p_RFC);
	END if;
	if(p_opcion=2) then
		UPDATE usuario
		SET Nombre=p_Nombre, ApellidoP=p_ApellidoP,
		ApellidoM=p_ApellidoM,FechaNacimiento=p_FechaNacimiento,
		RFC=p_RFC
		WHERE IdUsuario=p_IdUsuario;
	END if;
	if(p_opcion=3)then
		DELETE FROM usuario
		WHERE IdUsuario=p_IdUsuario;
	END if;
END//
DELIMITER ;

-- Volcando estructura para tabla agencia.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `IdUsuario` varchar(100) NOT NULL,
  `Nombre` varchar(100) DEFAULT NULL,
  `ApellidoP` varchar(100) DEFAULT NULL,
  `ApellidoM` varchar(100) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `RFC` varchar(13) DEFAULT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla agencia.usuario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`IdUsuario`, `Nombre`, `ApellidoP`, `ApellidoM`, `FechaNacimiento`, `RFC`) VALUES
	('Hatumer', 'Edelio', 'Sevilla', 'Arenas', '1991-01-23', 'SEAE9101231Q'),
	('Jared11', 'Jared Alonso', 'Pérez', 'Contreras', '2002-06-11', 'PECJ0206111H0');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

-- Volcando estructura para vista agencia.v_permisosherramienta
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `v_permisosherramienta` (
	`IdUsuario` VARCHAR(100) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`IdPermisoHerramienta` INT(10) NOT NULL,
	`Crear` TINYINT(1) NULL,
	`Leer` TINYINT(1) NULL,
	`Actualizar` TINYINT(1) NULL,
	`Borrar` TINYINT(1) NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista agencia.v_permisosproducto
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `v_permisosproducto` (
	`IdUsuario` VARCHAR(100) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`IdPermisoProducto` INT(10) NOT NULL,
	`Crear` TINYINT(1) NULL,
	`Leer` TINYINT(1) NULL,
	`Actualizar` TINYINT(1) NULL,
	`Borrar` TINYINT(1) NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista agencia.v_permisosherramienta
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `v_permisosherramienta`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `v_permisosherramienta` AS select `usuario`.`IdUsuario` AS `IdUsuario`,`permisoherramienta`.`IdPermisoHerramienta` AS `IdPermisoHerramienta`,`permiso`.`Crear` AS `Crear`,`permiso`.`Leer` AS `Leer`,`permiso`.`Actualizar` AS `Actualizar`,`permiso`.`Borrar` AS `Borrar` from ((`usuario` join `permiso`) join `permisoherramienta`) where ((`usuario`.`IdUsuario` = `permiso`.`fkIdUsuario`) and (`permiso`.`IdPermiso` = `permisoherramienta`.`fkIdPermiso`));

-- Volcando estructura para vista agencia.v_permisosproducto
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `v_permisosproducto`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `v_permisosproducto` AS select `usuario`.`IdUsuario` AS `IdUsuario`,`permisoproducto`.`IdPermisoProducto` AS `IdPermisoProducto`,`permiso`.`Crear` AS `Crear`,`permiso`.`Leer` AS `Leer`,`permiso`.`Actualizar` AS `Actualizar`,`permiso`.`Borrar` AS `Borrar` from ((`usuario` join `permiso`) join `permisoproducto`) where ((`usuario`.`IdUsuario` = `permiso`.`fkIdUsuario`) and (`permiso`.`IdPermiso` = `permisoproducto`.`fkIdPermiso`));

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
