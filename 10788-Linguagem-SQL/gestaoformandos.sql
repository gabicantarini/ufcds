create database gestaoformandos;

use gestaoformandos;

create table formando (
	id_formando		int,
    nome			varchar(100) not null,
    morada			varchar(100) not null,
    contacto 		varchar(9) null,
    iban			varchar(50) not null default '0',
    sexo			char(1)	not null,
    data_nascimento	date not null
);

insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values
(1, 'Ana Silva', 'Coimbra', NULL, '0', 'F', '2000-12-31'); 

select * from formando;
