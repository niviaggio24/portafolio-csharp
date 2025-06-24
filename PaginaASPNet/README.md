# 🧠 Proyecto ASP.NET Web Forms - Prueba

Este proyecto es una aplicación ASP.NET Web Forms que incluye:

 
- Páginas de gestión de cuentas (`Login`, `Register`, `Reset Password`, etc.). 
- Optimización de scripts con **bundling y minificación**.
- Integración opcional con un servicio **WCF**.
 
---

## 📁 Estructura del Proyecto

### 📂 Account/
Contiene formularios `.aspx` relacionados a la gestión de usuarios:

- `AddPhoneNumber.aspx`
- `Forgot.aspx`
- `Login.aspx`
- `Register.aspx`
- `Reset.aspx`
- Entre otros...

### 📂 App_Data/
Carpeta vacía reservada para almacenamiento (por ejemplo, archivos `.mdf` de SQL Server LocalDB).

### 📂 App_Start/
Contiene clases de configuración:

- `BundleConfig.cs`: Configura los scripts y recursos para minificación.
- `IdentityConfig.cs`: Configura ASP.NET Identity (usuarios, validaciones, servicios de email/SMS).
- `RouteConfig.cs`: Habilita URLs amigables usando `Microsoft.AspNet.FriendlyUrls`.

### 📂 Models/
Contiene la clase `ApplicationUser` y `ApplicationDbContext` utilizados por ASP.NET Identity.

---

## ⚙️ Características técnicas

- **ASP.NET Identity** para autenticación.
- Bundles de scripts (`WebForms.js`, `MsAjax`, `Modernizr`) para mejorar el rendimiento.

- Plantilla compatible con Visual Studio y ejecutable en IIS Express o IIS local.

---

## ▶️ Cómo ejecutar el proyecto

1. **Abrir el proyecto en Visual Studio**
   - Asegúrate de tener instalada la carga de trabajo para **ASP.NET Web Forms**.

2. **Revisar conexión de base de datos (si aplica)**
   - Si estás usando `ApplicationDbContext`, puede que necesites actualizar la cadena de conexión en `Web.config`.

3. **Ejecutar**
   - Presiona `Ctrl+F5` o haz clic en "Iniciar sin depuración".
   - Se abrirá la página de inicio en `http://localhost:puerto`.

4. **Registrar un usuario**
   - Ve a `/Account/Register.aspx` para registrar un nuevo usuario.

---

## 🧪 Funcionalidades incluidas

- Registro y login de usuarios.
- Restablecimiento de contraseña.
- Agregar número de teléfono (simulado).
 
 

---

## 📦 Paquetes NuGet importantes

- `Microsoft.AspNet.Identity`
- `Microsoft.Owin`
- `Microsoft.AspNet.FriendlyUrls`
- `System.Web.Optimization`

---
 
