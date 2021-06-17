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
						nro_cliente	INTEGER		NOT NULL,
						id_dispositivo INTEGER	NULL, 
						borrado BIT				DEFAULT 0,

					CONSTRAINT clienteXnumero
						FOREIGN KEY (nro_cliente)
						REFERENCES Cliente
						ON DELETE CASCADE,
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
									id_dispositivo INTEGER		NOT NULL,
									cant_cuotas	INTEGER			NOT NULL,
									descuento NUMERIC (3,1)		NULL,

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

