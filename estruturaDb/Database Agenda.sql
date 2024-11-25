DROP DATABASE dbAgenda;
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

CREATE TABLE tbInsert(
	id_insert_categoria int auto_increment primary key,
    usuario varchar(30),
    data_alteracao datetime, 
    descricao varchar(100)
    );

CREATE TABLE tbUpdate (
	id_update int auto_increment primary key,
	usuario varchar(30),
    data_alteracao datetime,
    descricao varchar(200)
    );

CREATE TABLE tbLog(
	id_alteracao int auto_increment primary key,
	usuario varchar(30),
    data_alteracao datetime,
    descricao varchar(200)
	);

DELIMITER $$
CREATE TRIGGER trInsertCategoria 
	BEFORE INSERT
	ON tbCategoria 
	FOR EACH ROW
BEGIN 
	SET NEW.usuario = user();
END$$

DELIMITER AlexMestreDosMago
CREATE TRIGGER trDelCategoriaUserLog
	BEFORE delete
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	insert into tbLog(
		usuario,
		data_alteracao,
		descricao
        )
    values( 
		user(),
		now(),
		CONCAT("A categoria ", old.categoria ," foi removida")
        );
END AlexMestreDosMago
    
DELIMITER AlexMestreDosMago
CREATE TRIGGER trInsertCategoriaUserLog
	BEFORE INSERT
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	INSERT INTO tbInsert(
		usuario,
        data_alteracao,
        descricao
        )
	VALUES (
		user(),
        now(),
        CONCAT("A categoria ", new.categoria, "foi inserida")
        );
END AlexMestreDosMago
    
DELIMITER AlexMestreDosMago
CREATE TRIGGER trUpdateCategoriaUserLog
	BEFORE UPDATE
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	INSERT INTO tbUpdate(
		usuario,
        data_alteracao,
        descricao
        )
	VALUES (
		user(),
        now(),
        CONCAT("A categoria ", old.categoria, "foi alterada para: ", new.categoria)
        );
END AlexMestreDosMago

select * from tbCategoria where usuario = "gustavo1@localhost" ;