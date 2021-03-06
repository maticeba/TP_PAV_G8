USE BD3K6G08_2021

/*
DROP TABLE Detalle_fact_llamada
DROP TABLE Detalle_fact_fijos
DROP TABLE Detalle_fact_datos
DROP TABLE Detalle_fact_prepago
DROP TABLE Detalle_fact_dispositivo

DROP TABLE Facturas

DROP TABLE Venta_dispositivo 
DROP TABLE Servicios_fijos
DROP TABLE Servicios_datos
DROP TABLE Servicios_prepago
DROP TABLE Servicios_contratados

DROP TABLE Llamadas
DROP TABLE Numero
DROP TABLE Dispositivos
DROP TABLE Tipo_dispositivo

DROP TABLE Cliente
DROP TABLE Barrio
DROP TABLE Ciudad
DROP TABLE Provincia
DROP TABLE Tipo_comunicacion
DROP TABLE Banda_horaria
DROP TABLE Region

*/
-- TABLA Tipo Comunicación

CREATE TABLE Tipo_comunicacion (	id_tipo_com INTEGER		NOT NULL PRIMARY KEY IDENTITY,
									descripcion VARCHAR(50) NOT NULL,
									costo MONEY				NOT NULL)

-- TABLA Banda Horaria

CREATE TABLE Banda_horaria		(	id_banda INTEGER		NOT NULL PRIMARY KEY IDENTITY,
									descripcion VARCHAR(50) NOT NULL,
									costo MONEY				NOT NULL)

-- TABLA Región

CREATE TABLE Region (	id_region INTEGER		NOT NULL PRIMARY KEY IDENTITY,
						descripcion_region VARCHAR(50) NOT NULL)

-- TABLA Provincia

CREATE TABLE Provincia	(	cod_prov INTEGER		NOT NULL PRIMARY KEY IDENTITY,
							nombre_prov VARCHAR(30)	NOT NULL);

-- TABLA Ciudad

CREATE TABLE Ciudad		(	cod_ciudad INTEGER		NOT NULL PRIMARY KEY IDENTITY,
							nombre_ciudad VARCHAR(30)	NOT NULL,
							id_provincia INTEGER			NOT NULL,
							
						CONSTRAINT provinciaXciudad
							FOREIGN KEY (id_provincia)
							REFERENCES Provincia
							ON DELETE CASCADE
						);

-- Tabla Barrio

CREATE TABLE Barrio		(	cod_barrio INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							nombre_barrio VARCHAR(30)	NOT NULL,
							id_ciudad	INTEGER			NOT NULL,
							
						CONSTRAINT ciudadXbarrio
							FOREIGN KEY (id_ciudad)
							REFERENCES Ciudad
							ON DELETE CASCADE
						);

-- Tabla Cliente

CREATE TABLE Cliente	(	nro_cliente INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							nombre_razonSocial VARCHAR(30)	NOT NULL,
							calle VARCHAR(30)			NOT NULL,
							nro INTEGER					NOT NULL,
							piso INTEGER				NULL,
							cod_barrio INTEGER			NULL,
							borrado	BIT					DEFAULT 0,
							fecha_alta DATE			    DEFAULT GETDATE(),
							fecha_baja DATE				NULL,

						CONSTRAINT barrioXcliente
							FOREIGN KEY (cod_barrio)
							REFERENCES Barrio
							ON DELETE SET NULL
						);

-- TABLA Tipo Dispositivo

CREATE TABLE Tipo_dispositivo	(	id_tipo_dispositivo INTEGER		NOT NULL PRIMARY KEY IDENTITY,
									nombre_tipo VARCHAR(30)			NOT NULL);

-- TABLA Dispositivos

CREATE TABLE Dispositivos		(	id_dispositivo INTEGER			NOT NULL PRIMARY KEY IDENTITY,
									fecha_elaboracion DATE			NOT NULL,
									marca VARCHAR(30)				NOT NULL,
									modelo VARCHAR(10)				NOT NULL,
									caracteristicas VARCHAR(100)	NOT NULL,
									precio MONEY					NOT NULL,
									id_tipo_dispositivo INTEGER		NOT NULL,

								CONSTRAINT tipo_dispositivoXnumero
									FOREIGN KEY(id_tipo_dispositivo)
									REFERENCES Tipo_dispositivo
									ON DELETE NO ACTION
								);

-- TABLA Numero

CREATE TABLE Numero (	id_numero INTEGER		NOT NULL PRIMARY KEY IDENTITY, 
						cod_nacional NCHAR(3)	NOT NULL,
						cod_area NCHAR(3)		NOT NULL,
						nro_telefono NCHAR(8)	NOT NULL,
						nro_cliente	INTEGER		NULL,
						id_dispositivo INTEGER	NULL, 
						borrado BIT				DEFAULT 0,
						fecha_baja DATE			NULL,

					CONSTRAINT clienteXnumero
						FOREIGN KEY (nro_cliente)
						REFERENCES Cliente
						ON DELETE SET NULL,
					CONSTRAINT dispositivoXnumero
						FOREIGN KEY (id_dispositivo)
						REFERENCES Dispositivos
						ON DELETE SET NULL
					);

-- TABLA Servicios Contratados

CREATE TABLE Servicios_contratados	(	cod_servicio INTEGER		NOT NULL PRIMARY KEY IDENTITY,
										tipo_servicio NCHAR(1)		NOT NULL,
										id_servicio INTEGER			NULL,
										fecha_desde DATE			NOT NULL,
										fecha_hasta DATE			NOT NULL,
										id_numero INTEGER			NULL,
										descuento NUMERIC (3,1)		NULL,

									CONSTRAINT numeroXservicio_contratado
										FOREIGN KEY (id_numero)
										REFERENCES Numero
										ON DELETE NO ACTION,
									CONSTRAINT tipo_serv_ck CHECK (tipo_servicio in ('A', 'B', 'C'))
									);

-- TABLA Servicio Fijo

CREATE TABLE Servicios_fijos	(	tipo_servicio NCHAR(1)	NOT NULL,
								cod_servicio INTEGER		NOT NULL IDENTITY,
								descripcion VARCHAR(100)	NOT NULL,
								costo_mensual MONEY			NOT NULL,

							PRIMARY KEY (tipo_servicio, cod_servicio), 
							CONSTRAINT tipo_servicio_fijo_ck CHECK (tipo_servicio = 'B')
							);

-- TABLA Servicios Datos

CREATE TABLE Servicios_datos	(	tipo_servicio NCHAR(1)	NOT NULL,
									cod_datos INTEGER		NOT NULL IDENTITY,
									limite_datos INTEGER	NOT NULL,
									descripcion VARCHAR(30)	NOT NULL,
									costo_fijo MONEY		NOT NULL,
									
								PRIMARY KEY (tipo_servicio, cod_datos),
								CONSTRAINT tipo_servicio_dato_ck CHECK (tipo_servicio = 'A')
								);

-- TABLA Servicios Prepagos

CREATE TABLE Servicios_prepago	(	tipo_servicio NCHAR(1)	NOT NULL,
									id_pack	INTEGER			NOT NULL IDENTITY,
									duracion FLOAT			NOT NULL,
									descripcion VARCHAR(30)	NOT NULL,
									costo MONEY				NOT NULL,
									id_region INTEGER		NOT NULL,

								PRIMARY KEY (tipo_servicio, id_pack),
								CONSTRAINT regionXprepago
									FOREIGN KEY	(id_region)
									REFERENCES region
									ON DELETE NO ACTION,
								CONSTRAINT tipo_servicio_prepago_ck CHECK (tipo_servicio = 'C')
								);

