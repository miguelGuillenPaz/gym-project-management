# GyM Project Management

Aplicación web interna para apoyar la gestión de proyectos de construcción e ingeniería de GyM. Centraliza información de proyectos y presupuestos, la planificación de actividades, los requerimientos legales y algunos procesos administrativos relacionados.

> **Estado del proyecto:** aplicación heredada. Los módulos de Planificación y Legal contienen los flujos más completos; Compras, Finanzas, Logística y Contenidos incluyen principalmente pantallas o implementaciones parciales.

## Funcionalidades

| Módulo | Alcance |
| --- | --- |
| Gestión de proyectos | Consulta de proyectos y navegación por el presupuesto y su modificación. |
| Planificación | Listado de proyectos preaprobados, creación del plan, registro de actividades y estimación rápida basada en proyectos históricos. |
| Área legal | Registro, búsqueda y consulta detallada de requerimientos legales asociados a proyectos. |
| Recursos humanos | Consulta o registro de postulantes y carga de catálogos como país y estado civil. |
| Compras | Pantallas para planes de abastecimiento, solicitudes de adquisición e ítems. |
| Finanzas, logística y contenidos | Vistas iniciales que sirven como base para completar estos módulos. |
| Seguridad | Registro, inicio de sesión y cambio de contraseña mediante ASP.NET Membership. |

## Tecnologías

- C# y .NET Framework 4.0.
- ASP.NET MVC 2 con vistas Web Forms (`.aspx`).
- SQL Server mediante ADO.NET y Entity Framework.
- ASP.NET Membership para autenticación.
- JavaScript y jQuery 1.4.1 en la interfaz.
- Solución creada originalmente para Visual Studio 2010.

## Estructura

```text
JuridicaProye/
├── Controllers/     # Acciones y flujos MVC
├── Models/          # Entidades, formularios y modelos de Entity Framework
├── Persistencia/    # Objetos DAO y acceso a SQL Server
├── Views/           # Vistas ASPX organizadas por módulo
├── Content/         # Hojas de estilo y fuentes
├── Scripts/         # JavaScript de la aplicación y dependencias
├── Images/          # Recursos gráficos
├── App_Data/        # Archivos locales de base de datos
└── GyM.ProjectManagement.sln
```

La ruta MVC predeterminada sigue el formato `{controller}/{action}/{id}` y abre `Home/Index`.

## Requisitos para desarrollo

Debido a que se trata de una aplicación ASP.NET clásica, se recomienda un entorno Windows con:

1. Visual Studio con soporte para proyectos ASP.NET sobre .NET Framework 4.0.
2. ASP.NET MVC 2 instalado.
3. SQL Server o SQL Server Express.
4. IIS o el servidor web de desarrollo compatible con la versión de Visual Studio utilizada.

## Configuración local

1. Abra `JuridicaProye/GyM.ProjectManagement.sln` en Visual Studio.
2. Revise las cadenas de conexión de `JuridicaProye/Web.config` y reemplácelas con valores válidos para su entorno.
3. Prepare las bases de datos que utilizan la aplicación principal, ASP.NET Membership y el módulo de recursos humanos.
4. Compile la solución y ejecútela desde Visual Studio o publíquela en IIS.

> No confirme credenciales reales en el repositorio. Para nuevos entornos, use transformaciones de configuración o un mecanismo externo de secretos.

## Convención del nombre

El nombre anterior, `DemoMVC`, describía la tecnología y el carácter demostrativo, pero no el propósito del sistema. Se adoptó **`GyM.ProjectManagement`**, siguiendo una estructura de organización y producto y usando `PascalCase` para el nombre funcional:

- `GyM`: abreviatura corporativa usada como dominio propietario.
- `ProjectManagement`: función principal de la aplicación.

El mismo nombre se utiliza en la solución, el proyecto, el ensamblado y el espacio de nombres raíz para evitar identidades distintas entre los artefactos de .NET. La elección sigue las [guías de diseño de nombres de espacios de nombres de .NET](https://learn.microsoft.com/dotnet/standard/design-guidelines/names-of-namespaces) y las [convenciones de nombres de identificadores de C#](https://learn.microsoft.com/dotnet/csharp/fundamentals/coding-style/identifier-names).

## Consideraciones de mantenimiento

- La plataforma y las bibliotecas son heredadas y ya no corresponden a las versiones actuales de ASP.NET.
- Antes de exponer el sistema públicamente, se recomienda revisar la gestión de secretos, autenticación, validación de entradas y consultas de base de datos.
- Una modernización futura podría separar los módulos, agregar pruebas automatizadas y migrar gradualmente a una versión de .NET con soporte vigente.
