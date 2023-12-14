CREATE DATABASE TiendaVirtualVista;
GO

USE TiendaVirtualVista;
GO

Alter authorization on database::TiendaVirtualVista to sa 
GO 

SET DATEFORMAT dmy 
SET LANGUAGE spanish 
GO

-- Tabla de Roles
CREATE TABLE Roles (
    RolID INT NOT NULL,
    Nombre VARCHAR(50),
	CONSTRAINT PK_Roles PRIMARY KEY (RolID)
);
GO

--Insertar datos en la tabla de Roles
INSERT INTO Roles (RolID, Nombre)
VALUES
    (0, 'COMUN'),
    (1, 'ADMINISTRADOR');
GO

-- Tabla de Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY(1, 1) NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Apellidos VARCHAR(50) NOT NULL,
	Edad INT NOT NULL,
    NombreUsuario VARCHAR(50) UNIQUE NOT NULL,
    CorreoElectronico VARCHAR(100) UNIQUE NOT NULL,
    HashContrasena CHAR(64) NOT NULL, -- Cambio en el tipo de dato para almacenar el hash
    FechaRegistro DATETIME NOT NULL,
	RolID INT NOT NULL,
	CONSTRAINT PK_Usuarios PRIMARY KEY (UsuarioID ASC),
	CONSTRAINT FK_Roles_Usuarios FOREIGN KEY (RolID) REFERENCES Roles(RolID),
	CONSTRAINT CH_Edad CHECK (Edad > 0)
);
INSERT INTO [dbo].[Usuarios] ([Nombre], [Apellidos], [Edad], [NombreUsuario], [CorreoElectronico],
	[HashContrasena], [FechaRegistro], [RolID])
	VALUES ('Jose Daniel', 'Castro Soto', 24, 'castro11', 'cassoto@yopmail.cc', HASHBYTES('SHA2_256', 'jd1111'), '2023-07-22 16:34:20', 0)
