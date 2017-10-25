USE[GD2C2017]
GO
--------------------------------------------------------------
				--Drop Table
--------------------------------------------------------------
IF OBJECT_ID('[GRUPO6].Rol_Funcionalidad') IS NOT NULL
	DROP TABLE [GRUPO6].Rol_Funcionalidad

IF OBJECT_ID('[GRUPO6].Rol_Usuario') IS NOT NULL
	DROP TABLE [GRUPO6].Rol_Usuario

IF OBJECT_ID('[GRUPO6].Rol') IS NOT NULL
	DROP TABLE [GRUPO6].Rol

IF OBJECT_ID('[GRUPO6].Funcionalidad') IS NOT NULL
	DROP TABLE [GRUPO6].Funcionalidad
	
IF OBJECT_ID('[GRUPO6].Usuario_Sucursal') IS NOT NULL
	DROP TABLE [GRUPO6].Usuario_Sucursal

IF OBJECT_ID('[GRUPO6].Usuario') IS NOT NULL
	DROP TABLE [GRUPO6].Usuario
	
IF OBJECT_ID('[GRUPO6].Item') IS NOT NULL
	DROP TABLE [GRUPO6].Item
	
IF OBJECT_ID('[GRUPO6].DevolucionFactura') IS NOT NULL
	DROP TABLE [GRUPO6].DevolucionFactura
	
IF OBJECT_ID('[GRUPO6].DevolucionRendicion') IS NOT NULL
	DROP TABLE [GRUPO6].DevolucionRendicion

IF OBJECT_ID('[GRUPO6].Empresa_Rendicion') IS NOT NULL
	DROP TABLE [GRUPO6].Empresa_Rendicion
	
IF OBJECT_ID('[GRUPO6].DevolucionRendicion') IS NOT NULL
	DROP TABLE [GRUPO6].DevolucionRendicion

IF OBJECT_ID('[GRUPO6].Factura') IS NOT NULL
	DROP TABLE [GRUPO6].Factura

IF OBJECT_ID('[GRUPO6].Rendicion') IS NOT NULL
	DROP TABLE [GRUPO6].Rendicion

IF OBJECT_ID('[GRUPO6].RegistroPago') IS NOT NULL
	DROP TABLE [GRUPO6].RegistroPago

IF OBJECT_ID('[GRUPO6].Sucursal') IS NOT NULL
	DROP TABLE [GRUPO6].Sucursal

IF OBJECT_ID('[GRUPO6].Cliente') IS NOT NULL
	DROP TABLE [GRUPO6].Cliente
	
IF OBJECT_ID('[GRUPO6].Empresa') IS NOT NULL
	DROP TABLE [GRUPO6].Empresa
	
IF OBJECT_ID('[GRUPO6].Rubro') IS NOT NULL
	DROP TABLE [GRUPO6].Rubro

IF OBJECT_ID('[GRUPO6].FormaPago') IS NOT NULL
	DROP TABLE [GRUPO6].FormaPago


--------------------------------------------------------------
				--DELETE FUNCTION
--------------------------------------------------------------
IF OBJECT_ID('[GRUPO6].obtenerCantFacturasXEmpresa') IS NOT NULL
	DROP FUNCTION [GRUPO6].obtenerCantFacturasXEmpresa

--------------------------------------------------------------
				--DELETE STORE PROCEDURE
--------------------------------------------------------------

IF OBJECT_ID('[GRUPO6].Migracion_CLIENTE') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_CLIENTE
IF OBJECT_ID('[GRUPO6].Migracion_RUBRO') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_RUBRO
IF OBJECT_ID('[GRUPO6].Migracion_SUCURSAL') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_SUCURSAL
IF OBJECT_ID('[GRUPO6].Migracion_EMPRESA') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_EMPRESA
IF OBJECT_ID('[GRUPO6].Migracion_RENDICION') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_RENDICION
IF OBJECT_ID('[GRUPO6].Migracion_FACTURA') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_FACTURA
IF OBJECT_ID('[GRUPO6].Migracion_ITEM') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_ITEM
IF OBJECT_ID('[GRUPO6].Migracion_REGISTRO_PAGO') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_REGISTRO_PAGO
IF OBJECT_ID('[GRUPO6].loginProc') IS NOT NULL
	DROP PROCEDURE [GRUPO6].loginProc
IF OBJECT_ID('[GRUPO6].obtenerRolesDeUsuario') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerRolesDeUsuario
IF OBJECT_ID('[GRUPO6].obtenerFuncionalidadesDeRol') IS NOT NULL
	DROP PROCEDURE [GRUPO6].ObtenerFuncionalidadesDeRol
IF OBJECT_ID('[GRUPO6].obtenerRoles') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerRoles
IF OBJECT_ID('[GRUPO6].obtenerFuncionalidades') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerFuncionalidades
IF OBJECT_ID('[GRUPO6].funcionesDelRol') IS NOT NULL
	DROP PROCEDURE [GRUPO6].funcionesDelRol
IF OBJECT_ID('[GRUPO6].agregarNuevoRol') IS NOT NULL
	DROP PROCEDURE [GRUPO6].agregarNuevoRol
IF OBJECT_ID('[GRUPO6].asignarNuevasFuncAlRol') IS NOT NULL
	DROP PROCEDURE [GRUPO6].asignarNuevasFuncAlRol
IF OBJECT_ID('[GRUPO6].buscarCliente') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarCliente
IF OBJECT_ID('[GRUPO6].nuevoCliente') IS NOT NULL
	DROP PROCEDURE [GRUPO6].nuevoCliente
IF OBJECT_ID('[GRUPO6].modificarCliente') IS NOT NULL
	DROP PROCEDURE [GRUPO6].modificarCliente
IF OBJECT_ID('[GRUPO6].buscarEmpresa') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarEmpresa
IF OBJECT_ID('[GRUPO6].obtenerRubros') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerRubros
IF OBJECT_ID('[GRUPO6].nuevaEmpresa') IS NOT NULL
	DROP PROCEDURE [GRUPO6].nuevaEmpresa
IF OBJECT_ID('[GRUPO6].modificarEmpresa') IS NOT NULL
	DROP PROCEDURE [GRUPO6].modificarEmpresa
IF OBJECT_ID('[GRUPO6].buscarSucursal') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarSucursal
IF OBJECT_ID('[GRUPO6].nuevaSucursal') IS NOT NULL
	DROP PROCEDURE [GRUPO6].nuevaSucursal
IF OBJECT_ID('[GRUPO6].modificarSucursal') IS NOT NULL
	DROP PROCEDURE [GRUPO6].modificarSucursal
IF OBJECT_ID('[GRUPO6].obtenerEmpresas') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerEmpresas
IF OBJECT_ID('[GRUPO6].buscarFactura') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarFactura
IF OBJECT_ID('[GRUPO6].obtenerSucursalesDeUsuario') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerSucursalesDeUsuario
IF OBJECT_ID('[GRUPO6].nuevaFactura') IS NOT NULL
	DROP PROCEDURE [GRUPO6].nuevaFactura
IF OBJECT_ID('[GRUPO6].obtenerItemsDeFactura') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerItemsDeFactura
IF OBJECT_ID('[GRUPO6].modificarFactura') IS NOT NULL
	DROP PROCEDURE [GRUPO6].modificarFactura
IF OBJECT_ID('[GRUPO6].buscarClientesDeEmpresas') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarClientesDeEmpresas
IF OBJECT_ID('[GRUPO6].buscarFacturasDeClientes') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarFacturasDeClientes
IF OBJECT_ID('[GRUPO6].buscarDatosDeFactura') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarDatosDeFactura
IF OBJECT_ID('[GRUPO6].nuevoPago') IS NOT NULL
	DROP PROCEDURE [GRUPO6].nuevoPago
IF OBJECT_ID('[GRUPO6].obtenerFormasDePago') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerFormasDePago
IF OBJECT_ID('[GRUPO6].obtenerListaRendiciones') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerListaRendiciones
IF OBJECT_ID('[GRUPO6].obtenerDetalleRendicion') IS NOT NULL
	DROP PROCEDURE [GRUPO6].obtenerDetalleRendicion
IF OBJECT_ID('[GRUPO6].efectuarRendicion') IS NOT NULL
	DROP PROCEDURE [GRUPO6].efectuarRendicion
IF OBJECT_ID('[GRUPO6].buscarFacturaADevolver') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarFacturaADevolver
IF OBJECT_ID('[GRUPO6].devolverFactura') IS NOT NULL
	DROP PROCEDURE [GRUPO6].devolverFactura
IF OBJECT_ID('[GRUPO6].buscarFacturaRendicionADevolver') IS NOT NULL
	DROP PROCEDURE [GRUPO6].buscarFacturaRendicionADevolver
IF OBJECT_ID('[GRUPO6].devolverFacturaRendicion') IS NOT NULL
	DROP PROCEDURE [GRUPO6].devolverFacturaRendicion
IF OBJECT_ID('[GRUPO6].generarListado0') IS NOT NULL
	DROP PROCEDURE [GRUPO6].generarListado0
IF OBJECT_ID('[GRUPO6].generarListado1') IS NOT NULL
	DROP PROCEDURE [GRUPO6].generarListado1
		
--------------------------------------------------------------
				--Drop Schema
