DROP DATABASE rastreio;
go

CREATE DATABASE rastreio;
go

USE rastreio;
go

CREATE TABLE Funcionarios (
	idFuncionario int IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(55) NOT NULL,
	cpf VARCHAR(15) NOT NULL,
	celular VARCHAR(20) NOT NULL,
	sexo VARCHAR(25) NOT NULL,
	cargo VARCHAR(55) NOT NULL,
	FK_enderecos INT NOT NULL,
	FK_sedes INT NOT NULL,
);
go

CREATE TABLE Sedes (
	idSede int IDENTITY(1,1) PRIMARY KEY,
	telefone VARCHAR(20) NOT NULL,
	email VARCHAR(55) NOT NULL,
	site VARCHAR(55) NOT NULL,
	nome VARCHAR(99) NOT NULL,
	FK_enderecos INT NOT NULL,
);
go

CREATE TABLE Encomendas (
	idEncomenda int IDENTITY(1,1) PRIMARY KEY,
	codRastreio VARCHAR(25) NOT NULL,
	peso INT NOT NULL,
	comprimento FLOAT NOT NULL,
	largura FLOAT NOT NULL,
	altura FLOAT NOT NULL,
	volume FLOAT NOT NULL,
	valorEntrega FLOAT NOT NULL,
	dataPostagem DATETIME NOT NULL,
	FK_status INT NOT NULL,
	FK_enderecoDestinatario INT NOT NULL,
	FK_enderecoRemetente INT NOT NULL,
	FK_enderecoSede INT NOT NULL,
);
go

CREATE TABLE Rotas (
	idRota int IDENTITY(1,1) PRIMARY KEY,
	FK_funcionario INT NOT NULL,
	data DATETIME NOT NULL,
);
go

CREATE TABLE Endereços (
	idEndereco int IDENTITY(1,1) PRIMARY KEY,
	rua VARCHAR(99) NOT NULL,
	numero INT NOT NULL,
	bairro VARCHAR(99) NOT NULL,
	cidade VARCHAR(99) NOT NULL,
	estado VARCHAR(99) NOT NULL,
	cep VARCHAR(10) NOT NULL,
	complemento VARCHAR(99) NOT NULL,
);
go

CREATE TABLE Status (
	idStatus int IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(25) NOT NULL,
);
go

CREATE TABLE Preco (
	idPreco int IDENTITY(1,1) PRIMARY KEY,
	precoKm FLOAT NOT NULL,
	precoPeso FLOAT NOT NULL,
	precoVolume FLOAT NOT NULL,
	precoFixo FLOAT NOT NULL,
);
go

CREATE TABLE Rotas_Encomendas (
	idRotaEncomenda int IDENTITY(1,1) PRIMARY KEY,
	FK_encomendas INT NOT NULL,
	FK_rotas INT NOT NULL,
	FK_status INT NOT NULL,
	FK_endereco INT NOT NULL,
);
go

ALTER TABLE Funcionarios ADD CONSTRAINT Funcionarios_fk0 FOREIGN KEY (FK_enderecos) REFERENCES Endereços(idEndereco);
go
ALTER TABLE Funcionarios ADD CONSTRAINT Funcionarios_fk1 FOREIGN KEY (FK_sedes) REFERENCES Sedes(idSede);
go
ALTER TABLE Sedes ADD CONSTRAINT Sedes_fk0 FOREIGN KEY (FK_enderecos) REFERENCES Endereços(idEndereco);
go
ALTER TABLE Encomendas ADD CONSTRAINT Encomendas_fk0 FOREIGN KEY (FK_status) REFERENCES Status(idStatus);
go
ALTER TABLE Encomendas ADD CONSTRAINT Encomendas_fk1 FOREIGN KEY (FK_enderecoDestinatario) REFERENCES Endereços(idEndereco);
go
ALTER TABLE Encomendas ADD CONSTRAINT Encomendas_fk2 FOREIGN KEY (FK_enderecoRemetente) REFERENCES Endereços(idEndereco);
go
ALTER TABLE Encomendas ADD CONSTRAINT Encomendas_fk3 FOREIGN KEY (FK_enderecoSede) REFERENCES Sedes(idSede);
go
ALTER TABLE Rotas ADD CONSTRAINT Rotas_fk0 FOREIGN KEY (FK_funcionario) REFERENCES Funcionarios(idFuncionario);
go
ALTER TABLE Rotas_Encomendas ADD CONSTRAINT Rotas_Encomendas_fk0 FOREIGN KEY (FK_encomendas) REFERENCES Encomendas(idEncomenda);
go
ALTER TABLE Rotas_Encomendas ADD CONSTRAINT Rotas_Encomendas_fk1 FOREIGN KEY (FK_rotas) REFERENCES Rotas(idRota);
go
ALTER TABLE Rotas_Encomendas ADD CONSTRAINT Rotas_Encomendas_fk2 FOREIGN KEY (FK_status) REFERENCES Status(idStatus);
go
ALTER TABLE Rotas_Encomendas ADD CONSTRAINT Rotas_Encomendas_fk3 FOREIGN KEY (FK_endereco) REFERENCES Endereços(idEndereco);
go
