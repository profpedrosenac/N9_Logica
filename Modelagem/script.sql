-- Criando uma Banco de dados
/*  

comentário

*/

create database n9_calendario
use n9_calendario

-- criando tabelas no BD
create table sala
(
	id_sala int not null identity primary key,
	nome_sala varchar(50) not null,
	qtdemax_sala int not null,
	tipo_sala varchar(30) not null, 
	obs_sala varchar(255) null,
	status_sala varchar(30) not null default 'ATIVO'
)
select * from sala
drop table sala -- exclui uma tabela

insert into sala 
	(nome_sala,qtdemax_sala,tipo_sala,obs_sala)
values
	('Lab204',22,'Lab Informática','')

insert into sala 
	(nome_sala,qtdemax_sala,tipo_sala,obs_sala)
values
	('Lab201',24,'Lab Informática',''),
	('Lab208',27,'Lab Informática','')

create table docente
(
	id_docente int not null identity primary key,
	nome_docente varchar(50) not null  ,
	registro_docente varchar(50) not null unique ,
	area_docente varchar(30) not null  ,
	telefone1_docente char(14) not null  ,
	telefone2_docente char(14) not null  ,
	email_docente varchar(50) not null  ,
	obs_docente varchar(255) null  ,
	status varchar(30) not null default 'ATIVO' 
)

select * from docente

create table curso
(
	id_curso int not null identity primary key,
	nome_curso varchar(50) not null  ,
	ch_curso decimal(10,2) not null  ,
	area_curso varchar(30) not null  ,
	obs_curso varchar(255) null  ,
	status_curso varchar(30) not null default 'ATIVO' 
)
select * from curso

create table turma
(
	id_turma int not null identity primary key,
	id_curso_turma int not null  ,
	nome_turma varchar(50) not null unique ,
	periodo_turma varchar(30) not null  ,
	qtdeAluno_turma int not null  ,
	obs_turma varchar(255) null  ,
	status_turma varchar(30) not null default 'ATIVO' 
)

select * from turma

create table uc
(
	id_uc int not null identity primary key,
	id_curso_uc int not null  ,
	nome_uc varchar(50) not null  ,
	ch_uc decimal(10,2) not null  ,
	obs_uc varchar(255) null  ,
	status_uc varchar(30) not null default 'ATIVO' 
)

create table aula
(
	id_aula int not null identity primary key,
	id_sala_aula int not null  ,
	id_docente_aula int not null  ,
	id_turma_aula int not null  ,
	id_uc_aula int not null  ,
	data_aula date not null  ,
	periodo_aula varchar(30) not null  ,
	obs_aula varchar(255) null  ,
	status_aula varchar(30) not null default 'ATIVO' 
)

select * from aula

alter table turma
	add constraint FK_id_curso_turma foreign key (id_curso_turma)
	references curso (id_curso)

drop table curso

alter table uc
	add constraint FK_id_curso_uc foreign key (id_curso_uc)
	references curso (id_curso)


alter table aula
	add constraint FK_id_sala_aula foreign key (id_sala_aula) references sala (id_sala)
alter table aula
	add constraint FK_id_docente_aula foreign key (id_docente_aula) references docente (id_docente)
alter table aula
	add constraint FK_id_turma_aula foreign Key (id_turma_aula) references turma (id_turma)
alter table aula
	add constraint FK_id_uc_aula foreign key (id_uc_aula) references uc (id_uc)





alter table turma
add constraint FK_id_curso_turma foreign key (id_curso_turma) references curso (id_curso)


alter table uc
add constraint FK_id_curso_uc foreign key (id_curso_uc) references curso (id_curso)


select * from sala

update sala set qtdemax_sala = 25, obs_sala = 'Ajuste da qtde de máquinas'
where id_sala = 2

update sala set status_sala = 'ATIVO'

delete from sala where id_sala = 3



select * from sala

select nome_sala, qtdemax_sala, tipo_sala from sala

select nome_sala as 'Nome da Sala', qtdemax_sala as 'Qtde', tipo_sala as 'Tipo' from sala

