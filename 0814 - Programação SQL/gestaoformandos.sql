drop database if exists gestaoformandos;

create database gestaoformandos;

use gestaoformandos;

create table formando (
	id_formando		int,
    nome			varchar(100) not null,
    morada			varchar(100) not null,
    contacto 		varchar(9) null,
    iban			varchar(50) not null default '0',
    sexo			char(1)	not null,
    data_nascimento	date not null,
    primary key (id_formando)
);

insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values
(1, 'Ana Silva', 'Coimbra', NULL, '0', 'F', '2000-12-31'); 

select * from formando;

Insert into formando (nome, id_formando, morada, contacto, iban, sexo, data_nascimento) values  
('Pinto da Costa', '10099', 'Rua do Porto', NULL, '0000000000000000000000000', 'M', '1950-06-22');

delete from formando where id_formando = '34738';

select max(id_formando) + 1 from formando;

delete from formando;

insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values 
('2', 'Guilherme', 'Rua dos Príncipes', '999999999', 'PT83092830928309283092830', 'M', '2010-01-10');

create table nacionalidade (
	id_nacionalidade int(11) not null auto_increment,
    alf2 varchar(2) default null unique,
    nacionalidade varchar(100) not null,
    primary key (id_nacionalidade)
);

insert into nacionalidade (id_nacionalidade, alf2, nacionalidade) values
(1, 'MO', 'Macau');

insert into nacionalidade (id_nacionalidade, alf2, nacionalidade) values
(0, 'PT', 'Portugal');

select * from nacionalidade;

select * from formando;

alter table formando
	add column id_nacionalidade int,
    add constraint fk_nacionalidade foreign key (id_nacionalidade) references nacionalidade (id_nacionalidade) 
		on update cascade;
        
create view vFormando as
select
	f.id_formando,
    f.nome, 
    f.iban,
    f.contacto,
    f.sexo,
    n.nacionalidade,
    n.id_nacionalidade
from
	formando f, nacionalidade n
where	
	f.id_nacionalidade = n.id_nacionalidade;

select
	f.id_formando,
    f.nome,
    f.morada,
    f.contacto,
    f.iban,
    f.sexo,
    f.data_nascimento,
    n.nacionalidade as nacionalidade
from
	formando f
join
	nacionalidade n on f.id_nacionalidade = n.id_nacionalidade;
    
select md5("1234");
select sha1("1234");
select sha2("1234",512);
select sha2("1234",0);
select sha2("1234",256);

select sha2(nome,512) from formando;

create table users (
	uname varchar(15) primary key,
    pwd varchar(25) not null,
    userRole varchar(25) not null
);

insert into users (uname, pwd, userRole) values
('user1','user1','Manager'),
('user2','user2','Admin'),
('user3','user3','User');

select * from users;

select * from users where binary uname = 'user1' and binary pwd = 'user1'; 

select uname, pwd, sha2(pwd,512) from users;

alter table users modify column pwd varchar(128);

update users set pwd = sha2(pwd,512);

select * from users where binary uname = 'user1';

select * from users where binary uname = 'user1' and pwd = sha2("user1",512);

insert into users (uname, pwd, userRole) values
('user4',sha2('user4',512),'Manager');

select uname from users where binary uname = 'user' and pwd = sha2("user1",512);








