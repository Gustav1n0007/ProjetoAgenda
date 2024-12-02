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

CREATE TABLE tbLog(
	id_alteracao int auto_increment primary key,
	usuario varchar(30),
    data_alteracao datetime,
    descricao varchar(200)
	);

CREATE TABLE tbContato(
	id_contato int auto_increment primary key,
    contato varchar(40) not null,
    telefone varchar(16),
    categoria varchar(50),
    usuario varchar(30)
    );

DELIMITER $$
CREATE TRIGGER trInsertContato
	BEFORE INSERT
	ON tbContato 
	FOR EACH ROW
BEGIN 
	SET NEW.usuario = user();
END$$	

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


DELIMITER $$
CREATE TRIGGER trExcluiContatoLog
	BEFORE DELETE
	ON tbContato
	FOR EACH ROW
BEGIN 
	insert into tbLog(
		usuario,
        data_alteracao,
        descricao
        )
	VALUES (
		user(),
        now(),
        CONCAT(user()," Excluiu o contato: ", old.contato)
        );
END$$

DELIMITER $$
CREATE TRIGGER trInsertContatoLog
	BEFORE INSERT
	ON tbContato
	FOR EACH ROW
BEGIN 
	insert into tbLog(
		usuario,
        data_alteracao,
        descricao
        )
	VALUES (
		user(),
        now(),
        CONCAT(user()," Inserio o contato: ", new.contato)
        );
END$$

DELIMITER $$
CREATE TRIGGER trUpdateContatoLog
	BEFORE UPDATE
	ON tbContato
	FOR EACH ROW
BEGIN 
	insert into tbLog(
		usuario,
        data_alteracao,
        descricao
        )
	VALUES (
		user(),
        now(),
        CONCAT(user()," Alterou o contato: ", old.contato, "Para: ", new.contato)
        );
END$$

DELIMITER AlexMestreDosMago
CREATE TRIGGER trInsertCategoriaUserLog
	BEFORE INSERT
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog(
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
	INSERT INTO tbLog(
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

select * from tblog; 
select * from tbInsert;
select * from tbUpdate;
select * from tbexcluicontato;
select * from tbinsertcontato;
select * from tbupdatecontato;