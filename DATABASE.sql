CREATE DATABASE OXFENIX
drop
ON(
NAME =TSQL2020_DAT,
FILENAME='C:\Users\renzo\OSFENIX2020_DAT.mdf',
SIZE=50mb,
MAXSIZE=250mb,
FILEGROWTH=50%
)
LOG ON(
NAME=TSQL2020_LOG,
FILENAME='C:\Users\renzo\OSFENIX2020_LOG.ldf',
SIZE=25mb,
FILEGROWTH=10%
)

GO
USE OXFENIX
GO

------------------------------------------------------------------------CLIENTE
CREATE TABLE CLIENTE
( 
	id_client            integer  not null ,
	apepat_client        varchar(20)  null ,
	nombres_client       varchar(20)  null ,
	doc_ind_client       varchar(20)  null ,
	email_client         varchar(20)  null ,
	movil_client         varchar(20)  null ,
	direccion_client     varchar(20)  null ,
	fechnaci_client      varchar(20)  null ,
	id_dis               varchar(20)  null
)
go



ALTER TABLE CLIENTE
	ADD CONSTRAINT XPKCLIENTE PRIMARY KEY  CLUSTERED (id_client   ASC)
go


-----------------------------------------------------------------------GARANTIA
CREATE TABLE GARANTIA
( 
	id_garan             integer  not null ,
	fecha_ini            datetime  null ,
	fech_limite          datetime  null ,
	tipo_garan           varchar(20)  null ,
	centro_inf           varchar(20)  null

)
go



ALTER TABLE GARANTIA
	ADD CONSTRAINT XPKGARANTIA PRIMARY KEY  CLUSTERED (id_garan  ASC)
go

---------------------------------------------------------------------ORDEN COMPRA POR PRODUCTO

CREATE TABLE ORDEN_COMPRAXPRODUCTO
( 
	id_orc_prod          varchar(20)  not null ,
	id_orc            integer  null ,
	id_prod              integer  null ,
	cantidad_prod        integer identity ( 1,1 )
)
go



ALTER TABLE ORDEN_COMPRAXPRODUCTO
	ADD CONSTRAINT XPKORDEN_COMPRAXPRODUCTO PRIMARY KEY  CLUSTERED (id_orc_prod ASC)
go


-------------------------------------------------------------------------ORDEN DE COMPRA
CREATE TABLE ORDEN_COMPRA
( 
	id_orc               integer  not null,
	fecha_ent            datetime  null ,
	referencia           varchar(200)  not null ,
	detalle_comp         varchar(200)  null ,
	id_pago              integer  null ,
	id_proveedor         integer  null 
)
go



ALTER TABLE ORDEN_COMPRA
	ADD CONSTRAINT XPKORDEN_COMPRA PRIMARY KEY  CLUSTERED (id_orc ASC)
go

-------------------------------------------------------------------------PAGO
CREATE TABLE PAGO
( 
	id_pago              integer  not null ,
	tipo_pago            varchar(20)  null ,
	cantida_pago         numeric  null ,
	cuota_pago           numeric  null ,
	interes_pago         numeric  not null ,
	fecha_ini            datetime  null ,
	fecha_finaliz        datetime  null ,
	pago_total           numeric  not null 
)
go



ALTER TABLE PAGO
	ADD CONSTRAINT XPKTIPO_COMPRA PRIMARY KEY  CLUSTERED (id_pago ASC)
go
--------------------------------------------------------------------PRODUCTO


CREATE TABLE PRODUCTO
( 
	id_prod              integer  not null ,
	nombre_prod          varchar(20)  null ,
	descrip_prod         varchar(20)  null ,
	composicion          varchar(20)  null ,
	fechfabricacion_prod varchar(20)  null
)
go



ALTER TABLE PRODUCTO
	ADD CONSTRAINT XPKPRODUCTO PRIMARY KEY  CLUSTERED (id_prod ASC)
go

--------------------------------------------------------------------PROVEEDOR

CREATE TABLE PROVEEDOR
( 
	id_proveedor         integer  not null ,
	razonsocial_prov     varchar(200)  null ,
	direccion_prov       varchar(200)  null ,
	rut_prov             varchar(200)  null ,
	numero_prov          varchar(20)  null ,
	id_dis               varchar(20)  null 
)
go



