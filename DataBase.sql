CREATE DATABASE ComunicAR;

USE ComunicAR

CREATE TABLE provincias
(cod_prov int identity,
nombre_prov varchar(50),

CONSTRAINT pk_provicia PRIMARY KEY(cod_prov))

CREATE TABLE ciudades
(cod_ciudad int identity,
nombre_ciudad varchar(50),
cod_prov int

CONSTRAINT pk_ciudad PRIMARY KEY(cod_ciudad),
CONSTRAINT fk_prov_ciudad FOREIGN KEY(cod_prov)
REFERENCES provincias(cod_prov))

CREATE TABLE barrios
(cod_barrio int identity,
nombre_barrio varchar(50),
cod_ciudad int

CONSTRAINT pk_barrios PRIMARY KEY(cod_barrio),
CONSTRAINT fk_ciudad_barrio FOREIGN KEY(cod_ciudad)
REFERENCES ciudades(cod_ciudad))

CREATE TABLE clientes
(nro_cliente int identity,
nombre_razonSocial varchar(50),
calle varchar(50),
nro int,
piso varchar(5),
cod_barrio int

CONSTRAINT pk_cliente PRIMARY KEY(nro_cliente),
CONSTRAINT fk_barrio_cliente FOREIGN KEY(cod_barrio)
REFERENCES barrios(cod_barrio))

CREATE TABLE dispositivos
(id_dispositivo int identity,
fecha_elaboracion date,
marca varchar(30),
modelo varchar(10),
caracteristicas varchar(100),
precio money,

CONSTRAINT pk_dispositivo PRIMARY KEY(id_dispositivo))

CREATE TABLE tiposComunicacion
(cod_tipo_comunic int identity,
deser_comunicacion varchar(50),
costo money,

CONSTRAINT pk_tipoComunicacion PRIMARY KEY(cod_tipo_comunic))

CREATE TABLE regiones
(id_region int identity,
descripcion varchar(100),

CONSTRAINT pk_region PRIMARY KEY(id_region))

CREATE TABLE serviciosPrepago
(id_pack int identity,
duracion float,
descripcion varchar(100),
costo money,
id_region int,

CONSTRAINT pk_servicioPrepago PRIMARY KEY(id_pack),
CONSTRAINT fk_region_servicioPrepago FOREIGN KEY(id_region)
REFERENCES regiones(id_region))

CREATE TABLE bandasHoraria
(cod_bandaHoraria int identity,
descripcion varchar(50),
costo money,

CONSTRAINT pk_bandaHoraria PRIMARY KEY(cod_bandaHoraria))
