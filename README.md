# Blog Application

Aplicación realizada con metodología en Clean Architecture.

 .Net 6

  NodeJS 21.1.0

  Angular 17

## Configuración de la base de datos
Para generar la base de datos debe dirigirse al archivo appsettings.json en el proyecto Blog.Api y modificar la cadena de conexión llamada ConnectionString para conectarse a su instancia de base de datos.

```json
{
 "ConnectionStrings": {
   "ConnectionString": "Server=localhost; Initial Catalog=Blog; Trusted_Connection=True; TrustServerCertificate=True;"
 },
}

```
Posterior a modificar la cadena de conexión se establece el proyecto Blog.Api como proyecto de inicio y se ejecuta. Al ejecutar se debe crear la base de datos llamada Blog con algunos registros pre cargados.

## Configuración de la aplicación web
En el proyecto Blog.WebApp/source/app/environments existe el archivo environment.ts, ahí se debe modificar el puerto dependiendo de cuál sea en el que está corriendo la Api previamente levantada.
```typescript
export const environment = {
  production: false,
  port: '****',
  url: 'http://localhost:',
  SECRET_KEY: 'test',
};


```
Una vez que ya se tenga instalado Angular y NodeJS se abre la ruta del proyecto Blog.WebApp desde la línea de comandos y se ejecuta lo siguiente:

`npm i` para que se instalen las dependencias correspondientes.

 `ng serve` para levantar el servidor.

## Dependencias y librerías
Para la solución de .Net 6 se utilizaron las siguientes dependencias:
* Api
  * Microsoft.EntityFrameworkCore.Tools (7.0.14)
* Application
  * AutoMapper (12.0.1)
  * FluentValidation (11.8.0)
  * FluentValidation.DependencyInjectionExtensions (11.8.0)
  * MediatR (12.1.1)
  * Microsoft.Extensions.Logging.Abstractions (8.0.0)
* Infrastructure
  * Microsoft.EntityFrameworkCore.SqlServer (7.0.14)
  * Microsoft.EntityFrameworkCore.Tools (7.0.14)

Para el proyecto web se utilizaron las siguientes dependencias:
* Bootstrap
* NgxSpinner
