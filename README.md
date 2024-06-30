# PruebaTecnicaBackend



Estructura del Proyecto
Tu proyecto está estructurado de la siguiente manera:

API: Proyecto principal de tipo ASP.NET Web API donde se encuentran los controladores.
Data: Biblioteca de clases que contiene el DbContext, migraciones y configuraciones de Entity Framework Core.
Models: Biblioteca de clases que contiene DTOs, entidades (Articulo.cs y Usuario.cs).
Tecnologías Utilizadas
ASP.NET Core Web API
Entity Framework Core
SQL Server
Funcionalidades Principales
Controllers
ArticuloController: CRUD completo para la gestión de artículos.
UsuarioController: Métodos para inicio de sesión y verificación de token Bearer.
Autenticación
La autenticación se gestiona mediante tokens JWT (Bearer token).

Configuración y Uso
Requisitos Previos
DotNet
.NET Core SDK
SQL Server
Configuración
Clona este repositorio.
Abre la solución en Visual Studio.
Configuración de la Base de Datos
Asegúrate de tener configurada la cadena de conexión en appsettings.json.
Ejecuta las migraciones de Entity Framework Core para crear la base de datos y las tablas necesarias.
bash
Copiar código
dotnet ef database update
Ejecución
Compila y ejecuta el proyecto API.
Utiliza herramientas como Postman o cURL para interactuar con los endpoints.
Contribución
Si deseas contribuir a este proyecto, por favor sigue estos pasos:

Haz un fork del repositorio.
Crea una nueva rama (git checkout -b feature/nueva-caracteristica).
Realiza tus cambios y haz commit (git commit -am 'Agrega nueva característica').
Sube los cambios a tu repositorio fork (git push origin feature/nueva-caracteristica).
Haz un pull request a la rama main del repositorio original.
Licencia
None

Este README proporciona una visión general de tu proyecto, incluyendo la estructura.
