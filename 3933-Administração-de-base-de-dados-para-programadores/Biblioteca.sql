-- 1)
drop database if exists Biblioteca;
 
create database Biblioteca;
 
use Biblioteca;
 
-- 2)
 
create table Autores (
    CodAutor int primary key,
    NomeAutor char(30)
);
 
create table Livros_Autores (
    CodLivro int not null,
    CodAutor int not null,
    primary key (CodLivro, CodAutor),
    foreign key (CodAutor) references Autores (CodAutor)
);
 
 
create table Areas_Tematicas (
    CodArea int primary key,
    Designacao char(30)
);
 
create table Livros (
    CodLivro int primary key,
    Titulo char(100),
    Editora char(50),
    Ano int,
    CodArea int,
    foreign key (CodArea) references Areas_Tematicas (CodArea)
		on update cascade
);
create table Utentes (
    ID_Utente int primary key,
    Nome char(30),
    Morada char(100)
);
 
create table Requisicoes (
    N_Requisicao int primary key,
    ID_Utente int,
    CodLivro int,
    DataRequisicao date,
    DataEntrega date,
    foreign key (CodLivro) references Livros (CodLivro),
    foreign key (ID_Utente) references Utentes (ID_Utente)
		on update cascade
);
 
-- 3)
 
insert into Autores(CodAutor,NomeAutor) values
 
(1,'Colleen Hoover'),
(2,'Stieg Larsson'),
(3,'Antoine de Saint-Exupéry');
 
-- select * from Autores;
 
insert into Livros_Autores(CodLivro,CodAutor) values
 
(10,1),
(20,2),
(30,3);
 
-- select * from Livros_Autores;
 
insert into Areas_Tematicas(CodArea,Designacao) values
 
(111,'Romance'),
(222,'Suspense'),
(333,'Infantil');
 
-- select * from Areas_Tematicas;
 
insert into Livros(CodLivro,Titulo,Editora,Ano,CodArea) values
 
(111,'It Ends With Us','Simom & Schuster',2016,111),
(222,'Os homens que odeiam as mulheres','Oceanos',2008,222),
(333,'O Principezinho para Crianças','Editorial Presença',2016,333);
 
-- select * from Livros;
 
insert into Utentes(ID_Utente,Nome,Morada) values
 
(01,'Britney Spears','Rua Womanizer'),
(02,'Camila Cabello','Rua Bam Bam'),
(03,'Damom Salvatori','Rua Diário de um Vampiro');
 
-- select * from Utentes;
 
insert into Requisicoes(N_Requisicao,ID_Utente,CodLivro,DataRequisicao,DataEntrega) values
 
(50,01,111,'2023-10-25','2024-01-20'),
(41,02,222,'2024-01-02','2024-01-25'),
(9,03,333,'2023-04-10','2023-06-02');
 
-- select * from Requisicoes;
 
-- 4.a)
 
alter table Utentes
 
add VIP bit not null default 0;
 
-- 4.b)
 
alter table Utentes
 
add Email varchar(255) unique,
add Data_Nascimento date;
 
-- 4.c)
 
alter table Requisicoes
add DataEntregaPrevista date check (DataEntregaPrevista>=DataRequisicao);
 
-- 5.a)
 
select *
from Livros
where Titulo like '%Portugal%';
 
-- 5.b)
 
select CodArea, count(*) as NumeroTotalLivros
from Livros
group by CodArea;
 
-- 5.c)
 
select*
from Requisicoes
where DataEntrega is null;
 
-- 5.d)
 
select *
from Requisicoes
where year(DataRequisicao) = 2019;
 
-- 5.e)
 
select *
from Requisicoes
where DataRequisicao>='2018-09-01' and DataRequisicao<='2018-12-31';
 
-- 5.f)
 
select 
	Autores.CodAutor,
    Autores.NomeAutor,
    count(Livros_Autores.CodLivro) as NumeroDeLivros
from
	Autores
join
	Livros_Autores on Autores.CodAutor=Livros_Autores.CodAutor
group by
	Autores.CodAutor, Autores.NomeAutor;
-- 5.g)
 
	update Utentes
    set VIP=1
    where ID_Utente in(
		select ID_Utente
        from Requisicoes
        group by ID_Utente
        having count(*)>10
        );
-- 6) Trigger para calcular DataEntregaPrevista
DELIMITER //
 
create trigger Insert_DataEntregaPrevista
before insert on Requisicoes
for each row
begin
    declare daysToAdd int;
    if (select VIP from Utentes where ID_Utente = new.ID_Utente) = 1 then
        set daysToAdd = 5;
    else
        set daysToAdd = 3;
    end if;
    set new.DataEntregaPrevista = DATE_ADD(new.DataRequisicao, INTERVAL daysToAdd DAY);
end;
//
 
DELIMITER ;