--------------------------------------------------------------
IF EXISTS (SELECT * FROM sys.schemas WHERE name='GRUPO6')
			DROP SCHEMA [GRUPO6]
GO
--------------------------------------------------------------
				--Create Schema
--------------------------------------------------------------
CREATE SCHEMA [GRUPO6] AUTHORIZATION [gd]
GO


--------------------------------------------------------------
				--Create Table
--------------------------------------------------------------
CREATE TABLE [GRUPO6].Rol(
	idRol NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	nombreRol VARCHAR(32) NOT NULL UNIQUE,
	estadoRol VARCHAR(10) NOT NULL DEFAULT 'Activo',
	CONSTRAINT estadoRol_chk CHECK (estadoRol = 'Activo' or estadoRol = 'Inactivo')
);
GO

CREATE TABLE [GRUPO6].Funcionalidad(
	idFuncionalidad NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	nombreFuncionalidad VARCHAR(32) NOT NULL UNIQUE
);
GO

CREATE TABLE [GRUPO6].Rol_Funcionalidad(
	idRol NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Rol(idRol),
	idFuncionalidad NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Funcionalidad(idFuncionalidad)
	CONSTRAINT rol_funcionalidad_id Primary KEY(idRol, idFuncionalidad),
	
);
GO

CREATE TABLE [GRUPO6].Usuario(
	idUsuario NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	loginUsuario VARCHAR(50) NOT NULL UNIQUE,
	passwordUsuario VARCHAR(255) NOT NULL UNIQUE,
	intentosFallidosUsuario NUMERIC(18,0) NOT NULL DEFAULT 0,
	estadoUsuario VARCHAR(10) NOT NULL DEFAULT 'Activo',
	CONSTRAINT intentosFallidosUsuario_chk CHECK (intentosFallidosUsuario>=0 AND intentosFallidosUsuario<=3),
	CONSTRAINT estadoUsuario_chk CHECK (estadoUsuario = 'Activo' or estadoUsuario = 'Inactivo')
);
GO

CREATE TABLE [GRUPO6].Rol_Usuario(
	idRol NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Rol(idRol),
	idUsuario NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Usuario(idUsuario)
	CONSTRAINT rol_usuario_id Primary KEY(idRol, idUsuario)
);
GO

CREATE TABLE [GRUPO6].Sucursal(
	idSucursal NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	nombreSucursal VARCHAR(50) NOT NULL UNIQUE,
	direccionSucursal VARCHAR(50) NOT NULL,
	CodigoPostalSucursal VARCHAR(50) NOT NULL,
	estadoSucursal VARCHAR(10) NOT NULL DEFAULT 'Activo',
	CONSTRAINT estadoSucursal_chk CHECK (estadoSucursal = 'Activo' or estadoSucursal = 'Inactivo')
);
GO

CREATE TABLE [GRUPO6].Usuario_Sucursal(
	idUsuario NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Usuario(idUsuario),
	idSucursal NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Sucursal(idSucursal)
	CONSTRAINT usuario_sucursal_id Primary KEY(idUsuario, idSucursal)
);
GO

CREATE TABLE [GRUPO6].Cliente(
	idCliente NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	nombreCliente VARCHAR(255) NOT NULL,
	apellidoCliente VARCHAR(255) NOT NULL,
	dniCliente NUMERIC(18,0) NOT NULL UNIQUE,
	mailCliente VARCHAR(255) NOT NULL UNIQUE,
	telefonoCliente VARCHAR(50),
	direccionCliente VARCHAR(255) NOT NULL,
	pisoCliente VARCHAR(10) NOT NULL,
	dptoCliente VARCHAR(10) NOT NULL,
	localidadCliente VARCHAR(255) NOT NULL,
	CodigoPostalCliente VARCHAR(255) NOT NULL,
	fechaNacimienteCliente DATETIME NOT NULL,
	estadoCliente VARCHAR(10) NOT NULL DEFAULT 'Activo',
	CONSTRAINT estadoCliente_chk CHECK (estadoCliente = 'Activo' or estadoCliente = 'Inactivo')
);
GO

CREATE TABLE [GRUPO6].Rubro(
	idRubro NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	descripcionRubro VARCHAR(255) NOT NULL UNIQUE
);
GO

CREATE TABLE [GRUPO6].Empresa(
	idEmpresa NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	nombreEmpresa VARCHAR(255) NOT NULL UNIQUE,
	cuitEmpresa VARCHAR(50) NOT NULL UNIQUE,
	direccionEmpresa VARCHAR(255) NOT NULL,
	idRubro NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Rubro(idRubro),
	estadoEmpresa VARCHAR(10) NOT NULL DEFAULT 'Activo',
	fechaRendicionEmpresa DATETIME NOT NULL,
	CONSTRAINT estadoEmpresa_chk CHECK (estadoEmpresa = 'Activo' or estadoEmpresa = 'Inactivo')
);
GO

CREATE TABLE [GRUPO6].Rendicion(
	idRendicion NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,	
	idEmpresa NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Empresa(idEmpresa),
	numeroRendicion NUMERIC(18,0) NOT NULL UNIQUE,
	fechaRendicion DATETIME NOT NULL,
	cantidadFacturasRendidas NUMERIC(18,0) NOT NULL,
	importeRendicion NUMERIC(18,2) NOT NULL,
	porcentajeComisionRendicion NUMERIC(18,2) NOT NULL,
	importeTotalRendicion NUMERIC(18,2) NOT NULL,	
	CONSTRAINT cantidadFacturasRendidas_chk CHECK (cantidadFacturasRendidas>0),
	CONSTRAINT importeRendicion_chk CHECK (importeRendicion>0),
	CONSTRAINT porcentajeComisionRendicion CHECK (porcentajeComisionRendicion>0),
	CONSTRAINT importeTotalRendicion_chk CHECK (importeTotalRendicion>0)
);
GO

CREATE TABLE [GRUPO6].RegistroPago(
	idRegistroPago NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idCliente NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Cliente(idCliente),	
	idSucursal NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Sucursal(idSucursal),	
	numeroPagoRegistroPago NUMERIC(18,0) NOT NULL UNIQUE,
	fechaCobroRegistroPago DATETIME NOT NULL,	
	importeRegistroPago NUMERIC(18,0) NOT NULL,
	idFormaPago NUMERIC(18,0) NOT NULL,
	CONSTRAINT importeRegistroPago_chk CHECK (importeRegistroPago>0)
);
GO

CREATE TABLE [GRUPO6].Factura(
	idFactura NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idEmpresa NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Empresa(idEmpresa),
	idCliente NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Cliente(idCliente),
	idRendicion NUMERIC(18,0) NULL DEFAULT NULL FOREIGN KEY REFERENCES [GRUPO6].Rendicion(idRendicion),
	idRegistroPago NUMERIC(18,0) NULL DEFAULT NULL FOREIGN KEY REFERENCES [GRUPO6].RegistroPago(idRegistroPago),
	numeroFactura NUMERIC(18,0) NOT NULL UNIQUE,
	fechaAltaFactura DATETIME NOT NULL,
	fechaVencimientoFactura DATETIME NOT NULL,
	estadoFactura VARCHAR(10) NOT NULL DEFAULT 'Activo',
	totalFactura NUMERIC(18,0) NOT NULL,
	CONSTRAINT estadoFactura_chk CHECK (estadoFactura = 'Activo' or estadoFactura = 'Inactivo'),
	CONSTRAINT fechaFactura_chk CHECK (fechaAltaFactura < fechaVencimientoFactura),
	CONSTRAINT totalFactura_chk CHECK (totalFactura>0)
);
GO

CREATE TABLE [GRUPO6].Item(
	idItem NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idFactura NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Factura(idFactura),
	montoItem NUMERIC(18,2) NOT NULL,
	cantidadItem NUMERIC(18,0) NOT NULL,
	nombreItem VARCHAR(255) NULL,
	CONSTRAINT montoItem_chk CHECK (montoItem>0),
	CONSTRAINT cantidadItem_chk CHECK (cantidadItem>0)
);
GO

CREATE TABLE [GRUPO6].DevolucionFactura(
	idDevolucionFactura NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idFactura NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Factura(idFactura),
	montoDevolucionFactura NUMERIC(18,2) NOT NULL,
	motivoDevolucionFactura VARCHAR(255) NOT NULL,
	CONSTRAINT montoDevolucionFactura_chk CHECK (montoDevolucionFactura>0)
);
GO

CREATE TABLE [GRUPO6].Empresa_Rendicion(
	idEmpresa NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Empresa(idEmpresa),
	idRendicion NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Rendicion(idRendicion)
	CONSTRAINT empresa_rendicion_id Primary KEY(idEmpresa, idRendicion)
);
GO

CREATE TABLE [GRUPO6].DevolucionRendicion(
	idDevolucionRendicion NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idFactura NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Factura(idFactura),
	--idRendicion NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Rendicion(idRendicion),
	montoDevolucionRendicion NUMERIC(18,0) NOT NULL,
	motivoDevolucionRendicion VARCHAR(255) NOT NULL,
	CONSTRAINT montoDevolucionRendicion_chk CHECK (montoDevolucionRendicion>0)
);
GO

CREATE TABLE [GRUPO6].FormaPago(
	idFormaPago NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	descripcionFormaPago VARCHAR(255) NOT NULL,
	
);
GO

