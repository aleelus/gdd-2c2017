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
	CONSTRAINT fechaFactura_chk CHECK (fechaAltaFactura < fechaAltaFactura),
	CONSTRAINT totalFactura_chk CHECK (totalFactura>0)
);
GO

CREATE TABLE [GRUPO6].Item(
	idItem NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	idFactura NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES [GRUPO6].Factura(idFactura),
	montoItem NUMERIC(18,0) NOT NULL,
	cantidadItem NUMERIC(18,0) NOT NULL,
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
	@nombre nvarchar(255)
AS

	SELECT Rol.nombreRol, Fun.nombreFuncionalidad, Fun.idFuncionalidad
		FROM [GRUPO6].Funcionalidad Fun, [GRUPO6].Rol Rol, [GRUPO6].Rol_Funcionalidad Rel
		WHERE Rel.idRol = Rol.idRol AND
			Rel.idFuncionalidad = Fun.idFuncionalidad AND
			Rol.idRol = @nombre
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
@cuit varchar(255),
@rubro varchar(255)

AS
	BEGIN
		SELECT idEmpresa, nombreEmpresa as 'Nombre', cuitEmpresa as ' Cuit', direccionEmpresa as 'Direccion', fechaRendicionEmpresa as 'Fecha de Rendicion', estadoEmpresa as 'Estado'
			FROM [GRUPO6].Empresa 	
			JOIN GRUPO6.Rubro
			ON descripcionRubro = @rubro
			WHERE nombreEmpresa like '%'+@nombre+'%' AND
			cuitEmpresa like '%'+@cuit+'%'
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
@idRubro numeric(18,0),
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

--------------------------------------------------------------
				--INSERTO DATOS
--------------------------------------------------------------
INSERT INTO [GRUPO6].Usuario(loginUsuario,passwordUsuario,estadoUsuario)
		VALUES ('admin','5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c','Activo'),
				('pepe','fJ58FJSyaEq3wZ1q/3N+Rg+p6Y1aI02hMQyX3fVpGDQ','Activo') -- Cobrador user:pepe password:pepe
-------------------------------------------------------------------------------------------		
INSERT INTO [GRUPO6].Funcionalidad(nombreFuncionalidad)
		VALUES	('ABM Rol'),
				('Registro de Usuario'),
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
		VALUES (1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8), (1,9), (1,10),
				(2,3), (2,4), (2,6), (2,7), (2,9)
-------------------------------------------------------------------------------------------		
INSERT INTO [GRUPO6].Rubro(descripcionRubro)
		VALUES	('Internet'),
				('Agua'),
				('Luz'),
				('Comunicaciones'),
				('Obra Social'),
				('Institucion escolar')
    
      
      
      
  
    
     

--------------------------------------------------------------
				--EXECUTE STORE PROCEDURE
--------------------------------------------------------------

EXEC [GRUPO6].Migracion_CLIENTE
