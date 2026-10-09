CREATE DATABASE BDSIGIV;
GO

USE BDSIGIV;
GO 

CREATE TABLE Rol
(
    IdRol INT PRIMARY KEY IDENTITY (1,1),
    Nombre NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE()
);
GO

CREATE TABLE Usuario 
(
    IdUsuario INT PRIMARY KEY IDENTITY (1,1),
    RolID INT NOT NULL,
    Nombre NVarchar(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Clave NVARCHAR(100) NOT NULL, 
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Telefono NVARCHAR(20) NOT NULL UNIQUE,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    Estado BIT DEFAULT 1,

    CONSTRAINT FK_Usuario_RolID FOREIGN KEY (RolID) REFERENCES Rol(IdRol),
    CONSTRAINT CHK_Usuario_Email CHECK (Email LIKE '%@%.%') 
);
GO

CREATE TABLE Permiso
(
    IdPermiso INT PRIMARY KEY IDENTITY (1,1),
    Nombre NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE()
);
GO

CREATE TABLE RolPermiso
(
    IdRP INT PRIMARY KEY IDENTITY (1,1),
    RolID INT NOT NULL,
    PermisoID INT NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),

    CONSTRAINT FK_RolPermiso_RolID FOREIGN KEY (RolID) REFERENCES Rol(IdRol) ON DELETE CASCADE,
    CONSTRAINT FK_RolPermiso_PermisoID FOREIGN KEY (PermisoID) REFERENCES Permiso(IdPermiso) ON DELETE CASCADE,
    CONSTRAINT UQ_RolPermiso UNIQUE (RolID, PermisoID)
);
GO