--------------------------------------------------------------
				--CREATE FUNCTION
--------------------------------------------------------------
CREATE FUNCTION [GRUPO6].obtenerCantFacturasXEmpresa(@id_empresa numeric(18,0),@anio numeric(18,0),@pMes numeric(18,0),@uMes numeric(18,0))
RETURNS numeric(18,0)
AS
	BEGIN 
		DECLARE @cant numeric(18,0)

		(SELECT @cant = COUNT(*) FROM GRUPO6.Factura f 
					JOIN GRUPO6.RegistroPago r ON (f.idEmpresa=@id_empresa AND f.idRegistroPago= r.idRegistroPago AND YEAR(r.fechaCobroRegistroPago) = @anio AND MONTH(r.fechaCobroRegistroPago) BETWEEN @pMes AND @uMes)
					WHERE f.idRegistroPago IS NOT NULL)

		RETURN @cant
	END
GO

--------------------------------------------------------------
				--CREATE STORE PROCEDURE
--------------------------------------------------------------

CREATE PROCEDURE [GRUPO6].Migracion_CLIENTE
	AS
	BEGIN
		INSERT INTO [GRUPO6].Cliente
			([dniCliente],[nombreCliente],[apellidoCliente],[fechaNacimienteCliente],[mailCliente],[telefonoCliente]
			,[direccionCliente],[pisoCliente],[dptoCliente],[localidadCliente],[CodigoPostalCliente])
			SELECT [Cliente-Dni],[Cliente-Nombre],[Cliente-Apellido],[Cliente-Fecha_Nac],
					CASE
						WHEN ROW_NUMBER() OVER(PARTITION BY [Cliente_Mail] order  BY [Cliente_Mail]) = 1 
							then [Cliente_Mail]
							ELSE CONCAT([Cliente_Mail],ROW_NUMBER() OVER(PARTITION BY [Cliente_Mail] order  BY [Cliente_Mail]))
					END AS Cliente_Mail,
					'Completar',[Cliente_Direccion],'Completar','Completar','Completar',[Cliente_Codigo_Postal] 
			FROM [GD2C2017].[gd_esquema].[Maestra]
			GROUP BY [Cliente-Dni],[Cliente-Nombre],[Cliente-Apellido],[Cliente-Fecha_Nac],Cliente_Mail
					,[Cliente_Direccion],[Cliente_Codigo_Postal] 
		UPDATE [GRUPO6].Cliente SET mailCliente=REPLACE(mailCliente, ' ', '')
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_RUBRO
	AS
	BEGIN
		INSERT INTO [GRUPO6].Rubro(descripcionRubro)
			SELECT DISTINCT Rubro_Descripcion
			FROM [GD2C2017].[gd_esquema].[Maestra]
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_SUCURSAL
	AS
	BEGIN
		INSERT INTO [GRUPO6].Sucursal(nombreSucursal,direccionSucursal,CodigoPostalSucursal,estadoSucursal)
			SELECT DISTINCT Sucursal_Nombre,Sucursal_Dirección,Sucursal_Codigo_Postal,'Activo'
			FROM [GD2C2017].[gd_esquema].[Maestra] WHERE Sucursal_Nombre IS NOT NULL
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_EMPRESA -- MIGRACION DE EMPRESA MOMENTANEA HASTA ENTENDER BIEN LO DE LAS RENDICIONES
	AS
	BEGIN
		INSERT INTO [GRUPO6].Empresa(nombreEmpresa,cuitEmpresa,direccionEmpresa,idRubro,estadoEmpresa,fechaRendicionEmpresa)
				SELECT DISTINCT Empresa_Nombre, Empresa_Cuit, Empresa_Direccion, Empresa_Rubro,'Activo',
					CONVERT(datetime ,(SELECT MAX(CONVERT(numeric(18,0),t2.Rendicion_Fecha)) FROM gd_esquema.Maestra t2 WHERE t1.Empresa_Cuit=t2.Empresa_Cuit))
					FROM [GD2C2017].[gd_esquema].[Maestra] t1 WHERE Empresa_Cuit IS NOT NULL
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_FACTURA -- DUDA SOBRE ESTA MIGRACION
	AS
	BEGIN
		INSERT INTO [GRUPO6].Factura(idEmpresa,idCliente,idRendicion,idRegistroPago,numeroFactura,fechaAltaFactura,fechaVencimientoFactura,estadoFactura,totalFactura)
			SELECT DISTINCT (SELECT emp.idEmpresa FROM GRUPO6.Empresa emp WHERE cuitEmpresa=maestra.Empresa_Cuit),
					(SELECT cli.idCliente FROM GRUPO6.Cliente cli WHERE cli.dniCliente=maestra.[Cliente-Dni]),
					(SELECT DISTINCT ren.idRendicion FROM gd_esquema.Maestra m1	JOIN GRUPO6.Rendicion ren ON ren.numeroRendicion = m1.Rendicion_Nro
																			WHERE m1.Rendicion_Nro IS NOT NULL AND m1.Nro_Factura = maestra.Nro_Factura),
					(SELECT DISTINCT reg.idRegistroPago FROM gd_esquema.Maestra m1	JOIN GRUPO6.RegistroPago reg ON reg.numeroPagoRegistroPago = m1.Pago_nro 																			 
																			WHERE m1.Pago_nro IS NOT NULL AND m1.Nro_Factura = maestra.Nro_Factura),
					maestra.Nro_Factura,
					maestra.Factura_Fecha,
					dateadd(day,30,maestra.Factura_Fecha_Vencimiento),
					'Activo',
					(SELECT SUM(ma.ItemFactura_Monto) FROM gd_esquema.Maestra ma WHERE ma.Pago_Fecha IS NULL AND maestra.Nro_Factura=ma.Nro_Factura GROUP BY Nro_Factura)
				FROM gd_esquema.Maestra maestra WHERE maestra.Pago_nro IS NULL
				
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_ITEM -- DUDA SOBRE ESTA MIGRACION
	AS
	BEGIN
		INSERT INTO [GRUPO6].Item(idFactura,montoItem,cantidadItem)
			SELECT (SELECT fac.idFactura FROM GRUPO6.Factura fac WHERE maestra.Nro_Factura = fac.numeroFactura),
			(maestra.ItemFactura_Monto/maestra.ItemFactura_Cantidad),
			maestra.ItemFactura_Cantidad
				FROM gd_esquema.Maestra maestra WHERE maestra.Pago_nro IS NULL
			
				
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_REGISTRO_PAGO
	AS
	BEGIN

		INSERT INTO [GRUPO6].FormaPago(descripcionFormaPago)
		VALUES	('Efectivo'),
				('Tarjeta de Crédito'),
				('Tarjeta de Débito'),
				('Cheque')
 

		INSERT INTO [GRUPO6].RegistroPago(idCliente,idSucursal,numeroPagoRegistroPago,fechaCobroRegistroPago,importeRegistroPago,idFormaPago)
			SELECT DISTINCT 
					(SELECT cli.idCliente FROM GRUPO6.Cliente cli WHERE cli.dniCliente = maestra.[Cliente-Dni]),					
					(SELECT suc.idSucursal FROM GRUPO6.Sucursal suc WHERE suc.CodigoPostalSucursal = maestra.Sucursal_Codigo_Postal),
					maestra.Pago_nro,
					maestra.Pago_Fecha,
					maestra.Total,
					(SELECT forma.idFormaPago FROM GRUPO6.FormaPago forma WHERE forma.descripcionFormaPago = maestra.FormaPagoDescripcion)					
				FROM gd_esquema.Maestra maestra WHERE maestra.Pago_nro IS NOT NULL
				
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_RENDICION 
	AS
	BEGIN
		INSERT INTO [GRUPO6].Rendicion(idEmpresa,numeroRendicion,fechaRendicion,cantidadFacturasRendidas,importeRendicion,porcentajeComisionRendicion,importeTotalRendicion)
			SELECT DISTINCT (SELECT emp.idEmpresa FROM GRUPO6.Empresa emp WHERE cuitEmpresa=maestra.Empresa_Cuit),
					maestra.Rendicion_Nro,
					maestra.Rendicion_Fecha,
					(SELECT COUNT(DISTINCT m1.Nro_Factura) FROM gd_esquema.Maestra m1 WHERE m1.Rendicion_Nro = maestra.Rendicion_Nro),
					maestra.ItemRendicion_Importe,
					CONVERT(numeric(18,2),((maestra.ItemRendicion_Importe*100)/maestra.Total)),
					maestra.Total
				FROM gd_esquema.Maestra maestra WHERE maestra.Rendicion_Nro IS NOT NULL
				
			
	END
GO

CREATE PROCEDURE [GRUPO6].loginProc
    @usu nvarchar(50), 
    @password char(43)