INSERT INTO [dbo].[Usuarios] ([Nombre], [Apellidos], [Edad], [NombreUsuario], [CorreoElectronico],
	[HashContrasena], [FechaRegistro], [RolID])
	VALUES ('Sofía', 'Jiménez Gamboa', 22, 'gamboa22', 'jsofia@yopmail.cc', HASHBYTES('SHA2_256', 'jg2222'(, '2023-07-22 16:34:20', 1)
GO

-- Tabla de Juegos
CREATE TABLE Juegos (
    JuegoID INT NOT NULL,
    Desarrollador VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Descripcion TEXT NOT NULL,
	CONSTRAINT PK_Juegos PRIMARY KEY (JuegoID),
	CONSTRAINT CH_Precio CHECK (Precio > 0)
);

INSERT INTO [dbo].[Juegos] ([JuegoID], [Desarrollador], [Precio], [Descripcion])
	VALUES (3498, 'Rockstar Games y Rockstar North', 32000, 'Es un videojuego de
	acción-aventura de mundo abierto en tercera persona desarrollado por el estudio 
	escocés Rockstar North y distribuido por Rockstar Games. ')
GO

-- Tabla de Carrito de Compras
CREATE TABLE Carrito (
    CarritoID INT IDENTITY(1, 1),
    UsuarioID INT,
    JuegoID INT,
	CONSTRAINT PK_Carrito PRIMARY KEY (CarritoID),
    CONSTRAINT FK_Usuarios_Carrito FOREIGN KEY (UsuarioID) REFERENCES Usuarios (UsuarioID),
    CONSTRAINT FK_Juegos_Carrito FOREIGN KEY (JuegoID) REFERENCES Juegos (JuegoID)
);

-- Tabla de Códigos
CREATE TABLE Codigos(
    CodigoID INT IDENTITY(1, 1),
    Codigo VARCHAR(50),
	Descuento Numeric(10, 2),
	CONSTRAINT PK_Codigos PRIMARY KEY (CodigoID)
);

INSERT INTO [dbo].[Codigos] ([Codigo], [Descuento]) 
	VALUES ('JKlm-POQ1', 10000)
INSERT INTO [dbo].[Codigos] ([Codigo], [Descuento]) 
	VALUES ('uRet-90As', 50000)
INSERT INTO [dbo].[Codigos] ([Codigo], [Descuento]) 
	VALUES ('5Lak-Sdqa', 20000)
INSERT INTO [dbo].[Codigos] ([Codigo], [Descuento]) 
	VALUES ('JpoD-23CV', 150000)
GO

-- Tabla de Compras
CREATE TABLE Compras (
    CompraID INT IDENTITY(1, 1) NOT NULL,
    IdDeCompra INT NOT NULL, -- Campo definido manualmente
    UsuarioID INT NOT NULL,
    JuegoID INT NOT NULL,
    CodigoID INT NULL,
    FechaCompra DATETIME NOT NULL,
    Descuento Numeric(10, 2) NOT NULL,
    TotalCompra DECIMAL(10, 2) NOT NULL,
    CONSTRAINT PK_Compras PRIMARY KEY (CompraID),
    CONSTRAINT FK_Usuarios_Compras FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    CONSTRAINT FK_Juegos_Compras FOREIGN KEY (JuegoID) REFERENCES Juegos(JuegoID),
    CONSTRAINT FK_Codigos_Compras FOREIGN KEY (CodigoID) REFERENCES Codigos(CodigoID)
);

-- Tabla de Wishlist
CREATE TABLE Wishlist (
    WishlistID INT IDENTITY(1, 1),
    IdDeWishlist INT NOT NULL, -- Campo definido manualmente
    UsuarioID INT,
    JuegoID INT,
    CONSTRAINT PK_Wishlist PRIMARY KEY (WishlistID),
    CONSTRAINT FK_Usuarios_Wishlist FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    CONSTRAINT FK_Juegos_Wishlist FOREIGN KEY (JuegoID) REFERENCES Juegos(JuegoID)
);

-- Tabla de Reseñas
CREATE TABLE Resenas (
    ReseñaID INT IDENTITY(1, 1),
    UsuarioID INT NOT NULL,
    JuegoID INT NOT NULL,
    Comentario TEXT NOT NULL,
    FechaReseña DATETIME,
	CONSTRAINT PK_Reseñas PRIMARY KEY (ReseñaID),
    CONSTRAINT FK_Usuarios_Reseñas FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    CONSTRAINT FK_Juegos_Reseñas FOREIGN KEY (JuegoID) REFERENCES Juegos(JuegoID)
);

INSERT INTO [dbo].[Resenas] ([UsuarioID], [JuegoID], [Comentario], [FechaReseña])
	VALUES (2, 3498, 'En mi opinión el mejor juego que han creado hasta el momento de este estilo', '2023-07-21 8:52:20')
INSERT INTO [dbo].[Resenas] ([UsuarioID], [JuegoID], [Comentario], [FechaReseña])
	VALUES (2, 3498, 'El multijugador es muy bueno, en sí es un juego de mundo abierto, el mejor de la saga', '2023-07-21 8:52:20')
GO

-- Tabla Estados para la solicitud
CREATE TABLE Estados(
	EstadoID INT NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Estados PRIMARY KEY (EstadoID)
);

-- Tabla Solicitudes
CREATE TABLE Solicitudes (
	SolicitudID INT IDENTITY(1, 1),
	UsuarioID1 INT,
    UsuarioID2 INT,
	EstadoID INT,
	CONSTRAINT PK_Solicitudes PRIMARY KEY (SolicitudID),
	CONSTRAINT FK_Usuarios_Amigos1 FOREIGN KEY (UsuarioID1) REFERENCES Usuarios(UsuarioID),
	CONSTRAINT FK_Usuarios_Amigos2 FOREIGN KEY (UsuarioID2) REFERENCES Usuarios(UsuarioID),
	CONSTRAINT FK_Estados_Solicitudes FOREIGN KEY (EstadoID) REFERENCES Estados(EstadoID)
);

-- Tabla de Amigos
CREATE TABLE Amigos (
    AmistadID INT IDENTITY(1, 1) NOT NULL,
    UsuarioID1 INT NOT NULL,
    UsuarioID2 INT NOT NULL,
    FechaAmistad DATETIME,
	CONSTRAINT PK_Amigos PRIMARY KEY (AmistadID),
	CONSTRAINT FK_Usuarios_Amigos3 FOREIGN KEY (UsuarioID1) REFERENCES Usuarios(UsuarioID),
	CONSTRAINT FK_Usuarios_Amigos4 FOREIGN KEY (UsuarioID2) REFERENCES Usuarios(UsuarioID)
);
GO


--Store Procedure de Login con encriptación de contraseña
CREATE PROCEDURE pa_Login
    @NombreUsuario VARCHAR(50),
    @Contrasena VARCHAR(100)
AS
BEGIN
    DECLARE @HashContrasena CHAR(64)
    SET @HashContrasena = HASHBYTES('SHA2_256', @Contrasena) -- Encriptación de la contraseña
    
    IF EXISTS (SELECT NombreUsuario, HashContrasena FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND HashContrasena = @HashContrasena) BEGIN
        SELECT UsuarioID, NombreUsuario, HashContrasena FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND HashContrasena = @HashContrasena
    END
END;
GO

--Store Procedure de Ingresar Usuario con encriptación de contraseña
CREATE PROCEDURE InsertarUsuario
    @Nombre VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Edad INT,
    @NombreUsuario VARCHAR(50),
    @CorreoElectronico VARCHAR(100),
    @Contrasena VARCHAR(100), -- Cambio en el parámetro
    @RolID INT
AS
BEGIN
    DECLARE @HashContrasena CHAR(64)
    SET @HashContrasena = HASHBYTES('SHA2_256', @Contrasena) -- Encriptación de la contraseña
    
    INSERT INTO Usuarios (Nombre, Apellidos, Edad, NombreUsuario, CorreoElectronico, HashContrasena, FechaRegistro, RolID)
    VALUES (@Nombre, @Apellidos, @Edad, @NombreUsuario, @CorreoElectronico, @HashContrasena, GETDATE(), @RolID);
END;
GO

--Store Procedure de Obtener todos los juegos
CREATE PROCEDURE ObtenerListaJuegos
AS
BEGIN
    SELECT * FROM Juegos;
END;
GO

--Store Procedure de Buscar Juego
CREATE PROCEDURE BuscarJuegoPorID
    @JuegoID INT
AS
BEGIN
    SELECT [JuegoID], [Desarrollador], [Genero], [Precio], [FechaLanzamiento], [Descripcion] 
	FROM Juegos WHERE JuegoID = @JuegoID;
END;
GO

--Store Procedure de Agregar juego al carrito
CREATE PROCEDURE AgregarJuegoAlCarrito
    @UsuarioID INT,
    @JuegoID INT
AS
BEGIN
    INSERT INTO Carrito (UsuarioID, JuegoID)
    VALUES (@UsuarioID, @JuegoID);
END;
GO

--Store Procedure de validar código de descuento
CREATE PROCEDURE ValidarCodigo
    @Codigo VARCHAR(50)
AS
BEGIN

	IF EXISTS(SELECT [Codigo] FROM [dbo].[Codigos] WHERE [Codigo] = @Codigo) BEGIN
		SELECT [Descuento] FROM Codigos WHERE [Codigo] = @Codigo
	END
END;
GO

--Store Procedure de comprar juego***********
CREATE PROCEDURE ComprarJuego
    @CarritoID INT,
	@CodigoID INT
AS 
BEGIN

DECLARE @Id VARCHAR (10)


    DECLARE @UsuarioID INT
	DECLARE @JuegoID INT
	DECLARE @Descuento NUMERIC(10, 2)
	DECLARE @Precio DECIMAL(10, 2)
	DECLARE @TotalCompra DECIMAL(10, 2)
	DECLARE @IdDeCompra INT

    SELECT @UsuarioID = UsuarioID, @JuegoID = JuegoID
    FROM Carrito
    WHERE CarritoID = @CarritoID;

--Generar un identificador único para cada compra
	SET @Id= CONCAT (@UsuarioID,MONTH (GETDATE()) ,YEAR (GETDATE()))   ---Método añadido 
	SET @IdDeCompra =CAST (@Id AS INTEGER)

    DELETE FROM Carrito WHERE CarritoID = @CarritoID;

	SET @Descuento = (SELECT [Descuento] FROM [dbo].[Codigos] WHERE [CodigoID] = @CodigoID)
	SET @Precio = (SELECT [Precio] FROM [dbo].[Juegos] WHERE [JuegoID] = @JuegoID)
	SET @TotalCompra = (@Precio - @Descuento)

    INSERT INTO Compras (IdDeCompra, UsuarioID, JuegoID, CodigoID, FechaCompra, TotalCompra)
    VALUES (@IdDeCompra ,@UsuarioID, @JuegoID, @CodigoID, GETDATE(), @TotalCompra);
END;
GO

--Store Procedure de agregar juego a la wishlist************
CREATE PROCEDURE AgregarJuegoAWishlist
    @UsuarioID INT,
    @JuegoID INT
AS
BEGIN
	
	DECLARE @IdDeWishList INT

--Generar un identificador único para cada juego en la wishlist segun id de usuario
	DECLARE @Id VARCHAR (10)
	SET @Id=CONCAT (@UsuarioID, YEAR (GETDATE()))
	SET @IdDeWishList =CAST (@Id AS INTEGER)

    INSERT INTO Wishlist (IdDeWishlist, UsuarioID, JuegoID)
    VALUES (@IdDeWishList, @UsuarioID, @JuegoID);
END;
GO

--Store Procedure de obtener wishlist de un usuario
CREATE PROCEDURE ObtenerWishlistDeUsuario
    @UsuarioID INT
AS
BEGIN
    SELECT J.JuegoID, J.Desarrollador, J.Genero, J.Precio, J.FechaLanzamiento, J.Descripcion
    FROM Wishlist W
    INNER JOIN Juegos J ON W.JuegoID = J.JuegoID
    WHERE W.UsuarioID = @UsuarioID;
END;
GO

--Store Procedure Eliminar juego de la wishlist
CREATE PROCEDURE EliminarJuegoDeWishlist
    @UsuarioID INT,
    @JuegoID INT
AS
BEGIN
    DELETE FROM Wishlist
    WHERE UsuarioID = @UsuarioID AND JuegoID = @JuegoID;
END;
GO

--Store Procedure de obtener los juegos comprados de un usuario
CREATE PROCEDURE ObtenerBibliotecaDeUsuario
    @UsuarioID INT
AS
BEGIN
    SELECT J.JuegoID, J.Desarrollador, J.Genero, J.Precio, J.FechaLanzamiento, J.Descripcion
    FROM Compras C
    INNER JOIN Juegos J ON C.JuegoID = J.JuegoID
    WHERE C.UsuarioID = @UsuarioID;
END;
GO

--Store Procedure de AgregarReseña
CREATE PROCEDURE AgregarReseña
    @UsuarioID INT,
    @JuegoID INT,
    @Comentario TEXT
AS
BEGIN
    INSERT INTO Resenas (UsuarioID, JuegoID, Comentario, FechaReseña)
    VALUES (@UsuarioID, @JuegoID, @Comentario, GETDATE());
END;
GO

--Store Procedure de Obtener Reseñas
CREATE PROCEDURE ObtenerResenas
	@juegoID INT
AS 
BEGIN
	SELECT [UsuarioID], [JuegoID], [Comentario], [FechaReseña] FROM [dbo].[Resenas]
	WHERE [JuegoID] = @juegoID
END
GO

--Store Procedure para obtener la lista de todos los usuarios
CREATE PROCEDURE ObtenerListaUsuarios
AS
BEGIN
    SELECT * FROM Usuarios;
END;
GO

--Store Procedure de obtener usuario
CREATE PROCEDURE ObtenerUsuario
	@UsuarioID INT
AS 
BEGIN
	SELECT [UsuarioID], [Nombre], [Apellidos], [Edad], [NombreUsuario], [CorreoElectronico], [Contrasena], [FechaRegistro], [RolID]
	FROM [dbo].[Usuarios] WHERE [UsuarioID] = @UsuarioID
END;
GO

--Store Procedure para eliminar usuario
CREATE PROCEDURE EliminarUsuario
    @UsuarioID INT
AS
BEGIN
    DELETE FROM Usuarios WHERE UsuarioID = @UsuarioID;
END;
GO

--Store Procedure para actualizar un usuario
CREATE PROCEDURE ActualizarUsuario
    @UsuarioID INT,
    @Nombre VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Edad INT,
    @NombreUsuario VARCHAR(50),
    @CorreoElectronico VARCHAR(100),
    @Contrasena VARCHAR(100),
    @RolID INT
AS
BEGIN

 DECLARE @HashContrasena CHAR(64)
    SET @HashContrasena = HASHBYTES('SHA2_256', @Contrasena) -- Encriptación de la contraseña
    UPDATE Usuarios
    SET Nombre = @Nombre,
        Apellidos = @Apellidos,
        Edad = @Edad,
        NombreUsuario = @NombreUsuario,
        CorreoElectronico = @CorreoElectronico,
        HashContrasena = @HashContrasena,
        RolID = @RolID
    WHERE UsuarioID = @UsuarioID;
END;
GO

--Store Procedure de enviar solicitud
CREATE PROCEDURE EnviarSolicitud
    @UsuarioID1 INT,
    @UsuarioID2 INT
AS
BEGIN
    INSERT INTO Solicitudes (UsuarioID1, UsuarioID2, EstadoID)
    VALUES (@UsuarioID1, @UsuarioID2, 1); -- 1 representa el estado "Pendiente"
END;
GO

--Store Procedure de aceptar solicitud e ingresar amigos
CREATE PROCEDURE AceptarSolicitud
    @SolicitudID INT
AS
BEGIN
    DECLARE @UsuarioID1 INT, @UsuarioID2 INT;

    SELECT @UsuarioID1 = UsuarioID1, @UsuarioID2 = UsuarioID2
    FROM Solicitudes
    WHERE SolicitudID = @SolicitudID;

    DELETE FROM Solicitudes WHERE SolicitudID = @SolicitudID;

    INSERT INTO Amigos (UsuarioID1, UsuarioID2, FechaAmistad)
    VALUES (@UsuarioID1, @UsuarioID2, GETDATE());
END;
GO



--INSERTS
-- Insert Usuario Común
INSERT INTO Usuarios (Nombre, Apellidos, Edad, NombreUsuario, CorreoElectronico, HashContrasena, FechaRegistro, RolID)
VALUES ('UsuarioComun', 'ApellidosComun', 25, 'user_comun', 'usuario_comun@example.com', HASHBYTES('SHA2_256', 'contrasena123'), GETDATE(), 0);

-- Insert Administrador
INSERT INTO Usuarios (Nombre, Apellidos, Edad, NombreUsuario, CorreoElectronico, HashContrasena, FechaRegistro, RolID)
VALUES ('Admin', 'AdminApellidos', 30, 'admin_user', 'admin@example.com', HASHBYTES('SHA2_256', 'adminpass123'), GETDATE(), 1);

-- Insert Códigos
INSERT INTO Codigos (Codigo, Descuento)
VALUES ('CODIGO123', 1000);

INSERT INTO Codigos (Codigo, Descuento)
VALUES ('DESCUENTO456', 1500);

-- Insert Estados
INSERT INTO Estados (EstadoID, Nombre)
VALUES (0, 'No aceptado');

INSERT INTO Estados (EstadoID, Nombre)
VALUES (1, 'Aceptado');

-- Inserts de Juegos con información ficticia
INSERT INTO Juegos (JuegoID, Desarrollador, Precio, Descripcion)
VALUES
    --(3498, 'Rockstar Games', 49.99, 'Grand Theft Auto V es un juego de acción y aventuras...'),
    (3328, 'CD Projekt RED', 29.99, 'The Witcher 3: Wild Hunt es un RPG de mundo abierto...'),
    (4200, 'Valve', 19.99, 'Portal 2 es un juego de puzles en primera persona...'),
    (5286, 'Crystal Dynamics', 14.99, 'Tomb Raider (2013) es un juego de acción y exploración...'),
    (4291, 'Valve', 9.99, 'Counter-Strike: Global Offensive es un shooter multijugador...'),
    (13536, 'Valve', 9.99, 'Portal es un juego de puzles en primera persona...'),
    (12020, 'Valve', 24.99, 'Left 4 Dead 2 es un shooter cooperativo de supervivencia...'),
    (5679, 'Bethesda Game Studios', 39.99, 'The Elder Scrolls V: Skyrim es un RPG de mundo abierto...'),
    (4062, 'Irrational Games', 29.99, 'BioShock Infinite es un shooter de acción en un mundo flotante...'),
    (28, 'Rockstar Games', 59.99, 'Red Dead Redemption 2 es un juego de acción en mundo abierto...'),
    (802, 'Gearbox Software', 19.99, 'Borderlands 2 es un shooter de acción con elementos RPG...'),
    (3439, 'DONTNOD Entertainment', 14.99, 'Life is Strange es un juego narrativo con mecánicas de tiempo...'),
    (13537, 'Valve', 9.99, 'Half-Life 2 es un shooter en primera persona con elementos de física...'),
    (4286, '2K Boston', 19.99, 'BioShock es un shooter en primera persona con elementos de RPG...'),
    (32, 'Bungie', 29.99, 'Destiny 2 es un juego de disparos en línea con elementos MMO...'),
    (1030, 'Playdead', 9.99, 'Limbo es un juego de plataformas y puzles en blanco y negro...'),
    (58175, 'Santa Monica Studio', 49.99, 'God of War (2018) es un juego de acción y mitología...'),
    (3070, 'Bethesda Game Studios', 19.99, 'Fallout 4 es un RPG de mundo abierto en un mundo postapocalíptico...'),
    (2454, 'id Software', 24.99, 'DOOM (2016) es un reboot del clásico shooter de demonios...'),
    (3939, 'OVERKILL - a Starbreeze Studio', 14.99, 'PAYDAY 2 es un shooter cooperativo con elementos de atraco...');