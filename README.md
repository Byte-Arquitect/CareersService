
# 🚀 Microservicio de gestión de carerras

Este proyecto utiliza .NET 8 como framework principal y MongoDB como base de datos. A continuación, encontrarás las instrucciones para configurar, ejecutar y entender este proyecto.

## Requisitos Previos

Antes de comenzar, asegúrate de tener lo siguiente instalado en tu máquina:

- **[.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)** o superior 
- **[Git](https://git-scm.com/downloads)** (Para clonar el repositorio)

## Configuración Inicial

1. **Clona el Repositorio**
   
   ```bash
   git clone https://github.com/Byte-Arquitect/CareersService.git
   cd /CareerService
   ```

2. **Restaura las Dependencias**

   ```bash
   dotnet restore
   ```

3. **Configura la Base de Datos**

   - Este proyecto utiliza una base de datos desplegada en **MongoDB Atlas**, por lo que no es necesario instalar MongoDB localmente.
   - Asegúrate que la cadena de conexión en `appsettings.json` se vea de la siguiente manera:

     ```json
      "MongoDB": {
      "AllowedHosts": "*","ConnectionString": "mongodb+srv://GioxBRUSH:mongo123@cluster0.6tkvd.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0",
      "DatabaseName": "CareerService",
      "CollectionName": "Careers"
      },

     ```

     **Nota**: Si prefieres utilizar tus propias credenciales para la conexión, actualiza el archivo con tu información.
      ```json
      {
      "MongoDBSettings": {
         "ConnectionString": "mongodb+srv://<tu_usuario>:<tu_contraseña>@<cluster>.mongodbnet",
         "DatabaseName": "CareerDB"
      }

4. **Ejecuta el Proyecto**

   ```bash
   dotnet run
   ```

   La API estará disponible en [https://localhost:5093](https://localhost:5093) por defecto.

## Endpoints

A continuación, se describen los endpoints principales de la API. Puedes utilizar herramientas como Postman, cURL o Swagger para probarlos.

- **GET /career**: Obtiene una lista de todas las carreras.
- **GET /subject**: Obtiene una lista de todas las asiganturas.
- **GET /subject/prerequisites-map**: Obtiene una lista que, por cada código de asignatura, muestra otro listado de los códigos de sus prerrequisitos. .
- **GET /subject/postrequisites-map**: Obtiene una lista que, por cada código de asignatura, muestra otro listado de los códigos de las asignaturas que abre.
- **GET /subject/prerequisites-map/objects**: Obtiene una lista que, por cada prerrequisito, muestra el código de la asignatura, el del prerrequisito y el Id interno de esta relación.