AS 
	DECLARE @id_usuario INT
	
	SET @id_usuario = (SELECT idUsuario FROM [GRUPO6].Usuario WHERE loginUsuario = @usu)
	IF @id_usuario IS NULL
		BEGIN
			RAISERROR ('No existe ese usuario',16,1)
			RETURN
		END
		
	IF (SELECT estadoUsuario FROM [GRUPO6].Usuario WHERE idUsuario = @id_usuario) = 'Inactivo'
		BEGIN
			RAISERROR ('Este usuario esta inhabilitado. Contacte a un administrador del sistema.',16,1)
			RETURN
		END
	
	IF (SELECT passwordUsuario FROM [GRUPO6].Usuario WHERE idUsuario = @id_usuario) = @password
		BEGIN			
			UPDATE [GRUPO6].Usuario
				SET intentosFallidosUsuario = 0
				WHERE idUsuario = @id_usuario	
			SELECT @id_usuario
		END
	ELSE
		BEGIN	
			UPDATE [GRUPO6].Usuario
				SET intentosFallidosUsuario = intentosFallidosUsuario + 1
				WHERE idUsuario = @id_usuario
					
			RAISERROR ('Contrasena incorrecta.',16,1)
			
			IF (SELECT intentosFallidosUsuario FROM [GRUPO6].Usuario WHERE idUsuario = @id_usuario) = 3
				BEGIN
					RAISERROR ('Ha introducido su contrasena mal 3 veces, por lo que su cuenta se ha inhabilitado. Contacte a un administrador del sistema.',16,1)
					UPDATE [GRUPO6].Usuario
						SET estadoUsuario = 'Inactivo'
						WHERE idUsuario = @id_usuario
				END
			RETURN
		END
GO

CREATE PROCEDURE [GRUPO6].obtenerRolesDeUsuario
@id_usuario numeric(18,0)
AS
	BEGIN
		SELECT rolUsuario.idRol,rol.nombreRol 
		FROM [GRUPO6].Rol rol,[GRUPO6].Rol_Usuario rolUsuario
		WHERE rolUsuario.idRol=rol.idRol  AND
			  rol.estadoRol = 'Activo' AND 
			  rolUsuario.idUsuario = @id_usuario
	END
GO    

CREATE PROCEDURE [GRUPO6].obtenerFuncionalidadesDeRol
@id_rol numeric(18,0)
AS
	BEGIN
		SELECT r.idFuncionalidad,f.nombreFuncionalidad 
		FROM [GRUPO6].Rol_Funcionalidad r, [GRUPO6].Funcionalidad f 
		WHERE r.idFuncionalidad=f.idFuncionalidad AND 
			  r.idRol = @id_rol
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerRoles
AS
	BEGIN
		SELECT *
		FROM [GRUPO6].Rol
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerFuncionalidades
AS
	BEGIN
		SELECT *
		FROM [GRUPO6].Funcionalidad
	END
GO

CREATE PROCEDURE [GRUPO6].funcionesDelRol
	@id_rol numeric(18,0)
AS

	SELECT Rol.nombreRol, Fun.nombreFuncionalidad, Fun.idFuncionalidad
		FROM [GRUPO6].Funcionalidad Fun, [GRUPO6].Rol Rol, [GRUPO6].Rol_Funcionalidad Rel
		WHERE Rel.idRol = Rol.idRol AND
			Rel.idFuncionalidad = Fun.idFuncionalidad AND
			Rol.idRol = @id_rol
GO

CREATE PROCEDURE [GRUPO6].agregarNuevoRol
	@nombre nvarchar(255)
AS
BEGIN
	DECLARE @existeRol nvarchar(255)
	SET @existeRol = (SELECT nombreRol FROM [GRUPO6].Rol WHERE nombreRol = @nombre)
	IF @existeRol IS NOT NULL
		BEGIN
			RAISERROR ('El nombre de rol ya existe, intente otro nombre',16,1)
			RETURN
		END
	INSERT INTO [GRUPO6].Rol(nombreRol, estadoRol)
		VALUES	(@nombre, 'Inactivo')
END		
GO

CREATE PROCEDURE [GRUPO6].asignarNuevasFuncAlRol
	@rol nvarchar(255),
	@rolNombreNuevo nvarchar(255),
	@id_rol numeric(18,0),
	@listaFuc nvarchar(255),
	@estado char(10)
AS
	BEGIN
		DELETE FROM [GRUPO6].Rol_Funcionalidad
			   FROM [GRUPO6].Rol_Funcionalidad Rel
				inner join [GRUPO6].Rol R
				on R.nombreRol = @rol AND
					R.idRol = Rel.idRol
					
		UPDATE [GRUPO6].Rol
		SET estadoRol = @estado, nombreRol = @rolNombreNuevo
		FROM [GRUPO6].Rol
			WHERE idRol = @id_rol
		
		DECLARE @strlist NVARCHAR(max), @pos INT, @delim CHAR, @lstr NVARCHAR(max)
		SET @strlist = ISNULL(@listaFuc,'')
		SET @delim = ','

		WHILE ((len(@strlist) > 0) and (@strlist <> ''))
			BEGIN
				SET @pos = charindex(@delim, @strlist)
        
				IF @pos > 0
					BEGIN
						SET @lstr = substring(@strlist, 1, @pos-1)
						SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000))
					END
				ELSE
					BEGIN
						SET @lstr = @strlist
						SET @strlist = ''
					END
			
			
			INSERT INTO [GRUPO6].Rol_Funcionalidad(idRol,idFuncionalidad)
				SELECT R.idRol, F.idFuncionalidad 
					FROM [GRUPO6].Rol R, [GRUPO6].Funcionalidad F
					WHERE R.nombreRol = @rol AND
						  F.nombreFuncionalidad = @lstr
			END
        RETURN 
    END
GO

CREATE PROCEDURE [GRUPO6].buscarCliente
@nombre varchar(255),
@apellido varchar(255),
@dni varchar(255)

AS
	BEGIN
		SELECT cli.idCliente,cli.nombreCliente as 'Nombre', cli.apellidoCliente as 'Apellido' , cli.dniCliente as 'Documento',cli.mailCliente as 'E-mail', cli.telefonoCliente 'Telefono',
				cli.direccionCliente as 'Direccion', cli.pisoCliente 'Piso', cli.dptoCliente as 'Dpto', cli.localidadCliente as 'Localidad', cli.CodigoPostalCliente as 'Cod Postal',cli.fechaNacimienteCliente as 'Fecha de Nacimiento', cli.estadoCliente as 'Estado'
			FROM [GRUPO6].Cliente cli 	
			WHERE cli.nombreCliente like '%'+@nombre+'%' AND
			cli.apellidoCliente like '%'+@apellido+'%' 	AND
			cli.dniCliente like '%'+@dni+'%'
		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].nuevoCliente
@nombre varchar(max),
@apellido varchar(max),
@dni numeric(18,0),
@email varchar(255),
@telefono varchar(255),
@direccion varchar(255),
@piso varchar(10),
@dpto varchar(10),
@localidad varchar(255),
@codPostal varchar(255),
@fechaNac datetime,
@estado varchar(10)

AS
	BEGIN
	
		DECLARE @error nvarchar(max)
		
		IF EXISTS (SELECT 1 FROM [GRUPO6].Cliente WHERE dniCliente = @dni)
			BEGIN
				SET @error = 'El cliente con dni  '+@dni+' ya se encuentra registrado. Intente otro'
				RAISERROR(@error,16,1)
				RETURN
			END
			
		IF EXISTS (SELECT 1 FROM [GRUPO6].Cliente WHERE mailCliente = @email)
			BEGIN
				SET @error = 'El email '+@email+' ya se encuentra registrado. Intente otro'
				RAISERROR(@error,16,1)
				RETURN
			END		
				
		INSERT INTO [GRUPO6].Cliente(nombreCliente,apellidoCliente,dniCliente,mailCliente,telefonoCliente,direccionCliente,pisoCliente,dptoCliente,localidadCliente,CodigoPostalCliente,fechaNacimienteCliente,estadoCliente)
				VALUES(@nombre,@apellido,@dni,@email,@telefono,@direccion,@piso,@dpto,@localidad,@codPostal,@fechaNac,@estado)
						
		
	END
GO

CREATE PROCEDURE [GRUPO6].modificarCliente
@id_cliente numeric(18,0),
@nombre varchar(255),
@apellido varchar(255),
@dni numeric(18,0),
@email varchar(255),
@telefono varchar(50),
@direccion varchar(255),
@piso varchar(10),
@dpto varchar(10),
@localidad varchar(255),
@codPostal varchar(255),
@fechaNac datetime,
@estado varchar(10)

AS
	BEGIN
	
		DECLARE @error nvarchar(max)
		
		IF EXISTS (SELECT 1 FROM [GRUPO6].Cliente WHERE dniCliente = @dni and idCliente != @id_cliente)
			BEGIN
				SET @error = 'El cliente con dni  '+CONVERT(varchar(255),@dni)+' ya se encuentra registrado. Intente otro'
				RAISERROR(@error,16,1)
				RETURN
			END
			
		IF EXISTS (SELECT 1 FROM [GRUPO6].Cliente WHERE mailCliente = @email and idCliente != @id_cliente)
			BEGIN
				SET @error = 'El email '+@email+' ya se encuentra registrado. Intente otro'
				RAISERROR(@error,16,1)
				RETURN
			END		
				
		UPDATE [GRUPO6].Cliente 
			SET nombreCliente=@nombre,
				apellidoCliente=@apellido,
				dniCliente=@dni,
				mailCliente=@email,
				telefonoCliente=@telefono,
				direccionCliente=@direccion,
				pisoCliente=@piso,
				dptoCliente=@dpto,
				localidadCliente=@localidad,
				CodigoPostalCliente=@codPostal,
				fechaNacimienteCliente=@fechaNac,
				estadoCliente=@estado
			WHERE idCliente=@id_cliente
						
		
	END
