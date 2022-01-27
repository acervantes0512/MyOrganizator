CREATE TABLE Rol
(
	IdRol  			int Primary Key,
	NombreRol		varchar(200) not null,
	Estado			int not null,
	FechaRegistro	Date not null
);

CREATE TABLE Usuario
(
	IdUsuario  		int Primary Key,
	NombreUsuario	varchar(200) not null,
	Clave			varchar(200) not null,
	FechaRegistro	Date not null,
	Estado			int not null,
	IdRol			int not null,
	CONSTRAINT FK_USUARIO_ROL FOREIGN KEY (IdRol) REFERENCES Rol (IdRol)
);

CREATE TABLE Tipo_Proyecto
(
	IdTipoProyecto  int Primary Key,
	Nombre			varchar(200) not null,
	Descripcion		varchar(500) not null,
	Estado			bit not null
);

CREATE TABLE Asignacion_Tipo_Proyecto
(
	IdAsignacionTipoProy	int Primary Key,
	IdTipoProyecto			int not null,
	Porcentaje				int not null,
	Estado					bit  not null,
	CONSTRAINT FK_ASIGNACION_TIPO_PROY_TIPO_PROY FOREIGN KEY (IdTipoProyecto) REFERENCES Tipo_Proyecto (IdTipoProyecto)
);

CREATE TABLE Asignacion_Proyecto
(
	IdAsignacionProyecto int Primary Key,
	IdAsignacionTipoProy int not null,
	Porcentaje			 int not null,
	Estado				 bit not null,
	CONSTRAINT FK_Asignacion_Proyecto_Asig_Tipo_Proy FOREIGN KEY (IdAsignacionProyecto) REFERENCES Asignacion_Tipo_Proyecto (IdAsignacionTipoProy)
);


CREATE TABLE Tipo_Actividad
(
	IdTipoActividad int Primary Key,
	Nombre			varchar(100) not null,
	Descripcion		varchar(500) not null,
	IdTipoProyecto	int not null,
	Estado			bit not null,
	CONSTRAINT FK_Tipo_Actividad_Asignacion_Proyecto FOREIGN KEY (IdTipoActividad) REFERENCES Tipo_Proyecto (IdTipoProyecto)
);

CREATE TABLE Tipo_Tiempo	
(
	IdTipoTiempo int Primary Key,
	Nombre			varchar(100) not null,
	Descripcion		varchar(500) not null,
	Estado			bit not null
);

CREATE TABLE Proyecto
(
	IdProyecto				int Primary Key,
	Nombre					varchar(100) not null,
	Descripcion				varchar(500) not null,
	Estado					bit not null,
	Etiqueta				varchar(100) not null,
	FechaCreacion			datetime not null,
	FechaInicio				datetime not null,
	FechaFin				datetime not null,
	DuracionMinutos			int not null,
	IdTipoProyecto			int not null,
	IdAsignacionProyecto	int not null,
	IdUsuario				int not null,
	CONSTRAINT FK_Proyecto_Tipo_Proyecto FOREIGN KEY (IdTipoProyecto) REFERENCES Tipo_Proyecto (IdTipoProyecto),
	CONSTRAINT FK_Asignacion_Proyecto FOREIGN KEY (IdAsignacionProyecto) REFERENCES Asignacion_Proyecto (IdAsignacionProyecto),
	CONSTRAINT FK_Usuario_Proyecto FOREIGN KEY (IdUsuario) REFERENCES Usuario (IdUsuario)
);


CREATE TABLE Plan_Actividad
(
	IdPlanActividad  int PRIMARY KEY,
	Nombre			 varchar(200) not null,
	Descripcion	     varchar(500) not null,
	DuracionMinutos	 int not null,
	FechaInicio	     datetime not null,
	FechaFin		 datetime not null,
	OrdenEjecucion	 int not null,
	IdTipoTiempo	 int not null,
	IdTipoActividad  int not null,
	IdProyecto       int not null,
    CONSTRAINT FK_Plan_Tipo_Tiempo FOREIGN KEY (IdTipoTiempo) REFERENCES Tipo_Proyecto (IdTipoProyecto),
	CONSTRAINT FK_Plan_Tipo_Actividad FOREIGN KEY (IdTipoActividad) REFERENCES Asignacion_Proyecto (IdAsignacionProyecto),
	CONSTRAINT FK_Plan_Proyecto FOREIGN KEY (IdProyecto) REFERENCES Asignacion_Proyecto (IdAsignacionProyecto)	
);

CREATE TABLE Tiempo_Real
(
	IdTiempoReal		int PRIMARY KEY,
	IdPlanActividad		int not null,
	FechaRegistro		Datetime,
	DuracionMinutos		int not null,
	CONSTRAINT FK_Tiempo_Real_Plan FOREIGN KEY (IdPlanActividad) REFERENCES Plan_Actividad (IdPlanActividad)	
);





























