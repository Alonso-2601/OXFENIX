GO
---------------------------PRODUCTO
---OBTENER DATOS PRODUCTO
go 
create Procedure producto_datos
as
           select * from  PRODUCTO 

exec producto_datos

---BUSCAR PRODUCTO POR ID
go 
create Procedure producto_buscar
@ID_PROD int
as
           select * from  PRODUCTO WHERE ID_PROD=@ID_PROD

exec producto_buscar '1'
---BUSCAR PRODUCTO POR NOMBRE-PRODUCTO
go 
create Procedure prod_buscar_nom
@nom nvarchar(200)
as
          select * from  PRODUCTO  WHERE NOMBRE_PROD like '%'+@nom+'%' 

exec prod_buscar_nom 'BIO_CONECTOR'




---INSERTAR DATOS TPO_PRODUCTO
go 
create Procedure producto_INSERTARXD
@ID_PROD int,
@NOMBRE_PROD varchar(200),
@DESCRIP_PROD varchar(200),
@COMPOSICION varchar(200),
@FECHFABRICACION_PROD varchar(200)
as
insert into PRODUCTO(ID_PROD,NOMBRE_PROD,DESCRIP_PROD,COMPOSICION,FECHFABRICACION_PROD)
values(@ID_PROD,@NOMBRE_PROD,@DESCRIP_PROD,@COMPOSICION,@FECHFABRICACION_PROD)


------- ELIMINACIÓN PRODUCTO
go
create procedure eliminacion_productoxdXD
@ID_PROD int
as
delete PRODUCTO where ID_PROD=@ID_PROD

-----Procedimiento de actualizacion 
go
create procedure actualizacion_producto
@ID_PROD int,
@NOMBRE_PROD varchar(200),
@DESCRIP_PROD varchar(200),
@COMPOSICION varchar(200),
@FECHFABRICACION_PROD datetime
as
update PRODUCTO
set
NOMBRE_PROD=@NOMBRE_PROD,
DESCRIP_PROD=@DESCRIP_PROD,
COMPOSICION=@COMPOSICION,
FECHFABRICACION_PROD=@FECHFABRICACION_PROD
WHERE ID_PROD=@ID_PROD