GO

CREATE PROCEDURE [GRUPO6].buscarEmpresa
@nombre varchar(255),
@cuit varchar(50),
@id_rubro varchar(50)

AS
	BEGIN

		IF @id_rubro = ''
			BEGIN
				SELECT emp.idEmpresa,emp.idRubro as 'Rubro',emp.nombreEmpresa as 'Nombre', emp.cuitEmpresa as 'Cuit', emp.direccionEmpresa as 'Direccion',emp.fechaRendicionEmpresa as 'Fecha de Rendicion', emp.estadoEmpresa as 'Estado'
						FROM [GRUPO6].Empresa emp
						WHERE emp.nombreEmpresa like '%'+@nombre+'%' AND
						emp.cuitEmpresa like '%'+@cuit+'%'
			END
		ELSE
			BEGIN

					SELECT emp.idEmpresa,emp.idRubro as 'Rubro',emp.nombreEmpresa as 'Nombre', emp.cuitEmpresa as 'Cuit', emp.direccionEmpresa as 'Direccion',emp.fechaRendicionEmpresa as 'Fecha de Rendicion', emp.estadoEmpresa as 'Estado'
						FROM [GRUPO6].Empresa emp
						WHERE emp.nombreEmpresa like '%'+@nombre+'%' AND
						emp.cuitEmpresa like '%'+@cuit+'%' AND
						emp.idRubro = CONVERT(numeric(18,0),@id_rubro)

			END

		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerRubros
AS
	BEGIN
		SELECT *
		FROM [GRUPO6].Rubro
	END
GO

CREATE PROCEDURE [GRUPO6].nuevaEmpresa
@nombre varchar(255),
@cuit varchar(50),
@direccion varchar(255),
@idRubro varchar(50),
@fecha datetime,
@estado varchar(10)

AS
	BEGIN
	
		DECLARE @error nvarchar(max)	

			
		IF EXISTS (SELECT 1 FROM [GRUPO6].Empresa WHERE cuitEmpresa = @cuit)
			BEGIN
				SET @error = 'El cuit '+@cuit+' ya se encuentra registrado. Intente otro'
				RAISERROR(@error,16,1)
				RETURN
			END		
				
		INSERT INTO [GRUPO6].Empresa(nombreEmpresa,cuitEmpresa,direccionEmpresa,idRubro,estadoEmpresa,fechaRendicionEmpresa)
				VALUES(@nombre,@cuit,@direccion,@idRubro,@estado,@fecha)
						
		
	END
GO

CREATE PROCEDURE [GRUPO6].modificarEmpresa
@id_empresa numeric(18,0),
@nombre varchar(255),
@cuit varchar(50),
@direccion varchar(255),
@idRubro varchar(50),
@fechaActual datetime,
@estado varchar(10)

AS
	BEGIN
	
		DECLARE @error nvarchar(max)
		
		IF EXISTS (SELECT 1 FROM [GRUPO6].Empresa WHERE cuitEmpresa = @cuit and idEmpresa != @id_empresa)
			BEGIN
				SET @error = 'La empresa con cuit  '+@cuit+' ya se encuentra registrada. Intente otra'
				RAISERROR(@error,16,1)
				RETURN
			END
			
		IF EXISTS (SELECT 1 FROM [GRUPO6].Factura Fac
					WHERE Fac.idEmpresa = @id_empresa AND Fac.idRegistroPago IS NOT NULL AND Fac.idRendicion IS NULL)
			BEGIN
				SET @error = 'La empresa con cuit  '+@cuit+' tiene rendiciones pendientes'
				RAISERROR(@error,16,1)
				RETURN
			END				
				
		UPDATE [GRUPO6].Empresa 
			SET nombreEmpresa=@nombre,
				cuitEmpresa=@cuit,
				direccionEmpresa=@direccion,
				idRubro=CONVERT(numeric(18,0),@idRubro),
				estadoEmpresa=@estado				
			WHERE idEmpresa=@id_empresa
						
		
	END
GO

CREATE PROCEDURE [GRUPO6].buscarSucursal
@nombre varchar(255),
@direccion varchar(255),
@codPostal varchar(255)

AS
	BEGIN
		SELECT suc.idSucursal, suc.nombreSucursal as 'Nombre', suc.direccionSucursal as 'Direccion', suc.CodigoPostalSucursal as 'Cod Postal', suc.estadoSucursal as 'Estado'
			FROM [GRUPO6].Sucursal suc
			WHERE suc.nombreSucursal like '%'+@nombre+'%' AND
			suc.direccionSucursal like '%'+@direccion+'%' 	AND
			suc.CodigoPostalSucursal like '%'+@codPostal+'%'
		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].nuevaSucursal
@nombre varchar(255),
@direccion varchar(255),
@codPostal varchar(50),
@estado varchar(10)

AS
	BEGIN
	
		DECLARE @error nvarchar(max)	

			
		IF EXISTS (SELECT 1 FROM [GRUPO6].Sucursal WHERE CodigoPostalSucursal= @codPostal)
			BEGIN
				SET @error = 'El Codigo Postal '+@codPostal+' ya se encuentra registrado. Intente otro'
				RAISERROR(@error,16,1)
				RETURN
			END		
				
		INSERT INTO [GRUPO6].Sucursal(nombreSucursal,direccionSucursal,CodigoPostalSucursal,estadoSucursal)
				VALUES(@nombre,@direccion,@codPostal,@estado)
						
		
	END
GO

CREATE PROCEDURE [GRUPO6].modificarSucursal
@id_sucursal numeric(18,0),
@nombre varchar(255),
@direccion varchar(255),
@codPostal varchar(255),
@estado varchar(10)

AS
	BEGIN
	
		DECLARE @error nvarchar(max)
		
		IF EXISTS (SELECT 1 FROM [GRUPO6].Sucursal WHERE CodigoPostalSucursal = @codPostal and idSucursal!= @id_sucursal)
			BEGIN
				SET @error = 'La sucursal con codigo postal '+@codPostal+' ya se encuentra registrada. Intente otra'
				RAISERROR(@error,16,1)
				RETURN
			END

		BEGIN TRANSACTION bajaAUsuariosPorSucursalInactiva

			IF (@estado = 'Inactivo')
				BEGIN
					UPDATE [GRUPO6].Usuario 
						SET estadoUsuario='Inactivo'
						WHERE idUsuario = (SELECT u_suc.idUsuario FROM GRUPO6.Usuario_Sucursal u_suc WHERE (u_suc.idSucursal = @id_sucursal AND u_suc.idUsuario != 1)) -- NO SE PUEDE DAR DE BAJA AL ADMIN
				END			
				
			UPDATE [GRUPO6].Sucursal 
				SET nombreSucursal=@nombre,
					direccionSucursal=@direccion,
					CodigoPostalSucursal=@codPostal,
					estadoSucursal=@estado				
				WHERE idSucursal=@id_sucursal

		COMMIT TRANSACTION bajaAUsuariosPorSucursalInactiva
						
		
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerEmpresas
AS
	BEGIN
		SELECT *
		FROM [GRUPO6].Empresa
	END
GO

CREATE PROCEDURE [GRUPO6].buscarFactura
@dni varchar(255),
@id_empresa varchar(50),
@nroFactura varchar(255)

AS
	BEGIN

		IF @id_empresa = ''
			BEGIN
				SELECT fac.idFactura,fac.idEmpresa,fac.idCliente,cli.dniCliente as 'Dni', fac.numeroFactura as 'Nro Factura',fac.fechaAltaFactura as 'Fecha de Alta', fac.fechaVencimientoFactura as 'Fecha de Vencimiento',fac.totalFactura as 'Total', fac.estadoFactura as 'Estado'
					FROM [GRUPO6].Factura fac
					JOIN GRUPO6.Cliente cli ON cli.idCliente = fac.idCliente  			
					WHERE cli.dniCliente like '%'+@dni+'%' AND
					fac.numeroFactura like '%'+@nroFactura+'%'					
			END
		ELSE
			BEGIN
				SELECT fac.idFactura,fac.idEmpresa,fac.idCliente,cli.dniCliente as 'Dni', fac.numeroFactura as 'Nro Factura',fac.fechaAltaFactura as 'Fecha de Alta', fac.fechaVencimientoFactura as 'Fecha de Vencimiento',fac.totalFactura as 'Total', fac.estadoFactura as 'Estado'
						FROM [GRUPO6].Factura fac
						JOIN GRUPO6.Cliente cli ON cli.idCliente = fac.idCliente  			
						WHERE cli.dniCliente like '%'+@dni+'%' AND
						fac.numeroFactura like '%'+@nroFactura+'%' AND
						fac.idEmpresa = CONVERT(numeric(18,0),@id_empresa)	
			END

			


		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerSucursalesDeUsuario
@id_usuario numeric(18,0)
AS
	BEGIN
		SELECT usu_suc.idSucursal ,suc.nombreSucursal
		FROM [GRUPO6].Sucursal suc,[GRUPO6].Usuario_Sucursal usu_suc
		WHERE usu_suc.idSucursal = suc.idSucursal  AND
			  suc.estadoSucursal = 'Activo' AND 
			  usu_suc.idUsuario = @id_usuario
	END
