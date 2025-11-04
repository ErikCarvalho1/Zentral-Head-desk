-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema kings
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema kings
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `kings` DEFAULT CHARACTER SET utf8mb4 ;
USE `kings` ;

-- -----------------------------------------------------
-- Table `kings`.`niveis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`niveis` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `sigla` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `kings`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`usuarios` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel_id` INT(11) NOT NULL,
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
  INDEX `fk_usuarios_niveis1_idx` (`nivel_id` ASC) VISIBLE,
  CONSTRAINT `fk_usuarios_niveis1`
    FOREIGN KEY (`nivel_id`)
    REFERENCES `kings`.`niveis` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1006;


-- -----------------------------------------------------
-- Table `kings`.`caixas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`caixas` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` INT(4) NOT NULL,
  `data_abertura` DATETIME NOT NULL,
  `saldo_inicial` DECIMAL(10,2) NOT NULL,
  `status` CHAR(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`),
  INDEX `fk_Caixa_Usuarios1_idx` (`usuario_id` ASC) VISIBLE,
  CONSTRAINT `fk_Caixa_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `kings`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`categorias` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `sigla` CHAR(3) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 3;


-- -----------------------------------------------------
-- Table `kings`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`clientes` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `telefone` CHAR(14) NULL DEFAULT NULL,
  `email` VARCHAR(60) NOT NULL,
  `data_nasc` DATE NULL DEFAULT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 10016;


-- -----------------------------------------------------
-- Table `kings`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`pedidos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` INT(4) NOT NULL,
  `cliente_id` INT(4) NOT NULL,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `status` CHAR(1) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Pedido_Usuarios1_idx` (`usuario_id` ASC) VISIBLE,
  INDEX `fk_Pedido_Clientes1_idx` (`cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_Pedido_Clientes1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedido_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `kings`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 100001;


-- -----------------------------------------------------
-- Table `kings`.`revendedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`revendedores` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `cpf_cnpj` VARCHAR(18) NOT NULL,
  `telefone` VARCHAR(20) NULL DEFAULT NULL,
  `email` VARCHAR(100) NULL DEFAULT NULL,
  `ativo` BIT(1) NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_cnpj_UNIQUE` (`cpf_cnpj` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`cupons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`cupons` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(100) NOT NULL,
  `codigo` VARCHAR(50) NOT NULL,
  `cupom_tipo` VARCHAR(20) NOT NULL,
  `data_criacao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `data_validade` DATE NOT NULL,
  `valor_pedido_minimo` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_maximo_desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_maximo_pedido` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_desconto` DECIMAL(10,2) NOT NULL,
  `descricao` TEXT NULL DEFAULT NULL,
  `tipo_desconto` BIT(1) NOT NULL,
  `cliente_id` INT(11) NULL DEFAULT NULL,
  `pedido_id` INT(11) NULL DEFAULT NULL,
  `revendedor_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `codigo` (`codigo` ASC) VISIBLE,
  INDEX `fk_cupons_clientes_idx` (`cliente_id` ASC) VISIBLE,
  INDEX `fk_cupons_pedidos_idx` (`pedido_id` ASC) VISIBLE,
  INDEX `fk_cupons_revendedores_idx` (`revendedor_id` ASC) VISIBLE,
  CONSTRAINT `fk_cupons_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_cupons_pedidos`
    FOREIGN KEY (`pedido_id`)
    REFERENCES `kings`.`pedidos` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_cupons_revendedores`
    FOREIGN KEY (`revendedor_id`)
    REFERENCES `kings`.`revendedores` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`enderecos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`enderecos` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `cliente_id` INT(4) NOT NULL,
  `cep` CHAR(8) NOT NULL,
  `logradouro` VARCHAR(100) NULL DEFAULT NULL,
  `numero` VARCHAR(40) NOT NULL,
  `complemento` VARCHAR(60) NULL DEFAULT NULL,
  `bairro` VARCHAR(60) NOT NULL,
  `cidade` VARCHAR(60) NOT NULL,
  `uf` CHAR(2) NOT NULL,
  `tipo_endereco` CHAR(3) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_table1_clientes_idx` (`cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_table1_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `kings`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3;


-- -----------------------------------------------------
-- Table `kings`.`produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`produtos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `cod_barras` VARCHAR(60) NOT NULL,
  `descricao` VARCHAR(60) NOT NULL,
  `valor_unit` DECIMAL(10,2) NOT NULL,
  `unidade_venda` VARCHAR(12) NOT NULL,
  `categoria_id` INT(4) NOT NULL,
  `estoque_minimo` DECIMAL(10,2) NOT NULL,
  `classe_desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  `imagem` BLOB NULL DEFAULT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `descontinuado` BIT(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `idProduto_UNIQUE` (`id` ASC) VISIBLE,
  UNIQUE INDEX `Produtocol_UNIQUE` (`cod_barras` ASC) VISIBLE,
  INDEX `fk_Produto_Categorias1_idx` (`categoria_id` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_Categorias1`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `kings`.`categorias` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 7400005;


-- -----------------------------------------------------
-- Table `kings`.`estoques`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`estoques` (
  `produto_id` INT(4) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `data_ultimo_movimento` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  INDEX `fk_Estoque_Produto1_idx` (`produto_id` ASC) VISIBLE,
  CONSTRAINT `fk_Estoque_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`fornecedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`fornecedores` (
  `id` INT(4) NOT NULL,
  `razao_social` VARCHAR(100) NOT NULL,
  `fantasia` VARCHAR(40) NOT NULL,
  `cnpj` CHAR(14) NOT NULL,
  `contato` VARCHAR(60) NULL DEFAULT NULL,
  `telefone` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(60) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cnpj_UNIQUE` (`cnpj` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`itempedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`itempedido` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `pedido_id` INT(11) NOT NULL,
  `produto_id` INT(11) NOT NULL,
  `valor_unit` DECIMAL(10,2) NOT NULL,
  `quantidade` DECIMAL(10,3) NOT NULL,
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_ItemPedido_Pedido1_idx` (`pedido_id` ASC) VISIBLE,
  INDEX `fk_ItemPedido_Produto1_idx` (`produto_id` ASC) VISIBLE,
  CONSTRAINT `fk_ItemPedido_Pedido1`
    FOREIGN KEY (`pedido_id`)
    REFERENCES `kings`.`pedidos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemPedido_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `kings`.`produtofornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `kings`.`produtofornecedor` (
  `produto_id` INT(4) NOT NULL,
  `fornecedores_id` INT(4) NOT NULL,
  PRIMARY KEY (`produto_id`, `fornecedores_id`),
  INDEX `fk_Produto_has_Fornecedores_Fornecedores1_idx` (`fornecedores_id` ASC) VISIBLE,
  INDEX `fk_Produto_has_Fornecedores_Produto1_idx` (`produto_id` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_has_Fornecedores_Fornecedores1`
    FOREIGN KEY (`fornecedores_id`)
    REFERENCES `kings`.`fornecedores` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_has_Fornecedores_Produto1`
    FOREIGN KEY (`produto_id`)
    REFERENCES `kings`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `kings` ;

-- -----------------------------------------------------
-- procedure sp_categoria_delete
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_delete`(spid int)
BEGIN
    DELETE FROM categorias WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_insert`(spnome varchar(40), spsigla char(3))
BEGIN
    INSERT INTO categorias VALUES (0, spnome, spsigla);
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_update`(spid int, spnome varchar(40), spsigla char(3))
BEGIN
    UPDATE categorias SET nome = spnome, sigla = spsigla WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente_insert`(
    spnome varchar(100), spcpf char(11), sptelefone char(14), spemail varchar(60), spdatanasc date)
BEGIN
    INSERT INTO clientes VALUES (0, spnome, spcpf, sptelefone, spemail, spdatanasc, DEFAULT, 1);
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cliente_update`(spid int, spnome varchar(100), sptelefone char(14), spdatanasc date)
BEGIN
    UPDATE clientes SET nome = spnome, telefone = sptelefone, data_nasc = spdatanasc WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_endereco_delete
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_delete`(spid int)
BEGIN
    DELETE FROM enderecos WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_endereco_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_endereco_insert`(
    spcliente_id int, spcep char(8), splogradouro varchar(100),
    spnumero varchar(40), spcomplemento varchar(60),
    spbairro varchar(60), spcidade varchar(60), spuf char(2), sptipo_endereco char(3))
BEGIN
    INSERT INTO enderecos VALUES (0, spcliente_id, spcep, splogradouro, spnumero, spcomplemento, spbairro, spcidade, spuf, sptipo_endereco);
    SELECT @@IDENTITY AS id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_estoque_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_estoque_insert`(
    IN spproduto_id INT,
    IN spquantidade DECIMAL(10,2),
    IN spdata_ultimo_movimento TIMESTAMP
)
BEGIN
    -- Verifica se o produto existe antes de inserir
    IF EXISTS (SELECT 1 FROM produtos WHERE id = spproduto_id) THEN
        INSERT INTO estoques (produto_id, quantidade, data_ultimo_movimento)
        VALUES (spproduto_id, spquantidade, spdata_ultimo_movimento);
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Produto informado não existe na tabela produtos.';
    END IF;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_estoque_listar
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_estoque_listar`()
BEGIN
   
         SELECT 
       e.produto_id, 
       e.produto_id, 
       p.descricao AS nome_produto, 
       e.quantidade, 
       e.data_ultimo_movimento
   FROM estoques e
   INNER JOIN produtos p ON p.id = e.produto_id
   ORDER BY e.data_ultimo_movimento DESC;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_estoque_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`%` PROCEDURE `sp_estoque_update`(
    IN spid INT,
    IN spproduto_id INT,
    IN spquantidade DECIMAL(10,2),
    IN spdata_ultimo_movimento TIMESTAMP
)
BEGIN
     UPDATE estoques
    SET 
        quantidade = spquantidade,
        data_ultimo_movimento = spdata_ultimo_movimento
    WHERE produto_id = spproduto_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_delete
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_delete`(spid int)
BEGIN
    DELETE FROM itempedido WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_insert`(sppedido_id int, spproduto_id int, spquantidade decimal(10,3), spdesconto decimal(10,2))
BEGIN
    INSERT INTO itempedido VALUES (0, sppedido_id, spproduto_id, (SELECT valor_unit FROM produtos WHERE id = spproduto_id), spquantidade, spdesconto);
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_itempedido_update`(spid int, spquantidade decimal(10,3), spdesconto decimal(10,2))
BEGIN
    UPDATE itempedido SET quantidade = spquantidade, desconto = spdesconto WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_nivel_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_nivel_insert`(spnome varchar(45), spsigla varchar(45))
BEGIN
    INSERT INTO niveis(nome, sigla) VALUES (spnome, spsigla);
    SELECT * FROM niveis WHERE id = LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_nivel_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_nivel_update`(spid int, spnome varchar(45), spsigla varchar(45))
BEGIN
    UPDATE niveis SET nome = spnome, sigla = spsigla WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pedido_insert`(spusuario_id int, spcliente_id int)
BEGIN
    INSERT INTO pedidos VALUES(0, spusuario_id, spcliente_id, DEFAULT, 'A', 0);
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pedido_update`(spid int, spstatus char(1), spdesconto decimal(10,2))
BEGIN
    UPDATE pedidos SET status = spstatus, desconto = spdesconto WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_insert`(
    spcod_barras varchar(60), spdescricao varchar(60), spvalor_unit decimal(10,2),
    spunidade_venda varchar(12), spcategoria_id int, spestoque_minimo decimal(10,3),
    spclasse_desconto decimal(10,4), spimagem blob)
BEGIN
    INSERT INTO produtos VALUES (
        0, spcod_barras, spdescricao, spvalor_unit, spunidade_venda, spcategoria_id,
        spestoque_minimo, (spclasse_desconto/100), spimagem, DEFAULT, DEFAULT);
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_update`(
    spid int, spcod_barras varchar(60), spdescricao varchar(60), spvalor_unit decimal(10,2),
    spunidade_venda varchar(12), spcategoria_id int, spestoque_minimo decimal(10,3),
    spclasse_desconto decimal(10,4), spimagem blob, spdescontinuado bit(1))
BEGIN
    UPDATE produtos SET cod_barras = spcod_barras, descricao = spdescricao, valor_unit = spvalor_unit,
    unidade_venda = spunidade_venda, categoria_id = spcategoria_id, estoque_minimo = spestoque_minimo,
    classe_desconto = (spclasse_desconto/100), imagem = spimagem, descontinuado = spdescontinuado WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_altera
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_altera`(spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
BEGIN
    UPDATE usuarios SET nome = spnome, senha = MD5(spsenha), nivel_id = spnivel WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_insert
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_insert`(spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel int)
BEGIN
    INSERT INTO usuarios VALUES (0, spnome, spemail, MD5(spsenha), spnivel, DEFAULT);
    SELECT * FROM usuarios WHERE id = LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_update
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuario_update`(spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
BEGIN
    UPDATE usuarios SET nome = spnome, senha = MD5(spsenha), nivel_id = spnivel WHERE id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_venda_terminal
-- -----------------------------------------------------

DELIMITER $$
USE `kings`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_venda_terminal`(spusuario_id int, spcpf char(11), spcodbar varchar(60))
BEGIN
    INSERT INTO pedidos VALUES(0, spusuario_id, (SELECT id FROM clientes WHERE cpf = spcpf), DEFAULT, 'A', 0);
    INSERT INTO itempedido VALUES (
        0,
        LAST_INSERT_ID(),
        (SELECT id FROM produtos WHERE cod_barras = spcodbar),
        (SELECT valor_unit FROM produtos WHERE cod_barras = spcodbar),
        1,
        0);
    SELECT * FROM itempedido WHERE id = LAST_INSERT_ID();
END$$

DELIMITER ;
USE `kings`;

DELIMITER $$
USE `kings`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `kings`.`trigger_gera_estoque`
AFTER INSERT ON `kings`.`produtos`
FOR EACH ROW
BEGIN
    INSERT INTO estoques VALUES(NEW.id, 0, CURRENT_DATE());
END$$

USE `kings`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `kings`.`trigger_baixa_estoque`
AFTER INSERT ON `kings`.`itempedido`
FOR EACH ROW
BEGIN
    UPDATE estoques SET quantidade = quantidade - NEW.quantidade, data_ultimo_movimento = CURRENT_DATE()
    WHERE produto_id = NEW.produto_id;
END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
