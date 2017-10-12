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
	
IF OBJECT_ID('[GRUPO6].RegistroPago') IS NOT NULL
	DROP TABLE [GRUPO6].RegistroPago

IF OBJECT_ID('[GRUPO6].Sucursal') IS NOT NULL
	DROP TABLE [GRUPO6].Sucursal
	
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

IF OBJECT_ID('[GRUPO6].Rendicion') IS NOT NULL
	DROP TABLE [GRUPO6].Rendicion

IF OBJECT_ID('[GRUPO6].Factura') IS NOT NULL
	DROP TABLE [GRUPO6].Factura

IF OBJECT_ID('[GRUPO6].Cliente') IS NOT NULL
	DROP TABLE [GRUPO6].Cliente
	
IF OBJECT_ID('[GRUPO6].Empresa') IS NOT NULL
	DROP TABLE [GRUPO6].Empresa
	
IF OBJECT_ID('[GRUPO6].Rubro') IS NOT NULL
	DROP TABLE [GRUPO6].Rubro

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
IF OBJECT_ID('[GRUPO6].Migracion_FACTURA') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_FACTURA
IF OBJECT_ID('[GRUPO6].Migracion_ITEM') IS NOT NULL
	DROP PROCEDURE [GRUPO6].Migracion_ITEM
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

CREATE TABLE [GRUPO6].Factura(
	idFactura NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idEmpresa NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Empresa(idEmpresa),
	idCliente NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Cliente(idCliente),
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
	montoDevolucionFactura NUMERIC(18,0) NOT NULL,
	motivoDevolucionFactura VARCHAR(255) NOT NULL,
	CONSTRAINT montoDevolucionFactura_chk CHECK (montoDevolucionFactura>0)
);
GO

CREATE TABLE [GRUPO6].Rendicion(
	idRendicion NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idFactura NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Factura(idFactura),
	fechaRendicion DATETIME NOT NULL,
	cantidadFacturasRendidas NUMERIC(18,0) NOT NULL,
	conjuntoFacturasRendidas NUMERIC(18,0) NOT NULL,
	importeRendicion NUMERIC(18,0) NOT NULL,
	porcentajeComicionRendicion NUMERIC(18,0) NOT NULL,
	importeTotalRendicion NUMERIC(18,0) NOT NULL,
	CONSTRAINT cantidadFacturasRendidas_chk CHECK (cantidadFacturasRendidas>0),
	CONSTRAINT importeRendicion_chk CHECK (importeRendicion>0),
	CONSTRAINT porcentajeComicionRendicion_chk CHECK (porcentajeComicionRendicion>0),
	CONSTRAINT importeTotalRendicion_chk CHECK (importeTotalRendicion>0)
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
	idRendicion NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Rendicion(idRendicion),
	montoDevolucionRendicion NUMERIC(18,0) NOT NULL,
	motivoDevolucionRendicion VARCHAR(255) NOT NULL,
	CONSTRAINT montoDevolucionRendicion_chk CHECK (montoDevolucionRendicion>0)
);
GO

CREATE TABLE [GRUPO6].RegistroPago(
	idRegistroPago NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	numeroFactura NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Factura(numeroFactura),	
	idSucursal NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Sucursal(idSucursal),
	numeroPagoRegistroPago NUMERIC(18,0) NOT NULL UNIQUE,
	fechaCobroRegistroPago DATETIME NOT NULL,
	fechaVencimientoRegistroPago DATETIME NOT NULL,
	importeRegistroPago NUMERIC(18,0) NOT NULL,
	formaPagoRegistroPago VARCHAR(255) NOT NULL,
	CONSTRAINT importeRegistroPago_chk CHECK (importeRegistroPago>0)
);
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
					CONVERT(datetime ,(SELECT MIN(CONVERT(numeric(18,0),t2.Rendicion_Fecha)) FROM gd_esquema.Maestra t2 WHERE t1.Empresa_Cuit=t2.Empresa_Cuit))
					FROM [GD2C2017].[gd_esquema].[Maestra] t1 WHERE Empresa_Cuit IS NOT NULL
			
	END
GO

CREATE PROCEDURE [GRUPO6].Migracion_FACTURA -- DUDA SOBRE ESTA MIGRACION
	AS
	BEGIN
		INSERT INTO [GRUPO6].Factura(idEmpresa,idCliente,numeroFactura,fechaAltaFactura,fechaVencimientoFactura,estadoFactura,totalFactura)
			SELECT DISTINCT (SELECT emp.idEmpresa FROM GRUPO6.Empresa emp WHERE cuitEmpresa=maestra.Empresa_Cuit),
					(SELECT cli.idCliente FROM GRUPO6.Cliente cli WHERE cli.dniCliente=maestra.[Cliente-Dni]),
					maestra.Nro_Factura,
					maestra.Factura_Fecha,
					dateadd(day,30,maestra.Factura_Fecha_Vencimiento),
					'Activo',
					(SELECT SUM(ma.ItemFactura_Monto) FROM gd_esquema.Maestra ma WHERE ma.Pago_Fecha IS NULL AND maestra.Nro_Factura=ma.Nro_Factura GROUP BY Nro_Factura)
				FROM gd_esquema.Maestra maestra
				
			
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
					JOIN GRUPO6.RegistroPago RegPago ON (RegPago.numeroFactura = Fac.numeroFactura AND Fac.idEmpresa=@id_empresa)					
					WHERE NOT EXISTS (SELECT 1 FROM GRUPO6.Rendicion Rend WHERE Rend.idFactura=Fac.idFactura)) -- REVISAR ESTA CONSULTA!!!!
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


--------------------------------------------------------------
				--EXECUTE STORE PROCEDURE
--------------------------------------------------------------

EXEC [GRUPO6].Migracion_CLIENTE
EXEC [GRUPO6].Migracion_RUBRO
EXEC [GRUPO6].Migracion_SUCURSAL
EXEC [GRUPO6].Migracion_EMPRESA
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
				('Registro de Pago de Facturas'),
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
				(2,3), (2,4), (2,6), (2,7), (2,9)
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
 
      
      
  
    
     


