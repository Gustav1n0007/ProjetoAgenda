CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuario(
	nome varchar(50) not null,
    telefone varchar(16),
    usuario varchar(30) primary key,
    senha varchar(20) not null
    );

CREATE TABLE tbCategoria(
    id_categoria int primary key auto_increment,
    categoria varchar(50) not null,
    usuario varchar(30)
    );
    
DELIMITER $$
CREATE TRIGGER trInsertCategoria 
	BEFORE INSERT
	ON tbCategoria 
	FOR EACH ROW
BEGIN 
	SET NEW.usuario = current_user();
END$$
