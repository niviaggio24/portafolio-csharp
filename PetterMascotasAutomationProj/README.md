##📁 Estructura del Proyecto
PetterMascotasAutomationProj/
│
├── UI/                         # Localizadores de las páginas web
│   ├── LoginPage.cs           # Elementos de la página de login
│   ├── PetterMPage.cs         # Elementos para registro de clientes
│   └── SalePage.cs            # Elementos para el módulo de ventas
│
├── TestCases/                 # Casos de prueba automatizados
│   ├── LoginTest.cs
│   ├── ClientTest.cs
│   └── SaleTest.cs
│
├── Drivers/                   # Controladores (WebDrivers)
│   └── chromedriver.exe       # WebDriver para Chrome
│
├── Utils/                     # Clases utilitarias (opcional)
│   └── SetupDriver.cs         # Inicialización y configuración del navegador
│
├── PetterMascotasAutomationProj.csproj
└── README.md

Esta fue la prueba de automatizacion
## ✅ Casos de prueba incluidos



🔐 LoginTest.cs
Verifica el ingreso al sistema con credenciales válidas

🧍 ClientTest.cs
Valida el registro de un nuevo cliente

Verifica que los campos requeridos sean completados

🛒 SaleTest.cs
Simula la venta de productos a un cliente registrado

Verifica el cálculo de total + IVA

Confirma el mensaje de éxito tras guardar la venta
## 💻 Uso

1. Clona este repositorio o copia el código fuente.
2. Abre el proyecto en Visual Studio o tu editor favorito.
3. Ejecuta el programa (`F5` o `dotnet run` si usas CLI).
4. Visualiza los datos generados directamente en la consola.

## 📦 Ejemplo de salida
```txt
1012393829
Cristiano Ronaldo
Calle 24 N° 5-60
prueba1@test.com
98231
