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

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Nicolás Carranza Nakayama', 'Garlot', 3187, Null, 1, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Matias Ceballos', 'Nicolás Berrotarán', 1454, Null, 2)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Francisico Alvarez', 'Independencia', 325, 5, 3)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Malena Lisboa', 'Urrutia', 2142, 0, 3)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Silvana Barrea', 'Alegras', 245, 3, 10, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Tomas Salomon', 'Riachuelo', 3665, Null, 12)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Alejo Fontao', 'Buenos Aires', 5468, 10, 15, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Francisco Marcuzzi', 'India', 54, Null, 8)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Joaco Castellano', 'Alliaga', 5487, Null, 5)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Gianni Peruzzi', 'Toledo', 265, 2, 5)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Renzo Padilla', 'Chacabuco', 5876, 21, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Augusto Alvarez', 'Illia', 3875, NULL, 5)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Ignacio Roberts', 'Valparaiso', 6587, 2, 2)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Juan Carlos Gómez', 'Rawson', 654, NULL, 7, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Braian Anastasia', 'Richierri', 975, 4, 4)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Manuel Zalazar', 'Ituzaingo', 457, 0, 5, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Julian Weich', 'San Francisco de Asis', 6875, 5, 4, 1)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES ('Marley Bo', '21 de Junio', 4582, NULL, 3)

INSERT	INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES ('Juan Domingo Peron', 'Juan Domingo Peron', 657, 1, 5,1)

INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('SUSANA GIMENEZ', 'MAKENA', 210, NULL, 32)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARIO GALA', 'MAKENA', 700, NULL, 32)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('ANA SOLER', 'MAKENA', 300, NULL, 30)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('PAOLA PEREZ', 'MAKENA', 50, NULL, 2)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('NICOLAS MORA', 'LIMA', 410, NULL, 3)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('SERGIO JAER', 'PERU', 400, NULL, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('ESTEBAN RODRIGUEZ', 'SALTA', 60, NULL, 1, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('EDUARDO TOLEDO', 'CHILE', 800, NULL, 36)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('MARIANA LENA', 'MORENO', 250, NULL, 37, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('SOFIA BIYOU', 'MORENO', 260, NULL, 38)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('EDGARD PATIÑO', 'SARMIENTO', 510, NULL, 38)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('DIEGO SUAREZ', 'LIMA', 410, NULL, 4)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('ISABELLA TOMASINA', 'SANTA FE', 410, NULL, 5, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('CRISTIAN DELGADO', 'SAN MARTIN', 660, NULL, 6)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('JESUS NAZAR', 'SARMIENTO', 770, NULL, 38)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('CARLOS MENEM', 'SARMIENTO', 910, NULL, 38)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('PEDRO ESCOBAR', 'SAN MARTIN', 110, NULL, 7)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('PABLO GROSSO', 'CHILE', 66, NULL, 8, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARIA PERALTA', 'SARMIENTO', 30, NULL, 9)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('EUGENIA GALAN', 'SAN MARTIN', 450, NULL, 9)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('VALERIA DAA', 'CHILE', 710, NULL, 35, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARIA DEL VALLE', 'CHILE', 810, NULL, 21)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('JC MARQUEZ', 'OCAMPO', 910, NULL, 21)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('BRISA LUNELA', 'OCAMPO', 100, NULL, 10)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('CRISTIANA BERTONA', 'CASEROS', 310, NULL, 11)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MIRANDA RESERO', 'CASEROS', 660, NULL, 12)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('VIRGINIA MUÑOZ', 'KENIA', 640, NULL, 12)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MATIAS PELELE', 'BOLIVAR', 350, NULL, 21)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('ARMANDO GARCIA', 'ROSAS', 29, NULL, 21,1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('ZANDRA ZELAYA', 'BELGRANO', 80, NULL, 15)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('HERNAN FERRERO', 'CORRIENTES', 500, NULL, 34, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARTIN REZZET', 'NEUQUEN', 28, NULL, 30)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('CELESTE CEBALLOS', 'ROSAS', 500, NULL, 19, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('CLAUDIO RIBOTTA', 'CAUDILLOS', 90, NULL, 13)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('DENIS YOHANSEN', 'BRASIL', 800, NULL, 14)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('PABLO NERUDA', 'SERENA', 60, NULL, 14,1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARIA TULA', 'MASEI', 100, NULL, 15)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('EUGENIA LUNA', 'ASTURIA', 70, NULL, 15)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('VALERIA GIMENEZ', 'LESA', 90, NULL, 29)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARIA DELGADO', 'PEROTI', 80, NULL, 30)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado )
		VALUES('JUAN JOSE PAUNERO', 'RUBA', 60, NULL, 16, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('BRIAN ESTERO', 'MAKENA', 50, NULL, 39)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('CRISTINA MARIA SALA', 'MAKENA', 40, NULL, 29)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MARIZA GONZALES', 'MAKENA', 30, NULL, 29)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('VIRGINIA ZOE', 'LIMA', 100, NULL, 17)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('MATIAS LUCA', 'SIMERA', 288, NULL, 17)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('ARMANDO J MENDOZA', 'VIREN', 290, NULL, 17)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado )
		VALUES('ZANDRA ALLENDE', 'KENIA', 280, NULL, 17, 1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio, borrado)
		VALUES('HILDA MARTINEZ', 'PENA', 200, NULL, 17,1)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('SANTINO ZUTINI', 'TT', 20, NULL, 33)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('CELESTE CARBALLO', 'MERLO', 310, NULL, 18)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('JEAN PIETRO TRATORIA', 'MASA', 110, NULL, 19)
INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio)
		VALUES('RAMBO STALLONE', 'SERATTI', 10, NULL, 19)


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

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo, borrado)
VALUES		(54, 351, 2633187, 8, 2, 1)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 351, 4670971, 3, 6)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 311, 3532931, 5, 1)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 314, 3532931, 5, 5)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 351, 2345343, 8, 3)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 351, 2253223, 3, 4)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 311, 3564995, 3, 1)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 332, 5487651, 5, 2)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(54, 343, 3564987, 6, 4)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(42, 231, 6598745, 4, 2)