GO  

CREATE PROCEDURE [GRUPO6].nuevaFactura
@dni numeric(18,0),
@id_empresa numeric(18,0),
@nroFactura numeric(18,0),
@fechaAlta datetime,
@fechaVto datetime,
@listaItems varchar(max),
@estado varchar(10),
@total numeric(18,0)

AS
	BEGIN

		DECLARE @error nvarchar(max)
		DECLARE @id_cliente numeric(18,0) = (SELECT cli.idCliente FROM GRUPO6.Cliente cli WHERE cli.dniCliente=@dni)
		

		IF @id_cliente IS NULL
			BEGIN
				SET @error = 'No existe un cliente con ese dni, debe ingresar los datos del cliente primero'
					RAISERROR(@error,16,1)
					RETURN
			END
		ELSE
			BEGIN 

				IF EXISTS (SELECT fac.numeroFactura FROM GRUPO6.Factura fac WHERE fac.numeroFactura=@nroFactura)
					BEGIN 
						SET @error = 'Ya existe ese nro de factura, ingrese otra distinta'
						RAISERROR(@error,16,1)
						RETURN
					END
				ELSE
					BEGIN
						
								
						BEGIN TRANSACTION agregarNuevaFactura

							INSERT INTO GRUPO6.Factura(idEmpresa,idCliente,numeroFactura,fechaAltaFactura,fechaVencimientoFactura,estadoFactura,totalFactura)
									VALUES(@id_empresa,	@id_cliente, @nroFactura,@fechaAlta,@fechaVto,@estado,@total)

							DECLARE @strlist NVARCHAR(max), @pos INT, @delim CHAR, @nombre NVARCHAR(max), @monto numeric(18,2), @cantidad numeric(18,0)
							SET @strlist = ISNULL(@listaItems,'')
							SET @delim = '*'


							
							WHILE ((len(@strlist) > 0) and (@strlist <> ''))
								BEGIN
									SET @pos = charindex(@delim, @strlist)
        
									IF @pos > 0
										BEGIN
											SET @nombre = substring(@strlist, 1, @pos-1)
											SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 

											SET @pos = charindex(@delim, @strlist)
											SET @monto = (SELECT TRY_PARSE(substring(@strlist, 1, @pos-1) as numeric(18,2) using 'es-ES'))	
											SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000))

											SET @pos = charindex(@delim, @strlist) 

											IF @pos > 0
												BEGIN
													SET @cantidad = CONVERT(numeric(18,0),substring(@strlist, 1, @pos-1)) 
													SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 						
												END
											ELSE
												BEGIN
													SET @cantidad = CONVERT(numeric(18,0),@strlist)
													SET @strlist = ''
												END
										END
									ELSE	
										BEGIN														
											SET @strlist = ''
										END

									INSERT INTO GRUPO6.Item(idFactura,montoItem,cantidadItem,nombreItem)
												VALUES((SELECT IDENT_CURRENT('GRUPO6.Factura')),@monto,@cantidad,@nombre)
								END		
						COMMIT TRANSACTION agregarNuevaFactura

					END
				
				
			END
		
		
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerItemsDeFactura
@id_factura numeric(18,0)

AS
	BEGIN
		SELECT idItem,nombreItem as 'Nombre', montoItem as 'Monto', cantidadItem as 'Cantidad'
		FROM [GRUPO6].Item
		WHERE idFactura = @id_factura
	END
GO

CREATE PROCEDURE [GRUPO6].modificarFactura
@dni numeric(18,0),
@id_empresa numeric(18,0),
@nroFactura numeric(18,0),
@fechaAlta datetime,
@fechaVto datetime,
@listaItems varchar(max),
@estado varchar(10),
@total numeric(18,0)

AS
	BEGIN

		DECLARE @error nvarchar(max)
		DECLARE @id_cliente numeric(18,0) = (SELECT cli.idCliente FROM GRUPO6.Cliente cli WHERE cli.dniCliente=@dni)
		

		IF @id_cliente IS NULL
			BEGIN
				SET @error = 'No existe un cliente con ese dni, debe ingresar los datos del cliente primero'
					RAISERROR(@error,16,1)
					RETURN
			END
		ELSE
			BEGIN 
				
				DECLARE @id_factura numeric(18,0) = (SELECT fac.idFactura FROM GRUPO6.Factura fac WHERE fac.numeroFactura=@nroFactura)

				IF @id_factura IS NULL
					BEGIN 
						SET @error = 'Factura inexistente'
						RAISERROR(@error,16,1)
						RETURN
					END
				ELSE
					BEGIN

								--listaItems = "item1*25*1*item2*15*5*......*itemN*montoN*cantidadN*"  VOY AGARRANDO DE a 3 EN EL WHILE
						BEGIN TRANSACTION modificarFacturaItems

							DELETE FROM [GRUPO6].Item
									FROM [GRUPO6].Item ite									
									WHERE ite.idFactura = @id_factura
											
						

							UPDATE GRUPO6.Factura SET 
									idEmpresa=@id_empresa,
									idCliente=@id_cliente,
									numeroFactura=@nroFactura,
									fechaAltaFactura=@fechaAlta,
									fechaVencimientoFactura=@fechaVto,
									estadoFactura=@estado,
									totalFactura=@total
									WHERE idFactura = @id_factura

							DECLARE @strlist NVARCHAR(max), @pos INT, @delim CHAR, @nombre NVARCHAR(max), @monto numeric(18,2), @cantidad numeric(18,0)
							SET @strlist = ISNULL(@listaItems,'')
							SET @delim = '*'


							
							WHILE ((len(@strlist) > 0) and (@strlist <> ''))
								BEGIN
									SET @pos = charindex(@delim, @strlist)
        
									IF @pos > 0
										BEGIN
											SET @nombre = substring(@strlist, 1, @pos-1)
											SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 
											SET @pos = charindex(@delim, @strlist)
											SET @monto = (SELECT TRY_PARSE(substring(@strlist, 1, @pos-1) as numeric(18,2) using 'es-ES'))											
											SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000))
											SET @pos = charindex(@delim, @strlist) 
											IF @pos > 0
												BEGIN
													SET @cantidad = CONVERT(numeric(18,0),substring(@strlist, 1, @pos-1)) 
													SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 						
												END
											ELSE
												BEGIN
													SET @cantidad = CONVERT(numeric(18,0),@strlist)
													SET @strlist = ''
												END
										END
									ELSE	
										BEGIN														
											SET @strlist = ''
										END

									INSERT INTO GRUPO6.Item(idFactura,montoItem,cantidadItem,nombreItem)
												VALUES(@id_factura,@monto,@cantidad,@nombre)
								END		
						COMMIT TRANSACTION modificarFacturaItems

					END
				
				
			END
		
		
	END
GO

CREATE PROCEDURE [GRUPO6].buscarClientesDeEmpresas
@id_empresa numeric(18,0)

AS
	BEGIN
		SELECT DISTINCT cli.idCliente, CONCAT(cli.nombreCliente,' ',cli.apellidoCliente,' :',cli.dniCliente) as 'Datos' FROM GRUPO6.Factura fac
			JOIN GRUPO6.Cliente cli ON cli.idCliente=fac.idCliente
			WHERE idEmpresa=@id_empresa
		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].buscarFacturasDeClientes
@id_cliente numeric(18,0)

AS
	BEGIN
		SELECT fac.idFactura, fac.numeroFactura  FROM GRUPO6.Factura fac
			WHERE fac.idCliente=@id_cliente
		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].buscarDatosDeFactura
@id_factura numeric(18,0)

AS
	BEGIN
		SELECT fac.totalFactura as 'Importe', fac.fechaVencimientoFactura as 'Fecha Vto'FROM GRUPO6.Factura fac
				WHERE fac.idFactura=@id_factura
		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].nuevoPago
@listaNuevoPago varchar(max)

-- idCliente*idSucursal*nroFactura*fechaCobro*importe*formaPago*

