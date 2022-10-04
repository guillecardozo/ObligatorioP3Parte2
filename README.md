**Proyecto acádemico de la Materia Programación 3 para un vivero de plantas.
Implementado en Visual Studio 2019 utilizando .NET Core 3.1, Web MVC, Entity Framework, LINQ, SQL Server.
Lenguaje: C#**

**Los Requerimientos implementados son:**
- Precarga de Usuarios
- Login
- Logout
- Alta (creación) de una planta
- Baja (eliminar) una planta
- Búsqueda de plantas (por nombre, por altura, por ambiente)
- Listado de todas las plantas
- Creación de un Tipo de Planta
- Eliminar un Tipo de Planta
- Modificar la descripción de un Tipo de Planta
- Listado de todos los Tipos de Plantas
- Creación de una Ficha de Cuidados para la planta
- Eliminar la Ficha de Cuidados

**PASOS PARA VER LA APLICACIÓN:**
- Descargar el Proyecto y abrirlo con Visual Studio 20XX
- En el menú, ir a Herramientas > Administrador de Paquetes NuGet > Consola del Administrador de paquetes
- En "Proyecto Predeterminado" seleccionar Repositorios
- Escribir el siguiente comando: **add-migration init**
- Una vez terminado, escribir el comando **update-database init** (Esto creará la base de datos con nombre ObligatorioP3Parte2 en SQL Server)
- Luego podemos ejecutar la aplicación normalmente desde Visual Studio
- Al ejecutar la aplicación, primero debemos precargar Usuarios, clickeando en el botón de "Precagar usuarios"
- Luego podemos loguearnos con usuario: **guille@usuario.com** y contraseña **guille123**
