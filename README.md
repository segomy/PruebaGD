Semaías Salatiel Gómez Yucuté
Programador Junior

# Documentación del Proyecto

## Paso 1: Base de Datos
Para la gestión de la información del proyecto se utilizó **SQL Server** como motor de base de datos.  
- Se **creó la base de datos** y las tablas necesarias para soportar las entidades principales (categorías, productos, ventas, etc.).  
- Se definieron **relaciones en cascada** entre tablas, de manera que al eliminar o actualizar un registro padre, los registros hijos relacionados se actualizaran o eliminaran automáticamente, garantizando la integridad referencial.  
- Se realizaron **inserciones manuales** en las tablas de *categorías* y *productos* para contar con información inicial de prueba.  
- Para la tabla de **ventas**, los inserts se implementaron de forma **dinámica**, con datos más variados.

## Paso 2: Creación del Proyecto en C#
El desarrollo de la aplicación se realizó utilizando **C# con ASP.NET MVC**.  
- Se creó un **proyecto MVC** para estructurar la solución bajo el patrón *Modelo - Vista - Controlador*.  
- Se configuró la **cadena de conexión** hacia la base de datos en el archivo de configuración (`appsettings.json`).  
- A través de **Scaffolding**, se generaron los **modelos directamente desde la base de datos**, lo que permitió trabajar con clases fuertemente tipadas que representan las tablas y relaciones definidas.  
- Se desarrolló la **lógica en los controladores**, encargados de manejar las peticiones del usuario y coordinar la comunicación entre los modelos y las vistas.  
- Finalmente, se construyó la **lógica en las vistas**, implementando interfaces gráficas que consumen los datos enviados por los controladores y permitiendo la interacción con el usuario de forma clara e intuitiva.
