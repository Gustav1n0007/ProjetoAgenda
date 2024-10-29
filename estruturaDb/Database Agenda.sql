CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuario(
	nome varchar(50) not null,
    telefone varchar(16),
    usuario varchar(30) primary key,
    senha varchar(20) not null
    );
    