--	TABLA Venta_dispositivo

CREATE TABLE Venta_dispositivo	(	id_venta_dispo INTEGER		NOT NULL PRIMARY KEY IDENTITY,
									fecha_venta DATE			NOT NULL,
									id_numero INTEGER			NOT NULL,
									id_dispositivo INTEGER		NOT NULL,
									cant_cuotas	INTEGER			NOT NULL,
									descuento NUMERIC (3,1)		NULL,

									CONSTRAINT id_numeroXventa
										FOREIGN KEY (id_numero)
										REFERENCES Numero,
									CONSTRAINT id_dispoXventa
										FOREIGN KEY (id_dispositivo)
										REFERENCES dispositivos,
									CONSTRAINT cant_cuotas_CK CHECK (cant_cuotas IN (1, 3, 6, 12, 18))
								);

-- TABLA Facturas

CREATE TABLE Facturas	(	nro_factura INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							fecha_emitido DATE			NOT NULL,
							fecha_1er_vto DATE			NOT NULL,
							fecha_2do_vto DATE			NOT NULL,
							nro_cliente INTEGER			NOT NULL,
							facturado BIT				NOT NULL DEFAULT 0,
							tipo_factura NCHAR(1)		NOT NULL DEFAULT 'A',
						
						CONSTRAINT tipo_factura_CK CHECK (tipo_factura IN ('A', 'B')),
						CONSTRAINT clienteXfactura
							FOREIGN KEY (nro_cliente)
							REFERENCES Cliente
						);

-- TABLA Detalle Factura Dispositivos

CREATE TABLE Detalle_fact_dispositivo	(	id_detalle_dispositivo INTEGER		NOT NULL IDENTITY,
											nro_factura INTEGER					NOT NULL,
											id_venta_dispo INTEGER				NOT NULL,
											marca VARCHAR(50)					NOT NULL,
											modelo VARCHAR(10)					NOT NULL,
											precio_venta MONEY					NOT NULL,
											descuento NUMERIC (4,2)				NULL,
											nro_cuota INTEGER				NULL,

										CONSTRAINT detalle_fact_dispo_PK
											PRIMARY KEY (id_detalle_dispositivo, nro_factura),
										CONSTRAINT dispositivoXdetalle_fact
											FOREIGN KEY (id_venta_dispo)
											REFERENCES Venta_dispositivo,
										CONSTRAINT facturaXdetalle_dispositivo
											FOREIGN KEY (nro_factura)
											REFERENCES facturas
										);

-- TABLA Detalle Factura Fijos

CREATE TABLE Detalle_fact_fijos	(	id_detalle_fijos INTEGER		NOT NULL IDENTITY,
									nro_factura INTEGER				NOT NULL,
									cod_serv_contratado INTEGER		NOT NULL,
									costo_final MONEY				NOT NULL,
									descuento NUMERIC (4,2)			NULL,
									nro_cuota INTEGER				NULL,

								CONSTRAINT detalle_fact_fijo_PK
									PRIMARY KEY (id_detalle_fijos, nro_factura),
								CONSTRAINT facturaXdetalle_fijo
									FOREIGN KEY (nro_factura)
									REFERENCES facturas,
								CONSTRAINT serv_fijoXdetalle_fijo
									FOREIGN KEY (cod_serv_contratado)
									REFERENCES Servicios_contratados,
								);

-- TABLA Detalle Factura Datos

CREATE TABLE Detalle_fact_datos	(	id_detalle_datos INTEGER		NOT NULL IDENTITY,
									nro_factura INTEGER				NOT NULL,
									cod_serv_contratado INTEGER		NOT NULL,
									costo_final MONEY				NOT NULL,
									descuento NUMERIC (4,2)			NULL,
									nro_cuota INTEGER				NULL,

								CONSTRAINT detalle_fact_dat_PK
									PRIMARY KEY (id_detalle_datos, nro_factura),
								CONSTRAINT facturaXdetalle_dato
									FOREIGN KEY (nro_factura)
									REFERENCES facturas,
								CONSTRAINT serv_fijoXdetalle_dato
									FOREIGN KEY (cod_serv_contratado)
									REFERENCES Servicios_contratados
								);

-- TABLA Llamadas

CREATE TABLE Llamadas	(	id_llamada INTEGER		NOT NULL PRIMARY KEY IDENTITY,
							id_nro_emisor INTEGER	NOT NULL,
							id_nro_receptor INTEGER	NOT NULL,
							fecha_hora_inicio DATETIME	NOT NULL,
							fecha_hora_fin DATETIME	NOT NULL,
							id_tipo_comun INTEGER	NOT NULL,
							id_band_horar INTEGER	NOT NULL,

						CONSTRAINT emisorXllamada
							FOREIGN KEY (id_nro_emisor)
							REFERENCES Numero
							ON DELETE NO ACTION,
						CONSTRAINT receptorXllamada
							FOREIGN KEY (id_nro_receptor)
							REFERENCES Numero
							ON DELETE NO ACTION,
						CONSTRAINT tipo_comXllamada
							FOREIGN KEY (id_tipo_comun)
							REFERENCES Tipo_Comunicacion
							ON DELETE NO ACTION,
						CONSTRAINT banda_horXllamada
							FOREIGN KEY (id_band_horar)
							REFERENCES Banda_horaria
							ON DELETE NO ACTION
						);

-- TABLA Detalle Factura Llamada

CREATE TABLE Detalle_fact_llamada	(	id_detalleLlamada INTEGER		NOT NULL IDENTITY,
											nro_factura INTEGER			NOT NULL,
											id_llamada INTEGER			NOT NULL,
											costo_final MONEY			NOT NULL,

										CONSTRAINT detalle_fact_llamada_PK
											PRIMARY KEY (id_detalleLlamada, nro_factura),
										CONSTRAINT facturaXdetalleLlamada
											FOREIGN KEY (nro_factura)
											REFERENCES facturas,
										CONSTRAINT llamadaXdetalleLlamada
											FOREIGN KEY (id_llamada)
											REFERENCES Llamadas,
										);

-- TABLA Detalle Factura Prepago

CREATE TABLE Detalle_fact_prepago	(	id_detallePrepago INTEGER		NOT NULL IDENTITY,
											nro_factura INTEGER				NOT NULL,
											cod_servicio_contratado INTEGER	NOT NULL,
											costo_final MONEY				NOT NULL,
											descuento NUMERIC (4,2)			NULL,
											nro_cuota INTEGER				NULL,

										CONSTRAINT detalle_fact_prepago_PK
											PRIMARY KEY (id_detallePrepago, nro_factura),
										CONSTRAINT facturaXdetalle_prepago
											FOREIGN KEY (nro_factura)
											REFERENCES facturas,
										CONSTRAINT prepagoXdetalle_prepago
											FOREIGN KEY (cod_servicio_contratado)
											REFERENCES Servicios_contratados,
										);

		--  DATOS

USE BD3K6G08_2021

-- DATOS PARA CREAR

	-- Provincia

INSERT	INTO Provincia (nombre_prov)
		VALUES ('Córdoba')
INSERT	INTO Provincia (nombre_prov)
		VALUES ('Buenos Aires')
INSERT	INTO Provincia (nombre_prov)
		VALUES ('Mendoza')

	-- Ciudad

INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('Córdoba Capital', 1)
INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('Villa Carlos Paz', 1)
INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('Villa Maria', 1)

INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('La Plata', 2)
INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('Banfield', 2)
INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('Colón', 2)

INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('Gran Mendoza', 3)
INSERT  INTO Ciudad (nombre_ciudad, id_provincia)
		VALUES ('San Rafael', 3)

	-- Barrio

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Jardin', 1)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Urca', 1)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Nueva Córdoba', 1)

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Centro', 2)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Cu-cú', 2)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Las Rosas Norte', 2)

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Almirante Brown', 3)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Belgrano', 3)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Los Olmos', 3)

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Hipódromo', 4)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Norte', 4)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Villa Elvira', 4)

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Constitución', 5)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Alberto Sabio', 5)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Banfield', 5)

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Colón', 6)


INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Mendoza', 7)
INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('Las Heras', 7)

INSERT	INTO Barrio (nombre_barrio, id_ciudad)
		VALUES ('San Rafael', 8)

INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Judería',1)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Santa Marina',4)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San Basilio',8)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San Lorenzo',4)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San Andrés',1)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San Agustín',3)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Barrio Jardin',5)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Maipu',6)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San Benardo',2)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Marisoles',5)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Calafan',5)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Catermo',4)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San Agustin',1)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Maria Gracia',8)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Tulupa',6)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Canteros',5)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Las Flores',1)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Horizonte',2)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('Villa dolroes',2)
INSERT INTO Barrio(nombre_barrio, id_ciudad)
		VALUES('San peter',7)

	-- Regiones

INSERT	INTO Region (descripcion_region)
		VALUES ('Local')
INSERT	INTO Region (descripcion_region)
		VALUES ('Regional')
INSERT	INTO Region (descripcion_region)
		VALUES ('Nacional')
INSERT	INTO Region (descripcion_region)
		VALUES ('Internacional')

	-- Cliente

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
		VALUES('Nicolás Carranza Nakayama', 'Garlot', 4351, 14, 20, 0, '2008-1-19', NULL)
INSERT  INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
		VALUES('Matias Ceballos', 'Nicolás Berrotarán', 3435, 3, 9, 1, '2017-7-10', '2017-11-9')