select COUNT(*) from sala

select sum(qtdemax_sala) from sala
select sum(qtdemax_sala) * 0.9 from sala

select AVG(qtdemax_sala) from sala

select * from sala where id_sala = 2

select * from sala where nome_sala = 'Lab204'

insert into sala
	(nome_sala, qtdemax_sala, tipo_sala,obs_sala)
values
	('Sala 101', 27, 'Aula Teórica', '')

select * from sala where qtdemax_sala = 27
select count(*) from sala where qtdemax_sala = 27

select * from sala where qtdemax_sala > 23

select * from sala where nome_sala like 'Lab%'

select * from sala where nome_sala like '%1'

select * from sala where nome_sala like '%a%' 

select * from sala where nome_sala like '%1' and qtdemax_sala < 26

insert into sala
	(nome_sala,qtdemax_sala,tipo_sala,obs_sala)
values
	('Lab208',27,'Lab Informática','')

insert into curso
(nome_curso,ch_curso,area_curso,obs_curso)
values
('Técnico em Informática',1200,'TI',''),
('Técnico em Administração',1000,'ADM',''),
('Técnico em TST',1000,'TST',''),
('Técnico em Enfermagem',1200,'Saúde',''),
('Técnico em Podologia',1000,'Saúde',''),
('Técnico em Redes',1000,'TI',''),
('Técnico em Informática para Internet',1000,'TI',''),
('Técnico em Jogos Digitais',1000,'TI','')


select * from curso
select * from turma

insert into turma
(id_curso_turma,nome_turma,periodo_turma,qtdeAluno_turma,obs_turma)
values
(4,'Adm-T78','Noite',18,''),
(7,'Red-N86','Tarde',24,''),
(8,'Inf-N21','Tarde',18,''),
(8,'Pod-T41','Noite',20,''),
(2,'Red-N76','Noite',17,''),
(5,'Enf-T96','Tarde',20,''),
(8,'Inf-T68','Noite',20,''),
(6,'TST-T11','Tarde',24,''),
(2,'Pod-N78','Tarde',24,''),
(5,'Int-N21','Tarde',21,''),
(5,'Pod-T68','Tarde',24,''),
(6,'Pod-N93','Tarde',15,''),
(3,'Red-T11','Noite',15,''),
(7,'Red-N93','Tarde',19,''),
(1,'Enf-T17','Tarde',24,''),
(4,'Jog-N71','Tarde',20,''),
(6,'TST-T70','Tarde',22,''),
(5,'Int-T65','Tarde',17,''),
(4,'TST-N46','Tarde',15,''),
(7,'Jog-N48','Noite',22,''),
(1,'Red-N75','Noite',19,''),
(7,'Enf-T88','Tarde',20,''),
(5,'Adm-N41','Noite',15,''),
(3,'Jog-T27','Tarde',17,''),
(6,'Pod-T41','Noite',25,''),
(2,'Red-T55','Noite',20,''),
(1,'Pod-N16','Tarde',21,''),
(8,'TST-N48','Tarde',24,''),
(8,'Red-N99','Tarde',16,''),
(5,'Enf-N86','Tarde',20,''),
(2,'Pod-T32','Tarde',16,''),
(8,'Red-T42','Tarde',23,''),
(5,'Enf-T74','Tarde',21,''),
(1,'Int-T78','Tarde',24,''),
(2,'TST-T97','Tarde',18,''),
(7,'Enf-T76','Noite',21,''),
(2,'Red-N36','Tarde',16,''),
(3,'Pod-N49','Noite',25,''),
(2,'Enf-N76','Tarde',15,'')


insert into turma
(id_curso_turma,nome_turma,periodo_turma,qtdeAluno_turma,obs_turma)
values
(10,'Adm-T88','Noite',18,'')

select * from turma
select * from curso

select 
turma.id_turma, curso.nome_curso,turma.nome_turma,turma.periodo_turma,turma.qtdeAluno_turma
from turma
inner join curso on turma.id_curso_turma = curso.id_curso

