create database Residencia_memorama
use Residencia_Memorama
--drop database Residencia_Memorama
--create table acceso
--(
--Id int identity primary key,
--Usuario varchar(30),
--Passw varchar(30)
--)

create table Usuarios
(
Id int  primary key identity(1,1),
Usuario varchar(30),
Correo varchar(30),
Passw varchar(30),
Passw1 varchar(30),
)
create table Historial
(
Id_Historial int identity(1,1),
Id_Usuario int foreign key references Usuarios(Id),
Tiempo varchar(10),
Movimientos int
)
select*from Usuarios
insert into Historial (Id_Usuario,Tiempo,Movimientos) values (1,'0',34)

create procedure dbo.Insertar_historial
@Id_Usuario int,
@Tiempo varchar(10),
@Movimientos int
AS
BEGIN
insert into dbo.Historial (Id_Usuario,Tiempo,Movimientos) values (@Id_Usuario,@Tiempo,@Movimientos)
end

create procedure [dbo].[Traer_Usuario]
@NombreUsuario varchar(30)=null
as
begin
select Id from Usuarios where Usuario='yim'
end
--alter procedure [dbo].[Traer_Usuario]
--@NombreUsuario varchar(30)=null
--AS
--BEGIN
--select Id from dbo.Usuarios  where Usuario = 'yim'
--end

select Id from dbo.Usuarios  where Usuario = 'yim'

exec [dbo].[Traer_Usuario] 'yim'


select*from Historial
select Tiempo,Movimientos from dbo.Historial where Id_Usuario= 1



insert into registro1(Usuario,Correo,Passw,Passw1) values('yim','jd','ut','ut')
select*from Usuarios

https://www.youtube.com/watch?v=4lfec3WsorQ


--agregar elementos
https://www.youtube.com/watch?v=L5x8PMW5C-c

CREATE PROCEDURE [dbo].[Reporte]

as begin 
select*from Historial

end 

CREATE PROCEDURE [dbo].[ReporteporUsuario]
@Id int

as begin 
select*from Historial where Id_Usuario=@Id
end 
GO