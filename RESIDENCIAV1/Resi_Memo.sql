create database Residencia_Memorama
use Residencia_Memorama

--create table acceso
--(
--Id int identity primary key,
--Usuario varchar(30),
--Passw varchar(30)
--)

create table Usuarios
(
Id int identity(1,1),
Usuario varchar(30),
Correo varchar(30),
Passw varchar(30),
Passw1 varchar(30),
)
create table Historial
(
Id_Historial int identity(1,1),
Id_Usuario int,
Tiempo varchar(10),
Movimientos int
)

ALTER TABLE Historial ADD FOREIGN KEY (Id_Usuario ) REFERENCES Usuarios(Id)
ALTER TABLE Usuarios ADD CONSTRAINT pk_Id PRIMARY KEY (Id)
Alter PROCEDURE [dbo].[Insertar_Historial] 
@Id_Usuario

insert into registro1(Usuario,Correo,Passw,Passw1) values('yim','jd','ut','ut')
select*from Usuarios

https://www.youtube.com/watch?v=4lfec3WsorQ


--agregar elementos
https://www.youtube.com/watch?v=L5x8PMW5C-c