AS
	BEGIN
		DECLARE @error nvarchar(max)	
		DECLARE @strlist NVARCHAR(max), @pos INT, @delim CHAR
		DECLARE @idCliente varchar(255), @idSucursal varchar(255),@nroFactura numeric(18,0), @fechaCobro datetime, @importePago numeric(18,2), @formaPago varchar(255)
		
		SET @strlist = ISNULL(@listaNuevoPago,'')
		SET @delim = '*'

		DECLARE @nro_pago numeric(18,0) = (SELECT TOP 1 numeroPagoRegistroPago FROM GRUPO6.RegistroPago ORDER BY numeroPagoRegistroPago DESC)
		SET @nro_pago = @nro_pago + 1

		DECLARE @id_formaPago numeric(18,0)
		DECLARE @bandera numeric(18,0) = 0
						
		SET @importePago = 0
		

							
		WHILE ((len(@strlist) > 0) and (@strlist <> ''))
			BEGIN		
							
				SET @pos = charindex(@delim, @strlist)
								
				IF @pos > 0
					BEGIN					
						
						SET @idCliente = substring(@strlist, 1, @pos-1)
						SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 

						SET @pos = charindex(@delim, @strlist)
						SET @idSucursal = substring(@strlist, 1, @pos-1)
						SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 

						SET @pos = charindex(@delim, @strlist)
						SET @nroFactura = CONVERT(numeric(18,0),substring(@strlist, 1, @pos-1))
						SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 

						SET @pos = charindex(@delim, @strlist)

						IF EXISTS (SELECT 1 FROM GRUPO6.Factura fac WHERE fac.numeroFactura = @nroFactura AND fac.idRegistroPago IS NOT NULL)
							BEGIN
								SET @error = 'La factura '+CONVERT(nvarchar(255),@nroFactura)+' ya fue pagada'
									RAISERROR(@error,16,1)												
									RETURN
							END								

						SET @fechaCobro  = CONVERT(datetime,substring(@strlist, 1, @pos-1))
						SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 
						SET @pos = charindex(@delim, @strlist)


						SET @importePago = @importePago +(SELECT TRY_PARSE(substring(@strlist, 1, @pos-1) as numeric(18,2) using 'es-ES'))	
						SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000))
						SET @pos = charindex(@delim, @strlist) 

						IF @pos > 0
							BEGIN
								SET @formaPago = substring(@strlist, 1, @pos-1)
								SET @strlist = ltrim(substring(@strlist,charindex(@delim, @strlist)+1, 8000)) 						
							END
						ELSE
							BEGIN
								SET @formaPago = substring(@strlist, 1, @pos-1)
								SET @strlist = ''								
							END
						END
					ELSE	
						BEGIN														
							SET @strlist = ''							
						END

				BEGIN TRANSACTION efectuarNuevoPago		
						
					SET @id_formaPago = (SELECT forma.idFormaPago FROM GRUPO6.FormaPago forma WHERE forma.descripcionFormaPago = @formaPago)

					IF @bandera = 0
						BEGIN
							INSERT INTO GRUPO6.RegistroPago(idCliente,idSucursal,numeroPagoRegistroPago,fechaCobroRegistroPago,importeRegistroPago,idFormaPago)
							VALUES(@idCliente,@idSucursal,@nro_pago,@fechaCobro,@importePago,@id_formaPago)

							SET @bandera = 1
						END							
													
					UPDATE [GRUPO6].Factura
							SET idRegistroPago = (SELECT IDENT_CURRENT('GRUPO6.RegistroPago'))
							WHERE numeroFactura = @nroFactura
					
				COMMIT TRANSACTION efectuarNuevoPago	
						
        
			END	

			
			UPDATE [GRUPO6].RegistroPago
				SET importeRegistroPago = @importePago 
				WHERE idRegistroPago = (SELECT IDENT_CURRENT('GRUPO6.RegistroPago'))
			
			
			
		
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerFormasDePago
AS
	BEGIN
		SELECT *
		FROM [GRUPO6].FormaPago
	END
GO

CREATE PROCEDURE [GRUPO6].obtenerListaRendiciones 
AS
	BEGIN 
		SELECT DISTINCT fac.idEmpresa,emp.nombreEmpresa,emp.fechaRendicionEmpresa
		FROM [GRUPO6].Factura fac
		JOIN GRUPO6.Empresa emp ON emp.idEmpresa = fac.idEmpresa
		WHERE fac.idRegistroPago IS NOT NULL AND fac.idRendicion IS NULL
		ORDER BY emp.nombreEmpresa,emp.fechaRendicionEmpresa DESC

	END
GO

CREATE PROCEDURE [GRUPO6].obtenerDetalleRendicion
@id_empresa numeric(18,0)
AS
	BEGIN
		SELECT fac.idFactura,fac.numeroFactura as 'Numero de factura',fac.totalFactura as 'Importe Total',fac.fechaVencimientoFactura as 'Fecha de Vencimiento'
		FROM [GRUPO6].Factura fac WHERE fac.idEmpresa = @id_empresa AND fac.idRegistroPago IS NOT NULL AND fac.idRendicion IS NULL
		ORDER BY fac.numeroFactura	

	END
GO

CREATE PROCEDURE [GRUPO6].efectuarRendicion
@id_empresa numeric(18,0),
@cant_facturas_rendidas numeric(18,0),
@importe_rendicion numeric(18,2),
@porcentaje_comision numeric(18,2),
@importe_total numeric(18,2)

AS
	BEGIN
		DECLARE @nro_rendicion numeric(18,2) = (SELECT TOP 1 numeroRendicion FROM GRUPO6.Rendicion ORDER BY numeroRendicion DESC) + 1

		INSERT INTO GRUPO6.Rendicion(idEmpresa,numeroRendicion,fechaRendicion,cantidadFacturasRendidas,importeRendicion,porcentajeComisionRendicion,importeTotalRendicion)
			VALUES(@id_empresa,@nro_rendicion,GETDATE(),@cant_facturas_rendidas,@importe_rendicion,@porcentaje_comision,@importe_total)

		UPDATE [GRUPO6].Factura 
						SET idRendicion=(SELECT IDENT_CURRENT('GRUPO6.Rendicion'))
						WHERE idRendicion IS NULL AND idRegistroPago IS NOT NULL AND idEmpresa = @id_empresa
			

	END
GO

CREATE PROCEDURE [GRUPO6].buscarFacturaADevolver
@dni varchar(255),
@id_empresa varchar(50),
@nroFactura varchar(255)

AS
	BEGIN

		IF @id_empresa = ''
			BEGIN
				SELECT fac.idFactura,fac.idEmpresa,fac.idCliente, fac.idRendicion,fac.idRegistroPago, cli.dniCliente as 'Dni', fac.numeroFactura as 'Nro Factura',fac.fechaAltaFactura as 'Fecha de Alta', fac.fechaVencimientoFactura as 'Fecha de Vencimiento',fac.totalFactura as 'Total', fac.estadoFactura as 'Estado'
					FROM [GRUPO6].Factura fac
					JOIN GRUPO6.Cliente cli ON cli.idCliente = fac.idCliente  			
					WHERE cli.dniCliente like '%'+@dni+'%' AND
					fac.numeroFactura like '%'+@nroFactura+'%' AND fac.idRegistroPago IS NOT NULL AND fac.idRendicion IS NULL				
			END
		ELSE
			BEGIN
				SELECT fac.idFactura,fac.idEmpresa,fac.idCliente, fac.idRendicion, fac.idRegistroPago, cli.dniCliente as 'Dni', fac.numeroFactura as 'Nro Factura',fac.fechaAltaFactura as 'Fecha de Alta', fac.fechaVencimientoFactura as 'Fecha de Vencimiento',fac.totalFactura as 'Total', fac.estadoFactura as 'Estado'
						FROM [GRUPO6].Factura fac
						JOIN GRUPO6.Cliente cli ON cli.idCliente = fac.idCliente  			
						WHERE cli.dniCliente like '%'+@dni+'%' AND
						fac.numeroFactura like '%'+@nroFactura+'%' AND
						fac.idEmpresa = CONVERT(numeric(18,0),@id_empresa)	AND fac.idRegistroPago IS NOT NULL AND fac.idRendicion IS NULL
			END

			


		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].devolverFactura
@id_factura numeric(18,0),
@id_registroPago numeric(18,0),
@nro_factura numeric(18,0),
@descripcionMotivo varchar(255),
@monto numeric(18,2)

AS
	BEGIN
		
		BEGIN TRANSACTION devolucionDeFactura
			UPDATE GRUPO6.Factura
					SET idRegistroPago = NULL
					WHERE idFactura = @id_factura

			
			IF NOT EXISTS (SELECT 1 FROM GRUPO6.Factura WHERE idRegistroPago = @id_registroPago)
				BEGIN
					DELETE FROM GRUPO6.RegistroPago WHERE idRegistroPago = @id_registroPago
				END			

			UPDATE GRUPO6.RegistroPago 
					SET importeRegistroPago = (importeRegistroPago - @monto)
					WHERE idRegistroPago = @id_registroPago
			

			INSERT INTO GRUPO6.DevolucionFactura(idFactura,montoDevolucionFactura,motivoDevolucionFactura)
					VALUES(@id_factura,@monto,@descripcionMotivo)	

			

		COMMIT TRANSACTION devolucionDeFactura

	END
GO

CREATE PROCEDURE [GRUPO6].buscarFacturaRendicionADevolver
@dni varchar(255),
@id_empresa varchar(50),
@nroFactura varchar(255)

AS
	BEGIN

		IF @id_empresa = ''
			BEGIN
				SELECT fac.idFactura,fac.idEmpresa,fac.idCliente, fac.idRendicion,fac.idRegistroPago, cli.dniCliente as 'Dni', fac.numeroFactura as 'Nro Factura',fac.fechaAltaFactura as 'Fecha de Alta', fac.fechaVencimientoFactura as 'Fecha de Vencimiento',fac.totalFactura as 'Total', fac.estadoFactura as 'Estado'
					FROM [GRUPO6].Factura fac
					JOIN GRUPO6.Cliente cli ON cli.idCliente = fac.idCliente  			
					WHERE cli.dniCliente like '%'+@dni+'%' AND
					fac.numeroFactura like '%'+@nroFactura+'%' AND fac.idRegistroPago IS NOT NULL AND fac.idRendicion IS NOT NULL				
			END
		ELSE
			BEGIN
				SELECT fac.idFactura,fac.idEmpresa,fac.idCliente, fac.idRendicion, fac.idRegistroPago, cli.dniCliente as 'Dni', fac.numeroFactura as 'Nro Factura',fac.fechaAltaFactura as 'Fecha de Alta', fac.fechaVencimientoFactura as 'Fecha de Vencimiento',fac.totalFactura as 'Total', fac.estadoFactura as 'Estado'
						FROM [GRUPO6].Factura fac
						JOIN GRUPO6.Cliente cli ON cli.idCliente = fac.idCliente  			
						WHERE cli.dniCliente like '%'+@dni+'%' AND
						fac.numeroFactura like '%'+@nroFactura+'%' AND
						fac.idEmpresa = CONVERT(numeric(18,0),@id_empresa)	AND fac.idRegistroPago IS NOT NULL AND fac.idRendicion IS NOT NULL
			END

			


		RETURN
	END
