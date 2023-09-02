CREATE DATABASE cad_usuarios;

USE cad_usuarios;

CREATE TABLE nivel (
  id_nivel int primary key IDENTITY,
  nome varchar(50) UNIQUE
); 

INSERT INTO nivel VALUES ('Administrador'),('Desenvolvedor'),('Usuário');

 

CREATE TABLE usuarios (
  id_usuario int NOT NULL IDENTITY,
  nome varchar(50) DEFAULT NULL,
  email varchar(50) UNIQUE,
  senha varchar(25) DEFAULT NULL,
  nivel int DEFAULT NULL,
  data datetime,
  PRIMARY KEY (id_usuario),
  CONSTRAINT fk_nivel FOREIGN KEY (nivel) REFERENCES nivel (id_nivel)
);

 

INSERT INTO usuarios VALUES ('admin','admin@barth.com.br','123456',1,'2021-05-10 21:38:35');