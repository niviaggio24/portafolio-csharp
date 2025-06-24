##📁 FN_Ransomware
**FN_Ransomware** es una aplicación de consola en C# que permite listar y comprimir archivos en formato ZIP desde una carpeta específica. 
Soporta la opción de proteger el archivo comprimido con contraseña utilizando la biblioteca `DotNetZip`.

Este programa busca archivos en una ruta específica (pasada como argumento al ejecutarse), los recopila (por ejemplo, archivos PDF) 
y luego los comprime en un archivo ZIP protegido con contraseña

Esta fue la prueba tecnica en una oportunidad
---


## ✅ Casos de prueba incluidos

Crea un archivo ZIP en C:\ArchivosPDF\Comprimido.zip.

Recorre todos los archivos listados en rutaArchivo y los añade al ZIP.

Usa System.IO.Compression (API nativa de .NET para comprimir).

No aplica contraseña ni cifrado: solo los comprime.

Devuelve true si se completa correctamente.
## 💻 Uso

1. Clona este repositorio o copia el código fuente.
2. Abre el proyecto en Visual Studio o tu editor favorito.
3. Ejecuta el programa (`F5` o `dotnet run` si usas CLI).
4. Visualiza los datos generados directamente en la consola.

 
