# Aplicación WebService POO (.NET Framework - WCF)

Este proyecto implementa un **servicio web SOAP** utilizando **Windows Communication Foundation (WCF)**, 
demostrando principios básicos de la programación orientada a objetos (POO) y servicios web en .NET Framework.

## 📌 Características

- Expone dos métodos a través del servicio:
  - `GetData(int value)`: Retorna un string con el número recibido.
  - `GetDataUsingDataContract(CompositeType composite)`: Manipula un objeto que contiene un booleano y una cadena de texto.

- Usa la tecnología **WCF auto-hospedado** en modo de diseño de Visual Studio.

## 📁 Estructura del Proyecto

- `IService1.cs`: Define la interfaz del servicio y el tipo compuesto `CompositeType`.
- `Service1.cs`: Implementación concreta del servicio.
- `App.config`: Contiene la configuración del host WCF con la URL base del servicio.

## ▶️ Cómo ejecutar

1. Abre la solución en **Visual Studio**.
2. Establece el proyecto como **proyecto de inicio**.
3. Presiona **F5** para iniciar la depuración o **Ctrl+F5** para ejecutar sin depuración.
4. Se abrirá tu navegador con la siguiente URL:


