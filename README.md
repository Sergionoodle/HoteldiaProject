# 🏨 HotelDia

**HotelDia** es una aplicación de gestión hotelera desarrollada con **Blazor Server** y **.NET 8**.  
Es un proyecto educativo que tiene como objetivo practicar y aplicar principios de desarrollo web full-stack utilizando tecnologías modernas del ecosistema .NET.

---

## 🎯 Objetivo del proyecto

El propósito principal de **HotelDia** es consolidar conocimientos en el desarrollo de aplicaciones web robustas utilizando **Blazor** y **C#**, aplicando buenas prácticas y patrones de arquitectura:

- Arquitectura por capas  
- Inyección de dependencias  
- Entity Framework Core para la persistencia de datos  
- Implementación de DTOs y mapeo con AutoMapper  
- Relaciones entre entidades (uno a muchos, muchos a muchos)  
- CRUD completos en componentes Blazor  
- Separación de responsabilidades (UI, lógica de negocio y acceso a datos)  

---

## 🧱 Funcionalidades en desarrollo

Actualmente, el sistema se encuentra en proceso de implementación de:

- **Gestión de categorías y propiedades** con relación uno a muchos  
- **Motor de reservas**: flujo de búsqueda, selección de fechas, disponibilidad y confirmación  
- **Componentes Blazor** con formularios de creación y edición de entidades  
- **Dropdowns dinámicos** vinculados a datos de la base de datos  
- **Servicios desacoplados** mediante interfaces  
- **DTOs para comunicación entre capas**  
- **Migraciones controladas con EF Core**  
- **Validación de formularios** y experiencia fluida en la UI  

---

## 🔧 Tecnologías utilizadas

- **Blazor Server** → UI interactiva en tiempo real  
- **.NET 8** → Framework principal  
- **C#** → Lenguaje de programación  
- **Entity Framework Core** → ORM para acceso a datos  
- **SQL Server** → Motor de base de datos  
- **AutoMapper** → Mapeo entre modelos y DTOs  
- **Inyección de dependencias** → Gestión de servicios  
- **EF Core Migrations** → Versionado del esquema de BD  
- **ASP.NET Core Identity** → Autenticación y autorización  
- **Visual Studio 2022** → IDE principal  
- **SSMS (SQL Server Management Studio)** → Gestión de base de datos  

---

## 🏗️ Estructura del proyecto

El proyecto está organizado de manera modular para facilitar el mantenimiento, la escalabilidad y la comprensión:
/Models -> Entidades de base de datos (EF Core) como Categoría, Propiedad y Reserva
/DTOs -> Objetos de transferencia de datos utilizados entre capas
/Repositories -> Clases que contienen la lógica de acceso a datos
/Interfaces -> Interfaces para los repositorios y servicios (contratos)
/Pages -> Componentes Blazor que representan la interfaz de usuario
/Mapper -> Configuración de AutoMapper para mapear modelos y DTOs
/Data -> ApplicationDbContext y configuración de EF Core
/Shared -> Componentes reutilizables (layouts, menús, formularios, dropdowns)
/wwwroot -> Archivos estáticos (CSS, JS, imágenes)

---

## 🚀 Motor de reservas

Se está desarrollando un sistema de reservas completo, integrado con la gestión de propiedades y usuarios:

### Flujo principal de reservas

1. **Búsqueda de disponibilidad**
   - El usuario selecciona fechas de entrada y salida.
   - Se filtran las propiedades disponibles en esas fechas.
2. **Selección de propiedad**
   - Se muestran opciones con detalles de categoría, precio y características.
   - El usuario selecciona la propiedad deseada.
3. **Registro de reserva**
   - El sistema solicita datos adicionales (usuario, pago si aplica, confirmación).
   - Se crea la reserva en la base de datos con estado “Pendiente” o “Confirmada”.
4. **Confirmación**
   - Se notifica al usuario y se actualiza el estado de la reserva.

---

### 🧩 Entidades involucradas

- **Usuario** (IdentityUser extendido)  
- **Categoría** (Tipo de habitación o propiedad)  
- **Propiedad** (Entidad de alojamiento)  
- **Reserva** (Entidad que relaciona Usuario y Propiedad con fechas y estado)  

---

### 🔄 Relaciones clave

- **Usuario ↔ Reserva** → Uno a muchos (un usuario puede tener varias reservas)  
- **Propiedad ↔ Reserva** → Uno a muchos (una propiedad puede estar reservada varias veces)  
- **Categoría ↔ Propiedad** → Uno a muchos (una categoría tiene varias propiedades)

---

### 💻 Implementación en Blazor

- **Formulario de búsqueda** con validación de fechas  
- **Listado de propiedades disponibles** con componentes dinámicos  
- **Formulario de reserva** con validaciones y mapeo a DTOs  
- **Servicios y repositorios** desacoplados para manejar la lógica de disponibilidad y creación de reservas  
- **Notificaciones y confirmaciones** integradas con el sistema de usuarios

---

### 🌐 Diagrama de flujo (Mermaid)

```mermaid
flowchart TD
    A[Inicio: Usuario ingresa al motor de reservas] --> B[Búsqueda de disponibilidad]
    B --> C{Propiedades disponibles?}
    C -- Sí --> D[Mostrar lista de propiedades]
    D --> E[Usuario selecciona propiedad]
    E --> F[Formulario de reserva]
    F --> G[Validación de datos y fechas]
    G --> H{Datos correctos?}
    H -- Sí --> I[Crear reserva en la base de datos]
    I --> J[Confirmación al usuario]
    H -- No --> K[Mostrar errores y solicitar correcciones]
    C -- No --> L[Mostrar mensaje de "No hay disponibilidad"]

## 🗃️ Base de datos

La base de datos utilizada es **SQL Server**, gestionada mediante **Entity Framework Core**. Las tablas se generan a partir de las entidades definidas en `/Models` y las relaciones entre ellas.

Los cambios en el esquema de la base de datos se aplican mediante migraciones:

- Add-Migration NombreMigracion
- Update-Database


## 🚧 Funcionalidades en desarrollo

Actualmente se están desarrollando e implementando:

- **Gestión CRUD** de entidades como **Categoría** y **Propiedad**
- **Formularios interactivos** en Blazor con validaciones (tanto del lado del cliente como del servidor)
- **Dropdowns dinámicos** para seleccionar relaciones entre entidades (por ejemplo, seleccionar una categoría al crear una propiedad)
- **Mapeo entre entidades y DTOs** mediante AutoMapper, evitando la exposición directa de las entidades del modelo
- **Inyección de dependencias** configurada en `Program.cs` para desacoplar lógica y facilitar pruebas
- **Repositorios e interfaces personalizados**, incluyendo métodos específicos de consulta y lógica de negocio
- **Renderizado dinámico** de componentes Blazor en función del estado del modelo o los datos recibidos
- **Gestión de errores y validaciones** utilizando bloques `try-catch`, validaciones por atributos y control del estado de los formularios
- **Autenticación y autorización con ASP.NET Core Identity**, incluyendo registro, inicio de sesión y control de acceso basado en roles

---

## 💡 Buenas prácticas aplicadas

- **Arquitectura en capas**: separación clara entre entidades, DTOs, lógica de negocio y presentación
- **DTOs personalizados**: utilizados para controlar qué información se expone o recibe en cada caso de uso
- **AutoMapper**: se encarga del mapeo automático entre modelos y DTOs, evitando código repetitivo
- **Uso de migraciones con EF Core**: permite versionar y aplicar cambios en el esquema de la base de datos de manera controlada
- **Inyección de dependencias** (`AddScoped`) para gestionar los ciclos de vida de los servicios de forma eficiente
- **Componentes reutilizables en Blazor**: layout, formularios y dropdowns
- **Uso del patrón repositorio** para desacoplar el acceso a datos de la lógica de negocio
- **ASP.NET Core Identity integrado** para manejar usuarios, roles y autenticación de forma segura y modular  
- **Protección de rutas y componentes** mediante `[Authorize]` y políticas personalizadas


---

## 👨‍💻 Autor

Proyecto creado por [Sergionoodle](https://github.com/Sergionoodle) como parte de su proceso de aprendizaje en desarrollo web full-stack con tecnologías modernas de Microsoft (.NET, Blazor, EF Core).

---

## 📄 Licencia

Este proyecto está disponible con fines educativos bajo una licencia de uso libre. Puedes usarlo, modificarlo y compartirlo siempre que se dé el crédito correspondiente al autor.

---