INSERT  INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
		VALUES('Francisico Alvarez', 'Independencia', 3494, 20, 5, 1, '2018-1-3', '2020-5-1')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Malena Lisboa', 'Urrutia', 5132, 10, 30, 0, '2003-7-16', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Silvana Barrea', 'Alegras', 3795, 19, 26, 0, '2005-8-3', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Tomas Salomon', 'Riachuelo', 3033, 0, 22, 0, '2016-8-6', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Alejo Fontao', 'Buenos Aires', 1992, 12, 3, 0, '2015-7-20', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Francisco Marcuzzi', 'India', 5227, 9, 22, 1, '2017-11-7', '2019-1-13')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Joaco Castellano', 'Alliaga', 1883, 29, 38, 1, '2012-10-22', '2015-2-18')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Gianni Peruzzi', 'Toledo', 2384, 24, 11, 0, '2001-1-5', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Renzo Padilla', 'Chacabuco', 2589, 22, 5, 0, '2013-10-2', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Augusto Alvarez', 'Illia', 4753, 6, 34, 0, '2005-5-6', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Ignacio Roberts', 'Valparaiso', 4948, 29, 23, 1, '2010-10-17', '2019-7-10')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Juan Carlos Gómez', 'Rawson', 4595, 28, 14, 1, '2000-6-7', '2003-3-1')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Braian Anastasia', 'Richierri', 5097, 21, 27, 0, '2013-12-23', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Manuel Zalazar', 'Ituzaingo', 1080, 1, 38, 0, '2010-1-19', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Julian Weich', 'San Francisco de Asis', 754, 22, 16, 0, '2015-8-2', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Marley Bo', '21 de Junio', 3224, 7, 24, 1, '2018-12-14', '2019-6-21')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('Juan Domingo Peron', 'Juan Domingo Peron', 1543, 8, 10, 0, '2010-6-4', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('SUSANA GIMENEZ', 'MAKENA', 604, 2, 30, 0, '2005-12-6', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIO GALA', 'MAKENA', 2400, 5, 28, 1, '2004-7-16', '2017-5-10')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ANA SOLER', 'MAKENA', 2794, 8, 6, 0, '2015-8-12', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('PAOLA PEREZ', 'MAKENA', 5982, 16, 28, 1, '1999-12-10', '2012-8-11')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('NICOLAS MORA', 'LIMA', 1243, 0, 7, 1, '2007-5-16', '2009-9-3')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('SERGIO JAER', 'PERU', 4277, 29, 4, 1, '2005-1-19', '2009-12-25')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ESTEBAN RODRIGUEZ', 'SALTA', 3338, 26, 33, 1, '2016-1-9', '2016-5-24')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('EDUARDO TOLEDO', 'CHILE', 1140, 29, 24, 1, '2007-2-2', '2020-2-6')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIANA LENA', 'MORENO', 1471, 9, 34, 1, '2012-6-18', '2013-1-17')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('SOFIA BIYOU', 'MORENO', 2096, 9, 6, 0, '2011-1-11', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('EDGARD PATIŃO', 'SARMIENTO', 1818, 24, 26, 1, '2013-5-8', '2019-12-1')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('DIEGO SUAREZ', 'LIMA', 2607, 25, 27, 0, '2003-3-18', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ISABELLA TOMASINA', 'SANTA FE', 2130, 22, 18, 0, '2013-8-13', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CRISTIAN DELGADO', 'SAN MARTIN', 3631, 11, 25, 1, '2016-10-3', '2016-3-2')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('JESUS NAZAR', 'SARMIENTO', 3237, 24, 31, 0, '2012-6-21', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CARLOS MENEM', 'SARMIENTO', 2912, 13, 29, 0, '2006-3-4', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('PEDRO ESCOBAR', 'SAN MARTIN', 3912, 20, 32, 0, '2010-8-16', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('PABLO GROSSO', 'CHILE', 40, 5, 10, 1, '2004-3-8', '2010-6-8')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIA PERALTA', 'SARMIENTO', 4490, 21, 14, 0, '1999-10-17', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('EUGENIA GALAN', 'SAN MARTIN', 2287, 27, 11, 1, '2013-5-20', '2015-4-19')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('VALERIA DAA', 'CHILE', 364, 9, 7, 0, '2007-8-9', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIA DEL VALLE', 'CHILE', 2886, 2, 18, 0, '2009-1-18', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('JC MARQUEZ', 'OCAMPO', 760, 12, 5, 0, '2009-5-6', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('BRISA LUNELA', 'OCAMPO', 1118, 28, 13, 0, '2012-11-9', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CRISTIANA BERTONA', 'CASEROS', 2837, 14, 19, 0, '2003-8-24', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MIRANDA RESERO', 'CASEROS', 4326, 5, 35, 0, '2016-7-7', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('VIRGINIA MUŃOZ', 'KENIA', 317, 10, 36, 0, '2010-6-3', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MATIAS PELELE', 'BOLIVAR', 1918, 18, 13, 1, '2017-5-4', '2018-3-26')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ARMANDO GARCIA', 'ROSAS', 3951, 11, 2, 0, '2004-9-27', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ZANDRA ZELAYA', 'BELGRANO', 2191, 3, 37, 1, '2013-9-3', '2016-5-21')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('HERNAN FERRERO', 'CORRIENTES', 2074, 24, 35, 0, '2018-5-10', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARTIN REZZET', 'NEUQUEN', 3605, 10, 26, 0, '2009-4-4', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CELESTE CEBALLOS', 'ROSAS', 3999, 15, 33, 0, '2013-6-4', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CLAUDIO RIBOTTA', 'CAUDILLOS', 46, 24, 15, 0, '2009-9-23', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('DENIS YOHANSEN', 'BRASIL', 3382, 23, 15, 1, '2008-7-20', '2013-11-14')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('PABLO NERUDA', 'SERENA', 4969, 5, 22, 0, '2013-12-9', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIA TULA', 'MASEI', 5004, 17, 7, 1, '2009-4-22', '2010-3-13')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('EUGENIA LUNA', 'ASTURIA', 5354, 7, 22, 0, '2011-7-5', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('VALERIA GIMENEZ', 'LESA', 2559, 25, 30, 0, '2011-3-14', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIA DELGADO', 'PEROTI', 4933, 29, 17, 0, '2017-9-18', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('JUAN JOSE PAUNERO', 'RUBA', 6, 6, 33, 1, '2015-3-21', '2018-9-19')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('BRIAN ESTERO', 'MAKENA', 2148, 6, 28, 0, '2000-3-18', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CRISTINA MARIA SALA', 'MAKENA', 4191, 24, 36, 0, '1999-6-2', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MARIZA GONZALES', 'MAKENA', 1874, 6, 11, 0, '2011-1-17', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('VIRGINIA ZOE', 'LIMA', 473, 25, 14, 0, '2008-4-26', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('MATIAS LUCA', 'SIMERA', 2312, 4, 10, 1, '2019-10-17', '2019-1-23')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ARMANDO J MENDOZA', 'VIREN', 5176, 26, 18, 0, '2000-10-9', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('ZANDRA ALLENDE', 'KENIA', 5008, 22, 4, 0, '2018-2-1', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('HILDA MARTINEZ', 'PENA', 1084, 22, 3, 0, '2004-8-6', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('SANTINO ZUTINI', 'Termas', 3109, 11, 29, 1, '2004-6-20', '2016-10-13')
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('CELESTE CARBALLO', 'MERLO', 2224, 25, 8, 0, '2009-3-18', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('JEAN PIETRO TRATORIA', 'MASA', 5453, 12, 2, 0, '2002-11-20', NULL)
INSERT    INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado, fecha_alta, fecha_baja) 
    VALUES('RAMBO STALLONE', 'SERATTI', 397, 3, 36, 1, '2002-11-19', '2004-5-1')

	-- Tipo Dispositivos

INSERT	INTO tipo_dispositivo (nombre_tipo)
		VALUES ('Celular')
INSERT	INTO tipo_dispositivo (nombre_tipo)
		VALUES ('Teléfono Fijo')

	-- Dispositivos

INSERT	INTO dispositivos (fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo)
		VALUES (CONVERT(DATE, '16/06/2016',103), 'Motorola', 'Moto G6', '', 20000, 1);

INSERT	INTO dispositivos (fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo)
		VALUES (CONVERT(DATE, '16/06/2016',103), 'Samsung', 'A-10', '', 40000, 1);

INSERT	INTO dispositivos (fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo)
		VALUES (CONVERT(DATE, '16/06/2020',103), 'Motorola', 'Moto G8', '', 30000, 1);

INSERT	INTO dispositivos (fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo)
		VALUES (CONVERT(DATE, '26/04/2005',103), 'Panasonic', 'Z-500', '', 10000, 2);

INSERT	INTO dispositivos (fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo)
		VALUES (CONVERT(DATE, '04/01/2010',103), 'Panasonic', 'A-6855', '', 12000, 2);

INSERT	INTO dispositivos (fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo)
		VALUES (CONVERT(DATE, '20/12/2004',103), 'Telecom', 'Z-500', '', 8000, 2);

INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('25-11-2015','LG','Velvet','',8000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('06-08-2014','Panasonic','P-500','',8000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('12-05-2012','Samsung','S8','',34000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('17-11-2018','LG','Serie G','',22000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('28-10-2018','Motorola','G8 Plus','',11000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('20-01-2016','Motorola','G9','',10000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('26-03-2019','LG','Serie X','',19000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('08-06-2019','Telecom','A-100', '',6000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('11-01-2014','LG', 'Cookie','',22000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('06-10-2016','Telecom', 'Z-300', '',7000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('24-03-2014','Samsung','S10 Plus' ,'',20000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('26-06-2019','Telecom', 'Y-840' ,'',6000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('10-06-2016','LG', 'K61 Quad', '' , 6000 , 1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('24-11-2015','Motorola', 'G10 PRO', '' ,25000 ,1 )
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('25-06-2016','Samsung','A45', '',19000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('20-07-2013','Samsung','S20', '',33000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('11-09-2013','Samsung', 'S25', '',25000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('10-10-2018','Panasonic', 'T-478', '',4000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('02-09-2012','LG', 'Z 45', '',8000,1)
INSERT INTO Dispositivos(fecha_elaboracion, marca, modelo, caracteristicas, precio, id_tipo_dispositivo) 
		VALUES	('21-07-2012','Panasonic', 'T-34', '',6000,1)

	-- Tipos Comunicacion

INSERT	INTO Tipo_comunicacion (descripcion, costo)
		VALUES ('Urbana', 0.05);
INSERT	INTO Tipo_comunicacion (descripcion, costo)
		VALUES ('Media Distancia', 0.20);
INSERT	INTO Tipo_comunicacion (descripcion, costo)
		VALUES ('Larga Distancia', 1.20)
INSERT	INTO Tipo_comunicacion (descripcion, costo)
		VALUES ('Teléfono Celular', 0.10)

	-- Bandas Horarias

INSERT	INTO banda_horaria (descripcion, costo)
		VALUES ('Normal', 0.20)
INSERT	INTO banda_horaria (descripcion, costo)
		VALUES ('Reducida', 0.10)
INSERT	INTO banda_horaria (descripcion, costo)
		VALUES ('Combinada', 0.30)

	-- Numeros

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 356, 7196360, 5, 14, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 354, 8410980, 54, 13, 1, '2018-12-22')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 347, 5412812, 69, 23, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 58, 342, 6608701, 30, 19, 1, '2018-12-22')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 341, 8555189, 29, 10, 1, '2004-12-12')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 359, 6307327, 24, 1, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 345, 2763714, 37, 25, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 48, 349, 3863344, 43, 3, 1, '2016-10-24')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 42, 347, 5871966, 34, 17, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 57, 350, 1940634, 63, 21, 1, '2013-4-10')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 343, 1445903, 56, 24, 1, '2003-11-12')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 340, 3384169, 59, 1, 1, '2012-3-13')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 45, 359, 1874816, 1, 9, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 54, 342, 3914547, 18, 8, 1, '2017-6-8')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 353, 2725989, 59, 21, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 352, 6686415, 27, 22, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 58, 354, 6384066, 34, 1, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 54, 348, 3083527, 2, 3, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 350, 8986636, 58, 7, 1, '2013-1-13')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 59, 349, 9018352, 3, 17, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 355, 2249752, 23, 7, 1, '2011-11-3')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 353, 7618177, 38, 4, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 356, 6892579, 34, 22, 1, '2010-4-9')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 344, 3910741, 11, 22, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 48, 355, 3694236, 28, 18, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 347, 1113446, 34, 25, 1, '2014-8-18')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 352, 4087946, 32, 1, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 48, 343, 6882026, 26, 4, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 358, 3721366, 66, 9, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 58, 350, 6136836, 45, 25, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 354, 9341311, 14, 12, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 348, 7444120, 16, 25, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 341, 2748534, 56, 24, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 357, 7032207, 17, 1, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 359, 4834718, 39, 22, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 347, 8130095, 61, 18, 1, '2019-4-14')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 358, 4181708, 40, 14, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 59, 356, 7808046, 16, 11, 1, '2010-3-19')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 359, 8515275, 35, 1, 1, '2002-3-15')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 57, 351, 9135625, 31, 9, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 44, 353, 5125605, 13, 3, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 48, 355, 7917488, 17, 12, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 58, 357, 8573968, 34, 25, 1, '2018-2-11')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 345, 2082518, 58, 7, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 55, 356, 4252940, 6, 1, 1, '2020-12-20')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 350, 4180988, 25, 16, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 45, 340, 2924235, 26, 16, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 348, 3833707, 10, 25, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 353, 2358573, 17, 1, 1, '2017-9-3')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 40, 346, 7815942, 8, 4, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 358, 8333747, 63, 14, 1, '2012-3-24')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 348, 1206833, 34, 4, 1, '2010-5-21')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 59, 354, 1615725, 51, 17, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 354, 9083086, 17, 16, 1, '2020-6-10')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 346, 5466160, 8, 7, 1, '2008-12-22')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 359, 2085144, 10, 8, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 354, 5781042, 45, 11, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 55, 346, 2112064, 5, 23, 1, '2014-6-4')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 40, 348, 3508535, 46, 9, 1, '2014-3-1')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 354, 8837369, 13, 1, 1, '2020-9-3')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 358, 1186391, 14, 24, 1, '2014-9-5')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 41, 358, 4040633, 29, 4, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 354, 6107427, 54, 15, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 346, 4556785, 26, 20, 1, '2013-4-4')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 351, 1862769, 49, 17, 1, '2020-11-1')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 349, 4697583, 22, 22, 1, '2020-11-8')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 57, 342, 4134584, 44, 17, 1, '2020-7-22')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 359, 5645416, 35, 14, 1, '2017-7-4')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 344, 2393713, 51, 14, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 43, 340, 1330859, 47, 21, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 351, 9359817, 14, 5, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 344, 6187063, 29, 12, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 353, 9156186, 50, 16, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 52, 340, 9765445, 12, 8, 1, '2018-2-17')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 54, 350, 4514074, 56, 16, 1, '2015-3-13')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 45, 359, 7379337, 9, 19, 1, '2015-9-25')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 42, 354, 2381003, 13, 4, 1, '2010-5-22')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 341, 3308718, 21, 19, 1, '2016-6-7')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 342, 9613131, 5, 10, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 45, 341, 8522424, 58, 10, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 350, 7357722, 11, 21, 1, '2017-2-27')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 49, 350, 5444282, 62, 2, 1, '2012-1-24')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 50, 351, 4200680, 12, 7, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 47, 354, 8563371, 35, 2, 1, '2018-4-13')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 42, 354, 4537203, 10, 18, 1, '2016-6-17')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 348, 5855856, 53, 11, 1, '2005-4-12')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 353, 3672571, 20, 25, 1, '2006-5-16')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 345, 2929093, 43, 18, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 46, 350, 7552379, 53, 3, 1, '2018-3-1')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 54, 340, 5885639, 44, 7, 1, '2020-4-1')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 55, 348, 6262192, 63, 25, 1, '2019-3-27')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 51, 351, 2061899, 49, 23, 1, '2007-4-3')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 349, 1788957, 58, 6, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 355, 2097757, 52, 1, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 48, 359, 4463411, 21, 5, 1, '2014-10-27')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 49, 352, 1174966, 65, 1, 1, '2020-5-16')
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 56, 359, 8552086, 26, 20, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 53, 353, 9035132, 45, 18, 0, NULL)
INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado, fecha_baja) 
    VALUES( 42, 344, 6765563, 63, 3, 1, '2014-4-27')

	-- Servicio Fijo

