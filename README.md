# GymRegister

Este es un proyecto CRUD de escritorio hecho en **VB.NET con SQL Server**, donde se pueden gestionar usuarios, servicios, reservas y reportes para un gimnasio.

##  Características principales

- Login con validación de roles
- Registro de usuarios y servicios
- Gestión de reservas
- Reportes con Crystal Reports
- Conexión a base de datos mediante capas (multicapa)
- Interfaz moderna con controles personalizados

##  Git Flow aplicado

Este repositorio usa Git Flow para organizar el trabajo:
- `main`: versión final del proyecto
- `develop`: integración de nuevas funciones
- `qa`: pruebas de integración
- `feature/`: desarrollo de nuevas funcionalidades
- `hotfix/`: correcciones rápidas

##  Funcionalidades implementadas en ramas feature/hotfix

- `feature/login-form`: formulario de inicio de sesión
- `feature/reservas-crud`: gestión de reservas
- `feature/reportes`: generación de reportes
- `feature/validate-input`: validación de campos
- `hotfix/fix-password-validation`: corrección en validación de contraseña

##  Pull Requests

Se realizaron 15 Pull Requests en total:
- Cada rama se integró a `develop`, `qa` y `main`.
- Todos los PR están cerrados o mergeados.

##  Tecnologías utilizadas

- VB.NET
- SQL Server
- Crystal Reports
- Git y GitHub con Git Flow

##  Estructura del proyecto

- `CapaDatos`: acceso a base de datos
- `CapaNegocio`: lógica de negocio
- `CapaPresentacion`: formularios y UI
- `Reportes`: Crystal Reports

---

**Autor:** David J. Guzman V.  
**Fecha:** Agosto 2025
