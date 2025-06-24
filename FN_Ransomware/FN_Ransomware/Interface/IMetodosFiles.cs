using System;
using System.Collections.Generic;
using System.Text;

namespace FN_Ransomware.Interface
{
    public interface IMetodosFiles
    {
        // Metodo declarado en la interfaz e su logica implementada en la clase MetodosFiles. 
        string[] listadoArchivos(string path);

        // Metodo declarado en la interfaz e su logica implementada en la clase MetodosFiles
        bool GenerarArchivo(string[] rutaArchivo);  //Es un tipo boleano porque retorna si el archivo se genero o no
       
    }
}
