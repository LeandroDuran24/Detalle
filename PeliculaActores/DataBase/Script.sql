create table Peliculas(
PeliculaId int identity(1,1) primary key,
Nombre varchar(100),
Actores varchar(150),
Fecha datetime,
);

create table Actores(
ActorId int identity(1,1) primary key,
Nombre varchar(150),
);

create table PeliculasActores(
PeliculaActor int identity(1,1) primary key,
PeliculaId int ,
ActoresId  int,
);