INSERT	INTO Servicios_fijos (tipo_servicio, descripcion, costo_mensual)
		VALUES ('B', 'Contestadora', 500)
INSERT	INTO Servicios_fijos (tipo_servicio, descripcion, costo_mensual)
		VALUES ('B', 'Llamadas a fijo', 250)
INSERT	INTO Servicios_fijos (tipo_servicio, descripcion, costo_mensual)
		VALUES ('B', 'Llamadas a Celular', 650)

INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Mensajes ilimitados a celulares para países limítrofes' ,700 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas a todos los celulares del país' ,600 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Mensajes ilimitados a todos los celulares del país' ,400 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas a celulares para países limítrofes' ,850 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas (hasta 1 hora al día) para provincia residente' ,330 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Internet Ilimitada dentro del pais' ,900 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Internet Ilimitada en paises limitrofes' ,1200 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Internet Ilimitada en paises de America' ,1500 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Internet Ilimitada en todo el mundo' ,2000 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas con 5GB para navegar en el pais' ,780 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('60 minutos para llamadas por dia con 3GB para navegar' ,480 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('60 minutos para llamadas dia con 150 mensajes por dia ' ,300 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas con 8GB para navegar en el pais ' ,980 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas con 3GB para navegar en el pais ' ,580 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Mensajes ilimitadas con 3GB para navegar en el pais ' ,380 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Mensajes ilimitadas con 5GB para navegar en el pais ' ,580 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Mensajes ilimitadas con 8GB para navegar en el pais ' ,780 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('100 minutos para llamadas dia con 150 mensajes por dia ' ,460 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('100 minutos para llamadas por dia con 3GB para navegar' ,660 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Mensajes,Llamadas e Intenet ilimitado en todo el pais ' ,1100 ,'B')
INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio) 
		VALUES ('Llamadas ilimitadas a todo el mundo con Redes Sociales gratis ' ,2100 ,'B')

	-- Servicio Prepago

INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Regional $300', 6, 300, 2);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Regional $100', 4, 100, 2);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Regional $500', 10, 500, 2);

INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Internacionales $750', 6, 750, 4);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Internacionales $500', 4, 500, 4);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Internacionales $1000', 10, 1000, 4);

INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Nacional $500', 6, 500, 3);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Nacional $600', 4, 600, 3);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Nacional $1000', 10, 700, 3);

INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Local $150', 6, 150, 1);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Local $250', 4, 250, 1);
INSERT	INTO Servicios_prepago (tipo_servicio, descripcion, duracion, costo, id_region)
		VALUES ('C', 'Llamadas Local $350', 10, 350, 1);

	-- Servicio de Datos

INSERT	INTO Servicios_datos (tipo_servicio, limite_datos, descripcion, costo_fijo)
		VALUES ('A', 500, '500Gb x Mes', 1000)
INSERT	INTO Servicios_datos (tipo_servicio, limite_datos, descripcion, costo_fijo)
		VALUES ('A', 500, '300Gb x Mes', 750)
INSERT	INTO Servicios_datos (tipo_servicio, limite_datos, descripcion, costo_fijo)
		VALUES ('A', 500, '100Gb x Mes', 500)

	-- Servicios Contratados

INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero)
VALUES		('B', 1, CONVERT(DATE, '04/01/2020', 103), CONVERT(DATE, '04/01/2021', 103),
			 1);

INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero)
VALUES		('C', 1, CONVERT(DATE, '12/03/2020', 103), CONVERT(DATE, '23/02/2021', 103),
			 3);

INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero)
VALUES		('A', 1, CONVERT(DATE, '12/03/2020', 103), CONVERT(DATE, '02/05/2021', 103),
			 5);

INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero)
VALUES		('C', 2, CONVERT(DATE, '01/05/2020', 103), CONVERT(DATE, '23/12/2020', 103),
			 10);

INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero)
VALUES		('C', 10, CONVERT(DATE, '01/05/2020', 103), CONVERT(DATE, '23/12/2020', 103),
			 9);

INSERT INTO Servicios_contratados 
VALUES('B', '23', '2020-3-25', '2021-4-17', 6, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '21', '2020-3-26', '2021-1-18', 25, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '14', '2020-3-27', '2021-1-29', 40, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '19', '2020-5-11', '2021-4-14', 42, NULL)
INSERT INTO Servicios_contratados 
VALUES('B', '19', '2020-2-12', '2021-10-21', 39, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-8-4', '2021-9-21', 20, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '1', '2020-10-4', '2021-3-16', 20, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '10', '2020-11-4', '2021-12-8', 23, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-2-24', '2021-12-17', 44, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '2', '2020-4-19', '2021-1-5', 12, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '12', '2020-8-25', '2021-9-27', 16, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '20', '2020-4-22', '2021-12-26', 33, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-3-22', '2021-4-5', 1, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '10', '2020-12-16', '2021-1-15', 5, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '4', '2020-5-30', '2021-4-19', 32, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '11', '2020-7-29', '2021-2-6', 40, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '11', '2020-4-3', '2021-8-28', 7, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-4-24', '2021-3-14', 25, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '12', '2020-4-24', '2021-9-25', 39, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '3', '2020-7-13', '2021-1-26', 10, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '23', '2020-11-21', '2021-10-4', 13, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-3-17', '2021-4-29', 22, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-3-20', '2021-11-11', 44, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-1-10', '2021-10-26', 1, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '3', '2020-4-12', '2021-7-25', 5, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '21', '2020-9-30', '2021-1-26', 6, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '1', '2020-9-3', '2021-3-28', 1, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '4', '2020-8-7', '2021-1-22', 38, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '3', '2020-9-14', '2021-10-23', 43, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-8-13', '2021-7-25', 23, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '12', '2020-2-26', '2021-5-20', 27, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '3', '2020-6-20', '2021-3-23', 25, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '5', '2020-11-6', '2021-11-14', 19, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '10', '2020-2-22', '2021-4-28', 34, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '7', '2020-10-4', '2021-4-11', 36, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-11-7', '2021-11-28', 46, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '21', '2020-06-07', '2021-12-30', 41, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-12-15', '2021-8-17', 40, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '6', '2020-11-20', '2021-9-4', 40, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '17', '2020-5-5', '2021-12-12', 45, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-8-26', '2021-8-13', 5, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-6-7', '2021-1-22', 22, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '19', '2020-10-11', '2021-6-8', 24, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '7', '2020-9-4', '2021-1-27', 32, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '11', '2020-3-11', '2021-7-4', 35, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '7', '2020-5-17', '2021-1-15', 36, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '6', '2020-4-24', '2021-6-8', 13, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '13', '2020-5-22', '2021-4-24', 12, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '8', '2020-12-21', '2021-10-12', 44, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '11', '2020-9-7', '2021-2-23', 30, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '7', '2020-9-24', '2021-3-12', 11, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-11-29', '2021-4-23', 40, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-9-11', '2021-9-14', 39, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-9-16', '2021-1-14', 13, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-3-29', '2021-11-30', 29, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-2-28', '2021-6-17', 8, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '7', '2020-12-22', '2021-8-21', 2, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '3', '2020-11-13', '2021-3-28', 24, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '15', '2020-5-14', '2021-12-27', 17, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '15', '2020-7-30', '2021-3-16', 12, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-12-13', '2021-10-8', 36, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '3', '2020-2-17', '2021-9-25', 46, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '14', '2020-11-17', '2021-3-30', 16, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '5', '2020-1-1', '2021-5-27', 3, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-7-6', '2021-5-28', 32, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-8-8', '2021-2-14', 23, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-1-21', '2021-5-13', 22, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '8', '2020-6-26', '2021-1-16', 2, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '16', '2020-1-18', '2021-10-9', 8, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '17', '2020-12-28', '2021-8-18', 3, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '6', '2020-3-2', '2021-1-25', 24, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '18', '2020-2-16', '2021-1-1', 1, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '20', '2020-2-5', '2021-11-14', 14, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '19', '2020-3-25', '2021-11-21', 2, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-4-19', '2021-5-20', 12, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-11-20', '2021-11-18', 41, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-2-9', '2021-6-7', 39, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-3-12', '2021-5-30', 32, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '3', '2020-6-15', '2021-11-3', 30, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '10', '2020-4-18', '2021-2-12', 23, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '9', '2020-8-13', '2021-1-18', 13, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '7', '2020-12-5', '2021-6-24', 24, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '3', '2020-3-23', '2021-9-12', 7, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-12-29', '2021-11-27', 14, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '5', '2020-4-20', '2021-9-19', 47, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '13', '2020-6-21', '2021-4-27', 8, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '6', '2020-2-14', '2021-5-17', 43, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-5-19', '2021-9-26', 39, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-2-28', '2021-11-20', 47, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-7-23', '2021-6-11', 21, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '3', '2020-8-21', '2021-3-15', 7, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '21', '2020-1-20', '2021-11-3', 44, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '6', '2020-4-7', '2021-7-28', 13, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '15', '2020-9-28', '2021-3-5', 9, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '10', '2020-6-3', '2021-12-3', 15, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '7', '2020-8-30', '2021-11-15', 39, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '12', '2020-7-20', '2021-11-19', 24, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '17', '2020-3-15', '2021-6-10', 4, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '2', '2020-7-25', '2021-11-11', 19, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '20', '2020-12-5', '2021-5-18', 44, NULL)
INSERT INTO Servicios_contratados
VALUES('A', '1', '2020-7-14', '2021-11-15', 24, NULL)
INSERT INTO Servicios_contratados
VALUES('C', '11', '2020-4-26', '2021-11-6', 22, NULL)
INSERT INTO Servicios_contratados
VALUES('B', '18', '2020-1-10', '2021-6-7', 7, NULL)

INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 23, '2013-6-8', '2014-2-20', 36);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 12, '2016-3-17', '2019-9-5', 23);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 19, '2011-5-13', '2013-7-14', 23);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 10, '2011-9-25', '2015-6-11', 19);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2012-4-10', '2018-5-16', 8);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 4, '2015-5-7', '2016-2-24', 23);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 7, '2019-4-17', '2019-11-15', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 2, '2017-11-17', '2017-11-1', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 1, '2013-8-11', '2018-4-13', 39);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2011-4-4', '2013-9-20', 12);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 19, '2015-11-2', '2019-6-24', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 7, '2014-9-25', '2014-10-14', 21);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2013-11-1', '2016-2-16', 11);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 1, '2012-2-6', '2017-8-19', 14);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 4, '2016-3-17', '2017-3-7', 4);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 1, '2017-10-2', '2018-5-18', 43);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2016-8-23', '2019-7-12', 11);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 12, '2013-2-27', '2016-6-8', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 6, '2015-3-18', '2018-7-21', 4);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 6, '2018-2-15', '2019-4-5', 4);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2017-6-25', '2018-4-11', 23);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 20, '2011-9-4', '2011-11-20', 14);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 1, '2018-6-5', '2018-7-15', 4);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 7, '2014-7-7', '2019-2-1', 11);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 5, '2019-11-12', '2019-11-20', 19);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 4, '2017-10-16', '2017-11-7', 45);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 22, '2016-11-19', '2017-4-14', 45);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2013-2-26', '2019-7-1', 12);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 10, '2019-10-20', '2019-10-10', 21);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 1, '2016-7-23', '2016-8-24', 4);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 10, '2018-4-13', '2019-2-25', 45);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 6, '2011-6-17', '2017-3-7', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2017-7-14', '2019-10-24', 14);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 1, '2016-11-19', '2017-3-7', 11);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 1, '2016-3-1', '2019-7-4', 12);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 5, '2010-3-17', '2015-3-27', 36);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2011-11-23', '2018-6-23', 23);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 8, '2018-5-3', '2019-10-11', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 2, '2017-6-13', '2018-1-15', 12);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 9, '2012-2-9', '2012-11-14', 43);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 19, '2014-3-4', '2016-4-2', 14);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 7, '2016-5-26', '2019-3-19', 38);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 11, '2013-9-18', '2018-5-16', 43);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('C', 7, '2014-11-9', '2017-7-1', 14);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 2, '2012-10-17', '2015-2-14', 14);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('A', 1, '2011-7-13', '2018-6-17', 39);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 21, '2014-11-6', '2015-10-6', 12);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 6, '2019-9-13', '2019-11-17', 36);
INSERT INTO Servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero) VALUES('B', 14, '2017-10-22', '2019-5-18', 39);
INSERT INTO Servicios_contratados 
VALUES ('A', 3, '2021-06-14', '2022-01-14', 13, NULL)

	-- Llamadas

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(1, 2, CONVERT(DATETIME, '04/09/2020 12:00:00', 103), 
			CONVERT(DATETIME, '04/09/2020 14:20:05', 103), 1, 1)
INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(13, 2, CONVERT(DATETIME, '04/05/2021 12:00:00', 103), 
			CONVERT(DATETIME, '04/05/2021 14:20:05', 103), 1, 1)
INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(3, 4, CONVERT(DATETIME, '17/12/2020 13:32:00', 103), 
			CONVERT(DATETIME, '17/12/2020 17:10:05', 103), 2, 1)

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(4, 2, CONVERT(DATETIME, '04/09/2020 12:00:00', 103), 
			CONVERT(DATETIME, '04/09/2020 14:20:05', 103), 1, 2)

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(10, 8, CONVERT(DATETIME, '01/09/2020 12:00:00', 103), 
			CONVERT(DATETIME, '04/09/2020 14:20:05', 103), 2, 3)

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(2, 5, CONVERT(DATETIME, '04/09/2020 12:00:00', 103), 
			CONVERT(DATETIME, '04/09/2020 14:20:05', 103), 2, 1)

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(8, 2, CONVERT(DATETIME, '04/02/2020 12:00:00', 103), 
			CONVERT(DATETIME, '04/02/2020 13:20:05', 103), 2, 1)

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(6, 1, CONVERT(DATETIME, '12/02/2020 10:00:00', 103), 
			CONVERT(DATETIME, '12/02/2020 16:20:05', 103), 2, 1)

insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	12,13,'2020-09-04T12:00:00.000','2020-09-04T12:30:00.000',1,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	13,14,'2020-09-05T12:00:00.000','2020-09-05T12:30:00.001',2,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	14,15,'2020-09-06T12:00:00.000','2020-09-06T12:30:00.002',3,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	15,16,'2020-09-07T12:00:00.000','2020-09-07T12:30:00.003',4,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	16,17,'2020-09-08T12:00:00.000','2020-09-08T12:30:00.004',1,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	17,18,'2020-09-09T12:00:00.000','2020-09-09T12:30:00.005',2,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	18,19,'2020-09-10T12:00:00.000','2020-09-10T12:30:00.006',3,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	19,20,'2020-09-11T12:00:00.000','2020-09-11T12:30:00.007',4,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	20,21,'2020-09-12T12:00:00.000','2020-09-12T12:30:00.008',1,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	21,22,'2020-09-13T12:00:00.000','2020-09-13T12:30:00.009',2,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	22,23,'2020-09-14T12:00:00.000','2020-09-14T12:30:00.010',3,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	23,24,'2020-09-15T12:00:00.000','2020-09-15T12:30:00.011',4,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	24,25,'2020-09-16T12:00:00.000','2020-09-16T12:30:00.012',1,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	25,26,'2020-09-17T12:00:00.000','2020-09-17T12:30:00.013',2,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	26,27,'2020-09-18T12:00:00.000','2020-09-18T12:30:00.014',3,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	27,28,'2020-09-19T12:00:00.000','2020-09-19T12:30:00.015',4,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	28,29,'2020-09-20T12:00:00.000','2020-09-20T12:30:00.016',1,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	29,30,'2020-09-21T12:00:00.000','2020-09-21T12:30:00.017',2,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	30,31,'2020-09-22T12:00:00.000','2020-09-22T12:30:00.018',3,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	31,32,'2020-09-23T12:00:00.000','2020-09-23T12:30:00.019',4,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	32,33,'2020-09-24T12:00:00.000','2020-09-24T12:30:00.020',1,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	33,34,'2020-09-25T12:00:00.000','2020-09-25T12:30:00.021',2,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	34,35,'2020-09-26T12:00:00.000','2020-09-26T12:30:00.022',3,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	35,36,'2020-09-27T12:00:00.000','2020-09-27T12:30:00.023',4,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	36,37,'2020-09-28T12:00:00.000','2020-09-28T12:30:00.024',1,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	37,38,'2020-09-29T12:00:00.000','2020-09-29T12:30:00.025',2,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	38,39,'2020-09-30T12:00:00.000','2020-09-30T12:30:00.026',3,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	39,40,'2020-10-01T12:00:00.000','2020-10-01T12:30:00.027',4,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	40,41,'2020-10-02T12:00:00.000','2020-10-02T12:30:00.028',1,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	41,42,'2020-10-03T12:00:00.000','2020-10-03T12:30:00.029',2,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	42,43,'2020-10-04T12:00:00.000','2020-10-04T12:30:00.030',3,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	43,44,'2020-10-05T12:00:00.000','2020-10-05T12:30:00.031',4,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	44,45,'2020-10-06T12:00:00.000','2020-10-06T12:30:00.032',1,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	45,46,'2020-10-07T12:00:00.000','2020-10-07T12:30:00.033',2,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	46,47,'2020-10-08T12:00:00.000','2020-10-08T12:30:00.034',3,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	47,48,'2020-10-09T12:00:00.000','2020-10-09T12:30:00.035',4,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	48,49,'2020-10-10T12:00:00.000','2020-10-10T12:30:00.036',1,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	49,50,'2020-10-11T12:00:00.000','2020-10-11T12:30:00.037',2,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	50,51,'2020-10-12T12:00:00.000','2020-10-12T12:30:00.038',3,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	51,52,'2020-10-13T12:00:00.000','2020-10-13T12:30:00.039',4,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	52,53,'2020-10-14T12:00:00.000','2020-10-14T12:30:00.040',1,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	53,54,'2020-10-15T12:00:00.000','2020-10-15T12:30:00.041',2,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	54,55,'2020-10-16T12:00:00.000','2020-10-16T12:30:00.042',3,1);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	55,56,'2020-10-17T12:00:00.000','2020-10-17T12:30:00.043',4,2);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) values (	56,57,'2020-10-18T12:00:00.000','2020-10-18T12:30:00.044',1,3);
insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) 
 values ( 41, 51, '2021-2-2 16:00:00.000', '2021-2-2 17:00:00.000', 1, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) 
 values ( 84, 91, '2021-5-1 2:00:00.000', '2021-5-1 11:00:00.000', 3, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar) 
 values ( 10, 96, '2021-12-21T21:00:00.000', '2021-12-21T22:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 34, 3, '2021-15-6 7:00:00.000', '2021-15-6 14:00:00.000', 3, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 69, 21, '2021-23-1 15:00:00.000', '2021-23-1 18:00:00.000', 1, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 46, 80, '2021-6-1 10:00:00.000', '2021-6-1 11:00:00.000', 2, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 40, 91, '2021-11-6 1:00:00.000', '2021-11-6 20:00:00.000', 2, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 32, 43, '2021-24-3 1:00:00.000', '2021-24-3 9:00:00.000', 2, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 40, 81, '2021-16-2 17:00:00.000', '2021-16-2 20:00:00.000', 3, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 74, 54, '2021-16-6 4:00:00.000', '2021-16-6 6:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 78, 47, '2021-5-4 1:00:00.000', '2021-5-4 8:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 5, 3, '2021-5-1 2:00:00.000', '2021-5-1 8:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 70, 10, '2021-27-3 15:00:00.000', '2021-27-3 16:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 97, 8, '2021-12-3 2:00:00.000', '2021-12-3 18:00:00.000', 3, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 94, 98, '2021-14-6 16:00:00.000', '2021-14-6 17:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 23, 23, '2021-4-2 9:00:00.000', '2021-4-2 12:00:00.000', 4, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 41, 23, '2021-10-3 1:00:00.000', '2021-10-3 11:00:00.000', 4, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 54, 19, '2021-25-4 22:00:00.000', '2021-25-4 23:00:00.000', 3, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 18, 65, '2021-16-1 13:00:00.000', '2021-16-1 14:00:00.000', 4, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 7, 30, '2021-6-1 9:00:00.000', '2021-6-1 10:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 75, 89, '2021-19-6 21:00:00.000', '2021-19-6 22:00:00.000', 2, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 2, 96, '2021-7-1 4:00:00.000', '2021-7-1 17:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 86, 8, '2021-4-2 9:00:00.000', '2021-4-2 11:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 76, 68, '2021-9-5 22:00:00.000', '2021-9-5 23:00:00.000', 4, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 37, 65, '2021-9-1 22:00:00.000', '2021-9-1 23:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 37, 37, '2021-20-2 18:00:00.000', '2021-20-2 19:00:00.000', 3, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 25, 86, '2021-5-2 21:00:00.000', '2021-5-2 22:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 58, 78, '2021-3-4 17:00:00.000', '2021-3-4 18:00:00.000', 1, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 86, 24, '2021-22-5 21:00:00.000', '2021-22-5 22:00:00.000', 3, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 91, 40, '2021-26-4 14:00:00.000', '2021-26-4 19:00:00.000', 2, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 73, 51, '2021-3-1 1:00:00.000', '2021-3-1 10:00:00.000', 4, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 48, 46, '2021-5-6 3:00:00.000', '2021-5-6 4:00:00.000', 4, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 98, 35, '2021-4-6 12:00:00.000', '2021-4-6 22:00:00.000', 2, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 72, 86, '2021-12-5 11:00:00.000', '2021-12-5 15:00:00.000', 1, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 68, 11, '2021-8-6 15:00:00.000', '2021-8-6 16:00:00.000', 3, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 4, 99, '2021-5-6 15:00:00.000', '2021-5-6 16:00:00.000', 4, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 57, 88, '2021-8-3 2:00:00.000', '2021-8-3 3:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 65, 41, '2021-21-2 14:00:00.000', '2021-21-2 20:00:00.000', 4, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 84, 51, '2021-4-1 14:00:00.000', '2021-4-1 15:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 42, 93, '2021-5-3 5:00:00.000', '2021-5-3 6:00:00.000', 4, 2)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 59, 99, '2021-29-5 19:00:00.000', '2021-29-5 22:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 32, 76, '2021-17-2 13:00:00.000', '2021-17-2 22:00:00.000', 1, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 31, 87, '2021-17-2 8:00:00.000', '2021-17-2 13:00:00.000', 4, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 76, 39, '2021-28-4 3:00:00.000', '2021-28-4 9:00:00.000', 1, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 61, 51, '2021-14-5 4:00:00.000', '2021-14-5 12:00:00.000', 1, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 92, 60, '2021-6-2 13:00:00.000', '2021-6-2 14:00:00.000', 4, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 34, 95, '2021-13-6 3:00:00.000', '2021-13-6 9:00:00.000', 3, 3)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 19, 81, '2021-27-4 14:00:00.000', '2021-27-4 15:00:00.000', 2, 1)
 insert into llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, id_tipo_comun, id_band_horar)
 values ( 44, 48, '2021-27-2 7:00:00.000', '2021-27-2 19:00:00.000', 4, 3)


-- Venta Dispositivo

INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento)
		VALUES ('2021-01-06', 13, 4, 12, NULL)
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2014-6-6', 76, 18, 3, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2011-1-7', 41, 5, 6, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2014-3-26', 36, 2, 6, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2011-9-14', 53, 4, 12, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2011-5-27', 94, 9, 6, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2011-11-26', 17, 23, 6, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2019-3-4', 22, 23, 18, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2014-3-19', 15, 8, 1, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-7-16', 4, 20, 12, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2017-9-9', 37, 21, 18, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2014-5-21', 49, 3, 1, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2019-5-9', 82, 4, 18, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2019-3-20', 72, 3, 12, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2019-6-26', 71, 17, 6, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-1-7', 42, 15, 1, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-10-21', 93, 22, 3, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2015-11-17', 59, 1, 12, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2010-5-15', 66, 16, 3, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2018-10-8', 5, 15, 1, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-11-2', 71, 2, 3, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2010-10-22', 3, 14, 18, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2010-5-9', 48, 10, 18, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2019-9-25', 85, 17, 3, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2017-11-21', 57, 9, 6, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2010-4-22', 88, 21, 12, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2014-4-23', 10, 17, 12, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2010-8-24', 14, 6, 3, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2018-2-6', 97, 15, 18, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-3-23', 53, 7, 18, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2013-4-20', 3, 17, 6, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2016-7-20', 79, 17, 1, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-10-16', 38, 9, 6, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2018-6-27', 39, 10, 3, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2018-7-16', 20, 19, 3, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2018-10-21', 58, 17, 3, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2016-8-21', 59, 12, 12, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2014-8-10', 37, 24, 1, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2016-7-16', 95, 3, 12, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2015-11-27', 64, 4, 12, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2012-4-22', 69, 5, 3, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-10-13', 1, 18, 12, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-2-4', 82, 25, 3, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2020-1-27', 63, 24, 6, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2012-2-6', 25, 11, 1, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2010-10-13', 96, 7, 18, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2013-3-9', 51, 16, 12, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2016-4-11', 51, 20, 3, NULL);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2017-2-17', 74, 17, 1, 10);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento) VALUES('2017-3-8', 86, 13, 12, 25);
INSERT INTO Venta_dispositivo (fecha_venta, id_numero, id_dispositivo, cant_cuotas, descuento)
		VALUES ('2021-01-06', 13, 9, 12, NULL)