INSERT INTO Numero (Cod_Nacional, Cod_Area, Nro_Telefono, Nro_Cliente, id_Dispositivo)
VALUES		(32, 331, 3264551, 1, 4)

INSERT INTO Numero
VALUES ('42','451','598436',1, 25, 1)
INSERT INTO Numero
VALUES ('42','451','21894',2,5, 1)
INSERT INTO Numero
VALUES ('53','251','849904',2,3,0)
INSERT INTO Numero
VALUES ('53','251','269485',2,26,0 )
INSERT INTO Numero
VALUES ('42','451','89456',3,6, 1 )
INSERT INTO Numero
VALUES ('53','251','568412',3,4,0 )
INSERT INTO Numero
VALUES ('42','451','654987',10,23, 1)
INSERT INTO Numero 
VALUES ('42','451','134568', 11, 21, 1)
INSERT INTO Numero
VALUES ('53','251','845961',6,2,0 )
INSERT INTO Numero
VALUES ('53','251','541356',15,1, 1 )
INSERT INTO Numero
VALUES ('32','551','345987',3,4,0 )
INSERT INTO Numero
VALUES ('32','551','458721',3,22,0 )
INSERT INTO Numero
VALUES ('32','551','951357',16,24,0 )
INSERT INTO Numero
VALUES ('32','551','951357',20,26,0 )
INSERT INTO Numero
VALUES ('32','551','456321',11,10, 1 )
INSERT INTO Numero
VALUES ('42','452','123654',17,19, 1 )
INSERT INTO Numero
VALUES ('42','452','456987',18,25,0 )
INSERT INTO Numero
VALUES ('42','452','984365',8,5,0 )
INSERT INTO Numero
VALUES ('42','452','874236',1,26,0 )
INSERT INTO Numero
VALUES ('42','452','258963',6,18,0 )
INSERT INTO Numero
VALUES ('32','552','741258',19,22,0 )
INSERT INTO Numero
VALUES ('32','552','963147',15,23, 1 )
INSERT INTO Numero
VALUES ('32','552','753874',9,25, 1 )
INSERT INTO Numero
VALUES ('32','552','965123',5,16,0 )
INSERT INTO Numero
VALUES ('32','552','874236',4,8, 1 )
INSERT INTO Numero
VALUES ('53','252','851632',7,22,0 )
INSERT INTO Numero
VALUES ('53','252','954021',2,16, 1 )
INSERT INTO Numero
VALUES ('53','252','486521',6,4,0 )
INSERT INTO Numero
VALUES ('42','453','652314',14,19,0 )
INSERT INTO Numero
VALUES ('42','453','021548',19,17 ,0)
INSERT INTO Numero
VALUES ('42','453','874000',1,20,0 )
INSERT INTO Numero
VALUES ('32','553','504809',5,10 ,0)
INSERT INTO Numero
VALUES ('32','553','704982',8,6, 1 )
INSERT INTO Numero
VALUES ('32','553','300650',6,4, 1 )
INSERT INTO Numero
VALUES ('53','253','410025',8,21,0 )
INSERT INTO Numero
VALUES ('53','253','984064',15,26,0 )
INSERT INTO Numero
VALUES ('53','253','864213',7,9,0 )

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

	-- Llamadas

INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, 
						id_tipo_comun, id_band_horar)
VALUES		(1, 2, CONVERT(DATETIME, '04/09/2020 12:00:00', 103), 
			CONVERT(DATETIME, '04/09/2020 14:20:05', 103), 1, 1)

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