CREATE TABLE Categoria
(
    IdCategoria INT PRIMARY KEY IDENTITY (1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE()
);
GO

CREATE TABLE SubCategoria
(
    IdSubcategoria INT PRIMARY KEY IDENTITY(1,1),
    CategoriaID INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(), 

    CONSTRAINT FK_SubCategoria_CategoriaID FOREIGN KEY (CategoriaID) REFERENCES Categoria(IdCategoria)
);
GO

CREATE TABLE Cliente
(
    IdCliente INT PRIMARY KEY IDENTITY (1,1),
    Nombre NVarchar(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Telefono NVarchar (20) NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    Estado BIT DEFAULT 1
);
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_Cliente_Telefono
ON Cliente(Telefono) WHERE Telefono IS NOT NULL;
GO

CREATE TABLE Factura
(
    IdFactura INT PRIMARY KEY IDENTITY (1,1),
    ClienteID INT NOT NULL,
    UsuarioID INT NOT NULL,
    NFactura Nvarchar (50) NOT NULL UNIQUE,
    Total DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Estado Nvarchar (30) DEFAULT 'Pagada',
    CreatedAt DATETIME2 DEFAULT GETDATE(),

    CONSTRAINT FK_Factura_ClienteID FOREIGN KEY (ClienteID) REFERENCES Cliente(IdCliente),
    CONSTRAINT FK_Factura_UsuarioID FOREIGN KEY (UsuarioID) REFERENCES Usuario(IdUsuario)
);
GO

CREATE TABLE Producto
(
    IdProducto INT PRIMARY KEY IDENTITY (1,1),
    SubCategoriaID INT NOT NULL,
    Codigo NVARCHAR(50) NOT NULL UNIQUE,
    Nombre NVarchar(100) NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    PrecioCompra DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    PrecioVenta DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    StockActual INT NOT NULL DEFAULT 0, 
    StockMinimo INT NOT NULL DEFAULT 0,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    Estado BIT DEFAULT 1,

    CONSTRAINT FK_Producto_SubCategoriaID FOREIGN KEY (SubCategoriaID) REFERENCES SubCategoria(IdSubcategoria)
 );
 GO

CREATE TABLE DetalleFactura 
(
    ID INT PRIMARY KEY IDENTITY (1,1),
    FacturaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    SubTotal  As (Cantidad * PrecioUnitario) ,
    CreatedAt DATETIME2 DEFAULT GETDATE(),

    CONSTRAINT FK_DetalleFactura_FacturaID FOREIGN KEY (FacturaID) REFERENCES Factura(IdFactura) ON DELETE CASCADE,
    CONSTRAINT FK_DetalleFactura_ProductoID FOREIGN KEY (ProductoID) REFERENCES Producto(IdProducto)
);
GO

CREATE TABLE Proveedor
(
    IdProveedor INT PRIMARY KEY IDENTITY (1,1),
    Nombre NVarchar(100) NOT NULL,
    Telefono NVARCHAR (20) NOT NULL UNIQUE,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    Estado BIT DEFAULT 1
);
GO

CREATE TABLE Compra
(
    IdCompra INT PRIMARY KEY IDENTITY (1,1),
    ProveedorID INT  NOT NULL,
    UsuarioID INT NOT NULL,
    NFactura NVARCHAR(50) NOT NULL UNIQUE, -- Corregido: Ahora admite letras/guiones
    Total DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Estado NVARCHAR(30) DEFAULT 'Procesada',
    CreatedAt DATETIME2 DEFAULT GETDATE(),

    CONSTRAINT fk_Compra_ProveedorID FOREIGN KEY (ProveedorID) REFERENCES Proveedor(IdProveedor),
    CONSTRAINT fk_Compra_UsuarioID FOREIGN KEY (UsuarioID) REFERENCES Usuario(IdUsuario)
);
GO

CREATE TABLE DetalleCompra 
(
    IdDC INT PRIMARY KEY IDENTITY (1,1),
    CompraID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioCompra DECIMAL(10,2) NOT NULL,
    SubTotal AS (Cantidad * PrecioCompra),
    CreatedAt DATETIME2 DEFAULT GETDATE(),

    CONSTRAINT fk_DetalleCompra_CompraID FOREIGN KEY (CompraID) REFERENCES Compra(IdCompra) ON DELETE CASCADE,
    CONSTRAINT fk_DetalleCompra_ProductoID FOREIGN KEY (ProductoID) REFERENCES Producto(IdProducto)
);
GO

CREATE TABLE ProductoSolicitado
(
    IdPS INT PRIMARY KEY identity (1,1),
    UsuarioID INT  NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL,
    Estado Nvarchar (30) NOT NUll DEfAULT 'Pendiente',
    CreatedAt DATETIME2 DEFAULT GETDATE(),

    CONSTRAINT fk_ProductoSolicitado_UsuarioID FOREIGN KEY (UsuarioID) REFERENCES Usuario(IdUsuario)
);
GO

CREATE TABLE MovimientoInventario
(
    IdMS INT PRIMARY KEY IDENTITY (1,1),
    UsuarioID INT NOT NULL,
    ProductoID INT NOT NULL,
    FacturaID INT NULL,
    CompraID INT NULL,
    TipoMovimiento VARCHAR(50) NOT NULL,
    Cantidad INT NOT NULL,
    StockAnterior INT NOT NULL,
    StockActual INT NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(), 

    CONSTRAINT fk_MovimientoInventario_UsuarioID FOREIGN KEY (UsuarioID) REFERENCES Usuario(IdUsuario),
    CONSTRAINT fk_MovimientoInventario_ProductoID FOREIGN KEY (ProductoID) REFERENCES Producto(IdProducto),
    CONSTRAINT fk_MovimientoInventario_FacturaID FOREIGN KEY (FacturaID) REFERENCES Factura(IdFactura),
    CONSTRAINT fk_MovimientoInventario_CompraID FOREIGN KEY (CompraID) REFERENCES Compra(IdCompra) 
);
GO


SELECT * FROM Cliente;

INSERT INTO Rol (Nombre) 
VALUES ('Administrador'), ('Vendedor');
GO

INSERT INTO Permiso (Nombre) 
VALUES
    ('Solicitudes_Eliminar'),('Solicitudes_Crear'), ('Solicitudes_Ver'), ('Solicitudes_Gestionar'),
    ('Clientes_Crear'), ('Clientes_Ver'), ('Clientes_Editar'),('Clientes_Eliminar'), 
    ('Inventario_Ver'), ('Inventario_Gestionar'), ('Inventario_Eliminar'),
    ('Usuarios_Gestionar'),('Usuarios_Eliminar'), ('Reportes_Ver'),
    ('Compras_Registrar'), ('Compras_Ver'), ('Compras_Eliminar'),
    ('Ventas_Crear'), ('Ventas_Ver'), ('Ventas_Anular'),
    ('Proveedores_Eliminar'),('Proveedores_Gestionar'), 
    ('Movimientos_Ver'), ('Movimientos_Ajustar');
GO

INSERT INTO Cliente (Nombre, Apellido, Telefono) 
VALUES('Consumidor', 'General', NULL);
GO

INSERT INTO RolPermiso(RolID, PermisoID)
SELECT r.IdRol, p.IdPermiso
FROM Rol AS r  
CROSS JOIN Permiso AS p
WHERE r.Nombre = 'Administrador';
GO

INSERT INTO RolPermiso (RolID, PermisoID)
SELECT r.IdRol, p.IdPermiso
FROM Rol AS r 
CROSS JOIN Permiso AS p
WHERE r.Nombre = 'Vendedor' 
AND p.Nombre IN
  (
  'Ventas_Crear', 'Ventas_Ver', 
  'Clientes_Crear', 'Clientes_Ver', 'Clientes_Editar', 
  'Inventario_Ver', 'Solicitudes_Crear', 'Solicitudes_Ver'
  );
GO

INSERT INTO Usuario (RolID, Nombre, Apellido, Username, Clave, Email, Telefono)
SELECT r.IdRol, 'Admin', 'Inicial', 'Admin1', 'Admin123', 'Admin@local.com', '12345678'
FROM Rol AS r
WHERE r.Nombre = 'Administrador';
GO

CREATE OR ALTER FUNCTION dbo.fnTienePermiso
(
  @idrol INT,
  @nombrepermiso NVARCHAR (100)
)
RETURNS BIT 
AS
BEGIN DECLARE @tiene BIT=0
IF EXISTS 
(
  SELECT 1
  FROM RolPermiso  AS rp
     INNER JOIN Permiso AS p ON rp.PermisoID = p.IdPermiso
  WHERE rp.RolID=@idrol
     AND p.Nombre=@nombrepermiso
)
BEGIN SET @tiene=1
END
RETURN @tiene;
END;
GO

CREATE OR ALTER VIEW vw_ProductosDetalle AS
SELECT 
     p.IdProducto,p.Codigo, p.Nombre AS Producto, 
     p.Descripcion, c.Nombre AS Categoria,
     sc.Nombre AS SubCategoria,
     p.PrecioCompra,p.PrecioVenta,p.StockActual,p.StockMinimo,
CASE  
  WHEN p.StockActual <= p.StockMinimo THEN 'stock bajo'
    ELSE 'normal'
       END AS EstadoStock
FROM Producto AS p
  INNER JOIN SubCategoria AS sc ON p.SubCategoriaID = sc.IdSubcategoria
  INNER JOIN Categoria c ON sc.CategoriaID = c.IdCategoria
WHERE p.Estado=1;
GO

CREATE OR ALTER VIEW vw_VentasResumen AS
SELECT 
    f.IdFactura,f.NFactura,f.CreatedAt As Fecha,
    c.Nombre + ' ' + ISNULL(c.Apellido, ' ') AS Cliente,
    u.Nombre  + ' ' + u.Apellido AS Vendedor,
    f.Total
FROM Factura AS f
  INNER JOIN Cliente AS c ON f.ClienteID = c.IdCliente
  INNER jOIN Usuario  AS u ON f.UsuarioID = u.IdUsuario;
GO

CREATE OR ALTER VIEW vw_ComprasResumen AS
SELECT 
    c.IdCompra, c.NFactura AS FacturaProveedor,
    c.CreatedAt AS Fecha,
    p.Nombre AS Proveedor,
    u.Nombre + ' ' + u.Apellido AS Comprador,
    c.Total
FROM Compra AS c
  INNER JOIN Proveedor AS p ON c.ProveedorID = p.IdProveedor
  INNER JOIN Usuario AS u ON c.UsuarioID = u.IdUsuario;
GO

CREATE OR ALTER VIEW vw_MovimientosInventario AS
SELECT
    mi.IdMS AS MovimientoID,
    p.Codigo, p.Nombre AS Producto,
    mi.TipoMovimiento,mi.Cantidad,mi.StockAnterior,mi.StockActual,
      ISNULL (CAST(mi.FacturaID AS NVARCHAR), 'N/A') AS FacturaVenta,
      ISNULL (CAST(mi.CompraID AS NVARCHAR), 'N/A') AS FacturaCompra,
    u.Nombre + '' + u.Apellido AS Registrado,
    mi.CreatedAt AS Fecha
FROM MovimientoInventario AS mi
  INNER JOIN Producto AS p ON mi.ProductoID = p.IdProducto
  INNER JOIN Usuario AS u ON mi.UsuarioID = u.IdUsuario;
GO

CREATE OR ALTER VIEW vw_SolicitudesProductos AS
SELECT 
   ps.IdPS AS SolicitudID,
   ps.Nombre AS Producto,
   ps.Cantidad, ps.Estado,
   u.Nombre + '' + u.Apellido AS Vendedor,
   ps.CreatedAt AS Fecha
FROM ProductoSolicitado AS ps
  INNER JOIN Usuario AS u ON ps.UsuarioID = u.IdUsuario;
GO

CREATE OR ALTER VIEW vw_Usuarios AS
SELECT 
   u.IdUsuario,u.username, u.Nombre + ' ' + u.Apellido AS NombreCompleto,
   r.Nombre AS Rol,
   u.Email,u.Telefono,u.CreatedAt AS FechaRegistro
FROM Usuario AS u
   INNER JOIN Rol AS r ON u.RolID = r.IdRol
WHERE u.Estado=1;
GO

CREATE OR ALTER TRIGGER trg_ActualizarStockVenta
ON DetalleFactura
AFTER INSERT
AS BEGIN SET NOCOUNT ON;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID,CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
SELECT
    f.UsuarioID, i.ProductoID, i.FacturaID,
       NULL,
          'Salida',
    i.Cantidad,
    p.StockActual,
    p.StockActual - i.Cantidad
FROM inserted AS i
  INNER JOIN Factura AS f ON i.FacturaID = f.IdFactura
  INNER JOIN Producto AS p ON i.ProductoID = p.IdProducto;

UPDATE p
SET p.StockActual = p.StockActual - i.Cantidad
FROM Producto AS p
  INNER JOIN inserted AS i ON p.IdProducto = i.ProductoID;
END;
GO

CREATE OR ALTER TRIGGER trg_ActualizarStockCompra
ON DetalleCompra
AFTER INSERT
AS BEGIN SET NOCOUNT ON;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID,CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
SELECT 
    c.UsuarioID,
    i.ProductoID,  i.CompraID,
       NULL,
         'Entrada',
    i.Cantidad,
    p.StockActual,
    p.StockActual + i.Cantidad
FROM inserted AS i
  INNER JOIN Compra AS c ON i.CompraID = c.IdCompra
  INNER JOIN Producto AS p ON i.ProductoID = p.IdProducto;

UPDATE p
SET p.StockActual = p.StockActual + i.Cantidad
FROM Producto AS p
  INNER JOIN inserted AS i ON p.IdProducto = i.ProductoID;
END; 
GO

CREATE OR ALTER TRIGGER trg_EvitarStockNegativo
ON Producto
AFTER UPDATE
AS BEGIN SET NOCOUNT ON;

IF EXISTS (SELECT 1 FROM inserted WHERE StockActual < 0)
  BEGIN
     RAISERROR('No se puede actualizar el stock a un valor negativo.', 16, 1);
     ROLLBACK TRANSACTION;
   END
END;
GO

CREATE OR ALTER TRIGGER  trg_restaurarstockVenta
ON DetalleFactura
AFTER DELETE
AS BEGIN SET NOCOUNT ON;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID,CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
SELECT
    f.UsuarioID,
    d.ProductoID,
    d.FacturaID,
                 NULL,
      'Devolucion',
    d.Cantidad,
    p.StockActual,
    p.StockActual + d.Cantidad
FROM deleted AS d
   INNER JOIN Factura AS f ON d.FacturaID = f.IdFactura
   INNER JOIN Producto AS p ON d.ProductoID = p.IdProducto;

UPDATE p
SET p.StockActual = p.StockActual + d.Cantidad
FROM Producto AS p
  INNER JOIN deleted AS d ON p.IdProducto = d.ProductoID;
END;
GO

CREATE OR ALTER TRIGGER trg_restaurarstockCompra
ON DetalleCompra
AFTER DELETE
AS BEGIN SET NOCOUNT ON;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID,CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
SELECT
    c.UsuarioID,
    d.ProductoID,
          NULL,
    d.CompraID,
    'Devolucion',
    d.Cantidad,
    p.StockActual,
    p.StockActual - d.Cantidad
FROM deleted AS d
    INNER JOIN Compra AS c ON d.CompraID = c.IdCompra
    INNER JOIN Producto AS p ON d.ProductoID = p.IdProducto;

UPDATE p
SET p.StockActual = p.StockActual - d.Cantidad
FROM Producto AS p
  INNER JOIN deleted AS d ON p.IdProducto = d.ProductoID;
END;
GO

CREATE OR ALTER TRIGGER trg_ProtegerFactura
ON DetalleFactura
INSTEAD OF UPDATE
AS BEGIN SET NOCOUNT ON;

RAISERROR('No se puede modificar el detalle de la factura. Para realizar cambios, elimine la factura y cree una nueva.', 16, 1);
ROLLBACK TRANSACTION;
END;
GO

CREATE OR ALTER TRIGGER trg_ProtegerCompra
ON DetalleCompra
INSTEAD OF UPDATE
AS BEGIN SET NOCOUNT ON;

RAISERROR('No se puede modificar el detalle de la compra. Para realizar cambios, elimine la compra y cree una nueva.', 16, 1);
ROLLBACK TRANSACTION;
END;
GO

CREATE OR ALTER PROCEDURE sp_AnularFactura
     @IdFactura INT,
     @UsuarioID INT

AS BEGIN SET NOCOUNT ON;

BEGIN TRANSACTION;
BEGIN TRY
   IF EXISTS (select 1 from Factura where IdFactura=@IdFactura AND Estado='Anulada')
BEGIN
    RAISERROR('La factura ya está anulada.', 16, 1);
    ROLLBACK TRANSACTION ;
    RETURN;
END

UPDATE Factura 
SET Estado='Anulada'
WHERE IdFactura=@IdFactura;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID,CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
SELECT
     @UsuarioID,
     df.ProductoID,
     @IdFactura,
           NULL,
           'Anulacion',
     df.Cantidad,
     p.StockActual,
     p.StockActual + df.Cantidad
FROM DetalleFactura AS df
    INNER JOIN Producto AS p ON df.ProductoID = p.IdProducto
WHERE df.FacturaID=@IdFactura;

UPDATE p
SET p.StockActual = p.StockActual + df.Cantidad
FROM Producto AS p
   INNER JOIN DetalleFactura AS df ON p.IdProducto = df.ProductoID
WHERE df.FacturaID=@IdFactura;

COMMIT TRANSACTION;
END 
   TRY
      BEGIN CATCH
           IF @@trancount > 0 ROLLBACK TRANSACTION;
          THROW;
  END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_AnularCompra
     @IdCompra INT,
     @UsuarioID INT
AS BEGIN SET NOCOUNT ON;

BEGIN TRANSACTION;
  BEGIN 
      TRY
        IF EXISTS (SELECT 1 FROM Compra WHERE IdCompra=@IdCompra AND Estado= 'Anulada')
  BEGIN
    RAISERROR('La compra ya está anulada.', 16, 1);
       ROLLBACK TRANSACTION;
    RETURN;
END

UPDATE Compra
SET Estado='Anulada'
WHERE IdCompra=@IdCompra;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID,CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
SELECT
    @UsuarioID, dc.ProductoID, NULL, @IdCompra, 'Anulacion', 
    dc.Cantidad, p.StockActual, p.StockActual - dc.Cantidad
FROM DetalleCompra AS dc
    INNER JOIN Producto AS p ON dc.ProductoID = p.IdProducto
WHERE dc.CompraID=@IdCompra;

UPDATE p
SET p.StockActual = p.StockActual - dc.Cantidad
FROM Producto AS p
   INNER JOIN DetalleCompra AS dc ON p.IdProducto = dc.ProductoID
WHERE dc.CompraID=@IdCompra;

COMMIT TRANSACTION;
END 
   TRY
     BEGIN CATCH
          IF @@trancount > 0 ROLLBACK TRANSACTION;
       THROW;
   END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_AjustarStock
    @ProductoID INT,
    @UsuarioID INT,
    @Cantidad INT,
    @Ingreso BIT
AS BEGIN SET NOCOUNT ON;

BEGIN TRANSACTION;
   BEGIN TRY
       DECLARE @StockAnterior INT;
       DECLARE @StockActual INT;
       DECLARE @TipoMovimiento VARCHAR(50);

SELECT @StockAnterior = StockActual
FROM Producto 
WHERE IdProducto=@ProductoID and Estado=1;

IF @StockAnterior IS NULL
  BEGIN
    RAISERROR('Producto no encontrado o inactivo.', 16, 1);
    ROLLBACK TRANSACTION;
  RETURN;
END

IF @Ingreso = 1
  BEGIN
     SET @StockActual = @StockAnterior + @Cantidad;
     SET @TipoMovimiento = 'Ajuste Entrada';
   END
ELSE
   BEGIN
      SET @StockActual = @StockAnterior - @Cantidad;
      SET @TipoMovimiento = 'Ajuste Salida';

IF @StockActual < 0
 BEGIN      
     RAISERROR('No se puede ajustar el stock a un valor negativo.', 16, 1);
     ROLLBACK TRANSACTION;
   RETURN;
  END
END

UPDATE Producto
SET StockActual = @StockActual
WHERE IdProducto=@ProductoID;

INSERT INTO MovimientoInventario (UsuarioID, ProductoID, FacturaID, CompraID, TipoMovimiento, Cantidad, StockAnterior, StockActual)
VALUES (@UsuarioID, @ProductoID, NULL, NULL, @TipoMovimiento, @Cantidad, @StockAnterior, @StockActual);

COMMIT TRANSACTION;
 END
   TRY
     BEGIN CATCH 
         IF @@trancount > 0 ROLLBACK TRANSACTION;
       THROW;
   END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_ValidarLogin
    @Username NVARCHAR(50),
    @Password NVARCHAR(100)
AS BEGIN SET NOCOUNT ON;

IF EXISTS (SELECT 1 FROM Usuario WHERE Username=@Username AND Clave=@Password AND Estado=1)
   BEGIN
    SELECT u.IdUsuario, u.RolID, r.Nombre AS Rol,
           u.Nombre+ ' '+ u.Apellido AS NombreCompleto
FROM Usuario AS u
    INNER JOIN Rol AS r ON u.RolID = r.IdRol
WHERE u.Username=@Username
    AND u.Clave=@Password;
 END
ELSE
   BEGIN
      SELECT NULL AS IdUsuario;
    END
END;
GO