Este programa fue desarrollado en ASP.Net Core 2.2 usando EntityFrameworkCore 2.2 
con un gestor de base de datos MSSqlServer 2014 y Visual Studio 2019.
- Se puede ejecutar desde Visual Studio con el ISS Express.
- Se incluye el backup de la base de datos .bak
- Se puede encontrar mas info de la conexion con la base de datos en appsettings.json

La carpeta ContactWeb es la carpeta para ser publicada en el servidor IIS, 
el archivo appsettings.production.json que esta dentro tiene la configuracion para conectarse con la BD 
("DefaultConnection": "Server=.;Database=Northwind;Trusted_Connection=True;").
SqlServer debera tener permisos DbOwner sobre Northwind en caso q se haga con la cuenta NT AUTHORITY\SYSTEM u otra autenticacion del server.

