create database Faculdade;
use Faculdade;

/* User  */
CREATE TABLE User(
	id int primary key auto_increment,
    nome varchar(100),
    RGM varchar(100),
    DataNascimento varchar(100),
    Curso varchar(100),
    Bolsista varchar(100),
    RG varchar(100),
    Genero varchar(100)
);

INSERT INTO User (nome, RGM, DataNascimento, Curso, Bolsista, RG, Genero) VALUES ('Nome01', '1212123992', '01-01-1877', 'Programming', 'Não', '1293812938-1', 'WWqq');
SELECT * from User;
UPDATE User set nome = "teste" WHERE (id = 1);
UPDATE User set RGM = "teste" WHERE (id = 1);
UPDATE User set DataNascimento = "02/02/1899" WHERE (id = 1);
UPDATE User set Curso = "Algum curso" WHERE (id = 1);
UPDATE User set Bolsista = 'Sim' WHERE (id = 1);
UPDATE User set RG = "1999213" WHERE (id = 1);
UPDATE User set Genero = "Dkwkw" WHERE (id = 1);
DELETE FROM User WHERE (id = 2); 
drop table User;

/* Library  */
CREATE TABLE Library(
	id int primary key auto_increment,
    ISBN varchar(100),
    Titulo varchar(100),
    Autor varchar(100),
    Ano int(30),
    Genero varchar(100),
    Edicao varchar(100),
    Quantidade int(30)
);

INSERT INTO Library (ISBN, Titulo, Autor, Ano, Genero, Edicao, Quantidade) VALUES ('ISBN LIVRO', "Titulo do livro", "Autor do livro", 1999, "Genero do livro", "Edição do livro", 10);
SELECT * from Library;
UPDATE Library set name = "Livro teste" WHERE (id = 1);
UPDATE Library set quantity = 3 WHERE (id = 1);
DELETE FROM Library WHERE (id = 1); 
drop table Library;
