create database N9_miniprojeto

use n9_miniprojeto

create table usuario
(
	id_Usuario int not null identity primary key,
	Nome_Usuario varchar(50) not null  ,
	Login_Usuario varchar(50) not null unique ,
	Senha_Usuario varchar(50) not null  ,
	Obs_Usuario varchar(255) null  ,
	Status_Usuario varchar(30) not null default 'ATIVO' 
)

insert into usuario(Nome_Usuario, Login_Usuario, Senha_Usuario,Obs_Usuario)values('Administrador do Sistema','admin','123456','')

	select * from usuario

update usuario set Nome_Usuario = '',Login_Usuario = '',Senha_Usuario = '',Status_Usuario = '',Obs_Usuario = '' where id_Usuario = 1

create table funcionario
(
	id_Funcionario int not null identity primary key,
	nome_Funcionario varchar(50) not null  ,
	sexo_Funcionario varchar(30) not null  ,
	estadocivil_Funcionario varchar(30) not null  ,
	cpf_Funcionario char(14) not null  ,
	rg_Funcionario char(12) not null  ,
	nascimento_Funcionario date not null  ,
	datacadastro_Funcionario smalldatetime not null default getdate() ,
	email_Funcionario varchar(50) not null  ,
	logradouro_Funcionario varchar(50) not null  ,
	numero_Funcionario int not null  ,
	complemento_Funcionario varchar(50) null  ,
	bairro_Funcionario varchar(30) not null  ,
	cidade_Funcionario varchar(30) not null  ,
	uf_Funcionario char(2) not null  ,
	cep_Funcionario char(9) not null  ,
	telefone_Funcionario char(16) null  ,
	celular_Funcionario char(16) not null  ,
	setor_Funcionario varchar(30) not null  ,
	cargo_Funcionario varchar(30) not null  ,
	obs_Funcionario varchar(255) null  ,
	status_Funcionario varchar(30) not null default 'ATIVO' 
)

select * from funcionario

create table categoria
(
id_categoria	int	not null	identity	primary key,
nome_categoria	varchar(50)	not null	unique	,
obs_categoria	varchar(255)	null		,
status_categoria	varchar(30)	not null	default 'ATIVO'	
)

select * from categoria

create table produto
(
	id_produto int not null identity primary key,
	id_categoria_produto int not null  ,
	nome_produto varchar(50) not null unique ,
	qtde_produto int not null  ,
	datacadastro_produto smalldatetime not null default getdate() ,
	valorvenda_produto decimal(10,2) not null  ,
	valorcusto_produto decimal(10,2) not null  ,
	obs_produto varchar(255) null  ,
	status_produto varchar(30) not null default 'ATIVO'

	constraint FK_id_categoria_produto foreign key (id_categoria_produto) 
		references categoria(id_categoria)
)

select * from produto

create table movimentacao
(
	id_movimentacao int not null identity primary key,
	id_usuario_movimentacao int not null  ,
	id_funcionario_movimentacao int not null  ,
	id_produto_movimentacao int not null  ,
	tipo_movimentacao varchar(10) not null  ,
	data_movimentacao smalldatetime not null  ,
	qtde_movimentacao int not null  ,
	valorvenda_movimentacao decimal(10,2) not null  ,
	valorcusto_movimentacao decimal(10,2) not null  ,
	obs_movimentacao varchar(255) null  ,
	status_movimentacao varchar(30) not null default 'ATIVO'

	constraint fk_id_usuario_movimentacao foreign key (id_usuario_movimentacao) references usuario (id_usuario),
	constraint fk_id_funcionario_movimentacao foreign key (id_funcionario_movimentacao) references funcionario(id_funcionario),
	constraint fk_id_produto_movimentacao foreign key (id_produto_movimentacao) references produto(id_produto)
)

alter table movimentacao
	add constraint 


	select * from usuario