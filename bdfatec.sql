CREATE DATABASE BDFATEC;

USE BDFATEC;

CREATE TABLE tb_clientes (
  id int auto_increment primary key,
  nome varchar(100),
  rg varchar (30),
  cpf varchar (20),
  email varchar(200),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  cidade varchar (100),
  estado varchar (2)
);
/*****************/

CREATE TABLE tb_fornecedores (
  id int auto_increment primary key,
  nome varchar(100),
  cnpj varchar (100),
  email varchar(200),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  cidade varchar (100),
  estado varchar (2)
);
/*****************/

CREATE TABLE tb_funcionarios (
  id int auto_increment primary key,
  nome varchar(100),
  rg varchar (30),
  cpf varchar (20),
  email varchar(200),
  senha varchar(10),
  cargo varchar(100),
  nivel_acesso varchar(50),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  cidade varchar (100),
  estado varchar (2)
);

insert into tb_funcionarios (nome,email,senha,nivel_acesso,cargo )
    values ('admin', 'admin@admin.com', 'admin', 'Administrador','Gerente');
    
CREATE TABLE tb_produtos (
  id int auto_increment primary key,
  descricao varchar(100),
  preco decimal (10,2),
  qtd_estoque int,
  for_id int,

  FOREIGN KEY (for_id) REFERENCES tb_fornecedores(id)
);
/*****************/

CREATE TABLE tb_vendas (
  id int auto_increment primary key,
  cliente_id int,
  data_venda datetime,
  total_venda decimal (10,2),
  observacoes text,

  FOREIGN KEY (cliente_id) REFERENCES tb_clientes(id)
);
/*****************/

CREATE TABLE tb_itensvendas (
  id int auto_increment primary key,
  venda_id int,
  produto_id int,
  qtd int,
  subtotal decimal (10,2),

  FOREIGN KEY (venda_id) REFERENCES tb_vendas(id),
  FOREIGN KEY (produto_id) REFERENCES tb_produtos(id)
);
/*****************/


/* CRIANDO AS PROCEDURES DA TABELA DE CLIENTE */
DROP procedure IF exists sp_cadastraCliente;

DELIMITER $$
CREATE PROCEDURE sp_cadastraCliente(
 in v_nome varchar(100),
 in v_rg varchar (30),
 in v_cpf varchar (20),
 in v_email varchar(200),
 in v_telefone varchar(30),
 in v_celular varchar(30),
 in v_cep varchar(100),
 in v_endereco varchar (255),
 in v_numero int,
 in v_complemento varchar (200),
 in v_bairro varchar (100),
 in v_cidade varchar (100),
 in v_estado varchar (2)
)
BEGIN
 insert into tb_cliente (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairo,cidade,estado)
    values (v_nome, v_rg, v_cpf, v_email,v_telefone,v_celular,v_cep,v_endereco,v_numero,v_complemento,v_bairo,v_cidade,v_estado);

END$$

/** Criando a sp_editarCliente() ***/
/* CRIANDO AS PROCEDURES DA TABELA DE CLIENTE */
DROP procedure IF EXISTS sp_editarCliente;
DELIMITER $$
CREATE PROCEDURE sp_editarCliente (
 in v_nome varchar(100),
 in v_rg varchar (30),
 in v_cpf varchar (20),
 in v_email varchar(200),
 in v_telefone varchar(30),
 in v_celular varchar(30),
 in v_cep varchar(100),
 in v_endereco varchar (255),
 in v_numero int,
 in v_complemento varchar (200),
 in v_bairro varchar (100),
 in v_cidade varchar (100),
 in v_estado varchar (2),
 in v_codigo int
)
BEGIN
 update tb_clientes set nome = v_nome,rg = v_rg, cpf = v_cpf,email=v_email,telefone=v_telefone,
                        celular = v_celular, cep = v_cep, endereco = v_endereco, numero = v_numero, 
                        complemento = v_complemento,
                        bairro = v_bairro, cidade = v_cidade, estado = v_estado where id = v_codigo;   
END$$