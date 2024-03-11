CREATE TABLE PERSONA (
    idpersona INT PRIMARY KEY,
    nombre VARCHAR(255),
    apellidos VARCHAR(255),
    Telefono VARCHAR(20),
    CI VARCHAR(20),
    correo VARCHAR(255),
    estado VARCHAR(50)
);

CREATE TABLE ROL (
    idrol INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(50)
);

CREATE TABLE TIPOPROD (
    idtipoprod INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(50)
);

CREATE TABLE MARCA (
    idmarca INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(50)
);

CREATE TABLE PRODUCTO (
    idproducto INT PRIMARY KEY,
    idtipoproducto INT,
    nombre VARCHAR(255),
    codigobarra VARCHAR(50),
    idmarca INT,
    unidad VARCHAR(50),
    descripcion TEXT,
    estado VARCHAR(50),
    FOREIGN KEY (idtipoproducto) REFERENCES TIPOPROD(idtipoprod),
    FOREIGN KEY (idmarca) REFERENCES MARCA(idmarca)
);

CREATE TABLE USUARIO (
    idusuario INT PRIMARY KEY,
    idpersona INT,
    nombreuser VARCHAR(50),
    contraseña VARCHAR(255),
    fechareg DATE,
    FOREIGN KEY (idpersona) REFERENCES PERSONA(idpersona)
);

CREATE TABLE USUARIOROL (
    idusuariorol INT PRIMARY KEY,
    idusuario INT,
    idrol INT,
    fechasigna DATE,
    estado VARCHAR(50),
    FOREIGN KEY (idusuario) REFERENCES USUARIO(idusuario),
    FOREIGN KEY (idrol) REFERENCES ROL(idrol)
);

CREATE TABLE CLIENTE (
    idcliente INT PRIMARY KEY,
    idpersona INT,
    tipocliente VARCHAR(50),
    codigoclie VARCHAR(20),
    estado VARCHAR(50),
    FOREIGN KEY (idpersona) REFERENCES PERSONA(idpersona)
);

CREATE TABLE VENTA (
    idventa INT PRIMARY KEY,
    idcliente INT,
    idvendedor INT,
    fecha DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idcliente) REFERENCES CLIENTE(idcliente)
);

CREATE TABLE DETALLEVENT (
    iddetallevent INT PRIMARY KEY,
    idventa INT,
    idproducto INT,
    cantidad INT,
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idventa) REFERENCES VENTA(idventa),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto)
);

CREATE TABLE PROVEEDOR (
    idproveedor INT PRIMARY KEY,
    nombre VARCHAR(255),
    telefono VARCHAR(20),
    direccoin VARCHAR(255),
    estado VARCHAR(50)
);

CREATE TABLE INGRESO (
    idingreso INT PRIMARY KEY,
    idproveedor INT,
    fechaingreso DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR(idproveedor)
);
CREATE TABLE PROVEE (
    idprovee INT PRIMARY KEY,
    idproducto INT,
    idproveedor INT,
    fecha DATE,
    precio DECIMAL(10, 2),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto),
    FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR(idproveedor)
);

CREATE TABLE DETALLEING (
    iddetalleing INT PRIMARY KEY,
    idproducto INT,
    idingreso INT,
    fechavenc DATE,
    cantidad INT,
    preciocosto DECIMAL(10, 2),
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto),
    FOREIGN KEY (idingreso) REFERENCES INGRESO(idingreso)
);


ALTER TABLE PERSONA
ADD CONSTRAINT PK_PERSONA PRIMARY KEY (idpersona);

ALTER TABLE USUARIO
ADD CONSTRAINT FK_USUARIOROL_USUARIO
FOREIGN KEY (idusuario) REFERENCES USUARIOROL(idusuario);

ALTER TABLE CLIENTE
ADD CONSTRAINT FK_VENTA_CLIENTE
FOREIGN KEY (idcliente) REFERENCES VENTA(idcliente);

ALTER TABLE VENTA
ADD CONSTRAINT FK_DETALLEVENT_VENTA
FOREIGN KEY (idventa) REFERENCES DETALLEVENT(idventa);

ALTER TABLE PRODUCTO
ADD CONSTRAINT FK_DETALLEVENT_PRODUCTO
FOREIGN KEY (idproducto) REFERENCES DETALLEVENT(idproducto);

ALTER TABLE PRODUCTO
ADD CONSTRAINT FK_DETALLEING_PRODUCTO
FOREIGN KEY (idproducto) REFERENCES DETALLEING(idproducto);

ALTER TABLE PROVEE
ADD CONSTRAINT FK_PROVEE_PRODUCTO
FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto);

ALTER TABLE PROVEE
ADD CONSTRAINT FK_PROVEE_PROVEEDOR
FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR(idproveedor);

ALTER TABLE INGRESO
ADD CONSTRAINT FK_DETALLEING_INGRESO
FOREIGN KEY (idingreso) REFERENCES DETALLEING(idingreso);

ALTER TABLE TIPOPROD
ADD CONSTRAINT FK_PRODUCTO_TIPOPROD
FOREIGN KEY (idtipoprod) REFERENCES PRODUCTO(idtipoproducto);

ALTER TABLE MARCA
ADD CONSTRAINT FK_PRODUCTO_MARCA
FOREIGN KEY (idmarca) REFERENCES PRODUCTO(idmarca);