ALTER TABLE PROVEEDOR
	ADD CONSTRAINT XPKPROVEEDOR PRIMARY KEY  CLUSTERED (id_proveedor ASC)
go

----------------------------------------------------------------------UBIGEO

CREATE TABLE UBIGEO
( 
	id_dis               Varchar(20) not null ,
	distrito             varchar(200)  null ,
	provincia            varchar(200)  null ,
	departamento         varchar(200)  null
)
go



ALTER TABLE UBIGEO
	ADD CONSTRAINT XPKDISTRITO PRIMARY KEY  CLUSTERED (id_dis ASC)
go

-----------------------------------------------------------------VENTA

CREATE TABLE VENTA
( 
	id_venta            integer  not null ,
	fech_emision         datetime  null ,
	fech_recojo          datetime  null ,
	realizacion_ped      varchar(20)  null ,
	detalle_ped          varchar(20)  null ,
	observaciones_ped    varchar(20)  null ,
	id_garan             integer  null,     
	id_client            integer  null

)
go



ALTER TABLE VENTA
	ADD CONSTRAINT XPKPEDIDO PRIMARY KEY  CLUSTERED (id_venta ASC)
go
------------------------------------------------------------------VENTA POR PRODUCTO


CREATE TABLE VENTAXPRODUCTO
( 
	id_vent_prod         varchar(20)  not null ,
	id_prod              integer  null ,
	cantidad_prod        varchar(20)  null ,
	id_venta            integer  null

)
go

ALTER TABLE VENTAXPRODUCTO
	ADD CONSTRAINT XPKVENTAXPRODUCTO PRIMARY KEY  CLUSTERED (id_vent_prod ASC)
go
-----------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------FK CLIENTE A UBIGEO
ALTER TABLE CLIENTE
	ADD CONSTRAINT R_4 FOREIGN KEY (id_dis) REFERENCES UBIGEO(id_dis)
go



-------------------------------------------------FK ORDEN_COMPRAXPRODUCTO A ORDEN_COMPRA Y PRODUCTO
ALTER TABLE ORDEN_COMPRAXPRODUCTO
	ADD CONSTRAINT R_46 FOREIGN KEY (id_orc) REFERENCES ORDEN_COMPRA(id_orc)
go




ALTER TABLE ORDEN_COMPRAXPRODUCTO
	ADD CONSTRAINT R_47 FOREIGN KEY (id_prod) REFERENCES PRODUCTO(id_prod)
go

-------------------------------------------------FK ORDEN_COMPRA A PAGO Y PROVEEDOR


ALTER TABLE ORDEN_COMPRA
	ADD CONSTRAINT R_21 FOREIGN KEY (id_pago) REFERENCES PAGO(id_pago)
go




ALTER TABLE ORDEN_COMPRA
	ADD CONSTRAINT R_39 FOREIGN KEY (id_proveedor) REFERENCES PROVEEDOR(id_proveedor)
go

---------------------------------------------------FK PROVEEDOR A UBIGEO

ALTER TABLE PROVEEDOR
	ADD CONSTRAINT R_5 FOREIGN KEY (id_dis) REFERENCES UBIGEO(id_dis)
go


---------------------------------------------------FK VENTA A  CLIENTE Y GARANTIA


ALTER TABLE VENTA
	ADD CONSTRAINT R_9 FOREIGN KEY (id_client) REFERENCES CLIENTE(id_client)
go




ALTER TABLE VENTA
	ADD CONSTRAINT R_48 FOREIGN KEY (id_garan) REFERENCES GARANTIA(id_garan)
go

----------------------------------------------------FK VENTAXPRODUCTO A PRODUCTO Y VENTA

ALTER TABLE VENTAXPRODUCTO
	ADD CONSTRAINT R_50 FOREIGN KEY (id_prod) REFERENCES PRODUCTO(id_prod)
go




ALTER TABLE VENTAXPRODUCTO
	ADD CONSTRAINT R_55 FOREIGN KEY (id_venta) REFERENCES VENTA(id_venta)
go
-----------------------------------------------------------------------------------------------º