GO

CREATE PROCEDURE [GRUPO6].devolverFacturaRendicion
@id_factura numeric(18,0),
@id_rendicion numeric(18,0),
@nro_factura numeric(18,0),
@descripcionMotivo varchar(255),
@monto numeric(18,2)

AS
	BEGIN
		
		BEGIN TRANSACTION devolucionDeFacturaRendicion

			UPDATE GRUPO6.Factura
					SET idRendicion = NULL
					WHERE idFactura = @id_factura AND numeroFactura=@nro_factura

			
			IF NOT EXISTS (SELECT 1 FROM GRUPO6.Factura WHERE idRendicion = @id_rendicion)
				BEGIN
					DELETE FROM GRUPO6.Rendicion WHERE idRendicion= @id_rendicion
				END			

			UPDATE GRUPO6.Rendicion 
					SET importeTotalRendicion = (importeTotalRendicion - @monto)
					WHERE idRendicion = @id_rendicion

			UPDATE GRUPO6.Rendicion 
					SET importeRendicion = (importeTotalRendicion*(porcentajeComisionRendicion/100))
					WHERE idRendicion = @id_rendicion
			

			INSERT INTO GRUPO6.DevolucionRendicion(idFactura,montoDevolucionRendicion,motivoDevolucionRendicion) -- DUDA SI ES QUE DevolucionRendicion TIENE QUE TENER idRendicion
					VALUES(@id_factura,@monto,@descripcionMotivo)	

			

		COMMIT TRANSACTION devolucionDeFacturaRendicion

	END
GO

CREATE PROCEDURE [GRUPO6].generarListado0
@anio numeric(18,0),
@primerMes numeric(18,0),
@ultimoMes numeric(18,0)
AS
	BEGIN
		DECLARE @error nvarchar(max)
		DECLARE @total numeric(18,0)= (SELECT COUNT(*) FROM GRUPO6.Factura fac 
		JOIN GRUPO6.RegistroPago reg ON (fac.idRegistroPago= reg.idRegistroPago AND YEAR(reg.fechaCobroRegistroPago) = @anio AND MONTH(reg.fechaCobroRegistroPago) BETWEEN @primerMes AND @ultimoMes)
		WHERE fac.idRegistroPago IS NOT NULL)

		IF @total = 0
			BEGIN				
				SET @error = 'total es igual a 0'
				RAISERROR(@error,16,1)												
				RETURN								
			END		

		-- NO ME ANDA CON LA IMPLEMENTACION DE LA FUNCION
		--SELECT DISTINCT emp.nombreEmpresa as 'Nombre de la Empresa',
		--		(CONVERT(numeric(18,2),(([GRUPO6].obtenerCantFacturasXEmpresa(emp.idEmpresa,@anio,@primerMes,@ultimoMes))/@total)*100)) as 'Porcentaje'
		--		FROM GRUPO6.Factura fac 
		--		JOIN GRUPO6.Empresa emp ON emp.idEmpresa = fac.idEmpresa
		--		WHERE fac.idRegistroPago IS NOT NULL

		SELECT DISTINCT TOP 5 emp.nombreEmpresa as 'Nombre de la Empresa',
				(CONVERT(numeric(18,2),((SELECT COUNT(*) FROM GRUPO6.Factura f 
					JOIN GRUPO6.RegistroPago r ON (f.idEmpresa= emp.idEmpresa AND f.idRegistroPago= r.idRegistroPago AND YEAR(r.fechaCobroRegistroPago) = @anio AND MONTH(r.fechaCobroRegistroPago) BETWEEN @primerMes AND @ultimoMes)
					WHERE f.idRegistroPago IS NOT NULL)/@total)*100)) as 'Porcentaje'
				FROM GRUPO6.Factura fac 
				JOIN GRUPO6.Empresa emp ON emp.idEmpresa = fac.idEmpresa
				WHERE fac.idRegistroPago IS NOT NULL ORDER BY Porcentaje DESC


	END
GO

CREATE PROCEDURE [GRUPO6].generarListado1
@anio numeric(18,0),
@primerMes numeric(18,0),
@ultimoMes numeric(18,0)
AS
	BEGIN
		DECLARE @error nvarchar(max)	

		SELECT TOP 5 emp.nombreEmpresa, 
		(SELECT SUM(r.importeTotalRendicion) FROM GRUPO6.Rendicion r WHERE r.idEmpresa=emp.idEmpresa AND YEAR(r.fechaRendicion) = @anio AND MONTH(r.fechaRendicion) BETWEEN @primerMes AND @ultimoMes) as 'Total Rendicion' 
		FROM GRUPO6.Empresa emp ORDER BY [Total Rendicion] DESC

	END
GO

--------------------------------------------------------------
				--EXECUTE STORE PROCEDURE
--------------------------------------------------------------

EXEC [GRUPO6].Migracion_CLIENTE
EXEC [GRUPO6].Migracion_RUBRO
EXEC [GRUPO6].Migracion_SUCURSAL
EXEC [GRUPO6].Migracion_EMPRESA
EXEC [GRUPO6].Migracion_REGISTRO_PAGO
EXEC [GRUPO6].Migracion_RENDICION
EXEC [GRUPO6].Migracion_FACTURA
EXEC [GRUPO6].Migracion_ITEM

--------------------------------------------------------------
				--INSERTO DATOS
--------------------------------------------------------------
INSERT INTO [GRUPO6].Usuario(loginUsuario,passwordUsuario,estadoUsuario)
		VALUES ('admin','5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c','Activo'),
				('pepe','fJ58FJSyaEq3wZ1q/3N+Rg+p6Y1aI02hMQyX3fVpGDQ','Activo') -- Cobrador user:pepe password:pepe
-------------------------------------------------------------------------------------------		
INSERT INTO [GRUPO6].Funcionalidad(nombreFuncionalidad)
		VALUES	('ABM Rol'),
				('ABM Cliente'),
				('ABM Empresa'),
				('ABM Sucursal'),
				('ABM Facturas'),
				('Registro de Pagos de Facturas'),
				('Rendicion de Facturas Cobradas'),
				('Devoluciones'),			
				('Listado Estadistico')
-------------------------------------------------------------------------------------------	
INSERT INTO [GRUPO6].Rol(nombreRol, estadoRol)
		VALUES	('Administrador', 'Activo'),
				('Cobrador', 'Activo')
-------------------------------------------------------------------------------------------	 
INSERT INTO [GRUPO6].Rol_Usuario(idRol, idUsuario)
		VALUES (1,1),(2,1),(2,2)		
-------------------------------------------------------------------------------------------				
INSERT INTO [GRUPO6].Rol_Funcionalidad(idRol, idFuncionalidad)
		VALUES (1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8), (1,9),
				(2,3), (2,4), (2,6), (2,7),(2,8),(2,9)
-------------------------------------------------------------------------------------------		
INSERT INTO [GRUPO6].Rubro(descripcionRubro)
		VALUES	('Internet'),
				('Agua'),
				('Luz'),
				('Comunicaciones'),
				('Obra Social'),
				('Institucion escolar')
-------------------------------------------------------------------------------------------	 
INSERT INTO GRUPO6.Sucursal(nombreSucursal,direccionSucursal,CodigoPostalSucursal,estadoSucursal)
		VALUES ('UTN-Medrano','Medrano 951','1111','Activo') ------ INSERT DE PRUEBA PARA AGREGAR MAS DATOS
-------------------------------------------------------------------------------------------	 
INSERT INTO [GRUPO6].Usuario_Sucursal(idUsuario, idSucursal)
		VALUES (1,1),(1,2),(2,1)
-------------------------------------------------------------------------------------------	 
INSERT INTO GRUPO6.Empresa(nombreEmpresa,cuitEmpresa,direccionEmpresa,idRubro,estadoEmpresa,fechaRendicionEmpresa)
		VALUES ('Telecentro','1111','Rosas 635','1','Activo','20170808'),
				('Edesur','2222','Asd 123','3','Activo','20170909')	  ------ INSERT DE PRUEBA PARA AGREGAR MAS DATOS
-------------------------------------------------------------------------------------------	 
INSERT INTO GRUPO6.Rendicion(idEmpresa,numeroRendicion,fechaRendicion,cantidadFacturasRendidas,importeRendicion,porcentajeComisionRendicion,importeTotalRendicion)
	VALUES(2,34649,'2017-09-09 00:00:00.000',2,100.00,10.00,1000.00),
		  (3,70051,'2016-10-12 00:00:00.000',2,100.00,10.00,2005000.00) -- INSERT DE PRUEBA PARA AGREGAR MAS DATOS
      
      
  
    
     


