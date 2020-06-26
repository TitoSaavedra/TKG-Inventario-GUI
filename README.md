# TKG Inventario GUI

## Comenzando 🚀

Para su funcionamiento debes simplemente clonar el repositorio y abrilo con VS2019

## Esquema de Base de Datos <img src="./image-README/database.svg" width="22px">

En función del problema de TKG, se desarrolla una solución bajo la siguiente estructura de datos
![Esquema de base de datos](./image-README/db.png)
El modelo lo que busca es abarcar simplemente los módulos más básicos del sistema ERPs

## Requerimientos del Sistema 📝

### Módulos

* CRUD Usuarios
* CRUD Familia de Productos
* CRUD Productos
* Registro de Compra de Productos
* Registro Auditor
* Login

### Requerimientos

Los módulos son realizados utilizando WindowsForm con acceso ambas bases de datos según lo siguiente

* CRUD usuario y Registro de datos a la Tabla Auditor (MySql)
* CRUD Familia de Productos, CRUD Productos, Registro de Compra de Productos (SqlServer)

### Anexos

Algunas cosas importantes de mencionar, en la tabla Auditar, se registran todas las acciones que se realizan en cada CRUD, identificando si Ingreso, Modifico, Elimino algún registro y que usuario realizo la acción. La tabla TipoUsuario, tiene los registros de los usuarios previamente ingresados, no requiere un CRUD.

## Construido con 🛠️

Herramienta **Visual Studio 2019**

<img src="./image-README/c-logo.svg" width="60px">
<img src="./image-README/mysql.svg" width="60px">
<img src="./image-README/sql-server.png" width="60px">

## Autores ✒️

* **TITO BELARMINO SAAVEDRA PASTEN** - *Trabajo Interfaces y Correcciones* - [Github: Tito Saavedra](https://github.com/TitoSaavedra)
* **PABLO ANDRES AHUMADA OLIVARES** - *CRUDs con MySQL* - [Github: Pablo Ahumada](https://github.com/Drezeenebe)
* **LEANDRO GEOVANNI CRUZ PIZARRO** - *CRUDs con SQL-Server* - [Github: Leandro Cruz](https://github.com/LeandroGCruzP)

## Licencia 📄

No hay licencias involucradas en el uso del proyecto, estamos aprendiendo y esperamos que les sirva para su aprendisaje❤️😊

